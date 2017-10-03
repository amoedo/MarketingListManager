namespace MarketingListManager
{
    partial class MainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForceCount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonCopy = new System.Windows.Forms.ToolStripSplitButton();
            this.copyToStaticListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyStaticListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDataCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyDataCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyListMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonDeleteList = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewLists = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnMemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripQuery = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBoxQuery = new System.Windows.Forms.RichTextBox();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLists)).BeginInit();
            this.toolStripQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadList,
            this.toolStripButtonCopyUrl,
            this.toolStripButtonForceCount,
            this.toolStripSplitButtonCopy,
            this.toolStripButtonDeleteList});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(614, 25);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonLoadList
            // 
            this.toolStripButtonLoadList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadList.Image")));
            this.toolStripButtonLoadList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadList.Name = "toolStripButtonLoadList";
            this.toolStripButtonLoadList.Size = new System.Drawing.Size(136, 22);
            this.toolStripButtonLoadList.Text = "Load Marketing Lists";
            this.toolStripButtonLoadList.Click += new System.EventHandler(this.toolStripButtonLoadList_Click);
            // 
            // toolStripButtonCopyUrl
            // 
            this.toolStripButtonCopyUrl.Enabled = false;
            this.toolStripButtonCopyUrl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyUrl.Image")));
            this.toolStripButtonCopyUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyUrl.Name = "toolStripButtonCopyUrl";
            this.toolStripButtonCopyUrl.Size = new System.Drawing.Size(122, 22);
            this.toolStripButtonCopyUrl.Text = "Copy URL to CRM";
            this.toolStripButtonCopyUrl.Click += new System.EventHandler(this.toolStripButtonCopyUrl_Click);
            // 
            // toolStripButtonForceCount
            // 
            this.toolStripButtonForceCount.Enabled = false;
            this.toolStripButtonForceCount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForceCount.Image")));
            this.toolStripButtonForceCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForceCount.Name = "toolStripButtonForceCount";
            this.toolStripButtonForceCount.Size = new System.Drawing.Size(140, 22);
            this.toolStripButtonForceCount.Text = "Force Member Count";
            this.toolStripButtonForceCount.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSplitButtonCopy
            // 
            this.toolStripSplitButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToStaticListToolStripMenuItem,
            this.copyStaticListToolStripMenuItem,
            this.copyListMenuItem1});
            this.toolStripSplitButtonCopy.Enabled = false;
            this.toolStripSplitButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonCopy.Image")));
            this.toolStripSplitButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonCopy.Name = "toolStripSplitButtonCopy";
            this.toolStripSplitButtonCopy.Size = new System.Drawing.Size(51, 22);
            this.toolStripSplitButtonCopy.Text = "Copy";
            this.toolStripSplitButtonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // copyToStaticListToolStripMenuItem
            // 
            this.copyToStaticListToolStripMenuItem.Name = "copyToStaticListToolStripMenuItem";
            this.copyToStaticListToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.copyToStaticListToolStripMenuItem.Text = "Copy Dynamic to Static List";
            this.copyToStaticListToolStripMenuItem.Click += new System.EventHandler(this.copyToStaticListToolStripMenuItem_Click);
            // 
            // copyStaticListToolStripMenuItem
            // 
            this.copyStaticListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDataCopyToolStripMenuItem,
            this.onlyDataCopyToolStripMenuItem});
            this.copyStaticListToolStripMenuItem.Name = "copyStaticListToolStripMenuItem";
            this.copyStaticListToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.copyStaticListToolStripMenuItem.Text = "Copy Static List";
            this.copyStaticListToolStripMenuItem.Click += new System.EventHandler(this.copyListToolStripMenuItem_Click);
            // 
            // listDataCopyToolStripMenuItem
            // 
            this.listDataCopyToolStripMenuItem.Name = "listDataCopyToolStripMenuItem";
            this.listDataCopyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.listDataCopyToolStripMenuItem.Text = "List + Data";
            this.listDataCopyToolStripMenuItem.Click += new System.EventHandler(this.listDataCopyToolStripMenuItem_Click);
            // 
            // onlyDataCopyToolStripMenuItem
            // 
            this.onlyDataCopyToolStripMenuItem.Name = "onlyDataCopyToolStripMenuItem";
            this.onlyDataCopyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.onlyDataCopyToolStripMenuItem.Text = "Only Data";
            this.onlyDataCopyToolStripMenuItem.Visible = false;
            // 
            // copyListMenuItem1
            // 
            this.copyListMenuItem1.Name = "copyListMenuItem1";
            this.copyListMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.copyListMenuItem1.Text = "Copy List";
            this.copyListMenuItem1.ToolTipText = "No data is copied for static lists";
            // 
            // toolStripButtonDeleteList
            // 
            this.toolStripButtonDeleteList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteList.Enabled = false;
            this.toolStripButtonDeleteList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteList.Image")));
            this.toolStripButtonDeleteList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteList.Name = "toolStripButtonDeleteList";
            this.toolStripButtonDeleteList.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonDeleteList.Text = "Delete";
            this.toolStripButtonDeleteList.Click += new System.EventHandler(this.toolStripButtonDeleteList_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewLists);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripQuery);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxQuery);
            this.splitContainer1.Size = new System.Drawing.Size(614, 403);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridViewLists
            // 
            this.dataGridViewLists.AllowUserToAddRows = false;
            this.dataGridViewLists.AllowUserToDeleteRows = false;
            this.dataGridViewLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnType,
            this.ColumnMemberType,
            this.ColumnCount});
            this.dataGridViewLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLists.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLists.Name = "dataGridViewLists";
            this.dataGridViewLists.ReadOnly = true;
            this.dataGridViewLists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLists.Size = new System.Drawing.Size(614, 201);
            this.dataGridViewLists.TabIndex = 1;
            this.dataGridViewLists.SelectionChanged += new System.EventHandler(this.dataGridViewLists_SelectionChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Dynamic";
            this.ColumnType.FalseValue = "";
            this.ColumnType.HeaderText = "Dynamic";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 54;
            // 
            // ColumnMemberType
            // 
            this.ColumnMemberType.DataPropertyName = "Type";
            this.ColumnMemberType.HeaderText = "Member Type";
            this.ColumnMemberType.Name = "ColumnMemberType";
            this.ColumnMemberType.ReadOnly = true;
            this.ColumnMemberType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnMemberType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnMemberType.Width = 78;
            // 
            // ColumnCount
            // 
            this.ColumnCount.DataPropertyName = "Count";
            this.ColumnCount.HeaderText = "Member Count";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Width = 101;
            // 
            // toolStripQuery
            // 
            this.toolStripQuery.Enabled = false;
            this.toolStripQuery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1});
            this.toolStripQuery.Location = new System.Drawing.Point(0, 0);
            this.toolStripQuery.Name = "toolStripQuery";
            this.toolStripQuery.Size = new System.Drawing.Size(614, 25);
            this.toolStripQuery.TabIndex = 1;
            this.toolStripQuery.Text = "toolStrip2";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // richTextBoxQuery
            // 
            this.richTextBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxQuery.Enabled = false;
            this.richTextBoxQuery.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxQuery.Name = "richTextBoxQuery";
            this.richTextBoxQuery.Size = new System.Drawing.Size(614, 170);
            this.richTextBoxQuery.TabIndex = 0;
            this.richTextBoxQuery.Text = "";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(614, 431);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLists)).EndInit();
            this.toolStripQuery.ResumeLayout(false);
            this.toolStripQuery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxQuery;
        private System.Windows.Forms.DataGridView dataGridViewLists;
        private System.Windows.Forms.ToolStrip toolStripQuery;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonForceCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonCopy;
        private System.Windows.Forms.ToolStripMenuItem copyToStaticListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyStaticListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyUrl;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteList;
        private System.Windows.Forms.ToolStripMenuItem listDataCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyDataCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyListMenuItem1;
    }
}
