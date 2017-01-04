namespace XML_Configurator
{
    partial class _03_DatabaseConnector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_03_DatabaseConnector));
            this.textBox_database_connect = new System.Windows.Forms.TextBox();
            this.button_database_connect = new System.Windows.Forms.Button();
            this.listBox_database_tables = new System.Windows.Forms.ListBox();
            this.comboBox_connection_type = new System.Windows.Forms.ComboBox();
            this.button_extract_table_definition = new System.Windows.Forms.Button();
            this.button_save_table_definition = new System.Windows.Forms.Button();
            this.treeView_table_columns = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_search_loaded_tables = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_database_connect
            // 
            this.textBox_database_connect.Location = new System.Drawing.Point(12, 14);
            this.textBox_database_connect.Name = "textBox_database_connect";
            this.textBox_database_connect.Size = new System.Drawing.Size(567, 20);
            this.textBox_database_connect.TabIndex = 0;
            this.textBox_database_connect.Text = "Driver={iSeries Access ODBC Driver};DSN=F40004DE.F19;Uid=QV_SQL;Pwd=kl987zzvtr;";
            // 
            // button_database_connect
            // 
            this.button_database_connect.Location = new System.Drawing.Point(12, 38);
            this.button_database_connect.Name = "button_database_connect";
            this.button_database_connect.Size = new System.Drawing.Size(75, 23);
            this.button_database_connect.TabIndex = 1;
            this.button_database_connect.Text = "Connect";
            this.button_database_connect.UseVisualStyleBackColor = true;
            this.button_database_connect.Click += new System.EventHandler(this.button_database_connect_Click);
            // 
            // listBox_database_tables
            // 
            this.listBox_database_tables.FormattingEnabled = true;
            this.listBox_database_tables.Location = new System.Drawing.Point(12, 106);
            this.listBox_database_tables.Name = "listBox_database_tables";
            this.listBox_database_tables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_database_tables.Size = new System.Drawing.Size(240, 407);
            this.listBox_database_tables.TabIndex = 3;
            // 
            // comboBox_connection_type
            // 
            this.comboBox_connection_type.FormattingEnabled = true;
            this.comboBox_connection_type.Items.AddRange(new object[] {
            "10.30.11.190",
            "10.64.17.103",
            "TEST"});
            this.comboBox_connection_type.Location = new System.Drawing.Point(463, 40);
            this.comboBox_connection_type.Name = "comboBox_connection_type";
            this.comboBox_connection_type.Size = new System.Drawing.Size(116, 21);
            this.comboBox_connection_type.TabIndex = 4;
            this.comboBox_connection_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_connection_type_SelectedIndexChanged);
            // 
            // button_extract_table_definition
            // 
            this.button_extract_table_definition.Location = new System.Drawing.Point(258, 106);
            this.button_extract_table_definition.Name = "button_extract_table_definition";
            this.button_extract_table_definition.Size = new System.Drawing.Size(75, 23);
            this.button_extract_table_definition.TabIndex = 5;
            this.button_extract_table_definition.Text = "Extract";
            this.button_extract_table_definition.UseVisualStyleBackColor = true;
            this.button_extract_table_definition.Click += new System.EventHandler(this.button_extract_table_definition_Click);
            // 
            // button_save_table_definition
            // 
            this.button_save_table_definition.Location = new System.Drawing.Point(258, 135);
            this.button_save_table_definition.Name = "button_save_table_definition";
            this.button_save_table_definition.Size = new System.Drawing.Size(75, 23);
            this.button_save_table_definition.TabIndex = 7;
            this.button_save_table_definition.Text = "Next";
            this.button_save_table_definition.UseVisualStyleBackColor = true;
            this.button_save_table_definition.Click += new System.EventHandler(this.button_save_table_definition_Click);
            // 
            // treeView_table_columns
            // 
            this.treeView_table_columns.Location = new System.Drawing.Point(339, 106);
            this.treeView_table_columns.Name = "treeView_table_columns";
            this.treeView_table_columns.Size = new System.Drawing.Size(240, 407);
            this.treeView_table_columns.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Connect (OBSOLETE)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_search_loaded_tables
            // 
            this.textBox_search_loaded_tables.Location = new System.Drawing.Point(12, 70);
            this.textBox_search_loaded_tables.Name = "textBox_search_loaded_tables";
            this.textBox_search_loaded_tables.Size = new System.Drawing.Size(240, 20);
            this.textBox_search_loaded_tables.TabIndex = 10;
            this.textBox_search_loaded_tables.TextChanged += new System.EventHandler(this.textBox_search_loaded_tables_TextChanged);
            // 
            // DatabaseConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 539);
            this.Controls.Add(this.textBox_search_loaded_tables);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView_table_columns);
            this.Controls.Add(this.button_save_table_definition);
            this.Controls.Add(this.button_extract_table_definition);
            this.Controls.Add(this.comboBox_connection_type);
            this.Controls.Add(this.listBox_database_tables);
            this.Controls.Add(this.button_database_connect);
            this.Controls.Add(this.textBox_database_connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseConnector";
            this.Text = "DatabaseConnector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_database_connect;
        private System.Windows.Forms.Button button_database_connect;
        private System.Windows.Forms.ListBox listBox_database_tables;
        private System.Windows.Forms.ComboBox comboBox_connection_type;
        private System.Windows.Forms.Button button_extract_table_definition;
        private System.Windows.Forms.Button button_save_table_definition;
        private System.Windows.Forms.TreeView treeView_table_columns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_search_loaded_tables;
    }
}