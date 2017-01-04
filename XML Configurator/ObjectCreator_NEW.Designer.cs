namespace XML_Configurator
{
    public partial class ObjectCreator_NEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectCreator_NEW));
            this.BUTTON_EXIT = new System.Windows.Forms.Button();
            this.BUTTON_CREATE_XML = new System.Windows.Forms.Button();
            this.BUTTON_CREATE_OBJECT = new System.Windows.Forms.Button();
            this.listView_all_objects = new System.Windows.Forms.ListBox();
            this.button_delete_list_item = new System.Windows.Forms.Button();
            this.button_list_item_move_up = new System.Windows.Forms.Button();
            this.button_list_item_move_down = new System.Windows.Forms.Button();
            this.textBox_folder_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label_file_name = new System.Windows.Forms.Label();
            this.button_update_object = new System.Windows.Forms.Button();
            this.openFileDialogLocation = new System.Windows.Forms.OpenFileDialog();
            this.button_load_xml = new System.Windows.Forms.Button();
            this.listBox_loaded_tables = new System.Windows.Forms.ListBox();
            this.label_loaded_tables = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUTTON_EXIT
            // 
            this.BUTTON_EXIT.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUTTON_EXIT.Location = new System.Drawing.Point(1034, 744);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(113, 23);
            this.BUTTON_EXIT.TabIndex = 0;
            this.BUTTON_EXIT.Text = "Exit";
            this.BUTTON_EXIT.UseVisualStyleBackColor = true;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // BUTTON_CREATE_XML
            // 
            this.BUTTON_CREATE_XML.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUTTON_CREATE_XML.Location = new System.Drawing.Point(1034, 603);
            this.BUTTON_CREATE_XML.Name = "BUTTON_CREATE_XML";
            this.BUTTON_CREATE_XML.Size = new System.Drawing.Size(113, 24);
            this.BUTTON_CREATE_XML.TabIndex = 0;
            this.BUTTON_CREATE_XML.Text = "Create XML file";
            this.BUTTON_CREATE_XML.UseVisualStyleBackColor = true;
            this.BUTTON_CREATE_XML.Click += new System.EventHandler(this.BUTTON_CREATE_XML_Click);
            // 
            // BUTTON_CREATE_OBJECT
            // 
            this.BUTTON_CREATE_OBJECT.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUTTON_CREATE_OBJECT.Location = new System.Drawing.Point(705, 633);
            this.BUTTON_CREATE_OBJECT.Name = "BUTTON_CREATE_OBJECT";
            this.BUTTON_CREATE_OBJECT.Size = new System.Drawing.Size(114, 23);
            this.BUTTON_CREATE_OBJECT.TabIndex = 33;
            this.BUTTON_CREATE_OBJECT.Text = "Create Object";
            this.BUTTON_CREATE_OBJECT.UseVisualStyleBackColor = true;
            this.BUTTON_CREATE_OBJECT.Click += new System.EventHandler(this.BUTTON_CREATE_OBJECT_Click);
            // 
            // listView_all_objects
            // 
            this.listView_all_objects.FormattingEnabled = true;
            this.listView_all_objects.Location = new System.Drawing.Point(705, 383);
            this.listView_all_objects.Name = "listView_all_objects";
            this.listView_all_objects.Size = new System.Drawing.Size(442, 212);
            this.listView_all_objects.TabIndex = 37;
            this.listView_all_objects.SelectedIndexChanged += new System.EventHandler(this.listView_all_objects_SelectedIndexChanged);
            // 
            // button_delete_list_item
            // 
            this.button_delete_list_item.Location = new System.Drawing.Point(649, 555);
            this.button_delete_list_item.Name = "button_delete_list_item";
            this.button_delete_list_item.Size = new System.Drawing.Size(50, 39);
            this.button_delete_list_item.TabIndex = 38;
            this.button_delete_list_item.Text = "DEL";
            this.button_delete_list_item.UseVisualStyleBackColor = true;
            this.button_delete_list_item.Click += new System.EventHandler(this.button_delete_list_item_Click);
            // 
            // button_list_item_move_up
            // 
            this.button_list_item_move_up.Location = new System.Drawing.Point(649, 383);
            this.button_list_item_move_up.Name = "button_list_item_move_up";
            this.button_list_item_move_up.Size = new System.Drawing.Size(50, 39);
            this.button_list_item_move_up.TabIndex = 39;
            this.button_list_item_move_up.Text = "UP";
            this.button_list_item_move_up.UseVisualStyleBackColor = true;
            this.button_list_item_move_up.Click += new System.EventHandler(this.button_list_item_move_up_Click);
            // 
            // button_list_item_move_down
            // 
            this.button_list_item_move_down.Location = new System.Drawing.Point(649, 428);
            this.button_list_item_move_down.Name = "button_list_item_move_down";
            this.button_list_item_move_down.Size = new System.Drawing.Size(50, 39);
            this.button_list_item_move_down.TabIndex = 40;
            this.button_list_item_move_down.Text = "DOWN";
            this.button_list_item_move_down.UseVisualStyleBackColor = true;
            this.button_list_item_move_down.Click += new System.EventHandler(this.button_list_item_move_down_Click);
            // 
            // textBox_folder_path
            // 
            this.textBox_folder_path.Location = new System.Drawing.Point(188, 44);
            this.textBox_folder_path.Name = "textBox_folder_path";
            this.textBox_folder_path.Size = new System.Drawing.Size(882, 20);
            this.textBox_folder_path.TabIndex = 42;
            this.textBox_folder_path.Text = "C:\\Users\\slobodan.sredojevic\\Desktop\\VS Projects\\XML Configurator\\XML Configurato" +
    "r\\bin\\Debug";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "XML file location";
            // 
            // folderBrowserDialogSaveLocation
            // 
            this.folderBrowserDialogSaveLocation.HelpRequest += new System.EventHandler(this.folderBrowserDialogSaveLocation_HelpRequest);
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(1076, 44);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(71, 24);
            this.button_browse.TabIndex = 43;
            this.button_browse.Text = "Browse...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(188, 7);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(323, 20);
            this.textBox_file_name.TabIndex = 45;
            this.textBox_file_name.Text = "text.xml";
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.Location = new System.Drawing.Point(12, 9);
            this.label_file_name.Name = "label_file_name";
            this.label_file_name.Size = new System.Drawing.Size(74, 13);
            this.label_file_name.TabIndex = 44;
            this.label_file_name.Text = "XML file name";
            // 
            // button_update_object
            // 
            this.button_update_object.Location = new System.Drawing.Point(705, 604);
            this.button_update_object.Name = "button_update_object";
            this.button_update_object.Size = new System.Drawing.Size(114, 23);
            this.button_update_object.TabIndex = 46;
            this.button_update_object.Text = "Update Object";
            this.button_update_object.UseVisualStyleBackColor = true;
            this.button_update_object.Click += new System.EventHandler(this.button_update_object_Click);
            // 
            // openFileDialogLocation
            // 
            this.openFileDialogLocation.DefaultExt = "xml";
            this.openFileDialogLocation.FileName = "openFileDialogXML";
            this.openFileDialogLocation.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialogLocation.InitialDirectory = "s";
            // 
            // button_load_xml
            // 
            this.button_load_xml.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_xml.Location = new System.Drawing.Point(1034, 349);
            this.button_load_xml.Name = "button_load_xml";
            this.button_load_xml.Size = new System.Drawing.Size(113, 24);
            this.button_load_xml.TabIndex = 47;
            this.button_load_xml.Text = "Load XML file...";
            this.button_load_xml.UseVisualStyleBackColor = true;
            this.button_load_xml.Click += new System.EventHandler(this.button_load_xml_Click);
            // 
            // listBox_loaded_tables
            // 
            this.listBox_loaded_tables.FormattingEnabled = true;
            this.listBox_loaded_tables.Location = new System.Drawing.Point(705, 122);
            this.listBox_loaded_tables.Name = "listBox_loaded_tables";
            this.listBox_loaded_tables.Size = new System.Drawing.Size(442, 212);
            this.listBox_loaded_tables.TabIndex = 48;
            this.listBox_loaded_tables.SelectedIndexChanged += new System.EventHandler(this.listBox_loaded_tables_SelectedIndexChanged);
            this.listBox_loaded_tables.DoubleClick += new System.EventHandler(this.listBox_loaded_tables_DoubleClick);
            this.listBox_loaded_tables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_loaded_tables_KeyPress);
            // 
            // label_loaded_tables
            // 
            this.label_loaded_tables.AutoSize = true;
            this.label_loaded_tables.Location = new System.Drawing.Point(621, 122);
            this.label_loaded_tables.Name = "label_loaded_tables";
            this.label_loaded_tables.Size = new System.Drawing.Size(78, 13);
            this.label_loaded_tables.TabIndex = 49;
            this.label_loaded_tables.Text = "Loaded Tables";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.BackgroundImage = global::XML_Configurator.Properties.Resources._1474913677_folder_with_file;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(564, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObjectCreator_NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 796);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_loaded_tables);
            this.Controls.Add(this.listBox_loaded_tables);
            this.Controls.Add(this.button_load_xml);
            this.Controls.Add(this.button_update_object);
            this.Controls.Add(this.textBox_file_name);
            this.Controls.Add(this.label_file_name);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox_folder_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_list_item_move_down);
            this.Controls.Add(this.button_list_item_move_up);
            this.Controls.Add(this.button_delete_list_item);
            this.Controls.Add(this.listView_all_objects);
            this.Controls.Add(this.BUTTON_CREATE_OBJECT);
            this.Controls.Add(this.BUTTON_CREATE_XML);
            this.Controls.Add(this.BUTTON_EXIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectCreator_NEW";
            this.Text = "XML Configurator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BUTTON_EXIT;
        private System.Windows.Forms.Button BUTTON_CREATE_XML;
        private System.Windows.Forms.Button BUTTON_CREATE_OBJECT;
        private System.Windows.Forms.ListBox listView_all_objects;
        private System.Windows.Forms.Button button_delete_list_item;
        private System.Windows.Forms.Button button_list_item_move_up;
        private System.Windows.Forms.Button button_list_item_move_down;
        private System.Windows.Forms.TextBox textBox_folder_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSaveLocation;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox textBox_file_name;
        private System.Windows.Forms.Label label_file_name;
        private System.Windows.Forms.Button button_update_object;
        private System.Windows.Forms.OpenFileDialog openFileDialogLocation;
        private System.Windows.Forms.Button button_load_xml;
        private System.Windows.Forms.ListBox listBox_loaded_tables;
        private System.Windows.Forms.Label label_loaded_tables;
        private System.Windows.Forms.Button button1;
    }
}

