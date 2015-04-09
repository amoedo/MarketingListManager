using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Attributes;
using Microsoft.Xrm.Sdk.Query;
using MarketingListManager.Code;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using MarketingListManager.Properties;

[assembly: BackgroundColor("")]
[assembly: PrimaryFontColor("")]
[assembly: SecondaryFontColor("Gray")]

namespace MarketingListManager
{
    public partial class MainControl : XrmToolBox.PluginBase, XrmToolBox.IGitHubPlugin
    {
        public MainControl()
        {
            InitializeComponent();
        }

        public string RepositoryName
        {
            get { return "MarketingListManager"; }
        }

        public override Image PluginLogo
        {
            get
            {
                return Resources.Amoedo;
            }
        }

        public string UserName
        {
            get { return "amoedo"; }
        }

        private MarketingListItem currentItem;


        private void toolStripButtonLoadList_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ProcessLoadLists);
        }

        private void ProcessLoadLists()
        {
            WorkAsync("Loading Marketing Lists...",
                (w, e) =>
                {
                    w.ReportProgress(10, "Starting query");
                    QueryExpression queryAllLists = new QueryExpression("list");
                    queryAllLists.ColumnSet = new ColumnSet(true);
                    var result = Service.RetrieveMultiple(queryAllLists);
                    w.ReportProgress(90, "Processing results");
                    e.Result = result;
                },
                e => // Finished Async Call.  Cleanup
                {
                    var list = MarketingListItem.LoadFromEntityCollection((EntityCollection)e.Result);
                    dataGridViewLists.AutoGenerateColumns = false;
                    dataGridViewLists.DataSource = list;
                },
                e => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                {
                    SetWorkingMessage(e.UserState.ToString());
                });
        }

        private void ProcessCount(MarketingListItem item)
        {
            WorkAsync("Starting Record count...",
                (w, ae) =>
                {
                    w.ReportProgress(10, "Obtaining query");


                    FetchXmlToQueryExpressionRequest request = new FetchXmlToQueryExpressionRequest() { FetchXml = item.Query };

                    var response = (FetchXmlToQueryExpressionResponse)Service.Execute(request);

                    var query = response.Query;
                    query.PageInfo = new PagingInfo();
                    query.PageInfo.Count = 5000;
                    query.PageInfo.PageNumber = 1;

                    query.NoLock = true;

                    int count = 0;

                    EntityCollection results;
                    w.ReportProgress(30, "Starting query");
                    do
                    {
                        results = Service.RetrieveMultiple(query);
                        count += results.Entities.Count;
                        query.PageInfo.PageNumber++;
                        query.PageInfo.PagingCookie = results.PagingCookie;
                        w.ReportProgress(50, string.Format("Found {0} so far...", count));

                    } while (results.MoreRecords);

                    item.Count = count;
                    ae.Result = count;
                    w.ReportProgress(99, string.Format("Record count {0}", count));
                },
                ae =>
                {
                    dataGridViewLists.Refresh();
                }, ae => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                {
                    SetWorkingMessage(ae.UserState.ToString());
                });
                        }

        private void ProcessSave(MarketingListItem item)
        {
            WorkAsync("Saving Marketing Lists...",
                (w, ae) =>
                {
                    w.ReportProgress(10, "Obtaining query");

                    Entity list = new Entity("list");
                    list["listid"] = item.Id;
                    list["query"] = item.Query;

                    Service.Update(list);

                    w.ReportProgress(99, "Done");
                },
                ae =>
                {
                    //ExecuteMethod(ProcessLoadLists);
                }, ae => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                {
                    SetWorkingMessage(ae.UserState.ToString());
                });
        }


        private void dataGridViewLists_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLists.SelectedRows.Count > 0)
            {
                var item = (MarketingListItem)dataGridViewLists.SelectedRows[0].DataBoundItem;
                if (item.Dynamic)
                {
                    SelectedItemChanged(item);
                }
                else
                {
                    SelectedItemChanged(null);
                }
            }
        }

        private void SelectedItemChanged(MarketingListItem item)
        {
            if (item != null)
            {
                this.richTextBoxQuery.Enabled = true;
                this.toolStripButtonForceCount.Enabled = true;
                this.richTextBoxQuery.Text = item.Query;
                this.currentItem = item;
                this.toolStripQuery.Enabled = true;
            }
            else
            {
                this.richTextBoxQuery.Enabled = false;
                this.toolStripQuery.Enabled = false;
                this.toolStripButtonForceCount.Enabled = false;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.currentItem.Query = richTextBoxQuery.Text;
            ExecuteMethod<MarketingListItem>(ProcessSave, this.currentItem);
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBoxQuery.Text);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) this.richTextBoxQuery.Text = Clipboard.GetText();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExecuteMethod<MarketingListItem>(ProcessCount, currentItem);
        }

    }
}
