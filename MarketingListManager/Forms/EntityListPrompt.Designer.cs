namespace MarketingListManager.Forms
{
    partial class EntityListPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPromptText = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewLists = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLists)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromptText
            // 
            this.lblPromptText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPromptText.Location = new System.Drawing.Point(0, 0);
            this.lblPromptText.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblPromptText.Name = "lblPromptText";
            this.lblPromptText.Size = new System.Drawing.Size(333, 13);
            this.lblPromptText.TabIndex = 0;
            this.lblPromptText.Text = "label1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(149, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(78, 32);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "OK";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnSubmitText_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(258, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 32);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewLists
            // 
            this.dataGridViewLists.AllowUserToAddRows = false;
            this.dataGridViewLists.AllowUserToDeleteRows = false;
            this.dataGridViewLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.ColumnName,
            this.ColumnMemberType});
            this.dataGridViewLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLists.Location = new System.Drawing.Point(0, 13);
            this.dataGridViewLists.MultiSelect = false;
            this.dataGridViewLists.Name = "dataGridViewLists";
            this.dataGridViewLists.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewLists.RowHeadersVisible = false;
            this.dataGridViewLists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewLists.Size = new System.Drawing.Size(333, 382);
            this.dataGridViewLists.TabIndex = 2;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.Frozen = true;
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Selected.Width = 55;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnMemberType
            // 
            this.ColumnMemberType.DataPropertyName = "Type";
            this.ColumnMemberType.HeaderText = "Member Type";
            this.ColumnMemberType.Name = "ColumnMemberType";
            this.ColumnMemberType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnMemberType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnMemberType.Width = 78;
            // 
            // EntityListPrompt
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(333, 427);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewLists);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPromptText);
            this.Name = "EntityListPrompt";
            this.Text = "TextPrompt";
            this.Load += new System.EventHandler(this.TextPrompt_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPromptText;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewLists;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMemberType;
    }
}