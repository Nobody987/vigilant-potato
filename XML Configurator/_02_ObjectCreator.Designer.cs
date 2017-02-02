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
            this.folderBrowserDialogSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogLocation = new System.Windows.Forms.OpenFileDialog();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.button_delete_list_item_2 = new System.Windows.Forms.Button();
            this.button_list_item_move_up_2 = new System.Windows.Forms.Button();
            this.button_list_item_move_down_2 = new System.Windows.Forms.Button();
            this.button_remove_all_listviewitems_2 = new System.Windows.Forms.Button();
            this.button_set_all_active_2 = new System.Windows.Forms.Button();
            this.button_set_all_notactive_2 = new System.Windows.Forms.Button();
            this.button_back_generator = new System.Windows.Forms.Button();
            this.button_list_item_move_up = new System.Windows.Forms.Button();
            this.button_list_item_move_down = new System.Windows.Forms.Button();
            this.button_delete_list_item = new System.Windows.Forms.Button();
            this.button_remove_all_listviewitems = new System.Windows.Forms.Button();
            this.button_set_all_notactive = new System.Windows.Forms.Button();
            this.button_set_all_active = new System.Windows.Forms.Button();
            this.button_next_transform = new System.Windows.Forms.Button();
            this.button_go_back_database_connector = new System.Windows.Forms.Button();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabTransformation = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.listView_all_transformations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_transformation_split_parameter = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_split_parameters = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_where_statement = new System.Windows.Forms.TextBox();
            this.textBox_file_name_2 = new System.Windows.Forms.TextBox();
            this.textBox_transformation_target_filename = new System.Windows.Forms.TextBox();
            this.textBox_transformation_target_folder = new System.Windows.Forms.TextBox();
            this.textBox_transformation_source_filename = new System.Windows.Forms.TextBox();
            this.textBox_transformation_source_folder = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_years = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_months = new System.Windows.Forms.TextBox();
            this.textBox_additional_transformation_number_of_days = new System.Windows.Forms.TextBox();
            this.textBox_transformation_statement = new System.Windows.Forms.TextBox();
            this.textBox_transformation_primary_key = new System.Windows.Forms.TextBox();
            this.textBox_transformation_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_transformation_target_filename = new System.Windows.Forms.Label();
            this.checkBox_transformation_incremental = new System.Windows.Forms.CheckBox();
            this.label_transformation_incremental = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.tabGenerator = new System.Windows.Forms.TabPage();
            this.label_object_active = new System.Windows.Forms.Label();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label_file_name = new System.Windows.Forms.Label();
            this.label_object_name = new System.Windows.Forms.Label();
            this.label_object_reload_minutes = new System.Windows.Forms.Label();
            this.label_object_comment = new System.Windows.Forms.Label();
            this.label_object_primary_key = new System.Windows.Forms.Label();
            this.listView_all_objects = new System.Windows.Forms.ListView();
            this.Object_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Object_load_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_object_where_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_fieldstoload_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_name = new System.Windows.Forms.TextBox();
            this.textBox_object_reload_minutes = new System.Windows.Forms.TextBox();
            this.textBox_object_comment = new System.Windows.Forms.TextBox();
            this.textBox_object_transformation_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_primary_key = new System.Windows.Forms.TextBox();
            this.textBox_object_select_statement = new System.Windows.Forms.TextBox();
            this.textBox_object_target_extraction_filename = new System.Windows.Forms.TextBox();
            this.textBox_object_target_extraction_folder = new System.Windows.Forms.TextBox();
            this.textBox_object_reorganization = new System.Windows.Forms.TextBox();
            this.textBox_object_time_format = new System.Windows.Forms.TextBox();
            this.textBox_object_datetime_format = new System.Windows.Forms.TextBox();
            this.textBox_object_date_format = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_object_select_statement = new System.Windows.Forms.Label();
            this.checkBox_object_active = new System.Windows.Forms.CheckBox();
            this.label_object_where_statement = new System.Windows.Forms.Label();
            this.label_object_fieldstoload_statement = new System.Windows.Forms.Label();
            this.label_object_load_type = new System.Windows.Forms.Label();
            this.comboBox_object_load_type = new System.Windows.Forms.ComboBox();
            this.label_object_transformation_statement = new System.Windows.Forms.Label();
            this.label_object_datetime_format = new System.Windows.Forms.Label();
            this.label_object_target_extraction_filename = new System.Windows.Forms.Label();
            this.label_object_date_format = new System.Windows.Forms.Label();
            this.label_object_time_format = new System.Windows.Forms.Label();
            this.label_object_reorganization = new System.Windows.Forms.Label();
            this.label_object_target_extraction_folder = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_load_xml = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_create_object = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_update_object = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_create_xml = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_execute_test_statement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_load_sample_object = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_save = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_folder_path = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_browse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_database = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_loaded_datasources = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.tabTransformation.SuspendLayout();
            this.tabGenerator.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogLocation
            // 
            this.openFileDialogLocation.DefaultExt = "xml";
            this.openFileDialogLocation.FileName = "openFileDialogXML";
            this.openFileDialogLocation.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialogLocation.InitialDirectory = "s";
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
            // button_back_generator
            // 
            this.button_back_generator.BackgroundImage = global::XML_Configurator.Properties.Resources._1481641481_Previous;
            this.button_back_generator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_generator.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_generator.Location = new System.Drawing.Point(1218, 475);
            this.button_back_generator.Name = "button_back_generator";
            this.button_back_generator.Size = new System.Drawing.Size(32, 32);
            this.button_back_generator.TabIndex = 119;
            this.toolTips.SetToolTip(this.button_back_generator, "Return to generator form");
            this.button_back_generator.UseVisualStyleBackColor = true;
            this.button_back_generator.Click += new System.EventHandler(this.button_back_generator_Click);
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
            // button_next_transform
            // 
            this.button_next_transform.BackgroundImage = global::XML_Configurator.Properties.Resources._1481573303_Next;
            this.button_next_transform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next_transform.Location = new System.Drawing.Point(1213, 544);
            this.button_next_transform.Name = "button_next_transform";
            this.button_next_transform.Size = new System.Drawing.Size(32, 32);
            this.button_next_transform.TabIndex = 65;
            this.toolTips.SetToolTip(this.button_next_transform, "Go to next form for transformation");
            this.button_next_transform.UseVisualStyleBackColor = true;
            this.button_next_transform.Click += new System.EventHandler(this.button_next_transform_Click);
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
            // EP
            // 
            this.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EP.ContainerControl = this;
            // 
            // tabTransformation
            // 
            this.tabTransformation.Controls.Add(this.button_back_generator);
            this.tabTransformation.Controls.Add(this.button_set_all_notactive_2);
            this.tabTransformation.Controls.Add(this.button_set_all_active_2);
            this.tabTransformation.Controls.Add(this.button_remove_all_listviewitems_2);
            this.tabTransformation.Controls.Add(this.button_list_item_move_down_2);
            this.tabTransformation.Controls.Add(this.button_list_item_move_up_2);
            this.tabTransformation.Controls.Add(this.button_delete_list_item_2);
            this.tabTransformation.Controls.Add(this.label19);
            this.tabTransformation.Controls.Add(this.listView_all_transformations);
            this.tabTransformation.Controls.Add(this.textBox_transformation_split_parameter);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_split_parameters);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_where_statement);
            this.tabTransformation.Controls.Add(this.textBox_file_name_2);
            this.tabTransformation.Controls.Add(this.textBox_transformation_target_filename);
            this.tabTransformation.Controls.Add(this.textBox_transformation_target_folder);
            this.tabTransformation.Controls.Add(this.textBox_transformation_source_filename);
            this.tabTransformation.Controls.Add(this.textBox_transformation_source_folder);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_number_of_years);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_number_of_months);
            this.tabTransformation.Controls.Add(this.textBox_additional_transformation_number_of_days);
            this.tabTransformation.Controls.Add(this.textBox_transformation_statement);
            this.tabTransformation.Controls.Add(this.textBox_transformation_primary_key);
            this.tabTransformation.Controls.Add(this.textBox_transformation_name);
            this.tabTransformation.Controls.Add(this.label16);
            this.tabTransformation.Controls.Add(this.label17);
            this.tabTransformation.Controls.Add(this.label18);
            this.tabTransformation.Controls.Add(this.label14);
            this.tabTransformation.Controls.Add(this.label_transformation_target_filename);
            this.tabTransformation.Controls.Add(this.checkBox_transformation_incremental);
            this.tabTransformation.Controls.Add(this.label_transformation_incremental);
            this.tabTransformation.Controls.Add(this.checkBox1);
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
            this.tabTransformation.Size = new System.Drawing.Size(1269, 607);
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
            // textBox_file_name_2
            // 
            this.textBox_file_name_2.Location = new System.Drawing.Point(234, 11);
            this.textBox_file_name_2.Name = "textBox_file_name_2";
            this.textBox_file_name_2.Size = new System.Drawing.Size(320, 20);
            this.textBox_file_name_2.TabIndex = 101;
            // 
            // textBox_transformation_target_filename
            // 
            this.textBox_transformation_target_filename.Location = new System.Drawing.Point(234, 491);
            this.textBox_transformation_target_filename.Name = "textBox_transformation_target_filename";
            this.textBox_transformation_target_filename.Size = new System.Drawing.Size(320, 20);
            this.textBox_transformation_target_filename.TabIndex = 96;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "XML file name";
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
            // tabGenerator
            // 
            this.tabGenerator.Controls.Add(this.button_go_back_database_connector);
            this.tabGenerator.Controls.Add(this.button_next_transform);
            this.tabGenerator.Controls.Add(this.label_object_active);
            this.tabGenerator.Controls.Add(this.textBox_file_name);
            this.tabGenerator.Controls.Add(this.button_set_all_active);
            this.tabGenerator.Controls.Add(this.label_file_name);
            this.tabGenerator.Controls.Add(this.button_set_all_notactive);
            this.tabGenerator.Controls.Add(this.label_object_name);
            this.tabGenerator.Controls.Add(this.label_object_reload_minutes);
            this.tabGenerator.Controls.Add(this.label_object_comment);
            this.tabGenerator.Controls.Add(this.label_object_primary_key);
            this.tabGenerator.Controls.Add(this.listView_all_objects);
            this.tabGenerator.Controls.Add(this.textBox_object_where_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_fieldstoload_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_name);
            this.tabGenerator.Controls.Add(this.textBox_object_reload_minutes);
            this.tabGenerator.Controls.Add(this.textBox_object_comment);
            this.tabGenerator.Controls.Add(this.textBox_object_transformation_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_primary_key);
            this.tabGenerator.Controls.Add(this.textBox_object_select_statement);
            this.tabGenerator.Controls.Add(this.textBox_object_target_extraction_filename);
            this.tabGenerator.Controls.Add(this.textBox_object_target_extraction_folder);
            this.tabGenerator.Controls.Add(this.textBox_object_reorganization);
            this.tabGenerator.Controls.Add(this.textBox_object_time_format);
            this.tabGenerator.Controls.Add(this.textBox_object_datetime_format);
            this.tabGenerator.Controls.Add(this.textBox_object_date_format);
            this.tabGenerator.Controls.Add(this.label2);
            this.tabGenerator.Controls.Add(this.label_object_select_statement);
            this.tabGenerator.Controls.Add(this.button_remove_all_listviewitems);
            this.tabGenerator.Controls.Add(this.checkBox_object_active);
            this.tabGenerator.Controls.Add(this.label_object_where_statement);
            this.tabGenerator.Controls.Add(this.label_object_fieldstoload_statement);
            this.tabGenerator.Controls.Add(this.label_object_load_type);
            this.tabGenerator.Controls.Add(this.button_delete_list_item);
            this.tabGenerator.Controls.Add(this.button_list_item_move_down);
            this.tabGenerator.Controls.Add(this.comboBox_object_load_type);
            this.tabGenerator.Controls.Add(this.button_list_item_move_up);
            this.tabGenerator.Controls.Add(this.label_object_transformation_statement);
            this.tabGenerator.Controls.Add(this.label_object_datetime_format);
            this.tabGenerator.Controls.Add(this.label_object_target_extraction_filename);
            this.tabGenerator.Controls.Add(this.label_object_date_format);
            this.tabGenerator.Controls.Add(this.label_object_time_format);
            this.tabGenerator.Controls.Add(this.label_object_reorganization);
            this.tabGenerator.Controls.Add(this.label_object_target_extraction_folder);
            this.tabGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabGenerator.Name = "tabGenerator";
            this.tabGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerator.Size = new System.Drawing.Size(1269, 605);
            this.tabGenerator.TabIndex = 0;
            this.tabGenerator.Text = "Generator";
            this.tabGenerator.UseVisualStyleBackColor = true;
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
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(183, 8);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(327, 20);
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
            // label_object_comment
            // 
            this.label_object_comment.AutoSize = true;
            this.label_object_comment.Location = new System.Drawing.Point(11, 143);
            this.label_object_comment.Name = "label_object_comment";
            this.label_object_comment.Size = new System.Drawing.Size(85, 13);
            this.label_object_comment.TabIndex = 3;
            this.label_object_comment.Text = "object_comment";
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
            // textBox_object_where_statement
            // 
            this.textBox_object_where_statement.Location = new System.Drawing.Point(554, 77);
            this.textBox_object_where_statement.Multiline = true;
            this.textBox_object_where_statement.Name = "textBox_object_where_statement";
            this.textBox_object_where_statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_object_where_statement.Size = new System.Drawing.Size(325, 170);
            this.textBox_object_where_statement.TabIndex = 25;
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
            // textBox_object_comment
            // 
            this.textBox_object_comment.Location = new System.Drawing.Point(181, 140);
            this.textBox_object_comment.Name = "textBox_object_comment";
            this.textBox_object_comment.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_comment.TabIndex = 19;
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
            // textBox_object_primary_key
            // 
            this.textBox_object_primary_key.Location = new System.Drawing.Point(181, 170);
            this.textBox_object_primary_key.Name = "textBox_object_primary_key";
            this.textBox_object_primary_key.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_primary_key.TabIndex = 20;
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
            // textBox_object_reorganization
            // 
            this.textBox_object_reorganization.Location = new System.Drawing.Point(181, 503);
            this.textBox_object_reorganization.Name = "textBox_object_reorganization";
            this.textBox_object_reorganization.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_reorganization.TabIndex = 29;
            // 
            // textBox_object_time_format
            // 
            this.textBox_object_time_format.Location = new System.Drawing.Point(181, 473);
            this.textBox_object_time_format.Name = "textBox_object_time_format";
            this.textBox_object_time_format.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_time_format.TabIndex = 24;
            // 
            // textBox_object_datetime_format
            // 
            this.textBox_object_datetime_format.Location = new System.Drawing.Point(181, 413);
            this.textBox_object_datetime_format.Name = "textBox_object_datetime_format";
            this.textBox_object_datetime_format.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_datetime_format.TabIndex = 22;
            // 
            // textBox_object_date_format
            // 
            this.textBox_object_date_format.Location = new System.Drawing.Point(181, 443);
            this.textBox_object_date_format.Name = "textBox_object_date_format";
            this.textBox_object_date_format.Size = new System.Drawing.Size(329, 20);
            this.textBox_object_date_format.TabIndex = 23;
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
            // label_object_select_statement
            // 
            this.label_object_select_statement.AutoSize = true;
            this.label_object_select_statement.Location = new System.Drawing.Point(11, 203);
            this.label_object_select_statement.Name = "label_object_select_statement";
            this.label_object_select_statement.Size = new System.Drawing.Size(122, 13);
            this.label_object_select_statement.TabIndex = 5;
            this.label_object_select_statement.Text = "object_select_statement";
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
            // label_object_where_statement
            // 
            this.label_object_where_statement.AutoSize = true;
            this.label_object_where_statement.Location = new System.Drawing.Point(551, 50);
            this.label_object_where_statement.Name = "label_object_where_statement";
            this.label_object_where_statement.Size = new System.Drawing.Size(123, 13);
            this.label_object_where_statement.TabIndex = 9;
            this.label_object_where_statement.Text = "object_where_statement";
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
            // comboBox_object_load_type
            // 
            this.comboBox_object_load_type.FormattingEnabled = true;
            this.comboBox_object_load_type.Location = new System.Drawing.Point(389, 49);
            this.comboBox_object_load_type.Name = "comboBox_object_load_type";
            this.comboBox_object_load_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_object_load_type.TabIndex = 35;
            this.comboBox_object_load_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_object_load_type_SelectedIndexChanged);
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
            // label_object_datetime_format
            // 
            this.label_object_datetime_format.AutoSize = true;
            this.label_object_datetime_format.Location = new System.Drawing.Point(11, 416);
            this.label_object_datetime_format.Name = "label_object_datetime_format";
            this.label_object_datetime_format.Size = new System.Drawing.Size(117, 13);
            this.label_object_datetime_format.TabIndex = 6;
            this.label_object_datetime_format.Text = "object_datetime_format";
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
            // label_object_date_format
            // 
            this.label_object_date_format.AutoSize = true;
            this.label_object_date_format.Location = new System.Drawing.Point(11, 446);
            this.label_object_date_format.Name = "label_object_date_format";
            this.label_object_date_format.Size = new System.Drawing.Size(98, 13);
            this.label_object_date_format.TabIndex = 7;
            this.label_object_date_format.Text = "object_date_format";
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
            // label_object_reorganization
            // 
            this.label_object_reorganization.AutoSize = true;
            this.label_object_reorganization.Location = new System.Drawing.Point(11, 506);
            this.label_object_reorganization.Name = "label_object_reorganization";
            this.label_object_reorganization.Size = new System.Drawing.Size(108, 13);
            this.label_object_reorganization.TabIndex = 13;
            this.label_object_reorganization.Text = "object_reorganization";
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
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabGenerator);
            this.tabControl.Controls.Add(this.tabTransformation);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1277, 631);
            this.tabControl.TabIndex = 66;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_load_xml,
            this.toolStripSeparator5,
            this.toolStripButton_create_object,
            this.toolStripButton_update_object,
            this.toolStripButton_create_xml,
            this.toolStripSeparator1,
            this.toolStripButton_execute_test_statement,
            this.toolStripSeparator2,
            this.toolStripButton_load_sample_object,
            this.toolStripSeparator3,
            this.toolStripLabel_save,
            this.toolStripTextBox_folder_path,
            this.toolStripButton_browse,
            this.toolStripSeparator4,
            this.toolStripLabel_database,
            this.toolStripComboBox_loaded_datasources});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1277, 25);
            this.toolStripMain.TabIndex = 67;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton_load_xml
            // 
            this.toolStripButton_load_xml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_load_xml.Image = global::XML_Configurator.Properties.Resources._1474913677_folder_with_file;
            this.toolStripButton_load_xml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_load_xml.Name = "toolStripButton_load_xml";
            this.toolStripButton_load_xml.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_load_xml.ToolTipText = "Load XML file from location";
            this.toolStripButton_load_xml.Click += new System.EventHandler(this.toolStripButton_load_xml_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_create_object
            // 
            this.toolStripButton_create_object.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_create_object.Image = global::XML_Configurator.Properties.Resources._1474915550_Add;
            this.toolStripButton_create_object.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_create_object.Name = "toolStripButton_create_object";
            this.toolStripButton_create_object.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_create_object.ToolTipText = "Create new object in the list";
            this.toolStripButton_create_object.Click += new System.EventHandler(this.toolStripButton_create_object_Click);
            // 
            // toolStripButton_update_object
            // 
            this.toolStripButton_update_object.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_update_object.Image = global::XML_Configurator.Properties.Resources._1474915038_system_restart;
            this.toolStripButton_update_object.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_update_object.Name = "toolStripButton_update_object";
            this.toolStripButton_update_object.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_update_object.ToolTipText = "Update selected object in the list";
            this.toolStripButton_update_object.Click += new System.EventHandler(this.toolStripButton_update_object_Click);
            // 
            // toolStripButton_create_xml
            // 
            this.toolStripButton_create_xml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_create_xml.Image = global::XML_Configurator.Properties.Resources._1474915151_Save;
            this.toolStripButton_create_xml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_create_xml.Name = "toolStripButton_create_xml";
            this.toolStripButton_create_xml.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_create_xml.ToolTipText = "Create XML file with objects from the list on chosen location";
            this.toolStripButton_create_xml.Click += new System.EventHandler(this.toolStripButton_create_xml_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_execute_test_statement
            // 
            this.toolStripButton_execute_test_statement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_execute_test_statement.Image = global::XML_Configurator.Properties.Resources._1481560037_icon_89_document_file_sql;
            this.toolStripButton_execute_test_statement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_execute_test_statement.Name = "toolStripButton_execute_test_statement";
            this.toolStripButton_execute_test_statement.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_execute_test_statement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_execute_test_statement.ToolTipText = "Execute statement to return number of rows affected";
            this.toolStripButton_execute_test_statement.Click += new System.EventHandler(this.toolStripButton_execute_test_statement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_load_sample_object
            // 
            this.toolStripButton_load_sample_object.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_load_sample_object.Image = global::XML_Configurator.Properties.Resources._1474916383_folder_new;
            this.toolStripButton_load_sample_object.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_load_sample_object.Name = "toolStripButton_load_sample_object";
            this.toolStripButton_load_sample_object.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_load_sample_object.ToolTipText = "Populate fields with sample data";
            this.toolStripButton_load_sample_object.Click += new System.EventHandler(this.toolStripButton_load_sample_object_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_save
            // 
            this.toolStripLabel_save.Name = "toolStripLabel_save";
            this.toolStripLabel_save.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel_save.Text = "XML Save Location";
            // 
            // toolStripTextBox_folder_path
            // 
            this.toolStripTextBox_folder_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_folder_path.Name = "toolStripTextBox_folder_path";
            this.toolStripTextBox_folder_path.Size = new System.Drawing.Size(750, 25);
            // 
            // toolStripButton_browse
            // 
            this.toolStripButton_browse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_browse.Image = global::XML_Configurator.Properties.Resources._1474913320_manilla_folder_saved_search;
            this.toolStripButton_browse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_browse.Name = "toolStripButton_browse";
            this.toolStripButton_browse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_browse.ToolTipText = "Browse location to store XML file";
            this.toolStripButton_browse.Click += new System.EventHandler(this.toolStripButton_browse_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_database
            // 
            this.toolStripLabel_database.Name = "toolStripLabel_database";
            this.toolStripLabel_database.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel_database.Text = "Database";
            // 
            // toolStripComboBox_loaded_datasources
            // 
            this.toolStripComboBox_loaded_datasources.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripComboBox_loaded_datasources.Name = "toolStripComboBox_loaded_datasources";
            this.toolStripComboBox_loaded_datasources.Size = new System.Drawing.Size(121, 25);
            // 
            // _02_ObjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1277, 658);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_02_ObjectCreator";
            this.Text = "XML Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectCreator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.tabTransformation.ResumeLayout(false);
            this.tabTransformation.PerformLayout();
            this.tabGenerator.ResumeLayout(false);
            this.tabGenerator.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSaveLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialogLocation;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ErrorProvider EP;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton_create_object;
        private System.Windows.Forms.ToolStripButton toolStripButton_update_object;
        private System.Windows.Forms.ToolStripButton toolStripButton_create_xml;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGenerator;
        private System.Windows.Forms.Button button_go_back_database_connector;
        private System.Windows.Forms.Button button_next_transform;
        private System.Windows.Forms.Label label_object_active;
        private System.Windows.Forms.TextBox textBox_file_name;
        private System.Windows.Forms.Button button_set_all_active;
        private System.Windows.Forms.Label label_file_name;
        private System.Windows.Forms.Button button_set_all_notactive;
        private System.Windows.Forms.Label label_object_name;
        private System.Windows.Forms.Label label_object_reload_minutes;
        private System.Windows.Forms.Label label_object_comment;
        private System.Windows.Forms.Label label_object_primary_key;
        private System.Windows.Forms.ListView listView_all_objects;
        private System.Windows.Forms.ColumnHeader Object_Name;
        private System.Windows.Forms.ColumnHeader Object_Active;
        private System.Windows.Forms.ColumnHeader Object_load_type;
        private System.Windows.Forms.TextBox textBox_object_where_statement;
        private System.Windows.Forms.TextBox textBox_object_fieldstoload_statement;
        private System.Windows.Forms.TextBox textBox_object_name;
        private System.Windows.Forms.TextBox textBox_object_reload_minutes;
        private System.Windows.Forms.TextBox textBox_object_comment;
        private System.Windows.Forms.TextBox textBox_object_transformation_statement;
        private System.Windows.Forms.TextBox textBox_object_primary_key;
        private System.Windows.Forms.TextBox textBox_object_select_statement;
        private System.Windows.Forms.TextBox textBox_object_target_extraction_filename;
        private System.Windows.Forms.TextBox textBox_object_target_extraction_folder;
        private System.Windows.Forms.TextBox textBox_object_reorganization;
        private System.Windows.Forms.TextBox textBox_object_time_format;
        private System.Windows.Forms.TextBox textBox_object_datetime_format;
        private System.Windows.Forms.TextBox textBox_object_date_format;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_object_select_statement;
        private System.Windows.Forms.Button button_remove_all_listviewitems;
        private System.Windows.Forms.CheckBox checkBox_object_active;
        private System.Windows.Forms.Label label_object_where_statement;
        private System.Windows.Forms.Label label_object_fieldstoload_statement;
        private System.Windows.Forms.Label label_object_load_type;
        private System.Windows.Forms.Button button_delete_list_item;
        private System.Windows.Forms.Button button_list_item_move_down;
        private System.Windows.Forms.ComboBox comboBox_object_load_type;
        private System.Windows.Forms.Button button_list_item_move_up;
        private System.Windows.Forms.Label label_object_transformation_statement;
        private System.Windows.Forms.Label label_object_datetime_format;
        private System.Windows.Forms.Label label_object_target_extraction_filename;
        private System.Windows.Forms.Label label_object_date_format;
        private System.Windows.Forms.Label label_object_time_format;
        private System.Windows.Forms.Label label_object_reorganization;
        private System.Windows.Forms.Label label_object_target_extraction_folder;
        private System.Windows.Forms.TabPage tabTransformation;
        private System.Windows.Forms.Button button_back_generator;
        private System.Windows.Forms.Button button_set_all_notactive_2;
        private System.Windows.Forms.Button button_set_all_active_2;
        private System.Windows.Forms.Button button_remove_all_listviewitems_2;
        private System.Windows.Forms.Button button_list_item_move_down_2;
        private System.Windows.Forms.Button button_list_item_move_up_2;
        private System.Windows.Forms.Button button_delete_list_item_2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView listView_all_transformations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox_transformation_split_parameter;
        private System.Windows.Forms.TextBox textBox_additional_transformation_split_parameters;
        private System.Windows.Forms.TextBox textBox_additional_transformation_where_statement;
        private System.Windows.Forms.TextBox textBox_file_name_2;
        private System.Windows.Forms.TextBox textBox_transformation_target_filename;
        private System.Windows.Forms.TextBox textBox_transformation_target_folder;
        private System.Windows.Forms.TextBox textBox_transformation_source_filename;
        private System.Windows.Forms.TextBox textBox_transformation_source_folder;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_years;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_months;
        private System.Windows.Forms.TextBox textBox_additional_transformation_number_of_days;
        private System.Windows.Forms.TextBox textBox_transformation_statement;
        private System.Windows.Forms.TextBox textBox_transformation_primary_key;
        private System.Windows.Forms.TextBox textBox_transformation_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_transformation_target_filename;
        private System.Windows.Forms.CheckBox checkBox_transformation_incremental;
        private System.Windows.Forms.Label label_transformation_incremental;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_execute_test_statement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_load_sample_object;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_save;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_folder_path;
        private System.Windows.Forms.ToolStripButton toolStripButton_browse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_database;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_loaded_datasources;
        private System.Windows.Forms.ToolStripButton toolStripButton_load_xml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

