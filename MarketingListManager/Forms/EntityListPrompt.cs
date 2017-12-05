using MarketingListManager.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingListManager.Forms
{
    public partial class EntityListPrompt : Form
    {
        public IList<MarketingListItem> Value
        {
            get {
                List<MarketingListItem> listIDs = new List<MarketingListItem>();

                foreach (DataGridViewRow item in this.dataGridViewLists.Rows)
                {
                    var currentML= (MarketingListItem)item.DataBoundItem;
                    bool isSelected = currentML.Selected;
                    if (isSelected)
                    {
                        listIDs.Add(currentML);
                    }
                }
                return listIDs;

            }
        }

        public EntityListPrompt(object sender,string promptInstructions)
        {
            InitializeComponent();
            this.dataGridViewLists.AutoGenerateColumns = false;
            lblPromptText.Text = promptInstructions;
            this.Text = promptInstructions;
        }
        public EntityListPrompt(object sender, string promptInstructions,List<MarketingListItem> marketingLists):this(sender,promptInstructions)
        {

            this.dataGridViewLists.DataSource = marketingLists.Where(ml => ml.Dynamic == false).ToList<MarketingListItem>() ;
        }
        public EntityListPrompt(object sender, string promptInstructions, List<MarketingListItem> marketingLists,bool? ShowDynamicLists,int? filterByMemberType) : this(sender, promptInstructions)
        {
            IEnumerable<MarketingListItem> listSource=marketingLists;
            if (ShowDynamicLists.HasValue)
            {
               listSource= marketingLists.Where(ml => ml.Dynamic == ShowDynamicLists); 
            }
            if (filterByMemberType.HasValue)
            {
                listSource = listSource.Where(ml => ml.Type == filterByMemberType);
            }
            this.dataGridViewLists.DataSource = listSource.ToList<MarketingListItem>();
        }

        private void BtnSubmitText_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void TextPrompt_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
