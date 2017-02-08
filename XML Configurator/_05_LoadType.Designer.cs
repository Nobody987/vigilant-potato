namespace XML_Configurator
{
    partial class _05_LoadType
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_load_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_load_prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_load_sufix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_reload_file = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_load_type,
            this.Column_load_prefix,
            this.Column_load_sufix});
            this.dataGridView.Location = new System.Drawing.Point(-1, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.Size = new System.Drawing.Size(955, 478);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_CurrentCellDirtyStateChanged);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            // 
            // Column_load_type
            // 
            this.Column_load_type.HeaderText = "Load Type Name";
            this.Column_load_type.Name = "Column_load_type";
            this.Column_load_type.Width = 300;
            // 
            // Column_load_prefix
            // 
            this.Column_load_prefix.HeaderText = "Load Type Prefix";
            this.Column_load_prefix.Name = "Column_load_prefix";
            this.Column_load_prefix.Width = 300;
            // 
            // Column_load_sufix
            // 
            this.Column_load_sufix.HeaderText = "Load Type Sufix";
            this.Column_load_sufix.Name = "Column_load_sufix";
            this.Column_load_sufix.Width = 300;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_reload_file,
            this.toolStripSeparator1,
            this.toolStripButton_save});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(952, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // toolStripButton_reload_file
            // 
            this.toolStripButton_reload_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_reload_file.Image = global::XML_Configurator.Properties.Resources._1474915038_system_restart;
            this.toolStripButton_reload_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_reload_file.Name = "toolStripButton_reload_file";
            this.toolStripButton_reload_file.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_reload_file.Text = "toolStripButton_reload_file";
            this.toolStripButton_reload_file.Click += new System.EventHandler(this.toolStripButton_reload_file_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = global::XML_Configurator.Properties.Resources._1474915151_Save;
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_save.Text = "toolStripButton_save";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // _05_LoadType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(952, 571);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dataGridView);
            this.Name = "_05_LoadType";
            this.Text = "Load Types";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_load_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_load_prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_load_sufix;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_reload_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
    }
}