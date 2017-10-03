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
    public partial class TextPrompt : Form
    {
        public string Value
        {
            get { return tbText.Text.Trim(); }
        }

        public TextPrompt(object sender,string promptInstructions)
        {
            InitializeComponent();
            lblPromptText.Text = promptInstructions;
        }
        public TextPrompt(object sender, string promptInstructions,string defaultValue) : this(sender, promptInstructions)
        {
            tbText.Text = defaultValue;
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
