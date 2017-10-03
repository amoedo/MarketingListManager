using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Query;
using MarketingListManager.Code;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using MarketingListManager.Properties;
using XrmToolBox.Extensibility;
using System.ComponentModel.Composition;
using XrmToolBox.Extensibility.Interfaces;
using MarketingListManager.Forms;

namespace MarketingListManager
{

    public partial class MainControl : PluginControlBase
    {
        public MainControl()
        {
            InitializeComponent();
        }

        public string RepositoryName
        {
            get { return "MarketingListManager"; }
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
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Marketing Lists...",
                Work = (w, e) =>
                {
                    w.ReportProgress(10, "Starting query");
                    QueryExpression queryAllLists = new QueryExpression("list");
                    queryAllLists.ColumnSet = new ColumnSet(true);
                    var result = Service.RetrieveMultiple(queryAllLists);
                    w.ReportProgress(90, "Processing results");
                    e.Result = result;
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                },
                PostWorkCallBack = e =>
                {
                    var list = MarketingListItem.LoadFromEntityCollection((EntityCollection)e.Result);
                    dataGridViewLists.AutoGenerateColumns = false;
                    dataGridViewLists.DataSource = list;
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void ProcessCount(MarketingListItem item)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Starting Record count...",
                Work = (w, ae) =>
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
                PostWorkCallBack = ae =>
                 {
                     dataGridViewLists.Refresh();
                 },
                ProgressChanged = ae => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                  {
                      SetWorkingMessage(ae.UserState.ToString());
                  }
            });
        }
        private void CopyToStaticList(MarketingListItem item)
        {
            WorkAsync(
                new WorkAsyncInfo
                {
                    Message = "Start copy of list",
                    Work = (w, ae) =>
                    {
                        Guid _staticListId = Guid.Empty;
                        // Copy the dynamic list to a static list.
                        CopyDynamicListToStaticRequest copyRequest =
                            new CopyDynamicListToStaticRequest()
                            {
                                ListId = item.Id                          
                            };
                        CopyDynamicListToStaticResponse copyResponse =
                            (CopyDynamicListToStaticResponse)Service.Execute(copyRequest);
                        _staticListId = copyResponse.StaticListId;
                        CopyUrlToClipboard(new MarketingListItem { Id = _staticListId });
                        w.ReportProgress(99, string.Format("Copied dynamic list to a static list with id {0}", _staticListId));
                    },
                    PostWorkCallBack = ae =>
                    {
                        ExecuteMethod(ProcessLoadLists);
                    },
                    ProgressChanged = ae =>
                    {
                        SetWorkingMessage(ae.UserState.ToString());
                    }
                }
                );
        }
        private void ProcessSave(MarketingListItem item)
        {
            WorkAsync(
                new WorkAsyncInfo
                {
                    Message = "Saving Marketing Lists...",
                    Work = (w, ae) =>
                      {
                          w.ReportProgress(10, "Obtaining query");

                          Entity list = new Entity("list");
                          list["listid"] = item.Id;
                          list["query"] = item.Query;

                          Service.Update(list);

                          w.ReportProgress(99, "Done");
                      },
                    PostWorkCallBack = ae =>
                     {
                         //ExecuteMethod(ProcessLoadLists);
                     },
                    ProgressChanged = ae => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                    {
                        SetWorkingMessage(ae.UserState.ToString());
                    }
                });
        }
        [STAThreadAttribute]
        private void CopyUrlToClipboard(MarketingListItem item) {
            string url = string.Format("{0}main.aspx?etc=4300&id={1}&pagetype=entityrecord", ConnectionDetail.WebApplicationUrl, item.Id);
            this.Invoke(new Action(()=> { Clipboard.SetText(url); }));
         
        }
        private void DeleteList(MarketingListItem item)
        {
            WorkAsync(
                new WorkAsyncInfo
                {
                    Message = "Deleting Marketing List",
                    Work = (w, ae) =>
                    {
                        Service.Delete("list",item.Id);

                        w.ReportProgress(99, "Done");
                    },
                    PostWorkCallBack = ae =>
                    {
                        ExecuteMethod(ProcessLoadLists);
                    },
                    ProgressChanged = ae => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                    {
                        SetWorkingMessage(ae.UserState.ToString());
                    }
                });
        }
        private void CopyListWithData(CopyListParameters parameters)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message="Copying Members",
                Work = (w, ae) =>
                {
                    CopyMembersListRequest req = new CopyMembersListRequest();
                    req.SourceListId = parameters.MarketingList.Id;
                    req.TargetListId = parameters.NewListId;
                    CopyMembersListResponse response = (CopyMembersListResponse)Service.Execute(req);
                },
                PostWorkCallBack = ae =>
                {
                    ExecuteMethod(ProcessLoadLists);
                },
                ProgressChanged = ae =>
                {
                    SetWorkingMessage(ae.UserState.ToString());
                }
            }
                );
        }
        private void CopyList(CopyListParameters parameters)
        {
            WorkAsync(
               new WorkAsyncInfo
               {
                   Message = "Copying Marketing List",
                   Work = (w, ae) =>
                   {
                       var originalList = parameters.MarketingList.FullRecord;
                       originalList.Attributes.Remove("listid");
                       originalList.Id = Guid.Empty;
                       if (!string.IsNullOrEmpty(parameters.NewName))
                       {
                           originalList["listname"] = parameters.NewName;
                       }
                       parameters.NewListId= Service.Create(originalList);
                       

                       w.ReportProgress(99, "Done");
                   },
                   PostWorkCallBack = ae =>
                   {
                       ExecuteMethod(ProcessLoadLists);
                       if (parameters.NextFunction!=null)
                       {
                           parameters.NextFunction(parameters);
                       }
                   },
                   ProgressChanged = ae => // Logic wants to display an update.  This gets called when ReportProgress Gets Called
                    {
                       SetWorkingMessage(ae.UserState.ToString());
                   }
               });
        }


        private void dataGridViewLists_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLists.SelectedRows.Count > 0)
            {
                var item = (MarketingListItem)dataGridViewLists.SelectedRows[0].DataBoundItem;
                    SelectedItemChanged(item);
               
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
                this.toolStripButtonCopyUrl.Enabled = true;
                this.toolStripButtonForceCount.Enabled = true;
                this.toolStripSplitButtonCopy.Enabled = true;
                this.toolStripButtonDeleteList.Enabled = true;
            }
            else
            {
                this.richTextBoxQuery.Enabled = false;
                this.toolStripQuery.Enabled = false;
                this.toolStripButtonForceCount.Enabled = false;

                this.toolStripButtonCopyUrl.Enabled = false;
                this.toolStripButtonForceCount.Enabled = false;
                this.toolStripSplitButtonCopy.Enabled = false;
                this.toolStripButtonDeleteList.Enabled = false;
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

        private void copyToStaticListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteMethod<MarketingListItem>(CopyToStaticList, currentItem);
        }

        private void copyListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonCopyUrl_Click(object sender, EventArgs e)
        {
            ExecuteMethod<MarketingListItem>(CopyUrlToClipboard, currentItem);
        }

        private void toolStripButtonDeleteList_Click(object sender, EventArgs e)
        {
            ExecuteMethod<MarketingListItem>(DeleteList, currentItem);
        }

        private void OnlyListCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new TextPrompt(this, "Type the name of the new list:",currentItem.Name);
            DialogResult dResult = t.ShowDialog();
            if (dResult==DialogResult.OK)
            {
                ExecuteMethod<CopyListParameters>(CopyList,new CopyListParameters { MarketingList = currentItem, NewName = t.Value }); 
            }
        }

        private void listDataCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new TextPrompt(this, "Type the name of the new list:", currentItem.Name);
            DialogResult dResult = t.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                ExecuteMethod<CopyListParameters>(CopyList, new CopyListParameters { MarketingList = currentItem, NewName = t.Value,NextFunction= CopyListWithData });
            }
        }
    }
}
