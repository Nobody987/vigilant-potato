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
            this.listView_all_objects = new System.Windows.Forms.ListView();
            this.Object_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_load_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.button_set_all_notactive = new System.Windows.Forms.Button();
            this.button_set_all_active = new System.Windows.Forms.Button();
            this.button_go_back_database_connector = new System.Windows.Forms.Button();
            this.button_next_transform = new System.Windows.Forms.Button();
            this.button_execute_test_statement = new System.Windows.Forms.Button();
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
            this.button_load_sample_transformation = new System.Windows.Forms.Button();
            this.button_update_transformation = new System.Windows.Forms.Button();
            this.button_create_transformation = new System.Windows.Forms.Button();
            this.button_browse_2 = new System.Windows.Forms.Button();
            this.button_load_transformation_file = new System.Windows.Forms.Button();
            this.button_set_all_notactive_2 = new System.Windows.Forms.Button();
            this.button_set_all_active_2 = new System.Windows.Forms.Button();
            this.button_remove_all_listviewitems_2 = new System.Windows.Forms.Button();
            this.button_list_item_move_down_2 = new System.Windows.Forms.Button();
            this.button_list_item_move_up_2 = new System.Windows.Forms.Button();
            this.button_delete_list_item_2 = new System.Windows.Forms.Button();
            this.button_back_generator = new System.Windows.Forms.Button();
            this.button_create_transformation_file = new System.Windows.Forms.Button();
            this.button_exit_2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_loaded_datasources = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGenerator = new System.Windows.Forms.TabPage();
            this.tabTransformation = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.listView_all_transformations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_transformation_split_parameter = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_split_parameters = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_where_statement = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_transformation_target_filename = new System.Windows.Forms.TextBox();
            this.label_transformation_target_filename = new System.Windows.Forms.Label();
            this.checkBox_transformation_incremental = new System.Windows.Forms.CheckBox();
            this.label_transformation_incremental = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_transformation_target_folder = new System.Windows.Forms.TextBox();
            this.textBox_transformation_source_filename = new System.Windows.Forms.TextBox();
            this.textBox_transformation_source_folder = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_years = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_months = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_days = new System.Windows.Forms.TextBox();
            this.textBox_transformation_statement = new System.Windows.Forms.TextBox();
            this.textBox_transformation_primary_key = new System.Windows.Forms.TextBox();
            this.textBox_transformation_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabGenerator.SuspendLayout();
            this.tabTransformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_object_name
            // 
            this.label_object_name.AutoSize = true;
            this.label_object_name.Location = new System.Drawing.Point(11, 80);
            this.label_object_name.Name = "label_object_name";
            this.label_object_name.Size = new System.Drawing.Size(68, 13);
            this.label_object_name.TabIndex = 1;
            this.label_object_name.Text = "object_name";
            // 
            // label_object_reload_minutes
            // 
            this.label_object_reload_minutes.AutoSize = true;
            this.label_object_reload_minutes.Location = new System.Drawing.Point(11, 113);
            this.label_object_reload_minutes.Name = "label_object_reload_minutes";
            this.label_object_reload_minutes.Size = new System.Drawing.Size(113, 13);
            this.label_object_reload_minutes.TabIndex = 2;
            this.label_object_reload_minutes.Text = "object_reload_minutes";
            // 
            // label_object_primary_key
            // 
            this.label_object_primary_key.AutoSize = true;
            this.label_object_primary_key.Location = new System.Drawing.Point(11, 173);
            this.label_object_primary_key.Name = "label_object_primary_key";
            this.label_object_primary_key.Size = new System.Drawing.Size(98, 13);
            this.label_object_primary_key.TabIndex = 4;
            this.label_object_primary_key.Text = "object_primary_key";
            // 
            // label_object_comment
            // 
            this.label_object_comment.AutoSize = true;
            this.label_object_comment.Location = new System.Drawing.Point(11, 143);
            this.label_object_comment.Name = "label_object_comment";
            this.label_object_comment.Size = new System.Drawing.Size(85, 13);
            this.label_object_comment.TabIndex = 3;
            this.label_object_comment.Text = "object_comment";
            // 
            // label_object_time_format
            // 
            this.label_object_time_format.AutoSize = true;
            this.label_object_time_format.Location = new System.Drawing.Point(11, 476);
            this.label_object_time_format.Name = "label_object_time_format";
            this.label_object_time_format.Size = new System.Drawing.Size(96, 13);
            this.label_object_time_format.TabIndex = 8;
            this.label_object_time_format.Text = "object_time_format";
            // 
            // label_object_date_format
            // 
            this.label_object_date_format.AutoSize = true;
            this.label_object_date_format.Location = new System.Drawing.Point(11, 446);
            this.label_object_date_format.Name = "label_object_date_format";
            this.label_object_date_format.Size = new System.Drawing.Size(98, 13);
            this.label_object_date_format.TabIndex = 7;
            this.label_object_date_format.Text = "object_date_format";
            // 
            // label_object_datetime_format
            // 
            this.label_object_datetime_format.AutoSize = true;
            this.label_object_datetime_format.Location = new System.Drawing.Point(11, 416);
            this.label_object_datetime_format.Name = "label_object_datetime_format";
            this.label_object_datetime_format.Size = new System.Drawing.Size(117, 13);
            this.label_object_datetime_format.TabIndex = 6;
            this.label_object_datetime_format.Text = "object_datetime_format";
            // 
            // label_object_select_statement
            // 
            this.label_object_select_statement.AutoSize = true;
            this.label_object_select_statement.Location = new System.Drawing.Point(11, 203);
            this.label_object_select_statement.Name = "label_object_select_statement";
            this.label_object_select_statement.Size = new System.Drawing.Size(122, 13);
            this.label_object_select_statement.TabIndex = 5;
            this.label_object_select_statement.Text = "object_select_statement";
            // 
            // label_object_target_extraction_filename
            // 
            this.label_object_target_extraction_filename.AutoSize = true;
            this.label_object_target_extraction_filename.Location = new System.Drawing.Point(11, 566);
            this.label_object_target_extraction_filename.Name = "label_object_target_extraction_filename";
            this.label_object_target_extraction_filename.Size = new System.Drawing.Size(166, 13);
            this.label_object_target_extraction_filename.TabIndex = 16;
            this.label_object_target_extraction_filename.Text = "object_target_extraction_filename";
            // 
            // label_object_target_extraction_folder
            // 
            this.label_object_target_extraction_folder.AutoSize = true;
            this.label_object_target_extraction_folder.Location = new System.Drawing.Point(11, 536);
            this.label_object_target_extraction_folder.Name = "label_object_target_extraction_folder";
            this.label_object_target_extraction_folder.Size = new System.Drawing.Size(153, 13);
            this.label_object_target_extraction_folder.TabIndex = 15;
            this.label_object_target_extraction_folder.Text = "object_target_extraction_folder";
            // 
            // label_object_transformation_statement
            // 
            this.label_object_transformation_statement.AutoSize = true;
            this.label_object_transformation_statement.Location = new System.Drawing.Point(551, 440);
            this.label_object_transformation_statement.Name = "label_object_transformation_statement";
            this.label_object_transformation_statement.Size = new System.Drawing.Size(160, 13);
            this.label_object_transformation_statement.TabIndex = 14;
            this.label_object_transformation_statement.Text = "object_transformation_statement";
            // 
            // label_object_reorganization
            // 
            this.label_object_reorganization.AutoSize = true;
            this.label_object_reorganization.Location = new System.Drawing.Point(11, 506);
            this.label_object_reorganization.Name = "label_object_reorganization";
            this.label_object_reorganization.Size = new System.Drawing.Size(108, 13);
            this.label_object_reorganization.TabIndex = 13;
            this.label_object_reorganization.Text = "object_reorganization";
            // 
            // label_object_fieldstoload_statement
            // 
            this.label_object_fieldstoload_statement.AutoSize = true;
            this.label_object_fieldstoload_statement.Location = new System.Drawing.Point(551, 250);
            this.label_object_fieldstoload_statement.Name = "label_object_fieldstoload_statement";
            this.label_object_fieldstoload_statement.Size = new System.Drawing.Size(147, 13);
            this.label_object_fieldstoload_statement.TabIndex = 12;
            this.label_object_fieldstoload_statement.Text = "object_fieldstoload_statement";
            // 
            // label_object_load_type
            // 
            this.label_object_load_type.AutoSize = true;
            this.label_object_load_type.Location = new System.Drawing.Point(295, 52);
            this.label_object_load_type.Name = "label_object_load_type";
            this.label_object_load_type.Size = new System.Drawing.Size(88, 13);
            this.label_object_load_type.TabIndex = 11;
            this.label_object_load_type.Text = "object_load_type";
            // 
            // label_object_active
            // 
            this.label_object_active.AutoSize = true;
            this.label_object_active.Location = new System.Drawing.Point(180, 52);
            this.label_object_active.Name = "label_object_active";
            this.label_object_active.Size = new System.Drawing.Size(71, 13);
            this.label_object_active.TabIndex = 10;
            this.label_object_active.Text = "object_active";
            // 
            // label_object_where_statement
            // 
            this.label_object_where_statement.AutoSize = true;
            this.label_object_where_statement.Location = new System.Drawing.Point(551, 50);
            this.label_object_where_statement.Name = "label_object_where_statement";
            this.label_object_where_statement.Size = new System.Drawing.Size(123, 13);
            this.label_object_where_statement.TabIndex = 9;
            this.label_object_where_statement.Text = "object_where_statement";
            // 
            // textBox_object_name
            // 
            this.textBox_object_name.Location = new System.Drawing.Point(181, 80);
            this.textBox_object_name.Name = "textBox_object_name";
            this.textBox_object_name.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_name.TabIndex = 17;
            this.textBox_object_name.TextChanged += new System.EventHandler(this.textBox_object_name_TextChanged);
            // 
            // textBox_object_reload_minutes
            // 
            this.textBox_object_reload_minutes.Location = new System.Drawing.Point(181, 110);
            this.textBox_object_reload_minutes.Name = "textBox_object_reload_minutes";
            this.textBox_object_reload_minutes.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_reload_minutes.TabIndex = 18;
            // 
            // textBox_object_primary_key
            // 
            this.textBox_object_primary_key.Location = new System.Drawing.Point(181, 170);
            this.textBox_object_primary_key.Name = "textBox_object_primary_key";
            this.textBox_object_primary_key.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_primary_key.TabIndex = 20;
            // 
            // textBox_object_comment
            // 
            this.textBox_object_comment.Location = new System.Drawing.Point(181, 140);
            this.textBox_object_comment.Name = "textBox_object_comment";
            this.textBox_object_comment.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_comment.TabIndex = 19;
            // 
            // textBox_object_time_format
            // 
            this.textBox_object_time_format.Location = new System.Drawing.Point(181, 473);
            this.textBox_object_time_format.Name = "textBox_object_time_format";
            this.textBox_object_time_format.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_time_format.TabIndex = 24;
            // 
            // textBox_object_date_format
            // 
            this.textBox_object_date_format.Location = new System.Drawing.Point(181, 443);
            this.textBox_object_date_format.Name = "textBox_object_date_format";
            this.textBox_object_date_format.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_date_format.TabIndex = 23;
            // 
            // textBox_object_datetime_format
            // 
            this.textBox_object_datetime_format.Location = new System.Drawing.Point(181, 413);
            this.textBox_object_datetime_format.Name = "textBox_object_datetime_format";
            this.textBox_object_datetime_format.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_datetime_format.TabIndex = 22;
            // 
            // textBox_object_select_statement
            // 
            this.textBox_object_select_statement.AcceptsReturn = true;
            this.textBox_object_select_statement.AcceptsTab = true;
            this.textBox_object_select_statement.Location = new System.Drawing.Point(181, 200);
            this.textBox_object_select_statement.Multiline = true;
            this.textBox_object_select_statement.Name = "textBox_object_select_statement";
            this.textBox_object_select_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_select_statement.Size = new System.Drawing.Size(329, 202);
            this.textBox_object_select_statement.TabIndex = 21;
            // 
            // textBox_object_target_extraction_filename
            // 
            this.textBox_object_target_extraction_filename.Location = new System.Drawing.Point(181, 563);
            this.textBox_object_target_extraction_filename.Name = "textBox_object_target_extraction_filename";
            this.textBox_object_target_extraction_filename.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_target_extraction_filename.TabIndex = 32;
            // 
            // textBox_object_target_extraction_folder
            // 
            this.textBox_object_target_extraction_folder.Location = new System.Drawing.Point(181, 533);
            this.textBox_object_target_extraction_folder.Name = "textBox_object_target_extraction_folder";
            this.textBox_object_target_extraction_folder.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_target_extraction_folder.TabIndex = 31;
            // 
            // textBox_object_transformation_statement
            // 
            this.textBox_object_transformation_statement.Location = new System.Drawing.Point(554, 456);
            this.textBox_object_transformation_statement.Multiline = true;
            this.textBox_object_transformation_statement.Name = "textBox_object_transformation_statement";
            this.textBox_object_transformation_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_transformation_statement.Size = new System.Drawing.Size(325, 127);
            this.textBox_object_transformation_statement.TabIndex = 30;
            // 
            // textBox_object_reorganization
            // 
            this.textBox_object_reorganization.Location = new System.Drawing.Point(181, 503);
            this.textBox_object_reorganization.Name = "textBox_object_reorganization";
            this.textBox_object_reorganization.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_reorganization.TabIndex = 29;
            // 
            // textBox_object_fieldstoload_statement
            // 
            this.textBox_object_fieldstoload_statement.Location = new System.Drawing.Point(554, 269);
            this.textBox_object_fieldstoload_statement.Multiline = true;
            this.textBox_object_fieldstoload_statement.Name = "textBox_object_fieldstoload_statement";
            this.textBox_object_fieldstoload_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_fieldstoload_statement.Size = new System.Drawing.Size(325, 164);
            this.textBox_object_fieldstoload_statement.TabIndex = 28;
            // 
            // textBox_object_where_statement
            // 
            this.textBox_object_where_statement.Location = new System.Drawing.Point(554, 77);
            this.textBox_object_where_statement.Multiline = true;
            this.textBox_object_where_statement.Name = "textBox_object_where_statement";
            this.textBox_object_where_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_where_statement.Size = new System.Drawing.Size(325, 170);
            this.textBox_object_where_statement.TabIndex = 25;
            // 
            // checkBox_object_active
            // 
            this.checkBox_object_active.AutoSize = true;
            this.checkBox_object_active.Location = new System.Drawing.Point(257, 52);
            this.checkBox_object_active.Name = "checkBox_object_active";
            this.checkBox_object_active.Size = new System.Drawing.Size(15, 14);
            this.checkBox_object_active.TabIndex = 34;
            this.checkBox_object_active.UseVisualStyleBackColor = true;
            // 
            // comboBox_object_load_type
            // 
            this.comboBox_object_load_type.FormattingEnabled = true;
            this.comboBox_object_load_type.Location = new System.Drawing.Point(389, 49);
            this.comboBox_object_load_type.Name = "comboBox_object_load_type";
            this.comboBox_object_load_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_object_load_type.TabIndex = 35;
            this.comboBox_object_load_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_object_load_type_SelectedIndexChanged);
            // 
            // textBox_folder_path
            // 
            this.textBox_folder_path.Location = new System.Drawing.Point(516, 8);
            this.textBox_folder_path.Name = "textBox_folder_path";
            this.textBox_folder_path.Size = new System.Drawing.Size(418, 20);
            this.textBox_folder_path.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 11);
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
            this.textBox_file_name.Location = new System.Drawing.Point(183, 8);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(151, 20);
            this.textBox_file_name.TabIndex = 45;
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.Location = new System.Drawing.Point(11, 12);
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
            // listView_all_objects
            // 
            this.listView_all_objects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Object_Name,
            this.Object_Active,
            this.Object_load_type});
            this.listView_all_objects.FullRowSelect = true;
            this.listView_all_objects.GridLines = true;
            this.listView_all_objects.HideSelection = false;
            this.listView_all_objects.Location = new System.Drawing.Point(933, 77);
            this.listView_all_objects.MultiSelect = false;
            this.listView_all_objects.Name = "listView_all_objects";
            this.listView_all_objects.Size = new System.Drawing.Size(274, 499);
            this.listView_all_objects.TabIndex = 50;
            this.listView_all_objects.UseCompatibleStateImageBehavior = false;
            this.listView_all_objects.View = System.Windows.Forms.View.Details;
            this.listView_all_objects.SelectedIndexChanged += new System.EventHandler(this.listView_all_objects_SelectedIndexChanged);
            // 
            // Object_Name
            // 
            this.Object_Name.Text = "Object Name";
            this.Object_Name.Width = 174;
            // 
            // Object_Active
            // 
            this.Object_Active.Text = "Active";
            this.Object_Active.Width = 45;
            // 
            // Object_load_type
            // 
            this.Object_load_type.Text = "Type";
            this.Object_load_type.Width = 49;
            // 
            // button_set_all_notactive
            // 
            this.button_set_all_notactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_set_all_notactive.Location = new System.Drawing.Point(895, 544);
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
            this.button_set_all_active.Location = new System.Drawing.Point(895, 506);
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
            this.button_go_back_database_connector.Location = new System.Drawing.Point(1175, 4);
            this.button_go_back_database_connector.Name = "button_go_back_database_connector";
            this.button_go_back_database_connector.Size = new System.Drawing.Size(32, 32);
            this.button_go_back_database_connector.TabIndex = 62;
            this.button_go_back_database_connector.Text = "<-";
            this.toolTips.SetToolTip(this.button_go_back_database_connector, "Return to database connection screen");
            this.button_go_back_database_connector.UseVisualStyleBackColor = true;
            this.button_go_back_database_connector.Click += new System.EventHandler(this.button_go_back_database_connector_Click);
            // 
            // button_next_transform
            // 
            this.button_next_transform.BackgroundImage = global::XML_Configurator.Properties.Resources._1481573303_Next;
            this.button_next_transform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next_transform.Location = new System.Drawing.Point(1074, 591);
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
            this.button_execute_test_statement.Location = new System.Drawing.Point(516, 200);
            this.button_execute_test_statement.Name = "button_execute_test_statement";
            this.button_execute_test_statement.Size = new System.Drawing.Size(32, 32);
            this.button_execute_test_statement.TabIndex = 63;
            this.toolTips.SetToolTip(this.button_execute_test_statement, "Execute statement to return number of rows affected\r\non current database\r\n");
            this.button_execute_test_statement.UseVisualStyleBackColor = true;
            this.button_execute_test_statement.Click += new System.EventHandler(this.button_execute_test_statement_Click);
            // 
            // button_load_sample_object
            // 
            this.button_load_sample_object.AccessibleDescription = "";
            this.button_load_sample_object.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_load_sample_object.BackgroundImage")));
            this.button_load_sample_object.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_load_sample_object.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_sample_object.Location = new System.Drawing.Point(10, 42);
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
            this.button_remove_all_listviewitems.Location = new System.Drawing.Point(895, 276);
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
            this.button_load_xml.Location = new System.Drawing.Point(1175, 39);
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
            this.button_update_object.Location = new System.Drawing.Point(64, 591);
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
            this.button_browse.Location = new System.Drawing.Point(940, 3);
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
            this.button_list_item_move_down.Location = new System.Drawing.Point(895, 116);
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
            this.button_list_item_move_up.Location = new System.Drawing.Point(895, 77);
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
            this.button_delete_list_item.Location = new System.Drawing.Point(895, 238);
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
            this.BUTTON_CREATE_OBJECT.Location = new System.Drawing.Point(14, 591);
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
            this.BUTTON_CREATE_XML.Location = new System.Drawing.Point(933, 591);
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
            this.BUTTON_EXIT.Location = new System.Drawing.Point(1175, 591);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(32, 32);
            this.BUTTON_EXIT.TabIndex = 0;
            this.toolTips.SetToolTip(this.BUTTON_EXIT, "Exit Application");
            this.BUTTON_EXIT.UseVisualStyleBackColor = true;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // button_load_sample_transformation
            // 
            this.button_load_sample_transformation.AccessibleDescription = "";
            this.button_load_sample_transformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_load_sample_transformation.BackgroundImage")));
            this.button_load_sample_transformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_load_sample_transformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_sample_transformation.Location = new System.Drawing.Point(8, 36);
            this.button_load_sample_transformation.Name = "button_load_sample_transformation";
            this.button_load_sample_transformation.Size = new System.Drawing.Size(32, 32);
            this.button_load_sample_transformation.TabIndex = 92;
            this.toolTips.SetToolTip(this.button_load_sample_transformation, "Populate fields with sample data");
            this.button_load_sample_transformation.UseVisualStyleBackColor = true;
            this.button_load_sample_transformation.Click += new System.EventHandler(this.button_load_sample_transformation_Click);
            // 
            // button_update_transformation
            // 
            this.button_update_transformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update_transformation.BackgroundImage")));
            this.button_update_transformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_update_transformation.Location = new System.Drawing.Point(50, 517);
            this.button_update_transformation.Name = "button_update_transformation";
            this.button_update_transformation.Size = new System.Drawing.Size(32, 32);
            this.button_update_transformation.TabIndex = 91;
            this.toolTips.SetToolTip(this.button_update_transformation, "Update selected object in the list");
            this.button_update_transformation.UseVisualStyleBackColor = true;
            this.button_update_transformation.Click += new System.EventHandler(this.button_update_transformation_Click);
            // 
            // button_create_transformation
            // 
            this.button_create_transformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_create_transformation.BackgroundImage")));
            this.button_create_transformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_create_transformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_create_transformation.Location = new System.Drawing.Point(11, 517);
            this.button_create_transformation.Name = "button_create_transformation";
            this.button_create_transformation.Size = new System.Drawing.Size(32, 32);
            this.button_create_transformation.TabIndex = 89;
            this.toolTips.SetToolTip(this.button_create_transformation, "Create new object in the list");
            this.button_create_transformation.UseVisualStyleBackColor = true;
            this.button_create_transformation.Click += new System.EventHandler(this.button_create_transformation_Click);
            // 
            // button_browse_2
            // 
            this.button_browse_2.BackgroundImage = global::XML_Configurator.Properties.Resources._1474913320_manilla_folder_saved_search;
            this.button_browse_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_browse_2.Location = new System.Drawing.Point(937, 4);
            this.button_browse_2.Name = "button_browse_2";
            this.button_browse_2.Size = new System.Drawing.Size(32, 32);
            this.button_browse_2.TabIndex = 99;
            this.toolTips.SetToolTip(this.button_browse_2, "Browse location to store XML file");
            this.button_browse_2.UseVisualStyleBackColor = true;
            this.button_browse_2.Click += new System.EventHandler(this.button_browse_2_Click);
            // 
            // button_load_transformation_file
            // 
            this.button_load_transformation_file.AccessibleDescription = "";
            this.button_load_transformation_file.BackgroundImage = global::XML_Configurator.Properties.Resources._1474913677_folder_with_file;
            this.button_load_transformation_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_load_transformation_file.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_transformation_file.Location = new System.Drawing.Point(1178, 49);
            this.button_load_transformation_file.Name = "button_load_transformation_file";
            this.button_load_transformation_file.Size = new System.Drawing.Size(32, 32);
            this.button_load_transformation_file.TabIndex = 109;
            this.toolTips.SetToolTip(this.button_load_transformation_file, "Load XML file from location");
            this.button_load_transformation_file.UseVisualStyleBackColor = true;
            this.button_load_transformation_file.Click += new System.EventHandler(this.button_load_transformation_file_Click);
            // 
            // button_set_all_notactive_2
            // 
            this.button_set_all_notactive_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_set_all_notactive_2.Location = new System.Drawing.Point(899, 479);
            this.button_set_all_notactive_2.Name = "button_set_all_notactive_2";
            this.button_set_all_notactive_2.Size = new System.Drawing.Size(32, 32);
            this.button_set_all_notactive_2.TabIndex = 116;
            this.button_set_all_notactive_2.Text = "N";
            this.toolTips.SetToolTip(this.button_set_all_notactive_2, "Set all items in the list to not active");
            this.button_set_all_notactive_2.UseVisualStyleBackColor = true;
            this.button_set_all_notactive_2.Click += new System.EventHandler(this.button_set_all_notactive_2_Click);
            // 
            // button_set_all_active_2
            // 
            this.button_set_all_active_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_set_all_active_2.Location = new System.Drawing.Point(899, 441);
            this.button_set_all_active_2.Name = "button_set_all_active_2";
            this.button_set_all_active_2.Size = new System.Drawing.Size(32, 32);
            this.button_set_all_active_2.TabIndex = 115;
            this.button_set_all_active_2.Text = "Y";
            this.toolTips.SetToolTip(this.button_set_all_active_2, "Set all items in the list to active");
            this.button_set_all_active_2.UseVisualStyleBackColor = true;
            this.button_set_all_active_2.Click += new System.EventHandler(this.button_set_all_active_2_Click);
            // 
            // button_remove_all_listviewitems_2
            // 
            this.button_remove_all_listviewitems_2.BackgroundImage = global::XML_Configurator.Properties.Resources._1474912315_human_user_trash;
            this.button_remove_all_listviewitems_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_remove_all_listviewitems_2.Location = new System.Drawing.Point(899, 277);
            this.button_remove_all_listviewitems_2.Name = "button_remove_all_listviewitems_2";
            this.button_remove_all_listviewitems_2.Size = new System.Drawing.Size(32, 32);
            this.button_remove_all_listviewitems_2.TabIndex = 114;
            this.toolTips.SetToolTip(this.button_remove_all_listviewitems_2, "Remove all objects from the list");
            this.button_remove_all_listviewitems_2.UseVisualStyleBackColor = true;
            this.button_remove_all_listviewitems_2.Click += new System.EventHandler(this.button_remove_all_listviewitems_2_Click);
            // 
            // button_list_item_move_down_2
            // 
            this.button_list_item_move_down_2.BackgroundImage = global::XML_Configurator.Properties.Resources._1474911115_Stock_Index_Down;
            this.button_list_item_move_down_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_list_item_move_down_2.Location = new System.Drawing.Point(899, 127);
            this.button_list_item_move_down_2.Name = "button_list_item_move_down_2";
            this.button_list_item_move_down_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_list_item_move_down_2.Size = new System.Drawing.Size(32, 32);
            this.button_list_item_move_down_2.TabIndex = 113;
            this.toolTips.SetToolTip(this.button_list_item_move_down_2, "Move object down in the list");
            this.button_list_item_move_down_2.UseVisualStyleBackColor = true;
            this.button_list_item_move_down_2.Click += new System.EventHandler(this.button_list_item_move_down_2_Click);
            // 
            // button_list_item_move_up_2
            // 
            this.button_list_item_move_up_2.BackgroundImage = global::XML_Configurator.Properties.Resources._1474911113_Stock_Index_Up;
            this.button_list_item_move_up_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_list_item_move_up_2.Location = new System.Drawing.Point(899, 89);
            this.button_list_item_move_up_2.Name = "button_list_item_move_up_2";
            this.button_list_item_move_up_2.Size = new System.Drawing.Size(32, 32);
            this.button_list_item_move_up_2.TabIndex = 112;
            this.toolTips.SetToolTip(this.button_list_item_move_up_2, "Move object up in the list");
            this.button_list_item_move_up_2.UseVisualStyleBackColor = true;
            this.button_list_item_move_up_2.Click += new System.EventHandler(this.button_list_item_move_up_2_Click);
            // 
            // button_delete_list_item_2
            // 
            this.button_delete_list_item_2.BackgroundImage = global::XML_Configurator.Properties.Resources._1474911120_Error;
            this.button_delete_list_item_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_delete_list_item_2.Location = new System.Drawing.Point(899, 239);
            this.button_delete_list_item_2.Name = "button_delete_list_item_2";
            this.button_delete_list_item_2.Size = new System.Drawing.Size(32, 32);
            this.button_delete_list_item_2.TabIndex = 111;
            this.toolTips.SetToolTip(this.button_delete_list_item_2, "Remove object from the list");
            this.button_delete_list_item_2.UseVisualStyleBackColor = true;
            this.button_delete_list_item_2.Click += new System.EventHandler(this.button_delete_list_item_2_Click);
            // 
            // button_back_generator
            // 
            this.button_back_generator.BackgroundImage = global::XML_Configurator.Properties.Resources._1481641481_Previous;
            this.button_back_generator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_generator.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_generator.Location = new System.Drawing.Point(1082, 517);
            this.button_back_generator.Name = "button_back_generator";
            this.button_back_generator.Size = new System.Drawing.Size(32, 32);
            this.button_back_generator.TabIndex = 119;
            this.toolTips.SetToolTip(this.button_back_generator, "Return to generator form");
            this.button_back_generator.UseVisualStyleBackColor = true;
            this.button_back_generator.Click += new System.EventHandler(this.button_back_generator_Click);
            // 
            // button_create_transformation_file
            // 
            this.button_create_transformation_file.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_create_transformation_file.BackgroundImage")));
            this.button_create_transformation_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_create_transformation_file.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_create_transformation_file.Location = new System.Drawing.Point(937, 517);
            this.button_create_transformation_file.Name = "button_create_transformation_file";
            this.button_create_transformation_file.Size = new System.Drawing.Size(32, 32);
            this.button_create_transformation_file.TabIndex = 117;
            this.toolTips.SetToolTip(this.button_create_transformation_file, "Create XML file with objects from the list on chosen location");
            this.button_create_transformation_file.UseVisualStyleBackColor = true;
            this.button_create_transformation_file.Click += new System.EventHandler(this.button_create_transformation_file_Click);
            // 
            // button_exit_2
            // 
            this.button_exit_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit_2.BackgroundImage")));
            this.button_exit_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_exit_2.Location = new System.Drawing.Point(1180, 517);
            this.button_exit_2.Name = "button_exit_2";
            this.button_exit_2.Size = new System.Drawing.Size(32, 32);
            this.button_exit_2.TabIndex = 118;
            this.toolTips.SetToolTip(this.button_exit_2, "Exit Application");
            this.button_exit_2.UseVisualStyleBackColor = true;
            this.button_exit_2.Click += new System.EventHandler(this.button_exit_2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(930, 52);
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
            this.label3.Location = new System.Drawing.Point(978, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Database";
            // 
            // comboBox_loaded_datasources
            // 
            this.comboBox_loaded_datasources.FormattingEnabled = true;
            this.comboBox_loaded_datasources.Location = new System.Drawing.Point(1057, 9);
            this.comboBox_loaded_datasources.Name = "comboBox_loaded_datasources";
            this.comboBox_loaded_datasources.Size = new System.Drawing.Size(112, 21);
            this.comboBox_loaded_datasources.TabIndex = 64;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGenerator);
            this.tabControl.Controls.Add(this.tabTransformation);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1226, 658);
            this.tabControl.TabIndex = 66;
            // 
            // tabGenerator
            // 
            this.tabGenerator.Controls.Add(this.button_go_back_database_connector);
            this.tabGenerator.Controls.Add(this.comboBox_loaded_datasources);
            this.tabGenerator.Controls.Add(this.button_next_transform);
            this.tabGenerator.Controls.Add(this.button_load_sample_object);
            this.tabGenerator.Controls.Add(this.label3);
            this.tabGenerator.Controls.Add(this.label_object_active);
            this.tabGenerator.Controls.Add(this.button_execute_test_statement);
            this.tabGenerator.Controls.Add(this.button_browse);
            this.tabGenerator.Controls.Add(this.textBox_file_name);
            this.tabGenerator.Controls.Add(this.button_set_all_active);
            this.tabGenerator.Controls.Add(this.label_file_name);
            this.tabGenerator.Controls.Add(this.button_set_all_notactive);
            this.tabGenerator.Controls.Add(this.label_object_name);
            this.tabGenerator.Controls.Add(this.textBox_folder_path);
            this.tabGenerator.Controls.Add(this.label_object_reload_minutes);
            this.tabGenerator.Controls.Add(this.label1);
            this.tabGenerator.Controls.Add(this.label_object_comment);
            this.tabGenerator.Controls.Add(this.label_object_primary_key);
            this.tabGenerator.Controls.Add(this.button_load_xml);
            this.tabGenerator.Controls.Add(this.listView_all_objects);
            this.tabGenerator.Controls.Add(this.label2);
            this.tabGenerator.Controls.Add(this.BUTTON_CREATE_XML);
            this.tabGenerator.Controls.Add(this.label_object_select_statement);
            this.tabGenerator.Controls.Add(this.button_remove_all_listviewitems);
            this.tabGenerator.Controls.Add(this.checkBox_object_active);
            this.tabGenerator.Controls.Add(this.BUTTON_EXIT);
            this.tabGenerator.Controls.Add(this.label_object_where_statement);
            this.tabGenerator.Controls.Add(this.label_object_fieldstoload_statement);
            this.tabGenerator.Controls.Add(this.button_update_object);
            this.tabGenerator.Controls.Add(this.textBox_object_where_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_fieldstoload_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_name);
            this.tabGenerator.Controls.Add(this.label_object_load_type);
            this.tabGenerator.Controls.Add(this.button_delete_list_item);
            this.tabGenerator.Controls.Add(this.button_list_item_move_down);
            this.tabGenerator.Controls.Add(this.comboBox_object_load_type);
            this.tabGenerator.Controls.Add(this.button_list_item_move_up);
            this.tabGenerator.Controls.Add(this.textBox_object_reload_minutes);
            this.tabGenerator.Controls.Add(this.textBox_object_comment);
            this.tabGenerator.Controls.Add(this.textBox_object_transformation_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_primary_key);
            this.tabGenerator.Controls.Add(this.label_object_transformation_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_select_statement);
            this.tabGenerator.Controls.Add(this.BUTTON_CREATE_OBJECT);
            this.tabGenerator.Controls.Add(this.label_object_datetime_format);
            this.tabGenerator.Controls.Add(this.textBox_object_target_extraction_filename);
            this.tabGenerator.Controls.Add(this.label_object_target_extraction_filename);
            this.tabGenerator.Controls.Add(this.label_object_date_format);
            this.tabGenerator.Controls.Add(this.textBox_object_target_extraction_folder);
            this.tabGenerator.Controls.Add(this.label_object_time_format);
            this.tabGenerator.Controls.Add(this.label_object_reorganization);
            this.tabGenerator.Controls.Add(this.textBox_object_reorganization);
            this.tabGenerator.Controls.Add(this.label_object_target_extraction_folder);
            this.tabGenerator.Controls.Add(this.textBox_object_time_format);
            this.tabGenerator.Controls.Add(this.textBox_object_datetime_format);
            this.tabGenerator.Controls.Add(this.textBox_object_date_format);
            this.tabGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabGenerator.Name = "tabGenerator";
            this.tabGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerator.Size = new System.Drawing.Size(1218, 632);
            this.tabGenerator.TabIndex = 0;
            this.tabGenerator.Text = "Generator";
            this.tabGenerator.UseVisualStyleBackColor = true;
            // 
            // tabTransformation
            // 
            this.tabTransformation.Controls.Add(this.button_back_generator);
            this.tabTransformation.Controls.Add(this.button_create_transformation_file);
            this.tabTransformation.Controls.Add(this.button_exit_2);
            this.tabTransformation.Controls.Add(this.button_set_all_notactive_2);
            this.tabTransformation.Controls.Add(this.button_set_all_active_2);
            this.tabTransformation.Controls.Add(this.button_remove_all_listviewitems_2);
            this.tabTransformation.Controls.Add(this.button_list_item_move_down_2);
            this.tabTransformation.Controls.Add(this.button_list_item_move_up_2);
            this.tabTransformation.Controls.Add(this.button_delete_list_item_2);
            this.tabTransformation.Controls.Add(this.label19);
            this.tabTransformation.Controls.Add(this.button_load_transformation_file);
            this.tabTransformation.Controls.Add(this.listView_all_transformations);
            this.tabTransformation.Controls.Add(this.textBox_transformation_split_parameter);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_split_parameters);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_where_statement);
            this.tabTransformation.Controls.Add(this.label16);
            this.tabTransformation.Controls.Add(this.label17);
            this.tabTransformation.Controls.Add(this.label18);
            this.tabTransformation.Controls.Add(this.button_browse_2);
            this.tabTransformation.Controls.Add(this.textBox1);
            this.tabTransformation.Controls.Add(this.label14);
            this.tabTransformation.Controls.Add(this.textBox2);
            this.tabTransformation.Controls.Add(this.label15);
            this.tabTransformation.Controls.Add(this.textBox_transformation_target_filename);
            this.tabTransformation.Controls.Add(this.label_transformation_target_filename);
            this.tabTransformation.Controls.Add(this.checkBox_transformation_incremental);
            this.tabTransformation.Controls.Add(this.label_transformation_incremental);
            this.tabTransformation.Controls.Add(this.button_load_sample_transformation);
            this.tabTransformation.Controls.Add(this.button_update_transformation);
            this.tabTransformation.Controls.Add(this.checkBox1);
            this.tabTransformation.Controls.Add(this.button_create_transformation);
            this.tabTransformation.Controls.Add(this.textBox_transformation_target_folder);
            this.tabTransformation.Controls.Add(this.textBox_transformation_source_filename);
            this.tabTransformation.Controls.Add(this.textBox_transformation_source_folder);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_number_of_years);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_number_of_months);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_number_of_days);
            this.tabTransformation.Controls.Add(this.textBox_transformation_statement);
            this.tabTransformation.Controls.Add(this.textBox_transformation_primary_key);
            this.tabTransformation.Controls.Add(this.textBox_transformation_name);
            this.tabTransformation.Controls.Add(this.label4);
            this.tabTransformation.Controls.Add(this.label5);
            this.tabTransformation.Controls.Add(this.label6);
            this.tabTransformation.Controls.Add(this.label7);
            this.tabTransformation.Controls.Add(this.label8);
            this.tabTransformation.Controls.Add(this.label9);
            this.tabTransformation.Controls.Add(this.label10);
            this.tabTransformation.Controls.Add(this.label11);
            this.tabTransformation.Controls.Add(this.label12);
            this.tabTransformation.Controls.Add(this.label13);
            this.tabTransformation.Location = new System.Drawing.Point(4, 22);
            this.tabTransformation.Name = "tabTransformation";
            this.tabTransformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransformation.Size = new System.Drawing.Size(1218, 632);
            this.tabTransformation.TabIndex = 1;
            this.tabTransformation.Text = "Transformation";
            this.tabTransformation.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(934, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 110;
            this.label19.Text = "Created objects";
            // 
            // listView_all_transformations
            // 
            this.listView_all_transformations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_all_transformations.FullRowSelect = true;
            this.listView_all_transformations.GridLines = true;
            this.listView_all_transformations.HideSelection = false;
            this.listView_all_transformations.Location = new System.Drawing.Point(937, 84);
            this.listView_all_transformations.MultiSelect = false;
            this.listView_all_transformations.Name = "listView_all_transformations";
            this.listView_all_transformations.Size = new System.Drawing.Size(275, 427);
            this.listView_all_transformations.TabIndex = 108;
            this.listView_all_transformations.UseCompatibleStateImageBehavior = false;
            this.listView_all_transformations.View = System.Windows.Forms.View.Details;
            this.listView_all_transformations.SelectedIndexChanged += new System.EventHandler(this.listView_all_transformations_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Object Name";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Object Active";
            this.columnHeader2.Width = 80;
            // 
            // textBox_transformation_split_parameter
            // 
            this.textBox_transformation_split_parameter.Location = new System.Drawing.Point(574, 386);
            this.textBox_transformation_split_parameter.Multiline = true;
            this.textBox_transformation_split_parameter.Name = "textBox_transformation_split_parameter";
            this.textBox_transformation_split_parameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_transformation_split_parameter.Size = new System.Drawing.Size(319, 125);
            this.textBox_transformation_split_parameter.TabIndex = 107;
            // 
            // textBox_additional_transformation_split_parameters
            // 
            this.textBox_additional_transformation_split_parameters.Location = new System.Drawing.Point(574, 237);
            this.textBox_additional_transformation_split_parameters.Multiline = true;
            this.textBox_additional_transformation_split_parameters.Name = "textBox_additional_transformation_split_parameters";
            this.textBox_additional_transformation_split_parameters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_additional_transformation_split_parameters.Size = new System.Drawing.Size(319, 130);
            this.textBox_additional_transformation_split_parameters.TabIndex = 106;
            // 
            // textBox_additional_transformation_where_statement
            // 
            this.textBox_additional_transformation_where_statement.Location = new System.Drawing.Point(574, 84);
            this.textBox_additional_transformation_where_statement.Multiline = true;
            this.textBox_additional_transformation_where_statement.Name = "textBox_additional_transformation_where_statement";
            this.textBox_additional_transformation_where_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_additional_transformation_where_statement.Size = new System.Drawing.Size(319, 134);
            this.textBox_additional_transformation_where_statement.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(571, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 13);
            this.label16.TabIndex = 104;
            this.label16.Text = "transformation_split_parameter";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(571, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(206, 13);
            this.label17.TabIndex = 103;
            this.label17.Text = "additional_transformation_split_parameters";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(571, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(211, 13);
            this.label18.TabIndex = 102;
            this.label18.Text = "additional_transformation_where_statement";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "XML file name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(418, 20);
            this.textBox2.TabIndex = 98;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 97;
            this.label15.Text = "XML file location";
            // 
            // textBox_transformation_target_filename
            // 
            this.textBox_transformation_target_filename.Location = new System.Drawing.Point(234, 491);
            this.textBox_transformation_target_filename.Name = "textBox_transformation_target_filename";
            this.textBox_transformation_target_filename.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_target_filename.TabIndex = 96;
            // 
            // label_transformation_target_filename
            // 
            this.label_transformation_target_filename.AutoSize = true;
            this.label_transformation_target_filename.Location = new System.Drawing.Point(8, 494);
            this.label_transformation_target_filename.Name = "label_transformation_target_filename";
            this.label_transformation_target_filename.Size = new System.Drawing.Size(151, 13);
            this.label_transformation_target_filename.TabIndex = 95;
            this.label_transformation_target_filename.Text = "transformation_target_filename";
            // 
            // checkBox_transformation_incremental
            // 
            this.checkBox_transformation_incremental.AutoSize = true;
            this.checkBox_transformation_incremental.Location = new System.Drawing.Point(539, 64);
            this.checkBox_transformation_incremental.Name = "checkBox_transformation_incremental";
            this.checkBox_transformation_incremental.Size = new System.Drawing.Size(15, 14);
            this.checkBox_transformation_incremental.TabIndex = 94;
            this.checkBox_transformation_incremental.UseVisualStyleBackColor = true;
            // 
            // label_transformation_incremental
            // 
            this.label_transformation_incremental.AutoSize = true;
            this.label_transformation_incremental.Location = new System.Drawing.Point(400, 64);
            this.label_transformation_incremental.Name = "label_transformation_incremental";
            this.label_transformation_incremental.Size = new System.Drawing.Size(133, 13);
            this.label_transformation_incremental.TabIndex = 93;
            this.label_transformation_incremental.Text = "transformation_incremental";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 90;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_transformation_target_folder
            // 
            this.textBox_transformation_target_folder.Location = new System.Drawing.Point(234, 466);
            this.textBox_transformation_target_folder.Name = "textBox_transformation_target_folder";
            this.textBox_transformation_target_folder.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_target_folder.TabIndex = 88;
            // 
            // textBox_transformation_source_filename
            // 
            this.textBox_transformation_source_filename.Location = new System.Drawing.Point(234, 441);
            this.textBox_transformation_source_filename.Name = "textBox_transformation_source_filename";
            this.textBox_transformation_source_filename.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_source_filename.TabIndex = 87;
            // 
            // textBox_transformation_source_folder
            // 
            this.textBox_transformation_source_folder.Location = new System.Drawing.Point(234, 416);
            this.textBox_transformation_source_folder.Name = "textBox_transformation_source_folder";
            this.textBox_transformation_source_folder.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_source_folder.TabIndex = 86;
            // 
            // textBox_additional_transformation_number_of_years
            // 
            this.textBox_additional_transformation_number_of_years.Location = new System.Drawing.Point(234, 391);
            this.textBox_additional_transformation_number_of_years.Name = "textBox_additional_transformation_number_of_years";
            this.textBox_additional_transformation_number_of_years.Size = new System.Drawing.Size(320, 20);
            this.textBox_additional_transformation_number_of_years.TabIndex = 85;
            // 
            // textBox_additional_transformation_number_of_months
            // 
            this.textBox_additional_transformation_number_of_months.Location = new System.Drawing.Point(234, 366);
            this.textBox_additional_transformation_number_of_months.Name = "textBox_additional_transformation_number_of_months";
            this.textBox_additional_transformation_number_of_months.Size = new System.Drawing.Size(320, 20);
            this.textBox_additional_transformation_number_of_months.TabIndex = 84;
            // 
            // textBox_additional_transformation_number_of_days
            // 
            this.textBox_additional_transformation_number_of_days.Location = new System.Drawing.Point(234, 341);
            this.textBox_additional_transformation_number_of_days.Name = "textBox_additional_transformation_number_of_days";
            this.textBox_additional_transformation_number_of_days.Size = new System.Drawing.Size(320, 20);
            this.textBox_additional_transformation_number_of_days.TabIndex = 83;
            // 
            // textBox_transformation_statement
            // 
            this.textBox_transformation_statement.AcceptsReturn = true;
            this.textBox_transformation_statement.AcceptsTab = true;
            this.textBox_transformation_statement.Location = new System.Drawing.Point(234, 134);
            this.textBox_transformation_statement.Multiline = true;
            this.textBox_transformation_statement.Name = "textBox_transformation_statement";
            this.textBox_transformation_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_transformation_statement.Size = new System.Drawing.Size(320, 202);
            this.textBox_transformation_statement.TabIndex = 82;
            // 
            // textBox_transformation_primary_key
            // 
            this.textBox_transformation_primary_key.Location = new System.Drawing.Point(234, 109);
            this.textBox_transformation_primary_key.Name = "textBox_transformation_primary_key";
            this.textBox_transformation_primary_key.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_primary_key.TabIndex = 81;
            // 
            // textBox_transformation_name
            // 
            this.textBox_transformation_name.Location = new System.Drawing.Point(234, 84);
            this.textBox_transformation_name.Name = "textBox_transformation_name";
            this.textBox_transformation_name.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_name.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "transformation_target_folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "transformation_source_filename";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "transformation_source_folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "transformation_active";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "additional_transformation_number_of_years";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "additional_transformation_number_of_months";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "additional_transformation_number_of_days";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "transformation_statement";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "transformation_primary_key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "transformation_name";
            // 
            // _02_ObjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1226, 658);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_02_ObjectCreator";
            this.Text = "XML Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectCreator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabGenerator.ResumeLayout(false);
            this.tabGenerator.PerformLayout();
            this.tabTransformation.ResumeLayout(false);
            this.tabTransformation.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListView listView_all_objects;
        private System.Windows.Forms.ColumnHeader Object_Name;
        private System.Windows.Forms.ColumnHeader Object_Active;
        private System.Windows.Forms.Button button_remove_all_listviewitems;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button button_load_sample_object;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_set_all_active;
        private System.Windows.Forms.Button button_set_all_notactive;
        private System.Windows.Forms.ErrorProvider EP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_go_back_database_connector;
        private System.Windows.Forms.Button button_execute_test_statement;
        private System.Windows.Forms.ComboBox comboBox_loaded_datasources;
        private System.Windows.Forms.ColumnHeader Object_load_type;
        private System.Windows.Forms.Button button_next_transform;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGenerator;
        private System.Windows.Forms.TabPage tabTransformation;
        private System.Windows.Forms.TextBox textBox_transformation_target_filename;
        private System.Windows.Forms.Label label_transformation_target_filename;
        private System.Windows.Forms.CheckBox checkBox_transformation_incremental;
        private System.Windows.Forms.Label label_transformation_incremental;
        private System.Windows.Forms.Button button_load_sample_transformation;
        private System.Windows.Forms.Button button_update_transformation;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_create_transformation;
        private System.Windows.Forms.TextBox textBox_transformation_target_folder;
        private System.Windows.Forms.TextBox textBox_transformation_source_filename;
        private System.Windows.Forms.TextBox textBox_transformation_source_folder;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_years;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_months;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_days;
        private System.Windows.Forms.TextBox textBox_transformation_statement;
        private System.Windows.Forms.TextBox textBox_transformation_primary_key;
        private System.Windows.Forms.TextBox textBox_transformation_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_browse_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_transformation_split_parameter;
        private System.Windows.Forms.TextBox textBox_additional_transformation_split_parameters;
        private System.Windows.Forms.TextBox textBox_additional_transformation_where_statement;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView listView_all_transformations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_load_transformation_file;
        private System.Windows.Forms.Button button_set_all_notactive_2;
        private System.Windows.Forms.Button button_set_all_active_2;
        private System.Windows.Forms.Button button_remove_all_listviewitems_2;
        private System.Windows.Forms.Button button_list_item_move_down_2;
        private System.Windows.Forms.Button button_list_item_move_up_2;
        private System.Windows.Forms.Button button_delete_list_item_2;
        private System.Windows.Forms.Button button_back_generator;
        private System.Windows.Forms.Button button_create_transformation_file;
        private System.Windows.Forms.Button button_exit_2;
    }
}

