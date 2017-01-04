using XML_Configurator.Custom.Controls;

namespace XML_Configurator
{
    public partial class _02_ObjectCreator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_02_ObjectCreator));
            this.label_object_name = new System.Windows.Forms.Label();
            this.label_object_reload_minutes = new System.Windows.Forms.Label();
            this.label_object_primary_key = new System.Windows.Forms.Label();
            this.label_object_comment = new System.Windows.Forms.Label();
            this.label_object_time_format = new System.Windows.Forms.Label();
            this.label_object_date_format = new System.Windows.Forms.Label();
            this.label_object_datetime_format = new System.Windows.Forms.Label();
            this.label_object_select_statement = new System.Windows.Forms.Label();
            this.label_object_target_extraction_filename = new System.Windows.Forms.Label();
            this.label_object_target_extraction_folder = new System.Windows.Forms.Label();
            this.label_object_transformation_statement = new System.Windows.Forms.Label();
            this.label_object_reorganization = new System.Windows.Forms.Label();
            this.label_object_fieldstoload_statement = new System.Windows.Forms.Label();
            this.label_object_load_type = new System.Windows.Forms.Label();
            this.label_object_active = new System.Windows.Forms.Label();
            this.label_object_where_statement = new System.Windows.Forms.Label();
            this.textBox_object_name = new System.Windows.Forms.TextBox();
            this.textBox_object_reload_minutes = new System.Windows.Forms.TextBox();
            this.textBox_object_primary_key = new System.Windows.Forms.TextBox();
            this.textBox_object_comment = new System.Windows.Forms.TextBox();
            this.textBox_object_time_format = new System.Windows.Forms.TextBox();
            this.textBox_object_date_format = new System.Windows.Forms.TextBox();
            this.textBox_object_datetime_format = new System.Windows.Forms.TextBox();
            this.textBox_object_select_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_target_extraction_filename = new System.Windows.Forms.TextBox();
            this.textBox_object_target_extraction_folder = new System.Windows.Forms.TextBox();
            this.textBox_object_transformation_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_reorganization = new System.Windows.Forms.TextBox();
            this.textBox_object_fieldstoload_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_where_statement = new System.Windows.Forms.TextBox();
            this.checkBox_object_active = new System.Windows.Forms.CheckBox();
            this.comboBox_object_load_type = new System.Windows.Forms.ComboBox();
            this.textBox_folder_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label_file_name = new System.Windows.Forms.Label();
            this.openFileDialogLocation = new System.Windows.Forms.OpenFileDialog();
            this.listBox_loaded_tables = new System.Windows.Forms.ListBox();
            this.label_loaded_tables = new System.Windows.Forms.Label();
            this.listView_all_objects = new System.Windows.Forms.ListView();
            this.Object_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_load_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.button_set_all_notactive = new System.Windows.Forms.Button();
            this.button_set_all_active = new System.Windows.Forms.Button();
            this.button_go_back_database_connector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_loaded_datasources = new System.Windows.Forms.ComboBox();
            this.textBox_current_database = new System.Windows.Forms.TextBox();
            this.button_next_transform = new System.Windows.Forms.Button();
            this.button_execute_test_statement = new System.Windows.Forms.Button();
            this.button_create_all_loaded_items = new System.Windows.Forms.Button();
            this.button_load_sample_object = new System.Windows.Forms.Button();
            this.button_remove_all_listviewitems = new System.Windows.Forms.Button();
            this.button_load_xml = new System.Windows.Forms.Button();
            this.button_update_object = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_list_item_move_down = new System.Windows.Forms.Button();
            this.button_list_item_move_up = new System.Windows.Forms.Button();
            this.button_delete_list_item = new System.Windows.Forms.Button();
            this.BUTTON_CREATE_OBJECT = new System.Windows.Forms.Button();
            this.BUTTON_CREATE_XML = new System.Windows.Forms.Button();
            this.BUTTON_EXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // label_object_name
            // 
            this.label_object_name.AutoSize = true;
            this.label_object_name.Location = new System.Drawing.Point(12, 157);
            this.label_object_name.Name = "label_object_name";
            this.label_object_name.Size = new System.Drawing.Size(68, 13);
            this.label_object_name.TabIndex = 1;
            this.label_object_name.Text = "object_name";
            // 
            // label_object_reload_minutes
            // 
            this.label_object_reload_minutes.AutoSize = true;
            this.label_object_reload_minutes.Location = new System.Drawing.Point(12, 187);
            this.label_object_reload_minutes.Name = "label_object_reload_minutes";
            this.label_object_reload_minutes.Size = new System.Drawing.Size(113, 13);
            this.label_object_reload_minutes.TabIndex = 2;
            this.label_object_reload_minutes.Text = "object_reload_minutes";
            // 
            // label_object_primary_key
            // 
            this.label_object_primary_key.AutoSize = true;
            this.label_object_primary_key.Location = new System.Drawing.Point(12, 247);
            this.label_object_primary_key.Name = "label_object_primary_key";
            this.label_object_primary_key.Size = new System.Drawing.Size(98, 13);
            this.label_object_primary_key.TabIndex = 4;
            this.label_object_primary_key.Text = "object_primary_key";
            // 
            // label_object_comment
            // 
            this.label_object_comment.AutoSize = true;
            this.label_object_comment.Location = new System.Drawing.Point(12, 217);
            this.label_object_comment.Name = "label_object_comment";
            this.label_object_comment.Size = new System.Drawing.Size(85, 13);
            this.label_object_comment.TabIndex = 3;
            this.label_object_comment.Text = "object_comment";
            // 
            // label_object_time_format
            // 
            this.label_object_time_format.AutoSize = true;
            this.label_object_time_format.Location = new System.Drawing.Point(12, 548);
            this.label_object_time_format.Name = "label_object_time_format";
            this.label_object_time_format.Size = new System.Drawing.Size(96, 13);
            this.label_object_time_format.TabIndex = 8;
            this.label_object_time_format.Text = "object_time_format";
            // 
            // label_object_date_format
            // 
            this.label_object_date_format.AutoSize = true;
            this.label_object_date_format.Location = new System.Drawing.Point(12, 515);
            this.label_object_date_format.Name = "label_object_date_format";
            this.label_object_date_format.Size = new System.Drawing.Size(98, 13);
            this.label_object_date_format.TabIndex = 7;
            this.label_object_date_format.Text = "object_date_format";
            // 
            // label_object_datetime_format
            // 
            this.label_object_datetime_format.AutoSize = true;
            this.label_object_datetime_format.Location = new System.Drawing.Point(12, 485);
            this.label_object_datetime_format.Name = "label_object_datetime_format";
            this.label_object_datetime_format.Size = new System.Drawing.Size(117, 13);
            this.label_object_datetime_format.TabIndex = 6;
            this.label_object_datetime_format.Text = "object_datetime_format";
            // 
            // label_object_select_statement
            // 
            this.label_object_select_statement.AutoSize = true;
            this.label_object_select_statement.Location = new System.Drawing.Point(12, 277);
            this.label_object_select_statement.Name = "label_object_select_statement";
            this.label_object_select_statement.Size = new System.Drawing.Size(122, 13);
            this.label_object_select_statement.TabIndex = 5;
            this.label_object_select_statement.Text = "object_select_statement";
            // 
            // label_object_target_extraction_filename
            // 
            this.label_object_target_extraction_filename.AutoSize = true;
            this.label_object_target_extraction_filename.Location = new System.Drawing.Point(12, 648);
            this.label_object_target_extraction_filename.Name = "label_object_target_extraction_filename";
            this.label_object_target_extraction_filename.Size = new System.Drawing.Size(166, 13);
            this.label_object_target_extraction_filename.TabIndex = 16;
            this.label_object_target_extraction_filename.Text = "object_target_extraction_filename";
            // 
            // label_object_target_extraction_folder
            // 
            this.label_object_target_extraction_folder.AutoSize = true;
            this.label_object_target_extraction_folder.Location = new System.Drawing.Point(12, 615);
            this.label_object_target_extraction_folder.Name = "label_object_target_extraction_folder";
            this.label_object_target_extraction_folder.Size = new System.Drawing.Size(153, 13);
            this.label_object_target_extraction_folder.TabIndex = 15;
            this.label_object_target_extraction_folder.Text = "object_target_extraction_folder";
            // 
            // label_object_transformation_statement
            // 
            this.label_object_transformation_statement.AutoSize = true;
            this.label_object_transformation_statement.Location = new System.Drawing.Point(653, 648);
            this.label_object_transformation_statement.Name = "label_object_transformation_statement";
            this.label_object_transformation_statement.Size = new System.Drawing.Size(160, 13);
            this.label_object_transformation_statement.TabIndex = 14;
            this.label_object_transformation_statement.Text = "object_transformation_statement";
            // 
            // label_object_reorganization
            // 
            this.label_object_reorganization.AutoSize = true;
            this.label_object_reorganization.Location = new System.Drawing.Point(12, 582);
            this.label_object_reorganization.Name = "label_object_reorganization";
            this.label_object_reorganization.Size = new System.Drawing.Size(108, 13);
            this.label_object_reorganization.TabIndex = 13;
            this.label_object_reorganization.Text = "object_reorganization";
            // 
            // label_object_fieldstoload_statement
            // 
            this.label_object_fieldstoload_statement.AutoSize = true;
            this.label_object_fieldstoload_statement.Location = new System.Drawing.Point(653, 401);
            this.label_object_fieldstoload_statement.Name = "label_object_fieldstoload_statement";
            this.label_object_fieldstoload_statement.Size = new System.Drawing.Size(147, 13);
            this.label_object_fieldstoload_statement.TabIndex = 12;
            this.label_object_fieldstoload_statement.Text = "object_fieldstoload_statement";
            // 
            // label_object_load_type
            // 
            this.label_object_load_type.AutoSize = true;
            this.label_object_load_type.Location = new System.Drawing.Point(398, 126);
            this.label_object_load_type.Name = "label_object_load_type";
            this.label_object_load_type.Size = new System.Drawing.Size(88, 13);
            this.label_object_load_type.TabIndex = 11;
            this.label_object_load_type.Text = "object_load_type";
            // 
            // label_object_active
            // 
            this.label_object_active.AutoSize = true;
            this.label_object_active.Location = new System.Drawing.Point(185, 126);
            this.label_object_active.Name = "label_object_active";
            this.label_object_active.Size = new System.Drawing.Size(71, 13);
            this.label_object_active.TabIndex = 10;
            this.label_object_active.Text = "object_active";
            // 
            // label_object_where_statement
            // 
            this.label_object_where_statement.AutoSize = true;
            this.label_object_where_statement.Location = new System.Drawing.Point(653, 160);
            this.label_object_where_statement.Name = "label_object_where_statement";
            this.label_object_where_statement.Size = new System.Drawing.Size(123, 13);
            this.label_object_where_statement.TabIndex = 9;
            this.label_object_where_statement.Text = "object_where_statement";
            // 
            // textBox_object_name
            // 
            this.textBox_object_name.Location = new System.Drawing.Point(188, 157);
            this.textBox_object_name.Name = "textBox_object_name";
            this.textBox_object_name.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_name.TabIndex = 17;
            this.textBox_object_name.TextChanged += new System.EventHandler(this.textBox_object_name_TextChanged);
            // 
            // textBox_object_reload_minutes
            // 
            this.textBox_object_reload_minutes.Location = new System.Drawing.Point(188, 187);
            this.textBox_object_reload_minutes.Name = "textBox_object_reload_minutes";
            this.textBox_object_reload_minutes.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_reload_minutes.TabIndex = 18;
            // 
            // textBox_object_primary_key
            // 
            this.textBox_object_primary_key.Location = new System.Drawing.Point(188, 247);
            this.textBox_object_primary_key.Name = "textBox_object_primary_key";
            this.textBox_object_primary_key.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_primary_key.TabIndex = 20;
            // 
            // textBox_object_comment
            // 
            this.textBox_object_comment.Location = new System.Drawing.Point(188, 217);
            this.textBox_object_comment.Name = "textBox_object_comment";
            this.textBox_object_comment.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_comment.TabIndex = 19;
            // 
            // textBox_object_time_format
            // 
            this.textBox_object_time_format.Location = new System.Drawing.Point(188, 545);
            this.textBox_object_time_format.Name = "textBox_object_time_format";
            this.textBox_object_time_format.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_time_format.TabIndex = 24;
            // 
            // textBox_object_date_format
            // 
            this.textBox_object_date_format.Location = new System.Drawing.Point(188, 515);
            this.textBox_object_date_format.Name = "textBox_object_date_format";
            this.textBox_object_date_format.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_date_format.TabIndex = 23;
            // 
            // textBox_object_datetime_format
            // 
            this.textBox_object_datetime_format.Location = new System.Drawing.Point(188, 485);
            this.textBox_object_datetime_format.Name = "textBox_object_datetime_format";
            this.textBox_object_datetime_format.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_datetime_format.TabIndex = 22;
            // 
            // textBox_object_select_statement
            // 
            this.textBox_object_select_statement.AcceptsReturn = true;
            this.textBox_object_select_statement.AcceptsTab = true;
            this.textBox_object_select_statement.Location = new System.Drawing.Point(188, 277);
            this.textBox_object_select_statement.Multiline = true;
            this.textBox_object_select_statement.Name = "textBox_object_select_statement";
            this.textBox_object_select_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_select_statement.Size = new System.Drawing.Size(425, 202);
            this.textBox_object_select_statement.TabIndex = 21;
            // 
            // textBox_object_target_extraction_filename
            // 
            this.textBox_object_target_extraction_filename.Location = new System.Drawing.Point(188, 645);
            this.textBox_object_target_extraction_filename.Name = "textBox_object_target_extraction_filename";
            this.textBox_object_target_extraction_filename.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_target_extraction_filename.TabIndex = 32;
            // 
            // textBox_object_target_extraction_folder
            // 
            this.textBox_object_target_extraction_folder.Location = new System.Drawing.Point(188, 612);
            this.textBox_object_target_extraction_folder.Name = "textBox_object_target_extraction_folder";
            this.textBox_object_target_extraction_folder.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_target_extraction_folder.TabIndex = 31;
            // 
            // textBox_object_transformation_statement
            // 
            this.textBox_object_transformation_statement.Location = new System.Drawing.Point(819, 648);
            this.textBox_object_transformation_statement.Multiline = true;
            this.textBox_object_transformation_statement.Name = "textBox_object_transformation_statement";
            this.textBox_object_transformation_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_transformation_statement.Size = new System.Drawing.Size(425, 231);
            this.textBox_object_transformation_statement.TabIndex = 30;
            // 
            // textBox_object_reorganization
            // 
            this.textBox_object_reorganization.Location = new System.Drawing.Point(188, 579);
            this.textBox_object_reorganization.Name = "textBox_object_reorganization";
            this.textBox_object_reorganization.Size = new System.Drawing.Size(425, 20);
            this.textBox_object_reorganization.TabIndex = 29;
            // 
            // textBox_object_fieldstoload_statement
            // 
            this.textBox_object_fieldstoload_statement.Location = new System.Drawing.Point(819, 401);
            this.textBox_object_fieldstoload_statement.Multiline = true;
            this.textBox_object_fieldstoload_statement.Name = "textBox_object_fieldstoload_statement";
            this.textBox_object_fieldstoload_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_fieldstoload_statement.Size = new System.Drawing.Size(425, 231);
            this.textBox_object_fieldstoload_statement.TabIndex = 28;
            // 
            // textBox_object_where_statement
            // 
            this.textBox_object_where_statement.Location = new System.Drawing.Point(819, 157);
            this.textBox_object_where_statement.Multiline = true;
            this.textBox_object_where_statement.Name = "textBox_object_where_statement";
            this.textBox_object_where_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_where_statement.Size = new System.Drawing.Size(425, 231);
            this.textBox_object_where_statement.TabIndex = 25;
            // 
            // checkBox_object_active
            // 
            this.checkBox_object_active.AutoSize = true;
            this.checkBox_object_active.Location = new System.Drawing.Point(262, 126);
            this.checkBox_object_active.Name = "checkBox_object_active";
            this.checkBox_object_active.Size = new System.Drawing.Size(15, 14);
            this.checkBox_object_active.TabIndex = 34;
            this.checkBox_object_active.UseVisualStyleBackColor = true;
            // 
            // comboBox_object_load_type
            // 
            this.comboBox_object_load_type.FormattingEnabled = true;
            this.comboBox_object_load_type.Location = new System.Drawing.Point(492, 123);
            this.comboBox_object_load_type.Name = "comboBox_object_load_type";
            this.comboBox_object_load_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_object_load_type.TabIndex = 35;
            this.comboBox_object_load_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_object_load_type_SelectedIndexChanged);
            // 
            // textBox_folder_path
            // 
            this.textBox_folder_path.Location = new System.Drawing.Point(188, 38);
            this.textBox_folder_path.Name = "textBox_folder_path";
            this.textBox_folder_path.Size = new System.Drawing.Size(1013, 20);
            this.textBox_folder_path.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "XML file location";
            // 
            // folderBrowserDialogSaveLocation
            // 
            this.folderBrowserDialogSaveLocation.HelpRequest += new System.EventHandler(this.folderBrowserDialogSaveLocation_HelpRequest);
            // 
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(188, 7);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(457, 20);
            this.textBox_file_name.TabIndex = 45;
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
            // openFileDialogLocation
            // 
            this.openFileDialogLocation.DefaultExt = "xml";
            this.openFileDialogLocation.FileName = "openFileDialogXML";
            this.openFileDialogLocation.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialogLocation.InitialDirectory = "s";
            // 
            // listBox_loaded_tables
            // 
            this.listBox_loaded_tables.FormattingEnabled = true;
            this.listBox_loaded_tables.Location = new System.Drawing.Point(1332, 116);
            this.listBox_loaded_tables.Name = "listBox_loaded_tables";
            this.listBox_loaded_tables.Size = new System.Drawing.Size(442, 212);
            this.listBox_loaded_tables.TabIndex = 48;
            this.listBox_loaded_tables.SelectedIndexChanged += new System.EventHandler(this.listBox_loaded_tables_SelectedIndexChanged);
            this.listBox_loaded_tables.DoubleClick += new System.EventHandler(this.listBox_loaded_tables_DoubleClick);
            // 
            // label_loaded_tables
            // 
            this.label_loaded_tables.AutoSize = true;
            this.label_loaded_tables.Location = new System.Drawing.Point(1329, 87);
            this.label_loaded_tables.Name = "label_loaded_tables";
            this.label_loaded_tables.Size = new System.Drawing.Size(144, 13);
            this.label_loaded_tables.TabIndex = 49;
            this.label_loaded_tables.Text = "Loaded tables from database";
            // 
            // listView_all_objects
            // 
            this.listView_all_objects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Object_Name,
            this.Object_Active,
            this.Object_load_type});
            this.listView_all_objects.FullRowSelect = true;
            this.listView_all_objects.GridLines = true;
            this.listView_all_objects.HideSelection = false;
            this.listView_all_objects.Location = new System.Drawing.Point(1332, 373);
            this.listView_all_objects.MultiSelect = false;
            this.listView_all_objects.Name = "listView_all_objects";
            this.listView_all_objects.Size = new System.Drawing.Size(442, 517);
            this.listView_all_objects.TabIndex = 50;
            this.listView_all_objects.UseCompatibleStateImageBehavior = false;
            this.listView_all_objects.View = System.Windows.Forms.View.Details;
            this.listView_all_objects.SelectedIndexChanged += new System.EventHandler(this.listView_all_objects_SelectedIndexChanged);
            // 
            // Object_Name
            // 
            this.Object_Name.Text = "Object Name";
            this.Object_Name.Width = 271;
            // 
            // Object_Active
            // 
            this.Object_Active.Text = "Object Active";
            this.Object_Active.Width = 80;
            // 
            // Object_load_type
            // 
            this.Object_load_type.Text = "Extraction Type";
            this.Object_load_type.Width = 87;
            // 
            // button_set_all_notactive
            // 
            this.button_set_all_notactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_set_all_notactive.Location = new System.Drawing.Point(1294, 851);
            this.button_set_all_notactive.Name = "button_set_all_notactive";
            this.button_set_all_notactive.Size = new System.Drawing.Size(32, 32);
            this.button_set_all_notactive.TabIndex = 56;
            this.button_set_all_notactive.Text = "N";
            this.toolTips.SetToolTip(this.button_set_all_notactive, "Set all items in the list to not active");
            this.button_set_all_notactive.UseVisualStyleBackColor = true;
            this.button_set_all_notactive.Click += new System.EventHandler(this.button_set_all_notactive_Click);
            // 
            // button_set_all_active
            // 
            this.button_set_all_active.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_set_all_active.Location = new System.Drawing.Point(1294, 813);
            this.button_set_all_active.Name = "button_set_all_active";
            this.button_set_all_active.Size = new System.Drawing.Size(32, 32);
            this.button_set_all_active.TabIndex = 55;
            this.button_set_all_active.Text = "Y";
            this.toolTips.SetToolTip(this.button_set_all_active, "Set all items in the list to active");
            this.button_set_all_active.UseVisualStyleBackColor = true;
            this.button_set_all_active.Click += new System.EventHandler(this.button_set_all_active_Click);
            // 
            // button_go_back_database_connector
            // 
            this.button_go_back_database_connector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_go_back_database_connector.Location = new System.Drawing.Point(1169, 0);
            this.button_go_back_database_connector.Name = "button_go_back_database_connector";
            this.button_go_back_database_connector.Size = new System.Drawing.Size(32, 32);
            this.button_go_back_database_connector.TabIndex = 62;
            this.button_go_back_database_connector.Text = "<-";
            this.toolTips.SetToolTip(this.button_go_back_database_connector, "Return to database connection screen");
            this.button_go_back_database_connector.UseVisualStyleBackColor = true;
            this.button_go_back_database_connector.Click += new System.EventHandler(this.button_go_back_database_connector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1329, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Created objects";
            // 
            // EP
            // 
            this.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EP.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(958, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Database";
            // 
            // comboBox_loaded_datasources
            // 
            this.comboBox_loaded_datasources.FormattingEnabled = true;
            this.comboBox_loaded_datasources.Location = new System.Drawing.Point(1017, 5);
            this.comboBox_loaded_datasources.Name = "comboBox_loaded_datasources";
            this.comboBox_loaded_datasources.Size = new System.Drawing.Size(146, 21);
            this.comboBox_loaded_datasources.TabIndex = 64;
            // 
            // textBox_current_database
            // 
            this.textBox_current_database.CausesValidation = false;
            this.textBox_current_database.Enabled = false;
            this.textBox_current_database.Location = new System.Drawing.Point(1207, 6);
            this.textBox_current_database.Name = "textBox_current_database";
            this.textBox_current_database.Size = new System.Drawing.Size(146, 20);
            this.textBox_current_database.TabIndex = 60;
            this.textBox_current_database.Text = "No Database";
            // 
            // button_next_transform
            // 
            this.button_next_transform.BackgroundImage = global::XML_Configurator.Properties.Resources._1481573303_Next;
            this.button_next_transform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next_transform.Location = new System.Drawing.Point(1704, 904);
            this.button_next_transform.Name = "button_next_transform";
            this.button_next_transform.Size = new System.Drawing.Size(32, 32);
            this.button_next_transform.TabIndex = 65;
            this.toolTips.SetToolTip(this.button_next_transform, "Go to next form for transformation");
            this.button_next_transform.UseVisualStyleBackColor = true;
            this.button_next_transform.Click += new System.EventHandler(this.button_next_transform_Click);
            // 
            // button_execute_test_statement
            // 
            this.button_execute_test_statement.BackgroundImage = global::XML_Configurator.Properties.Resources._1481559993_icon_89_document_file_sql;
            this.button_execute_test_statement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_execute_test_statement.Location = new System.Drawing.Point(619, 277);
            this.button_execute_test_statement.Name = "button_execute_test_statement";
            this.button_execute_test_statement.Size = new System.Drawing.Size(32, 32);
            this.button_execute_test_statement.TabIndex = 63;
            this.toolTips.SetToolTip(this.button_execute_test_statement, "Execute statement to return number of rows affected\r\non current database\r\n");
            this.button_execute_test_statement.UseVisualStyleBackColor = true;
            this.button_execute_test_statement.Click += new System.EventHandler(this.button_execute_test_statement_Click);
            // 
            // button_create_all_loaded_items
            // 
            this.button_create_all_loaded_items.BackgroundImage = global::XML_Configurator.Properties.Resources._1475159585_document_add;
            this.button_create_all_loaded_items.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_create_all_loaded_items.Location = new System.Drawing.Point(1294, 116);
            this.button_create_all_loaded_items.Name = "button_create_all_loaded_items";
            this.button_create_all_loaded_items.Size = new System.Drawing.Size(32, 32);
            this.button_create_all_loaded_items.TabIndex = 53;
            this.toolTips.SetToolTip(this.button_create_all_loaded_items, "Add all items from list of loaded tables from database");
            this.button_create_all_loaded_items.UseVisualStyleBackColor = true;
            this.button_create_all_loaded_items.Click += new System.EventHandler(this.button_create_all_loaded_items_Click);
            // 
            // button_load_sample_object
            // 
            this.button_load_sample_object.AccessibleDescription = "";
            this.button_load_sample_object.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_load_sample_object.BackgroundImage")));
            this.button_load_sample_object.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_load_sample_object.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_sample_object.Location = new System.Drawing.Point(15, 68);
            this.button_load_sample_object.Name = "button_load_sample_object";
            this.button_load_sample_object.Size = new System.Drawing.Size(32, 32);
            this.button_load_sample_object.TabIndex = 52;
            this.toolTips.SetToolTip(this.button_load_sample_object, "Populate fields with sample data");
            this.button_load_sample_object.UseVisualStyleBackColor = true;
            this.button_load_sample_object.Click += new System.EventHandler(this.button_load_sample_object_Click);
            // 
            // button_remove_all_listviewitems
            // 
            this.button_remove_all_listviewitems.BackgroundImage = global::XML_Configurator.Properties.Resources._1474912315_human_user_trash;
            this.button_remove_all_listviewitems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_remove_all_listviewitems.Location = new System.Drawing.Point(1294, 576);
            this.button_remove_all_listviewitems.Name = "button_remove_all_listviewitems";
            this.button_remove_all_listviewitems.Size = new System.Drawing.Size(32, 32);
            this.button_remove_all_listviewitems.TabIndex = 51;
            this.toolTips.SetToolTip(this.button_remove_all_listviewitems, "Remove all objects from the list");
            this.button_remove_all_listviewitems.UseVisualStyleBackColor = true;
            this.button_remove_all_listviewitems.Click += new System.EventHandler(this.button_remove_all_listviewitems_Click);
            // 
            // button_load_xml
            // 
            this.button_load_xml.AccessibleDescription = "";
            this.button_load_xml.BackgroundImage = global::XML_Configurator.Properties.Resources._1474913677_folder_with_file;
            this.button_load_xml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_load_xml.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_xml.Location = new System.Drawing.Point(1742, 334);
            this.button_load_xml.Name = "button_load_xml";
            this.button_load_xml.Size = new System.Drawing.Size(32, 32);
            this.button_load_xml.TabIndex = 47;
            this.toolTips.SetToolTip(this.button_load_xml, "Load XML file from location");
            this.button_load_xml.UseVisualStyleBackColor = true;
            this.button_load_xml.Click += new System.EventHandler(this.button_load_xml_Click);
            // 
            // button_update_object
            // 
            this.button_update_object.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update_object.BackgroundImage")));
            this.button_update_object.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_update_object.Location = new System.Drawing.Point(65, 679);
            this.button_update_object.Name = "button_update_object";
            this.button_update_object.Size = new System.Drawing.Size(32, 32);
            this.button_update_object.TabIndex = 46;
            this.toolTips.SetToolTip(this.button_update_object, "Update selected object in the list");
            this.button_update_object.UseVisualStyleBackColor = true;
            this.button_update_object.Click += new System.EventHandler(this.button_update_object_Click);
            // 
            // button_browse
            // 
            this.button_browse.BackgroundImage = global::XML_Configurator.Properties.Resources._1474913320_manilla_folder_saved_search;
            this.button_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_browse.Location = new System.Drawing.Point(651, 0);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(32, 32);
            this.button_browse.TabIndex = 43;
            this.toolTips.SetToolTip(this.button_browse, "Browse location to store XML file");
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_list_item_move_down
            // 
            this.button_list_item_move_down.BackgroundImage = global::XML_Configurator.Properties.Resources._1474911115_Stock_Index_Down;
            this.button_list_item_move_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_list_item_move_down.Location = new System.Drawing.Point(1294, 411);
            this.button_list_item_move_down.Name = "button_list_item_move_down";
            this.button_list_item_move_down.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_list_item_move_down.Size = new System.Drawing.Size(32, 32);
            this.button_list_item_move_down.TabIndex = 40;
            this.toolTips.SetToolTip(this.button_list_item_move_down, "Move object down in the list");
            this.button_list_item_move_down.UseVisualStyleBackColor = true;
            this.button_list_item_move_down.Click += new System.EventHandler(this.button_list_item_move_down_Click);
            // 
            // button_list_item_move_up
            // 
            this.button_list_item_move_up.BackgroundImage = global::XML_Configurator.Properties.Resources._1474911113_Stock_Index_Up;
            this.button_list_item_move_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_list_item_move_up.Location = new System.Drawing.Point(1294, 373);
            this.button_list_item_move_up.Name = "button_list_item_move_up";
            this.button_list_item_move_up.Size = new System.Drawing.Size(32, 32);
            this.button_list_item_move_up.TabIndex = 39;
            this.toolTips.SetToolTip(this.button_list_item_move_up, "Move object up in the list");
            this.button_list_item_move_up.UseVisualStyleBackColor = true;
            this.button_list_item_move_up.Click += new System.EventHandler(this.button_list_item_move_up_Click);
            // 
            // button_delete_list_item
            // 
            this.button_delete_list_item.BackgroundImage = global::XML_Configurator.Properties.Resources._1474911120_Error;
            this.button_delete_list_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_delete_list_item.Location = new System.Drawing.Point(1294, 538);
            this.button_delete_list_item.Name = "button_delete_list_item";
            this.button_delete_list_item.Size = new System.Drawing.Size(32, 32);
            this.button_delete_list_item.TabIndex = 38;
            this.toolTips.SetToolTip(this.button_delete_list_item, "Remove object from the list");
            this.button_delete_list_item.UseVisualStyleBackColor = true;
            this.button_delete_list_item.Click += new System.EventHandler(this.button_delete_list_item_Click);
            // 
            // BUTTON_CREATE_OBJECT
            // 
            this.BUTTON_CREATE_OBJECT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUTTON_CREATE_OBJECT.BackgroundImage")));
            this.BUTTON_CREATE_OBJECT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUTTON_CREATE_OBJECT.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUTTON_CREATE_OBJECT.Location = new System.Drawing.Point(15, 679);
            this.BUTTON_CREATE_OBJECT.Name = "BUTTON_CREATE_OBJECT";
            this.BUTTON_CREATE_OBJECT.Size = new System.Drawing.Size(32, 32);
            this.BUTTON_CREATE_OBJECT.TabIndex = 33;
            this.toolTips.SetToolTip(this.BUTTON_CREATE_OBJECT, "Create new object in the list");
            this.BUTTON_CREATE_OBJECT.UseVisualStyleBackColor = true;
            this.BUTTON_CREATE_OBJECT.Click += new System.EventHandler(this.BUTTON_CREATE_OBJECT_Click);
            // 
            // BUTTON_CREATE_XML
            // 
            this.BUTTON_CREATE_XML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUTTON_CREATE_XML.BackgroundImage")));
            this.BUTTON_CREATE_XML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUTTON_CREATE_XML.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUTTON_CREATE_XML.Location = new System.Drawing.Point(1332, 904);
            this.BUTTON_CREATE_XML.Name = "BUTTON_CREATE_XML";
            this.BUTTON_CREATE_XML.Size = new System.Drawing.Size(32, 32);
            this.BUTTON_CREATE_XML.TabIndex = 0;
            this.toolTips.SetToolTip(this.BUTTON_CREATE_XML, "Create XML file with objects from the list on chosen location");
            this.BUTTON_CREATE_XML.UseVisualStyleBackColor = true;
            this.BUTTON_CREATE_XML.Click += new System.EventHandler(this.BUTTON_CREATE_XML_Click);
            // 
            // BUTTON_EXIT
            // 
            this.BUTTON_EXIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUTTON_EXIT.BackgroundImage")));
            this.BUTTON_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUTTON_EXIT.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUTTON_EXIT.Location = new System.Drawing.Point(1742, 904);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(32, 32);
            this.BUTTON_EXIT.TabIndex = 0;
            this.toolTips.SetToolTip(this.BUTTON_EXIT, "Exit Application");
            this.BUTTON_EXIT.UseVisualStyleBackColor = true;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // _02_ObjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1874, 735);
            this.Controls.Add(this.button_next_transform);
            this.Controls.Add(this.comboBox_loaded_datasources);
            this.Controls.Add(this.button_execute_test_statement);
            this.Controls.Add(this.button_go_back_database_connector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_current_database);
            this.Controls.Add(this.button_set_all_notactive);
            this.Controls.Add(this.button_set_all_active);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_create_all_loaded_items);
            this.Controls.Add(this.button_load_sample_object);
            this.Controls.Add(this.button_remove_all_listviewitems);
            this.Controls.Add(this.listView_all_objects);
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
            this.Controls.Add(this.comboBox_object_load_type);
            this.Controls.Add(this.checkBox_object_active);
            this.Controls.Add(this.BUTTON_CREATE_OBJECT);
            this.Controls.Add(this.textBox_object_target_extraction_filename);
            this.Controls.Add(this.textBox_object_target_extraction_folder);
            this.Controls.Add(this.textBox_object_transformation_statement);
            this.Controls.Add(this.textBox_object_reorganization);
            this.Controls.Add(this.textBox_object_fieldstoload_statement);
            this.Controls.Add(this.textBox_object_where_statement);
            this.Controls.Add(this.textBox_object_time_format);
            this.Controls.Add(this.textBox_object_date_format);
            this.Controls.Add(this.textBox_object_datetime_format);
            this.Controls.Add(this.textBox_object_select_statement);
            this.Controls.Add(this.textBox_object_primary_key);
            this.Controls.Add(this.textBox_object_comment);
            this.Controls.Add(this.textBox_object_reload_minutes);
            this.Controls.Add(this.textBox_object_name);
            this.Controls.Add(this.label_object_target_extraction_filename);
            this.Controls.Add(this.label_object_target_extraction_folder);
            this.Controls.Add(this.label_object_transformation_statement);
            this.Controls.Add(this.label_object_reorganization);
            this.Controls.Add(this.label_object_fieldstoload_statement);
            this.Controls.Add(this.label_object_load_type);
            this.Controls.Add(this.label_object_active);
            this.Controls.Add(this.label_object_where_statement);
            this.Controls.Add(this.label_object_time_format);
            this.Controls.Add(this.label_object_date_format);
            this.Controls.Add(this.label_object_datetime_format);
            this.Controls.Add(this.label_object_select_statement);
            this.Controls.Add(this.label_object_primary_key);
            this.Controls.Add(this.label_object_comment);
            this.Controls.Add(this.label_object_reload_minutes);
            this.Controls.Add(this.label_object_name);
            this.Controls.Add(this.BUTTON_CREATE_XML);
            this.Controls.Add(this.BUTTON_EXIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_02_ObjectCreator";
            this.Text = "XML Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectCreator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BUTTON_EXIT;
        private System.Windows.Forms.Button BUTTON_CREATE_XML;
        private System.Windows.Forms.Label label_object_name;
        private System.Windows.Forms.Label label_object_reload_minutes;
        private System.Windows.Forms.Label label_object_primary_key;
        private System.Windows.Forms.Label label_object_comment;
        private System.Windows.Forms.Label label_object_time_format;
        private System.Windows.Forms.Label label_object_date_format;
        private System.Windows.Forms.Label label_object_datetime_format;
        private System.Windows.Forms.Label label_object_select_statement;
        private System.Windows.Forms.Label label_object_target_extraction_filename;
        private System.Windows.Forms.Label label_object_target_extraction_folder;
        private System.Windows.Forms.Label label_object_transformation_statement;
        private System.Windows.Forms.Label label_object_fieldstoload_statement;
        private System.Windows.Forms.Label label_object_load_type;
        private System.Windows.Forms.Label label_object_active;
        private System.Windows.Forms.Label label_object_where_statement;
        private System.Windows.Forms.TextBox textBox_object_name;
        private System.Windows.Forms.TextBox textBox_object_reload_minutes;
        private System.Windows.Forms.TextBox textBox_object_primary_key;
        private System.Windows.Forms.TextBox textBox_object_comment;
        private System.Windows.Forms.TextBox textBox_object_time_format;
        private System.Windows.Forms.TextBox textBox_object_date_format;
        private System.Windows.Forms.TextBox textBox_object_datetime_format;
        private System.Windows.Forms.TextBox textBox_object_select_statement;
        private System.Windows.Forms.TextBox textBox_object_target_extraction_filename;
        private System.Windows.Forms.TextBox textBox_object_target_extraction_folder;
        private System.Windows.Forms.TextBox textBox_object_transformation_statement;
        private System.Windows.Forms.TextBox textBox_object_reorganization;
        private System.Windows.Forms.TextBox textBox_object_fieldstoload_statement;
        private System.Windows.Forms.TextBox textBox_object_where_statement;
        private System.Windows.Forms.Label label_object_reorganization;
        private System.Windows.Forms.Button BUTTON_CREATE_OBJECT;
        private System.Windows.Forms.CheckBox checkBox_object_active;
        private System.Windows.Forms.ComboBox comboBox_object_load_type;
        private System.Windows.Forms.Button button_delete_list_item;
        private System.Windows.Forms.Button button_list_item_move_up;
        private System.Windows.Forms.Button button_list_item_move_down;
        public System.Windows.Forms.TextBox textBox_folder_path;
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
        private System.Windows.Forms.ListView listView_all_objects;
        private System.Windows.Forms.ColumnHeader Object_Name;
        private System.Windows.Forms.ColumnHeader Object_Active;
        private System.Windows.Forms.Button button_remove_all_listviewitems;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button button_load_sample_object;
        private System.Windows.Forms.Button button_create_all_loaded_items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_set_all_active;
        private System.Windows.Forms.Button button_set_all_notactive;
        private System.Windows.Forms.ErrorProvider EP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_go_back_database_connector;
        private System.Windows.Forms.Button button_execute_test_statement;
        private System.Windows.Forms.ComboBox comboBox_loaded_datasources;
        private System.Windows.Forms.TextBox textBox_current_database;
        private System.Windows.Forms.ColumnHeader Object_load_type;
        private System.Windows.Forms.Button button_next_transform;
    }
}

