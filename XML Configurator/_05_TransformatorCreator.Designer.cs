using XML_Configurator.Custom.Controls;

namespace XML_Configurator
{
    public partial class _05_TransformatorCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_05_TransformatorCreator));
            this.label_object_name = new System.Windows.Forms.Label();
            this.label_object_primary_key = new System.Windows.Forms.Label();
            this.label_object_time_format = new System.Windows.Forms.Label();
            this.label_object_date_format = new System.Windows.Forms.Label();
            this.label_object_datetime_format = new System.Windows.Forms.Label();
            this.label_object_select_statement = new System.Windows.Forms.Label();
            this.label_object_target_extraction_filename = new System.Windows.Forms.Label();
            this.label_object_target_extraction_folder = new System.Windows.Forms.Label();
            this.label_object_transformation_statement = new System.Windows.Forms.Label();
            this.label_object_reorganization = new System.Windows.Forms.Label();
            this.label_object_fieldstoload_statement = new System.Windows.Forms.Label();
            this.label_object_active = new System.Windows.Forms.Label();
            this.label_object_where_statement = new System.Windows.Forms.Label();
            this.textBox_transformation_name = new System.Windows.Forms.TextBox();
            this.textBox_transformation_primary_key = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_years = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_months = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_days = new System.Windows.Forms.TextBox();
            this.textBox_transformation_statement = new System.Windows.Forms.TextBox();
            this.textBox_transformation_target_folder = new System.Windows.Forms.TextBox();
            this.textBox_transformation_source_filename = new System.Windows.Forms.TextBox();
            this.textBox_transformation_split_parameter = new System.Windows.Forms.TextBox();
            this.textBox_transformation_source_folder = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_split_parameters = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_where_statement = new System.Windows.Forms.TextBox();
            this.checkBox_object_active = new System.Windows.Forms.CheckBox();
            this.textBox_folder_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label_file_name = new System.Windows.Forms.Label();
            this.openFileDialogLocation = new System.Windows.Forms.OpenFileDialog();
            this.listView_all_objects = new System.Windows.Forms.ListView();
            this.Object_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.button_set_all_notactive = new System.Windows.Forms.Button();
            this.button_set_all_active = new System.Windows.Forms.Button();
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
            this.button_back_generator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox_transformation_incremental = new System.Windows.Forms.CheckBox();
            this.label_transformation_incremental = new System.Windows.Forms.Label();
            this.textBox_transformation_target_filename = new System.Windows.Forms.TextBox();
            this.label_transformation_target_filename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // label_object_name
            // 
            this.label_object_name.AutoSize = true;
            this.label_object_name.Location = new System.Drawing.Point(12, 125);
            this.label_object_name.Name = "label_object_name";
            this.label_object_name.Size = new System.Drawing.Size(105, 13);
            this.label_object_name.TabIndex = 1;
            this.label_object_name.Text = "transformation_name";
            // 
            // label_object_primary_key
            // 
            this.label_object_primary_key.AutoSize = true;
            this.label_object_primary_key.Location = new System.Drawing.Point(12, 162);
            this.label_object_primary_key.Name = "label_object_primary_key";
            this.label_object_primary_key.Size = new System.Drawing.Size(135, 13);
            this.label_object_primary_key.TabIndex = 4;
            this.label_object_primary_key.Text = "transformation_primary_key";
            // 
            // label_object_time_format
            // 
            this.label_object_time_format.AutoSize = true;
            this.label_object_time_format.Location = new System.Drawing.Point(12, 492);
            this.label_object_time_format.Name = "label_object_time_format";
            this.label_object_time_format.Size = new System.Drawing.Size(211, 13);
            this.label_object_time_format.TabIndex = 8;
            this.label_object_time_format.Text = "additional_transformation_number_of_years";
            // 
            // label_object_date_format
            // 
            this.label_object_date_format.AutoSize = true;
            this.label_object_date_format.Location = new System.Drawing.Point(12, 455);
            this.label_object_date_format.Name = "label_object_date_format";
            this.label_object_date_format.Size = new System.Drawing.Size(220, 13);
            this.label_object_date_format.TabIndex = 7;
            this.label_object_date_format.Text = "additional_transformation_number_of_months";
            // 
            // label_object_datetime_format
            // 
            this.label_object_datetime_format.AutoSize = true;
            this.label_object_datetime_format.Location = new System.Drawing.Point(12, 418);
            this.label_object_datetime_format.Name = "label_object_datetime_format";
            this.label_object_datetime_format.Size = new System.Drawing.Size(208, 13);
            this.label_object_datetime_format.TabIndex = 6;
            this.label_object_datetime_format.Text = "additional_transformation_number_of_days";
            // 
            // label_object_select_statement
            // 
            this.label_object_select_statement.AutoSize = true;
            this.label_object_select_statement.Location = new System.Drawing.Point(12, 199);
            this.label_object_select_statement.Name = "label_object_select_statement";
            this.label_object_select_statement.Size = new System.Drawing.Size(125, 13);
            this.label_object_select_statement.TabIndex = 5;
            this.label_object_select_statement.Text = "transformation_statement";
            // 
            // label_object_target_extraction_filename
            // 
            this.label_object_target_extraction_filename.AutoSize = true;
            this.label_object_target_extraction_filename.Location = new System.Drawing.Point(12, 603);
            this.label_object_target_extraction_filename.Name = "label_object_target_extraction_filename";
            this.label_object_target_extraction_filename.Size = new System.Drawing.Size(138, 13);
            this.label_object_target_extraction_filename.TabIndex = 16;
            this.label_object_target_extraction_filename.Text = "transformation_target_folder";
            // 
            // label_object_target_extraction_folder
            // 
            this.label_object_target_extraction_folder.AutoSize = true;
            this.label_object_target_extraction_folder.Location = new System.Drawing.Point(12, 566);
            this.label_object_target_extraction_folder.Name = "label_object_target_extraction_folder";
            this.label_object_target_extraction_folder.Size = new System.Drawing.Size(156, 13);
            this.label_object_target_extraction_folder.TabIndex = 15;
            this.label_object_target_extraction_folder.Text = "transformation_source_filename";
            // 
            // label_object_transformation_statement
            // 
            this.label_object_transformation_statement.AutoSize = true;
            this.label_object_transformation_statement.Location = new System.Drawing.Point(697, 455);
            this.label_object_transformation_statement.Name = "label_object_transformation_statement";
            this.label_object_transformation_statement.Size = new System.Drawing.Size(150, 13);
            this.label_object_transformation_statement.TabIndex = 14;
            this.label_object_transformation_statement.Text = "transformation_split_parameter";
            // 
            // label_object_reorganization
            // 
            this.label_object_reorganization.AutoSize = true;
            this.label_object_reorganization.Location = new System.Drawing.Point(12, 529);
            this.label_object_reorganization.Name = "label_object_reorganization";
            this.label_object_reorganization.Size = new System.Drawing.Size(143, 13);
            this.label_object_reorganization.TabIndex = 13;
            this.label_object_reorganization.Text = "transformation_source_folder";
            // 
            // label_object_fieldstoload_statement
            // 
            this.label_object_fieldstoload_statement.AutoSize = true;
            this.label_object_fieldstoload_statement.Location = new System.Drawing.Point(697, 279);
            this.label_object_fieldstoload_statement.Name = "label_object_fieldstoload_statement";
            this.label_object_fieldstoload_statement.Size = new System.Drawing.Size(206, 13);
            this.label_object_fieldstoload_statement.TabIndex = 12;
            this.label_object_fieldstoload_statement.Text = "additional_transformation_split_parameters";
            // 
            // label_object_active
            // 
            this.label_object_active.AutoSize = true;
            this.label_object_active.Location = new System.Drawing.Point(238, 91);
            this.label_object_active.Name = "label_object_active";
            this.label_object_active.Size = new System.Drawing.Size(108, 13);
            this.label_object_active.TabIndex = 10;
            this.label_object_active.Text = "transformation_active";
            // 
            // label_object_where_statement
            // 
            this.label_object_where_statement.AutoSize = true;
            this.label_object_where_statement.Location = new System.Drawing.Point(697, 106);
            this.label_object_where_statement.Name = "label_object_where_statement";
            this.label_object_where_statement.Size = new System.Drawing.Size(211, 13);
            this.label_object_where_statement.TabIndex = 9;
            this.label_object_where_statement.Text = "additional_transformation_where_statement";
            // 
            // textBox_transformation_name
            // 
            this.textBox_transformation_name.Location = new System.Drawing.Point(237, 122);
            this.textBox_transformation_name.Name = "textBox_transformation_name";
            this.textBox_transformation_name.Size = new System.Drawing.Size(425, 20);
            this.textBox_transformation_name.TabIndex = 17;
            this.textBox_transformation_name.TextChanged += new System.EventHandler(this.textBox_object_name_TextChanged);
            // 
            // textBox_transformation_primary_key
            // 
            this.textBox_transformation_primary_key.Location = new System.Drawing.Point(237, 159);
            this.textBox_transformation_primary_key.Name = "textBox_transformation_primary_key";
            this.textBox_transformation_primary_key.Size = new System.Drawing.Size(425, 20);
            this.textBox_transformation_primary_key.TabIndex = 20;
            // 
            // textBox_additional_transformation_number_of_years
            // 
            this.textBox_additional_transformation_number_of_years.Location = new System.Drawing.Point(237, 489);
            this.textBox_additional_transformation_number_of_years.Name = "textBox_additional_transformation_number_of_years";
            this.textBox_additional_transformation_number_of_years.Size = new System.Drawing.Size(425, 20);
            this.textBox_additional_transformation_number_of_years.TabIndex = 24;
            // 
            // textBox_additional_transformation_number_of_months
            // 
            this.textBox_additional_transformation_number_of_months.Location = new System.Drawing.Point(237, 452);
            this.textBox_additional_transformation_number_of_months.Name = "textBox_additional_transformation_number_of_months";
            this.textBox_additional_transformation_number_of_months.Size = new System.Drawing.Size(425, 20);
            this.textBox_additional_transformation_number_of_months.TabIndex = 23;
            // 
            // textBox_additional_transformation_number_of_days
            // 
            this.textBox_additional_transformation_number_of_days.Location = new System.Drawing.Point(237, 415);
            this.textBox_additional_transformation_number_of_days.Name = "textBox_additional_transformation_number_of_days";
            this.textBox_additional_transformation_number_of_days.Size = new System.Drawing.Size(425, 20);
            this.textBox_additional_transformation_number_of_days.TabIndex = 22;
            // 
            // textBox_transformation_statement
            // 
            this.textBox_transformation_statement.AcceptsReturn = true;
            this.textBox_transformation_statement.AcceptsTab = true;
            this.textBox_transformation_statement.Location = new System.Drawing.Point(237, 196);
            this.textBox_transformation_statement.Multiline = true;
            this.textBox_transformation_statement.Name = "textBox_transformation_statement";
            this.textBox_transformation_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_transformation_statement.Size = new System.Drawing.Size(425, 202);
            this.textBox_transformation_statement.TabIndex = 21;
            // 
            // textBox_transformation_target_folder
            // 
            this.textBox_transformation_target_folder.Location = new System.Drawing.Point(237, 600);
            this.textBox_transformation_target_folder.Name = "textBox_transformation_target_folder";
            this.textBox_transformation_target_folder.Size = new System.Drawing.Size(425, 20);
            this.textBox_transformation_target_folder.TabIndex = 32;
            // 
            // textBox_transformation_source_filename
            // 
            this.textBox_transformation_source_filename.Location = new System.Drawing.Point(237, 563);
            this.textBox_transformation_source_filename.Name = "textBox_transformation_source_filename";
            this.textBox_transformation_source_filename.Size = new System.Drawing.Size(425, 20);
            this.textBox_transformation_source_filename.TabIndex = 31;
            // 
            // textBox_transformation_split_parameter
            // 
            this.textBox_transformation_split_parameter.Location = new System.Drawing.Point(700, 471);
            this.textBox_transformation_split_parameter.Multiline = true;
            this.textBox_transformation_split_parameter.Name = "textBox_transformation_split_parameter";
            this.textBox_transformation_split_parameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_transformation_split_parameter.Size = new System.Drawing.Size(425, 149);
            this.textBox_transformation_split_parameter.TabIndex = 30;
            // 
            // textBox_transformation_source_folder
            // 
            this.textBox_transformation_source_folder.Location = new System.Drawing.Point(237, 526);
            this.textBox_transformation_source_folder.Name = "textBox_transformation_source_folder";
            this.textBox_transformation_source_folder.Size = new System.Drawing.Size(425, 20);
            this.textBox_transformation_source_folder.TabIndex = 29;
            // 
            // textBox_additional_transformation_split_parameters
            // 
            this.textBox_additional_transformation_split_parameters.Location = new System.Drawing.Point(700, 295);
            this.textBox_additional_transformation_split_parameters.Multiline = true;
            this.textBox_additional_transformation_split_parameters.Name = "textBox_additional_transformation_split_parameters";
            this.textBox_additional_transformation_split_parameters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_additional_transformation_split_parameters.Size = new System.Drawing.Size(425, 149);
            this.textBox_additional_transformation_split_parameters.TabIndex = 28;
            // 
            // textBox_additional_transformation_where_statement
            // 
            this.textBox_additional_transformation_where_statement.Location = new System.Drawing.Point(700, 122);
            this.textBox_additional_transformation_where_statement.Multiline = true;
            this.textBox_additional_transformation_where_statement.Name = "textBox_additional_transformation_where_statement";
            this.textBox_additional_transformation_where_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_additional_transformation_where_statement.Size = new System.Drawing.Size(425, 149);
            this.textBox_additional_transformation_where_statement.TabIndex = 25;
            // 
            // checkBox_object_active
            // 
            this.checkBox_object_active.AutoSize = true;
            this.checkBox_object_active.Location = new System.Drawing.Point(352, 91);
            this.checkBox_object_active.Name = "checkBox_object_active";
            this.checkBox_object_active.Size = new System.Drawing.Size(15, 14);
            this.checkBox_object_active.TabIndex = 34;
            this.checkBox_object_active.UseVisualStyleBackColor = true;
            // 
            // textBox_folder_path
            // 
            this.textBox_folder_path.Location = new System.Drawing.Point(237, 44);
            this.textBox_folder_path.Name = "textBox_folder_path";
            this.textBox_folder_path.Size = new System.Drawing.Size(888, 20);
            this.textBox_folder_path.TabIndex = 42;
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
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(237, 13);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(408, 20);
            this.textBox_file_name.TabIndex = 45;
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.Location = new System.Drawing.Point(12, 15);
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
            this.Object_Active});
            this.listView_all_objects.FullRowSelect = true;
            this.listView_all_objects.GridLines = true;
            this.listView_all_objects.HideSelection = false;
            this.listView_all_objects.Location = new System.Drawing.Point(1183, 122);
            this.listView_all_objects.MultiSelect = false;
            this.listView_all_objects.Name = "listView_all_objects";
            this.listView_all_objects.Size = new System.Drawing.Size(357, 498);
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
            // button_set_all_notactive
            // 
            this.button_set_all_notactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_set_all_notactive.Location = new System.Drawing.Point(1145, 585);
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
            this.button_set_all_active.Location = new System.Drawing.Point(1145, 547);
            this.button_set_all_active.Name = "button_set_all_active";
            this.button_set_all_active.Size = new System.Drawing.Size(32, 32);
            this.button_set_all_active.TabIndex = 55;
            this.button_set_all_active.Text = "Y";
            this.toolTips.SetToolTip(this.button_set_all_active, "Set all items in the list to active");
            this.button_set_all_active.UseVisualStyleBackColor = true;
            this.button_set_all_active.Click += new System.EventHandler(this.button_set_all_active_Click);
            // 
            // button_load_sample_object
            // 
            this.button_load_sample_object.AccessibleDescription = "";
            this.button_load_sample_object.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_load_sample_object.BackgroundImage")));
            this.button_load_sample_object.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_load_sample_object.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_load_sample_object.Location = new System.Drawing.Point(15, 74);
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
            this.button_remove_all_listviewitems.Location = new System.Drawing.Point(1145, 333);
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
            this.button_load_xml.Location = new System.Drawing.Point(1508, 80);
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
            this.button_update_object.Location = new System.Drawing.Point(54, 671);
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
            this.button_browse.Location = new System.Drawing.Point(651, 6);
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
            this.button_list_item_move_down.Location = new System.Drawing.Point(1145, 166);
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
            this.button_list_item_move_up.Location = new System.Drawing.Point(1145, 128);
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
            this.button_delete_list_item.Location = new System.Drawing.Point(1145, 295);
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
            this.BUTTON_CREATE_OBJECT.Location = new System.Drawing.Point(15, 671);
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
            this.BUTTON_CREATE_XML.Location = new System.Drawing.Point(1183, 623);
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
            this.BUTTON_EXIT.Location = new System.Drawing.Point(1508, 623);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(32, 32);
            this.BUTTON_EXIT.TabIndex = 0;
            this.toolTips.SetToolTip(this.BUTTON_EXIT, "Exit Application");
            this.BUTTON_EXIT.UseVisualStyleBackColor = true;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // button_back_generator
            // 
            this.button_back_generator.BackgroundImage = global::XML_Configurator.Properties.Resources._1481641481_Previous;
            this.button_back_generator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_generator.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_generator.Location = new System.Drawing.Point(1410, 623);
            this.button_back_generator.Name = "button_back_generator";
            this.button_back_generator.Size = new System.Drawing.Size(32, 32);
            this.button_back_generator.TabIndex = 67;
            this.toolTips.SetToolTip(this.button_back_generator, "Return to generator form");
            this.button_back_generator.UseVisualStyleBackColor = true;
            this.button_back_generator.Click += new System.EventHandler(this.button_back_generator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1180, 90);
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
            // checkBox_transformation_incremental
            // 
            this.checkBox_transformation_incremental.AutoSize = true;
            this.checkBox_transformation_incremental.Location = new System.Drawing.Point(651, 91);
            this.checkBox_transformation_incremental.Name = "checkBox_transformation_incremental";
            this.checkBox_transformation_incremental.Size = new System.Drawing.Size(15, 14);
            this.checkBox_transformation_incremental.TabIndex = 66;
            this.checkBox_transformation_incremental.UseVisualStyleBackColor = true;
            // 
            // label_transformation_incremental
            // 
            this.label_transformation_incremental.AutoSize = true;
            this.label_transformation_incremental.Location = new System.Drawing.Point(512, 91);
            this.label_transformation_incremental.Name = "label_transformation_incremental";
            this.label_transformation_incremental.Size = new System.Drawing.Size(133, 13);
            this.label_transformation_incremental.TabIndex = 65;
            this.label_transformation_incremental.Text = "transformation_incremental";
            // 
            // textBox_transformation_target_filename
            // 
            this.textBox_transformation_target_filename.Location = new System.Drawing.Point(237, 639);
            this.textBox_transformation_target_filename.Name = "textBox_transformation_target_filename";
            this.textBox_transformation_target_filename.Size = new System.Drawing.Size(425, 20);
            this.textBox_transformation_target_filename.TabIndex = 69;
            // 
            // label_transformation_target_filename
            // 
            this.label_transformation_target_filename.AutoSize = true;
            this.label_transformation_target_filename.Location = new System.Drawing.Point(12, 642);
            this.label_transformation_target_filename.Name = "label_transformation_target_filename";
            this.label_transformation_target_filename.Size = new System.Drawing.Size(151, 13);
            this.label_transformation_target_filename.TabIndex = 68;
            this.label_transformation_target_filename.Text = "transformation_target_filename";
            // 
            // _05_TransformatorCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1560, 715);
            this.Controls.Add(this.textBox_transformation_target_filename);
            this.Controls.Add(this.label_transformation_target_filename);
            this.Controls.Add(this.button_back_generator);
            this.Controls.Add(this.checkBox_transformation_incremental);
            this.Controls.Add(this.label_transformation_incremental);
            this.Controls.Add(this.button_set_all_notactive);
            this.Controls.Add(this.button_set_all_active);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_load_sample_object);
            this.Controls.Add(this.button_remove_all_listviewitems);
            this.Controls.Add(this.listView_all_objects);
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
            this.Controls.Add(this.checkBox_object_active);
            this.Controls.Add(this.BUTTON_CREATE_OBJECT);
            this.Controls.Add(this.textBox_transformation_target_folder);
            this.Controls.Add(this.textBox_transformation_source_filename);
            this.Controls.Add(this.textBox_transformation_split_parameter);
            this.Controls.Add(this.textBox_transformation_source_folder);
            this.Controls.Add(this.textBox_additional_transformation_split_parameters);
            this.Controls.Add(this.textBox_additional_transformation_where_statement);
            this.Controls.Add(this.textBox_additional_transformation_number_of_years);
            this.Controls.Add(this.textBox_additional_transformation_number_of_months);
            this.Controls.Add(this.textBox_additional_transformation_number_of_days);
            this.Controls.Add(this.textBox_transformation_statement);
            this.Controls.Add(this.textBox_transformation_primary_key);
            this.Controls.Add(this.textBox_transformation_name);
            this.Controls.Add(this.label_object_target_extraction_filename);
            this.Controls.Add(this.label_object_target_extraction_folder);
            this.Controls.Add(this.label_object_transformation_statement);
            this.Controls.Add(this.label_object_reorganization);
            this.Controls.Add(this.label_object_fieldstoload_statement);
            this.Controls.Add(this.label_object_active);
            this.Controls.Add(this.label_object_where_statement);
            this.Controls.Add(this.label_object_time_format);
            this.Controls.Add(this.label_object_date_format);
            this.Controls.Add(this.label_object_datetime_format);
            this.Controls.Add(this.label_object_select_statement);
            this.Controls.Add(this.label_object_primary_key);
            this.Controls.Add(this.label_object_name);
            this.Controls.Add(this.BUTTON_CREATE_XML);
            this.Controls.Add(this.BUTTON_EXIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_05_TransformatorCreator";
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
        private System.Windows.Forms.Label label_object_primary_key;
        private System.Windows.Forms.Label label_object_time_format;
        private System.Windows.Forms.Label label_object_date_format;
        private System.Windows.Forms.Label label_object_datetime_format;
        private System.Windows.Forms.Label label_object_select_statement;
        private System.Windows.Forms.Label label_object_target_extraction_filename;
        private System.Windows.Forms.Label label_object_target_extraction_folder;
        private System.Windows.Forms.Label label_object_transformation_statement;
        private System.Windows.Forms.Label label_object_fieldstoload_statement;
        private System.Windows.Forms.Label label_object_active;
        private System.Windows.Forms.Label label_object_where_statement;
        private System.Windows.Forms.TextBox textBox_transformation_name;
        private System.Windows.Forms.TextBox textBox_transformation_primary_key;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_years;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_months;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_days;
        private System.Windows.Forms.TextBox textBox_transformation_statement;
        private System.Windows.Forms.TextBox textBox_transformation_target_folder;
        private System.Windows.Forms.TextBox textBox_transformation_source_filename;
        private System.Windows.Forms.TextBox textBox_transformation_split_parameter;
        private System.Windows.Forms.TextBox textBox_transformation_source_folder;
        private System.Windows.Forms.TextBox textBox_additional_transformation_split_parameters;
        private System.Windows.Forms.TextBox textBox_additional_transformation_where_statement;
        private System.Windows.Forms.Label label_object_reorganization;
        private System.Windows.Forms.Button BUTTON_CREATE_OBJECT;
        private System.Windows.Forms.CheckBox checkBox_object_active;
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
        private System.Windows.Forms.CheckBox checkBox_transformation_incremental;
        private System.Windows.Forms.Label label_transformation_incremental;
        private System.Windows.Forms.Button button_back_generator;
        private System.Windows.Forms.TextBox textBox_transformation_target_filename;
        private System.Windows.Forms.Label label_transformation_target_filename;
    }
}

