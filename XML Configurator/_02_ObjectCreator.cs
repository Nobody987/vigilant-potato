using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using XML_Configurator.DataModel;

namespace XML_Configurator
{
    public partial class _02_ObjectCreator : Form
    {
        List<load_types> list_load_types;
        List<data_type> list_data_types;
        List<database_table> loaded_tables;
        _03_DatabaseConnector form_database_connector;
        datasource datasource;
        _00_Controller _controller;

        public _02_ObjectCreator(List<database_table> loaded_tables_from_database, datasource loaded_datasource, _03_DatabaseConnector dc)
        {
            InitializeComponent();
            _controller = _00_Controller._instance;
            loaded_tables = loaded_tables_from_database;
            WindowState = FormWindowState.Maximized;

            form_database_connector = dc;
            datasource = loaded_datasource;

            list_load_types = load_types.read_load_types_file();
            list_data_types = data_type.read_data_type_file();
            comboBox_object_load_type.Items.AddRange(load_types.read_load_types_file().ToArray());
            comboBox_object_load_type.SelectedIndex = 0;
            populateComboBox();

            populate_listview_all_objects();
            if (listView_all_objects.SelectedItems.Count == 0)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", false);
            }
            textBox_file_name.Text = "XML_FILE.xml";
            toolStripTextBox_folder_path.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void populateComboBox()
        {
            toolStripComboBox_loaded_datasources.Items.Clear();
            toolStripComboBox_loaded_datasources.Items.AddRange(datasource.read_datasource_file().ToArray());
        }

        private void populate_listview_all_objects()
        {
            if (loaded_tables != null) //ovo se koristi kada se pravi novi xml, tj prosledjena je lista, pa mora da se popuni listview
            {
                foreach (database_table item in loaded_tables)
                {
                    populate_fields(loaded_tables, loaded_tables.IndexOf(item));
                    createGeneratorItem();
                }
            }
            loaded_tables = null;
        }

        private void populate_fields(List<database_table> loaded_tables, int index)
        {
            textBox_object_name.Text = loaded_tables[index].ToString();
            textBox_object_comment.Text = loaded_tables[index].ToString();

            textBox_object_primary_key.Text = null;

            for (int i = 0; i < loaded_tables[index].List_column_objects.Count(); i++)
            {
                if (!loaded_tables[index].List_column_objects[i].Column_nullable.Equals("YES") && !loaded_tables[index].List_column_objects[i].Column_nullable.Equals("Y"))
                {
                    if (string.IsNullOrEmpty(textBox_object_primary_key.Text))
                    {
                        textBox_object_primary_key.Text += loaded_tables[index].List_column_objects[i].Column_name.ToString();
                    }
                    else
                    {
                        textBox_object_primary_key.Text += " & '_' & " + loaded_tables[index].List_column_objects[i].Column_name.ToString();
                    }
                }
            }

            textBox_object_datetime_format.Text = "YYYYMMDDhhmmss";
            textBox_object_date_format.Text = "YYYYMMDD";
            textBox_object_time_format.Text = "hhmmss";

            ///////////////////////////////////////////////////////////
            //  Select Statement
            ///////////////////////////////////////////////////////////

            StringBuilder sb = new StringBuilder().AppendLine("SELECT");

            //for (int i = 0; i < loaded_tables[index].Columns.Count; i++)
            //{
            //    //sb.AppendLine("\t" + statement_builder(loaded_tables[index].ToString(), loaded_tables[index].Columns[i], loaded_tables[index].Columns_types[i]));
            //}

            //foreach (string column in loaded_tables[index].Columns)
            //{
            //    sb.AppendLine("\t" + column);
            //}

            sb.AppendLine("\t" + "$(vDatasource_Object_FieldsToLoad_Statement)");

            if (!string.IsNullOrEmpty(datasource.Datasource_library)) //proverava dali postoji library da se doda u upit
            {
                sb.Append("FROM " + datasource.Datasource_library + "." + loaded_tables[index].ToString());
            }
            else
            {
                sb.Append("FROM " + loaded_tables[index].ToString());
            }
            textBox_object_select_statement.Text = sb.ToString();

            ///////////////////////////////////////////////////////////
            //  Select Statement
            ///////////////////////////////////////////////////////////


            checkBox_object_active.Checked = true;
            comboBox_object_load_type.SelectedIndex = 0;
            textBox_object_target_extraction_folder.Text = loaded_tables[index].ToString();
            textBox_object_target_extraction_filename.Text = list_load_types[0].Load_type_file_prefix + loaded_tables[index].ToString() + list_load_types[0].Load_type_file_sufix;

            ///////////////////////////////////////////////////////////
            //  Transformation Statement  
            ///////////////////////////////////////////////////////////

            StringBuilder transformation_builder = new StringBuilder();

            for (int i = 0; i < loaded_tables[index].List_column_objects.Count; i++)
            {
                transformation_builder.AppendLine(statement_builder(loaded_tables[index].ToString(), loaded_tables[index].List_column_objects[i].Column_name, loaded_tables[index].List_column_objects[i].Column_data_type));
            }
            transformation_builder.Remove(transformation_builder.ToString().LastIndexOf(','), 1);
            textBox_object_transformation_statement.Text = transformation_builder.ToString();

            ///////////////////////////////////////////////////////////
            //  Transformation Statement
            ///////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////
            //  Fields to load Statement
            ///////////////////////////////////////////////////////////

            StringBuilder fields_to_load_builder = new StringBuilder();

            for (int i = 0; i < loaded_tables[index].List_column_objects.Count; i++)
            {
                if (loaded_tables[index].List_column_objects[i].Column_name != loaded_tables[index].List_column_objects.Last().Column_name)
                {
                    fields_to_load_builder.AppendLine(loaded_tables[index].List_column_objects[i].Column_name.ToString() + ",\t");
                }
                else
                {
                    fields_to_load_builder.AppendLine(loaded_tables[index].List_column_objects[i].Column_name.ToString() + "\t");
                }
            }

            textBox_object_fieldstoload_statement.Text = fields_to_load_builder.ToString();

            ///////////////////////////////////////////////////////////
            //  Fields to load Statement
            ///////////////////////////////////////////////////////////        
        }

        internal void add_database_objects(List<database_table> list_selected_tables, datasource ds, _03_DatabaseConnector _03_DatabaseConnector)
        {
            loaded_tables = list_selected_tables;
            populate_listview_all_objects();
            datasource = ds;
            //populate_fields(loaded_tables, 0);
        }

        private string statement_builder(string table_name, string column_name, string data_type_instance)
        {
            foreach (data_type item in list_data_types)
            {
                if (item.Data_type_name.ToUpper() == data_type_instance.ToUpper())
                {
                    return item.Data_type_return_value.Replace("COLUMN_NAME", column_name) + " AS " + table_name + "." + column_name + ",";
                }
            }
            return column_name + " AS " + table_name + "." + column_name + "," + @" //Unknown data type " + data_type_instance;
        }

        private string write_multiline_statement(string v)
        {
            string return_string = "";
            //string[] string_array = v.Trim().Replace("\t", "").Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] string_array = v.Trim().Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < string_array.Length; i++)
            {
                if (!string.IsNullOrEmpty(string_array[i].Trim()))
                {
                    string item = string_array[i].Trim();
                    if (string_array[i].ToUpper().Contains("SELECT")) //SELECT
                    {
                        return_string += "\r\n\t\t" + item;
                    }
                    else if (string_array[i].ToUpper().Contains("FROM") && string_array[i] == string_array.Last()) //FROM i zadnji element
                    {
                        return_string += "\r\n\t\t" + item + "\r\n\t  ";
                    }
                    else if (string_array[i].ToUpper().Contains("FROM") && string_array[i] != string_array.Last()) //FROM i nije zadnji element
                    {
                        return_string += "\r\n\t\t" + item;
                    }
                    else if (item.Trim().ToUpper().Contains("WHERE") && string_array[i] == string_array.Last()) //WHERE i zadnji elemnt
                    {
                        return_string += "\r\n\t\t" + item.Trim() + "\r\n\t  ";
                    }
                    else if (item.Trim().ToUpper().Contains("WHERE") && string_array[i] != string_array.Last()) //WHERE i nije zadnji elemnt
                    {
                        return_string += "\r\n\t\t" + item.Trim();
                    }
                    else if (string_array[i] != string_array.Last())
                    {
                        return_string += "\r\n\t\t\t" + item;
                    }
                    else if (string_array[i] == string_array.Last()) //ako je poslednji element a nije FROM ni SELECT
                    {
                        return_string += "\r\n\t\t\t" + item + "\r\n\t  ";
                    }
                }
            }
            return return_string;
        }

        private bool check_select_statement(string text)
        {
            return text.Substring(text.LastIndexOf("SELECT"), text.IndexOf("FROM")).Contains('*') ? false : true;
        }

        private bool validate_control(IEnumerable<TextBox> control_collection, string v) //da li je dobar return?
        {
            int number_of_errors = 0;

            foreach (var control in control_collection)
            {
                string text = control.Text;

                switch (v)
                {
                    case "":
                        if (string.IsNullOrEmpty(text))
                        {
                            EP.SetError(control, "Field must not be empty");
                            number_of_errors++;
                            break;
                        }
                        else
                        {
                            EP.SetError(control, null);
                            break;
                        }
                    default:
                        break;
                }
            }

            return number_of_errors > 0 ? true : false;
        }

        private void listview_check_colors(ListView listview_object)
        {
            foreach (ListViewItem item in listview_object.Items)
            {
                if (item.SubItems[1].Text.ToUpper() == "N")
                {
                    item.ForeColor = Color.Red;
                }
            }
        }

        private string display_formatted_text(string select_statement_for_display)
        {
            if (select_statement_for_display.StartsWith("\n") || select_statement_for_display.StartsWith("\t")) //skracujem za tab i newline da bi se lepo prikazalo u textboxu. moguci bagovi
            {
                select_statement_for_display = select_statement_for_display.Remove(0, select_statement_for_display.IndexOf("SELECT"));
            }
            select_statement_for_display = select_statement_for_display.Replace("\n", "\r\n");
            select_statement_for_display = select_statement_for_display.Replace("\t\t", "");
            return select_statement_for_display;
        }

        private void button_update_object_Click(object sender, EventArgs e)
        {
            if (textBox_object_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            generatorObject obj = new generatorObject();

            obj.Object_name = textBox_object_name.Text;
            obj.Object_reload_minutes = textBox_object_reload_minutes.Text;
            obj.Object_comment = textBox_object_comment.Text;
            obj.Object_primary_key = textBox_object_primary_key.Text;
            obj.select_statement_for_display = textBox_object_select_statement.Text;
            //obj.Object_select_statement = this.textBox_object_select_statement.Text;
            obj.Object_select_statement = generatorObject.ConstructSelectStatement(textBox_object_select_statement.Text);
            obj.Object_datetime_format = textBox_object_datetime_format.Text;
            obj.Object_date_format = textBox_object_date_format.Text;
            obj.Object_time_format = textBox_object_time_format.Text;
            obj.Object_where_statement = generatorObject.ConstructSelectStatement(textBox_object_where_statement.Text);
            obj.Object_active = checkBox_object_active.Checked ? 'Y' : 'N';
            obj.Object_load_type = comboBox_object_load_type.SelectedItem.ToString();
            obj.Object_fieldstoload_statement = generatorObject.ConstructSelectStatement(textBox_object_fieldstoload_statement.Text);
            obj.Object_reorganization = textBox_object_reorganization.Text;
            obj.Object_transformation_statement = generatorObject.ConstructSelectStatement(textBox_object_transformation_statement.Text);
            obj.Object_target_extraction_folder = textBox_object_target_extraction_folder.Text;
            obj.Object_target_extraction_filename = textBox_object_target_extraction_filename.Text;
            obj.Select_statement_for_display_string_array = textBox_object_select_statement.Text;

            listView_all_objects.Items[listView_all_objects.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors(listView_all_objects);
        }

        private void add_autocomplete_function(List<database_table> loaded_tables, int selectedIndex)
        {
            List<string> list_of_column_names = new List<string>();
            foreach (column_object item in loaded_tables[selectedIndex].List_column_objects)
            {
                list_of_column_names.Add(item.Column_name);
            }
            string[] arr = list_of_column_names.ToArray();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);
            textBox_object_primary_key.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_object_primary_key.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_object_primary_key.AutoCompleteCustomSource = collection;

            //textBoxExtended1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBoxExtended1.MyAutoCompleteSource = loaded_tables[selectedIndex].Columns;

            //textBoxImproved1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBoxImproved1.MyAutoCompleteSource = loaded_tables[selectedIndex].Columns;
            //textBoxImproved1.Values = arr;
        }

        private void listView_all_objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_all_objects.SelectedItems.Count != 0)
            {
                generatorObject obj = (generatorObject)listView_all_objects.SelectedItems[0];
                textBox_object_name.Text = obj.Object_name;
                textBox_object_reload_minutes.Text = obj.Object_reload_minutes.ToString();
                textBox_object_comment.Text = obj.Object_comment;
                textBox_object_primary_key.Text = obj.Object_primary_key;
                //               this.textBox_object_select_statement.Text = obj.select_statement_for_display;
                //this.textBox_object_select_statement.Text = display_formatted_text(obj.select_statement_for_display);

                //textBox_object_select_statement.Text = ""; //obrisem prvo pre nego sto pocne da pise tekst. dodje do dupliranja zbog +=
                //foreach (var item in obj.Select_statement_for_display_string_array)
                //{
                //    textBox_object_select_statement.Text += item;
                //}
                textBox_object_select_statement.Text = obj.Object_select_statement;

                textBox_object_datetime_format.Text = obj.Object_datetime_format;
                textBox_object_date_format.Text = obj.Object_date_format;
                textBox_object_time_format.Text = obj.Object_time_format;
                textBox_object_where_statement.Text = obj.Object_where_statement; //ovde treba srediti da se formatira kao i select
                checkBox_object_active.Checked = char.ToUpper(obj.Object_active) == 'Y' ? true : false;

                comboBox_object_load_type.SelectedIndex = comboBox_object_load_type.FindStringExact(list_load_types.Single(s => s.Load_type_name == obj.Object_load_type).ToString());

                //comboBox_object_load_type.SelectedIndex = comboBox_object_load_type.
                //comboBox_object_load_type.SelectedItem = list_load_types.Where(s => s.Load_type_name == obj.Object_load_type) ;

                textBox_object_fieldstoload_statement.Text = obj.Object_fieldstoload_statement;
                textBox_object_reorganization.Text = obj.Object_reorganization;
                textBox_object_transformation_statement.Text = obj.Object_transformation_statement;
                textBox_object_target_extraction_folder.Text = obj.Object_target_extraction_folder;
                textBox_object_target_extraction_filename.Text = obj.Object_target_extraction_filename;

                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", true);
            }
            else
            {
                textBox_object_name.Text = null;
                textBox_object_reload_minutes.Text = null;
                textBox_object_comment.Text = null;
                textBox_object_primary_key.Text = null;
                textBox_object_select_statement.Text = null;
                textBox_object_datetime_format.Text = null;
                textBox_object_date_format.Text = null;
                textBox_object_time_format.Text = null;
                textBox_object_where_statement.Text = null;
                checkBox_object_active.Checked = false;
                comboBox_object_load_type.SelectedIndex = 0;
                textBox_object_fieldstoload_statement.Text = null;
                textBox_object_reorganization.Text = null;
                textBox_object_transformation_statement.Text = null;
                textBox_object_target_extraction_folder.Text = null;
                textBox_object_target_extraction_filename.Text = null;

                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", false);
            }
        }

        private void listView_all_transformations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAllTransformations.SelectedItems.Count != 0)
            {
                transformationObject obj = (transformationObject)listViewAllTransformations.SelectedItems[0];
                textBox_transformation_name.Text = obj.Transformation_name;
                textBox_transformation_primary_key.Text = obj.Transformation_primary_key;
                //               this.textBox_object_select_statement.Text = obj.select_statement_for_display;
                //this.textBox_object_select_statement.Text = display_formatted_text(obj.select_statement_for_display);

                textBox_transformation_statement.Text = ""; //obrisem prvo pre nego sto pocne da pise tekst. dodje do dupliranja zbog +=
                foreach (var item in obj.Transformation_statement)
                {
                    textBox_transformation_statement.Text += item;
                }

                textBox_additional_transformation_number_of_days.Text = obj.Additional_transformation_number_of_days;
                textBox_additional_transformation_number_of_months.Text = obj.Additional_transformation_number_of_months;
                textBox_additional_transformation_number_of_years.Text = obj.Additional_transformation_number_of_years;
                textBox_additional_transformation_where_statement.Text = obj.Additional_transformation_where_statement; //ovde treba srediti da se formatira koa i select
                checkBox_transformation_active.Checked = obj.Transformation_active.ToUpper() == "Y" ? true : false;
                checkBox_transformation_incremental.Checked = obj.Transformation_incremental.ToUpper() == "Y" ? true : false;
                textBox_additional_transformation_split_parameters.Text = obj.Additional_transformation_split_parameters;
                textBox_transformation_split_parameter.Text = obj.Transformation_split_parameter;

                textBox_transformation_source_folder.Text = obj.Transformation_source_folder;
                textBox_transformation_source_filename.Text = obj.Transformation_source_filename;
                textBox_transformation_target_folder.Text = obj.Transformation_target_folder;
                textBox_transformation_target_filename.Text = obj.Transformation_target_filename;


                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", true);
            }
            else
            {
                textBox_transformation_name.Text = null;
                textBox_transformation_primary_key.Text = null;
                textBox_transformation_statement.Text = null;
                textBox_additional_transformation_number_of_days.Text = null;
                textBox_additional_transformation_number_of_months.Text = null;
                textBox_additional_transformation_number_of_years.Text = null;
                textBox_additional_transformation_where_statement.Text = null;
                checkBox_object_active.Checked = false;
                textBox_additional_transformation_split_parameters.Text = null;
                textBox_transformation_source_folder.Text = null;
                textBox_transformation_split_parameter.Text = null;
                textBox_transformation_source_filename.Text = null;
                textBox_transformation_target_folder.Text = null;

                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", false);
            }
        }

        private void button_go_back_database_connector_Click(object sender, EventArgs e)
        {
            if (form_database_connector == null)
            {
                Hide();
                form_database_connector = new _03_DatabaseConnector(this);
                form_database_connector.Visible = true;
            }
            else
            {
                Hide();
                form_database_connector.Show();
            }
        }

        private void textBox_object_name_TextChanged(object sender, EventArgs e)
        {
            string entered_text = textBox_object_name.Text;

            //set values to other fields
            textBox_object_comment.Text = entered_text;
            textBox_object_target_extraction_folder.Text = entered_text;

            textBox_object_target_extraction_filename.Text = list_load_types[comboBox_object_load_type.SelectedIndex].Load_type_file_prefix + entered_text + list_load_types[comboBox_object_load_type.SelectedIndex].Load_type_file_sufix;
            //if (comboBox_object_load_type.SelectedItem.ToString() == "DELTA")
            //{
            //    textBox_object_target_extraction_filename.Text = @"10 - DELTA\" + entered_text + "_$(vCurrentLoadDate)_$(vCurrentLoadTime)";
            //}
            //else if (comboBox_object_load_type.SelectedItem.ToString() == "FULL")
            //{
            //    textBox_object_target_extraction_filename.Text = @"10 - DELTA\" + entered_text;
            //}
        }

        private void comboBox_object_load_type_SelectedIndexChanged(object sender, EventArgs e)//ovde moze biti problema. Npr ako se promeni text u textboxu i onda se promeni vrednost combo boxa, pregazice se vrednost.
        {
            if (!string.IsNullOrEmpty(textBox_object_name.Text))
            {
                textBox_object_target_extraction_filename.Text = list_load_types[comboBox_object_load_type.SelectedIndex].Load_type_file_prefix + textBox_object_name.Text + list_load_types[comboBox_object_load_type.SelectedIndex].Load_type_file_sufix;

                //switch (comboBox_object_load_type.SelectedItem.ToString().ToUpper())
                //{
                //    case "FULL":
                //        textBox_object_target_extraction_filename.Text = @"10 - DELTA\" + textBox_object_name.Text;
                //        return;
                //    case "DELTA":
                //        textBox_object_target_extraction_filename.Text = @"10 - DELTA\" + textBox_object_name.Text + @"_$(vCurrentLoadDate)_$(vCurrentLoadTime)";
                //        return;

                //    default:
                //        break;
                //}
            }
        }

        private void button_next_transform_Click(object sender, EventArgs e)
        {
            nextTabTransformation();
        }

        private void nextTabTransformation()
        {
            if (listViewAllTransformations.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Transformation list already contains objects. Do you want to remove them and add objects defined in generator object list?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    List<ListViewItem> object_list = new List<ListViewItem>();
                    foreach (ListViewItem item in listView_all_objects.Items)
                    {
                        object_list.Add((ListViewItem)(transformationObject)(generatorObject)item);
                    }
                    listViewAllTransformations.Items.Clear();
                    listViewAllTransformations.Items.AddRange(object_list.ToArray());
                    tabControl.SelectedTab = tabTransformation;
                }
                else if (dr == DialogResult.No)
                {
                    tabControl.SelectedTab = tabTransformation;
                }
                else
                {
                    return;
                }
            }
            else
            {
                List<ListViewItem> object_list = new List<ListViewItem>();
                foreach (ListViewItem item in listView_all_objects.Items)
                {
                    object_list.Add((ListViewItem)(transformationObject)(generatorObject)item);
                }
                listViewAllTransformations.Items.Clear();
                listViewAllTransformations.Items.AddRange(object_list.ToArray());
                tabControl.SelectedTab = tabTransformation;
            }
        }

        private void nextTabGenerator()
        {
            //List<ListViewItem> object_list = new List<ListViewItem>();
            //foreach (ListViewItem item in listView_all_objects.Items)
            //{
            //    object_list.Add((ListViewItem)(generator_object_id)(transformator_object_id)item);
            //}
            //listView_all_transformations.Items.AddRange(object_list.ToArray());
            tabControl.SelectedTab = tabGenerator;
        }

        //public void _05_TransformatorCreator(List<generator_object_id> items, _02_ObjectCreator _02_ObjectCreator)
        //{
        //    transformation_items = new List<transformator_object_id>();
        //    InitializeComponent();
        //    WindowState = FormWindowState.Maximized;

        //    foreach (generator_object_id item in items)
        //    {
        //        transformator_object_id new_item = (transformator_object_id)item;
        //        transformation_items.Add(new_item);
        //        listView_all_objects.Items.Add((ListViewItem)new_item);
        //    }

        //    listView_all_objects.Refresh();

        //    this._02_ObjectCreator = _02_ObjectCreator;

        //    textBox_file_name.Text = "transformation_parameters.xml";
        //    textBox_folder_path.Text = _02_ObjectCreator.textBox_folder_path.Text;
        //}

        private void button_back_generator_Click(object sender, EventArgs e)
        {

        }

        #region ListView items manipulation
        #region Listview generator
        private void button_list_item_move_up_Click(object sender, EventArgs e)
        {
            if (listView_all_objects.Items.Count > 0)
            {
                var currentIndex = listView_all_objects.SelectedItems[0].Index;
                var item = listView_all_objects.SelectedItems[0];
                if (currentIndex > 0)
                {
                    listView_all_objects.Items.RemoveAt(currentIndex);
                    listView_all_objects.Items.Insert(currentIndex - 1, item);
                    listView_all_objects.Select();
                }
            }
        }
        private void button_list_item_move_down_Click(object sender, EventArgs e) //ispraviti
        {
            if (listView_all_objects.Items.Count > 0)
            {
                var currentIndex = listView_all_objects.SelectedItems[0].Index;
                var item = listView_all_objects.SelectedItems[0];
                if (currentIndex < listView_all_objects.Items.Count - 1)
                {
                    listView_all_objects.Items.RemoveAt(currentIndex);
                    listView_all_objects.Items.Insert(currentIndex + 1, item);
                    listView_all_objects.Select();
                }
            }
        }
        private void button_delete_list_item_Click(object sender, EventArgs e)//ovde proveriti da li je bolje da brise sve elemente liste, ili kad dodje do vrha posle brisanja da stane i ne selektuje elemente u sledecem redu
        {
            if (listView_all_objects.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove " + listView_all_objects.SelectedItems[0].ToString() + " from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    var currentIndex = listView_all_objects.SelectedItems[0].Index;
                    if (currentIndex != 0)
                    {
                        listView_all_objects.Items[currentIndex - 1].Selected = true; //ako izbrisani element nije prvi u listi, selektuj prethodni element 
                    }
                    else if (currentIndex != listView_all_objects.Items.Count - 1)
                    {
                        listView_all_objects.Items[currentIndex + 1].Selected = true; //ako je izbrisani element prvi u listi, selektuj sledecti element
                    }
                    listView_all_objects.Items.RemoveAt(currentIndex);
                    listView_all_objects.Select();
                }
                else
                {
                    return;
                }
            }
        }
        private void button_remove_all_listviewitems_Click(object sender, EventArgs e)
        {
            if (listView_all_objects.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove all items from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listView_all_objects.Items.Clear();
                }
                else
                {
                    return;
                }
            }
        }
        private void button_set_all_active_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_all_objects.Items.Count; i++)
            {
                ListViewItem item = listView_all_objects.Items[i];
                generatorObject object_item = (generatorObject)item;
                object_item.Object_active = 'Y';
                item = (ListViewItem)object_item;
                listView_all_objects.Items[i] = item;
            }
            listview_check_colors(listView_all_objects);
        }
        private void button_set_all_notactive_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_all_objects.Items.Count; i++)
            {
                ListViewItem item = listView_all_objects.Items[i];
                generatorObject object_item = (generatorObject)item;
                object_item.Object_active = 'N';
                item = (ListViewItem)object_item;
                listView_all_objects.Items[i] = item;
            }
            listview_check_colors(listView_all_objects);
        }
        #endregion

        #region ListView transforamtion
        private void button_list_item_move_up_2_Click(object sender, EventArgs e)
        {
            if (listViewAllTransformations.Items.Count > 0)
            {
                var currentIndex = listViewAllTransformations.SelectedItems[0].Index;
                var item = listViewAllTransformations.SelectedItems[0];
                if (currentIndex > 0)
                {
                    listViewAllTransformations.Items.RemoveAt(currentIndex);
                    listViewAllTransformations.Items.Insert(currentIndex - 1, item);
                    listViewAllTransformations.Select();
                }
            }
        }
        private void button_list_item_move_down_2_Click(object sender, EventArgs e)
        {
            if (listViewAllTransformations.Items.Count > 0)
            {
                var currentIndex = listViewAllTransformations.SelectedItems[0].Index;
                var item = listViewAllTransformations.SelectedItems[0];
                if (currentIndex < listViewAllTransformations.Items.Count - 1)
                {
                    listViewAllTransformations.Items.RemoveAt(currentIndex);
                    listViewAllTransformations.Items.Insert(currentIndex + 1, item);
                    listViewAllTransformations.Select();
                }
            }
        }
        private void button_delete_list_item_2_Click(object sender, EventArgs e)
        {
            if (listViewAllTransformations.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove " + listViewAllTransformations.SelectedItems[0].ToString() + " from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    var currentIndex = listViewAllTransformations.SelectedItems[0].Index;
                    if (currentIndex != 0)
                    {
                        listViewAllTransformations.Items[currentIndex - 1].Selected = true; //ako izbrisani element nije prvi u listi, selektuj prethodni element 
                    }
                    else if (currentIndex != listViewAllTransformations.Items.Count - 1)
                    {
                        listViewAllTransformations.Items[currentIndex + 1].Selected = true; //ako je izbrisani element prvi u listi, selektuj sledecti element
                    }
                    listViewAllTransformations.Items.RemoveAt(currentIndex);
                    listViewAllTransformations.Select();
                }
                else
                {
                    return;
                }
            }
        }
        private void button_remove_all_listviewitems_2_Click(object sender, EventArgs e)
        {
            if (listViewAllTransformations.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove all items from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listViewAllTransformations.Items.Clear();
                }
                else
                {
                    return;
                }
            }
        }
        private void button_set_all_active_2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewAllTransformations.Items.Count; i++)
            {
                ListViewItem item = listViewAllTransformations.Items[i];
                generatorObject object_item = (generatorObject)item;
                object_item.Object_active = 'Y';
                item = (ListViewItem)object_item;
                listViewAllTransformations.Items[i] = item;
            }
            listview_check_colors(listViewAllTransformations);
        }
        private void button_set_all_notactive_2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewAllTransformations.Items.Count; i++)
            {
                ListViewItem item = listViewAllTransformations.Items[i];
                generatorObject object_item = (generatorObject)item;
                object_item.Object_active = 'N';
                item = (ListViewItem)object_item;
                listViewAllTransformations.Items[i] = item;
            }
            listview_check_colors(listViewAllTransformations);
        }
        #endregion
        #endregion

        #region toolstrip

        private void toolStripButton_load_sample_object_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                loadSampleGeneratorObject();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                loadSampleTransformationObject();
            }
            else if (tabControl.SelectedTab == tabAggregation)
            {
                loadSampleAggregationObject();
            }
        }

        private void toolStripButton_create_object_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                createGeneratorItem();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                createTransformationItem();
            }
            else if (tabControl.SelectedTab == tabAggregation)
            {
                createAggregationItem();
            }
        }



        private void toolStripButton_update_object_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                updateGeneratorItem();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                updateTransformationItem();
            }
            else if (tabControl.SelectedTab == tabAggregation)
            {
                updateAggregationItem();
            }
        }


        private void toolStripButton_create_xml_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                createGeneratorXml();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                createTranformationXml();
            }
            else if (tabControl.SelectedTab == tabAggregation)
            {
                createAggregationXml();
            }
        }

        private void toolStripButton_execute_test_statement_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                test_statement();
            }
        }

        private void toolStripButton_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSaveLocation.ShowDialog() == DialogResult.OK)
            {
                toolStripTextBox_folder_path.Text = folderBrowserDialogSaveLocation.SelectedPath;
            }
        }

        private void enable_disable_toolstrip_item(ToolStrip toolStripMain, string itemName, bool enabled)
        {
            toolStripMain.Items[itemName].Enabled = enabled;
        }

        private void toolStripButton_load_xml_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                loadGeneratorXml();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                loadTransformationXml();
            }
            else if (tabControl.SelectedTab == tabAggregation)
            {
                loadAggregationXml();
            }
        }



        #endregion

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            update_tab_gui(tabControl.SelectedTab);
            //update_tab_data(tabControl.SelectedTab);
        }

        private void update_tab_gui(TabPage selected_tab) //TODO dodati da se updateuje i update object button; trenutno ne radi kada se doda item u jedan tab, aktivira se na svim tabovima. treba da se proveri da li ima itema u listview-u
        {
            if (selected_tab == tabGenerator)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_execute_test_statement", true);
                enable_disable_toolstrip_item(toolStripMain, "toolStripLabel_database", true);
                enable_disable_toolstrip_item(toolStripMain, "toolStripComboBox_loaded_datasources", true);
            }
            else if (selected_tab == tabTransformation)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_execute_test_statement", false);
                enable_disable_toolstrip_item(toolStripMain, "toolStripLabel_database", false);
                enable_disable_toolstrip_item(toolStripMain, "toolStripComboBox_loaded_datasources", false);
            }

            else if (selected_tab == tabAggregation)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_execute_test_statement", false);
                enable_disable_toolstrip_item(toolStripMain, "toolStripLabel_database", false);
                enable_disable_toolstrip_item(toolStripMain, "toolStripComboBox_loaded_datasources", false);
            }
        }
        //private void update_tab_data(TabPage selected_tab)
        //{
        //    if (selected_tab == tabTransformation)
        //    {
        //        nextTabTransformation();
        //    }
        //    else if (selected_tab == tabGenerator)
        //    {
        //        nextTabGenerator();
        //    }
        //}

        private void loadGeneratorXml()
        {
            try
            {
                if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
                {
                    listView_all_objects.Items.Clear(); //clear list before use
                    Console.WriteLine(openFileDialogLocation.FileName.ToString());
                    XmlDocument document = new XmlDocument();
                    document.Load(openFileDialogLocation.FileName.ToString());

                    XmlNode node = document.DocumentElement.SelectSingleNode("/datasource/objects");
                    foreach (XmlNode new_object in node)
                    {
                        if (new_object.NodeType != XmlNodeType.Comment)
                        {
                            generatorObject object_id_instance = new generatorObject();

                            try
                            {
                                object_id_instance.Object_name = new_object["object_name"].InnerText;
                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_reload_minutes = new_object["object_reload_minutes"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_comment = new_object["object_comment"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_primary_key = new_object["object_primary_key"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_select_statement = generatorObject.ConstructSelectStatement(new_object["object_select_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Select_statement_for_display_string_array = new_object["object_select_statement"].InnerText.Trim();

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_datetime_format = new_object["object_datetime_format"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_date_format = new_object["object_date_format"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_time_format = new_object["object_time_format"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_where_statement = generatorObject.ConstructSelectStatement(new_object["object_where_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_active = Char.Parse(new_object["object_active"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_load_type = new_object["object_load_type"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_fieldstoload_statement = generatorObject.ConstructSelectStatement(new_object["object_fieldstoload_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_reorganization = new_object["object_reorganization"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_transformation_statement = generatorObject.ConstructSelectStatement(new_object["object_transformation_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_target_extraction_folder = new_object["object_target_extraction_folder"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Object_target_extraction_filename = new_object["object_target_extraction_filename"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }

                            ListViewItem ListItem = (ListViewItem)object_id_instance;
                            listView_all_objects.Items.Add(ListItem);

                            listview_check_colors(listView_all_objects);
                        }
                    }
                    if (listView_all_objects.Items.Count > 0)
                    {
                        listView_all_objects.Items[0].Selected = true;
                        listView_all_objects.Select();
                    }

                    if (document.DocumentElement.SelectSingleNode("/datasource/datasource_name") != null)
                    {
                        XmlNode datasource_node = document.DocumentElement.SelectSingleNode("/datasource/datasource_name");
                        if (!string.IsNullOrEmpty(datasource_node.InnerText))
                        {
                            toolStripComboBox_loaded_datasources.SelectedIndex = toolStripComboBox_loaded_datasources.FindString(datasource_node.InnerText); //prepraviti ako moze na lepsi nacin...
                            if (toolStripComboBox_loaded_datasources.SelectedIndex == -1)
                            {
                                DialogResult dialog = MessageBox.Show("Warning! Datasource definition for " + datasource_node.InnerText + " does not exists. \n\nDo you want to create datasource definition now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dialog == DialogResult.Yes)
                                {
                                    var connectionCreator = new _04_ConnectionCreator(datasource_node.InnerText);
                                    connectionCreator.Show();

                                    //add subsciption to ConnectionListUpdated
                                    connectionCreator.ConnectionListUpdated += OnConnectionListUpdated;
                                }
                            }
                        }
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Warning! XML file contains no datasource information! You can select predefined datasource for the list or leave it empty, however test queries will be disabled. \n\nDo you want to select datasource now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            _0201_PopupDatasource popup = new _0201_PopupDatasource(this);
                            DialogResult dialog_result = popup.ShowDialog();
                            if (dialog_result == DialogResult.OK)
                            {
                                toolStripComboBox_loaded_datasources.SelectedIndex = toolStripComboBox_loaded_datasources.FindString(popup.return_datasource.ToString()); //prepraviti ako moze na lepsi nacin...
                            }

                            else if (dialog_result == DialogResult.Cancel)
                            {
                                toolStripComboBox_loaded_datasources.SelectedIndex = -1; //prepraviti ako moze na lepsi nacin...
                            }
                            popup.Dispose();
                        }
                        else if (dialog == DialogResult.No)
                        {
                            toolStripComboBox_loaded_datasources.SelectedIndex = -1;
                        }
                    }

                    textBox_file_name.Text = openFileDialogLocation.FileName.Substring(openFileDialogLocation.FileName.LastIndexOf('\\') + 1);
                    toolStripTextBox_folder_path.Text = openFileDialogLocation.FileName.Substring(0, openFileDialogLocation.FileName.LastIndexOf('\\'));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred during load of file! Please check if correct XML file is marked for load.");
            }
        }
        private void loadTransformationXml()
        {
            try
            {
                if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
                {
                    listViewAllTransformations.Items.Clear(); //clear list before use
                    Console.WriteLine(openFileDialogLocation.FileName.ToString());
                    XmlDocument document = new XmlDocument();
                    document.Load(openFileDialogLocation.FileName.ToString());

                    XmlNode node = document.DocumentElement.SelectSingleNode("/transformations");
                    foreach (XmlNode new_object in node)
                    {
                        if (new_object.NodeType != XmlNodeType.Comment)
                        {
                            transformationObject object_id_instance = new transformationObject();
                            try
                            {
                                object_id_instance.Transformation_name = new_object["transformation_name"].InnerText;
                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_active = new_object["transformation_active"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_incremental = new_object["transformation_incremental"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_statement = generatorObject.ConstructSelectStatement(new_object["transformation_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_split_parameter = new_object["transformation_split_parameter"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_primary_key = new_object["transformation_primary_key"].InnerText.Trim();

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Additional_transformation_split_parameters = new_object["additional_transformation_split_parameters"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Additional_transformation_where_statement = new_object["additional_transformation_where_statement"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Additional_transformation_number_of_days = new_object["additional_transformation_number_of_days"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Additional_transformation_number_of_months = new_object["additional_transformation_number_of_months"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Additional_transformation_number_of_years = new_object["additional_transformation_number_of_years"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_source_folder = new_object["transformation_source_folder"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_source_filename = new_object["transformation_source_filename"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_target_folder = new_object["transformation_target_folder"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.Transformation_target_filename = new_object["transformation_target_filename"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }

                            ListViewItem ListItem = (ListViewItem)object_id_instance;
                            listViewAllTransformations.Items.Add(ListItem);

                            listview_check_colors(listViewAllTransformations);
                        }
                    }
                    if (listViewAllTransformations.Items.Count > 0)
                    {
                        listViewAllTransformations.Items[0].Selected = true;
                        listViewAllTransformations.Select();
                    }

                    //if (document.DocumentElement.SelectSingleNode("/datasource/datasource_name") != null)
                    //{
                    //    XmlNode datasource_node = document.DocumentElement.SelectSingleNode("/datasource/datasource_name");
                    //    if (!string.IsNullOrEmpty(datasource_node.InnerText))
                    //    {
                    //        comboBox_loaded_datasources.SelectedIndex = comboBox_loaded_datasources.FindString(datasource_node.InnerText); //prepraviti ako moze na lepsi nacin...
                    //        if (comboBox_loaded_datasources.SelectedIndex == -1)
                    //        {
                    //            DialogResult dialog = MessageBox.Show("Warning! Datasource definition for " +datasource_node.InnerText+ " does not exists. \n\nDo you want to create datasource definition now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    DialogResult dialog = MessageBox.Show("Warning! XML file contains no datasource information! You can select predefined datasource for the list or leave it empty, however test queries will be disabled. \n\nDo you want to select datasource now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //    if (dialog == DialogResult.Yes)
                    //    {
                    //        _0201_PopupDatasource popup = new _0201_PopupDatasource(this);
                    //        DialogResult dialog_result = popup.ShowDialog();
                    //        if (dialog_result == DialogResult.OK)
                    //        {
                    //            comboBox_loaded_datasources.SelectedIndex = comboBox_loaded_datasources.FindString(popup.return_datasource.ToString()); //prepraviti ako moze na lepsi nacin...
                    //        }

                    //        else if (dialog_result == DialogResult.Cancel)
                    //        {
                    //            comboBox_loaded_datasources.SelectedIndex = -1; //prepraviti ako moze na lepsi nacin...
                    //        }
                    //        popup.Dispose();
                    //    }
                    //    else if (dialog == DialogResult.No)
                    //    {
                    //        comboBox_loaded_datasources.SelectedIndex = -1;
                    //    }
                    //}

                    textBox_file_name_2.Text = openFileDialogLocation.FileName.Substring(openFileDialogLocation.FileName.LastIndexOf('\\') + 1);
                    toolStripTextBox_folder_path.Text = openFileDialogLocation.FileName.Substring(0, openFileDialogLocation.FileName.LastIndexOf('\\'));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during load of file! Please check if correct XML file is marked for load. \n\n" + ex.Message);
            }
        }
        private void loadAggregationXml()
        {
            try
            {
                if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
                {
                    listViewAllAggregations.Items.Clear(); //clear list before use
                    Console.WriteLine(openFileDialogLocation.FileName.ToString());
                    XmlDocument document = new XmlDocument();
                    document.Load(openFileDialogLocation.FileName.ToString());

                    XmlNode node = document.DocumentElement.SelectSingleNode("/aggregations");
                    foreach (XmlNode new_object in node)
                    {
                        if (new_object.NodeType != XmlNodeType.Comment)
                        {
                            aggregationObject object_id_instance = new aggregationObject();
                            try
                            {
                                object_id_instance.aggregation_name = new_object["aggregation_name"].InnerText;
                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_active = new_object["aggregation_active"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_incremental = new_object["aggregation_incremental"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_select_statement = generatorObject.ConstructSelectStatement(new_object["aggregation_select_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_concatenation_statement = generatorObject.ConstructSelectStatement(new_object["aggregation_concatenation_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_where_statement = generatorObject.ConstructSelectStatement(new_object["aggregation_where_statement"].InnerText);

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_primary_key = new_object["aggregation_primary_key"].InnerText.Trim();

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_by_day = new_object["aggregation_by_day"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_by_week = new_object["aggregation_by_week"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_by_month = new_object["aggregation_by_month"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_by_year = new_object["aggregation_by_year"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_number_of_months = new_object["aggregation_number_of_months"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_by_procedure = new_object["aggregation_by_procedure"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_source_folder = new_object["aggregation_source_folder"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_source_filename = new_object["aggregation_source_filename"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_target_folder = new_object["aggregation_target_folder"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }
                            try
                            {
                                object_id_instance.aggregation_target_filename = new_object["aggregation_target_filename"].InnerText;

                            }
                            catch (NullReferenceException)
                            {
                            }

                            ListViewItem ListItem = (ListViewItem)object_id_instance;
                            listViewAllAggregations.Items.Add(ListItem);

                            listview_check_colors(listViewAllAggregations);
                        }
                    }
                    if (listViewAllAggregations.Items.Count > 0)
                    {
                        listViewAllAggregations.Items[0].Selected = true;
                        listViewAllAggregations.Select();
                    }

                    textBoxAggregationFileName.Text = openFileDialogLocation.FileName.Substring(openFileDialogLocation.FileName.LastIndexOf('\\') + 1);
                    toolStripTextBox_folder_path.Text = openFileDialogLocation.FileName.Substring(0, openFileDialogLocation.FileName.LastIndexOf('\\'));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during load of file! Please check if correct XML file is marked for load. \n\n" + ex.Message);
            }
        }

        private void loadSampleGeneratorObject()
        {
            textBox_object_name.Text = "ARTIC01L";
            textBox_object_reload_minutes.Text = "30";
            textBox_object_comment.Text = "ARTIC01L";
            textBox_object_primary_key.Text = "ARCODI & '_' & ARCOME";
            textBox_object_select_statement.Text = "SELECT \r\n\t$(vDatasource_Object_FieldsToLoad_Statement) \r\nFROM ARTIC01L";
            textBox_object_datetime_format.Text = "YYYYMMDDhhmmss";
            textBox_object_date_format.Text = "YYYYMMDD";
            textBox_object_time_format.Text = "hhmmss";
            textBox_object_where_statement.Text = "length(trim(ARACTY)) = 0 AND length(trim(ARDESC)) <> 0 AND ARCODI <> 'PDE'";
            checkBox_object_active.Checked = true;
            comboBox_object_load_type.SelectedItem = "FULL";
            textBox_object_fieldstoload_statement.Text = "";
            textBox_object_reorganization.Text = "";
            textBox_object_transformation_statement.Text = "*";
            textBox_object_target_extraction_folder.Text = "ARTIC01L";
            textBox_object_target_extraction_filename.Text = @"90 - CUBES\ARTIC01L_FullRefresh";
        }
        private void loadSampleTransformationObject()
        {
            textBox_transformation_name.Text = "PSAVEAK";
            textBox_transformation_primary_key.Text = "PSAVEAK_AKKONZ & '_' & PSAVEAK_AKFIRM & '_' & PSAVEAK_AKAPN";
            textBox_transformation_statement.Text = "*,\r\ndate(date#(PSAVEAK_AKDTDI,'YYYYMMDD'), 'DD.MM.YYYY')	AS PSAVEAK_AKDTDI_DATUM,\r\ntime(time#(Right(trim('000000' &amp; PSAVEAK_AKTIDI),6),'hhmmss'), 'hh:mm:ss') as PSAVEAK_AKTIDI_TIME,\r\n1 as NEW_FIELD";
            textBox_additional_transformation_number_of_days.Text = "1";
            textBox_additional_transformation_number_of_months.Text = "1";
            textBox_additional_transformation_number_of_years.Text = "0";
            textBox_additional_transformation_where_statement.Text = "PSAVEAK_AKDTB_DATUM <= date#('$(v_Additional_Load_Date_formated)', 'DD.MM.YYYY')";
            checkBox_object_active.Checked = true;
            checkBox_transformation_incremental.Checked = false;
            textBox_additional_transformation_split_parameters.Text = "PSAVEAK_AKKONZ; PSAVEAK_AKFIRM; PSAVEAK_AKAPN; PSAVEAK_AKDTDI; PSAVEAK_AKDTB_DATUM; PSAVEAK_AKANR1";
            textBox_transformation_source_folder.Text = @"..\15 - Interface\PSAVEAK\10 - DELTA";
            textBox_transformation_split_parameter.Text = "SAVEAK_AKKONZ; PSAVEAK_AKFIRM; PSAVEAK_AKDTDI";
            textBox_transformation_source_filename.Text = "PSAVEAK*";
            textBox_transformation_target_folder.Text = @"..\15 - Interface\PSAVEAK\90 - CUBES";
            textBox_transformation_target_filename.Text = "PSAVEAK*";
        }
        private void loadSampleAggregationObject()
        {
            textBoxAggregationName.Text = "SHIPPING_312_006";
            textBoxAggregationPrimaryKey.Text = "PHISTTP_TPKONZ &amp; '_' &amp; PHISTTP_TPFIRM  &amp; '_' &amp;PHISTTP_TPPALN &amp; '_' &amp; PHISTTP_TPPALP";
            checkBoxAggregationByDay.Checked = false;
            checkBoxAggregationByWeek.Checked = false;
            checkBoxAggregationByMonth.Checked = true;
            checkBoxAggregationByYear.Checked = false;
            numericUpDownAggregationNumberOfMonths.Value = 3;
            textBoxAggregationProcedure.Text = "ResolveAndLoadTablesByWhereStatementsByJoinTypeWithPathMonths('312', '006', 'PPAKET', 'PPAKET_PKDTVE_DATUM >= date#(' &amp; chr(39) &amp; '$(v_LastLoadDate_Formated)' &amp; chr(39) &amp; ',' &amp; chr(39) &amp; 'DD.MM.YYYY' &amp; chr(39) &amp; ')', 'PPAKET_PKDTDI', '', '', '', '', '', '', '', '', '..')";

            textBoxAggregationSourceFolder.Text = @"..\15 - Interface\PPAKET\90 - CUBES";
            textBoxAggregationSourceFilename.Text = "SHIPPING*";
            textBoxAggregationTargetFolder.Text = @"..\35 - QVD Aggregated";
            textBoxAggregationTargetFilename.Text = "SHIPPING_312_006_$(vCurrentParam)";

            textBoxAggregationSelectStatement.Text = "PPAKET_PKDTVE_DATUM AS SHIPPING_STOCK_ARTICLE_PKDTVE,\r\nPPAKET_PKKONZ AS SHIPPING_STOCK_ARTICLE_PKKONZ,\r\nPPAKET_PKFIRM AS SHIPPING_STOCK_ARTICLE_PKFIRM, \r\nHour(PPAKET_PKTIVE_TIME) AS SHIPPING_STOCK_ARTICLE_PKTIVE_HOUR,\r\nPPAKET_PKIDEN AS SHIPPING_STOCK_ARTICLE_PKIDEN,\r\nSUM(if (len(trim(PPAKET_PKPTYP)) = 0, PPAKET_PKPMEN)) AS SHIPPING_STOCK_ARTICLE_UNITS_SHIPPED";
            textBoxAggregationWhereStatement.Text = "Match(PPAKET_PKPSTS,'E') AND Match(PPAKET_PKVART, 'RTV') = 0 and PPAKET_PKPMEN &gt; 0 and len(trim(PPAKET_PKIDEN)) &gt; 0 and match(PPAKET_PKKONZ, '312') AND MATCH(PPAKET_PKFIRM, '006')\r\nGROUP BY PPAKET_PKDTVE_DATUM,Hour(PPAKET_PKTIVE_TIME),PPAKET_PKIDEN, PPAKET_PKKONZ, PPAKET_PKFIRM";
            textBoxAggregationConcatenateStatement.Text = "";

            checkBoxAggregationActive.Checked = true;
            checkBoxAggregationIncremental.Checked = true;

        }

        private void createGeneratorItem()
        {
            //if (validate_control(this.Controls.OfType<TextBox>(), ""))
            //{
            //    return;
            //}

            if (textBox_object_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }

            if (!check_select_statement(textBox_object_select_statement.Text.Trim().ToUpper()))
            {
                MessageBox.Show("SELECT statement must not contain STAR (*)! Please insert columns from database!");
                return;
            }

            //String object_name = new Random().Next().ToString();
            string object_name = textBox_object_name.Text;

            string object_reload_minutes = textBox_object_reload_minutes.Text;
            string object_comment = textBox_object_comment.Text;
            string object_primary_key = textBox_object_primary_key.Text;
            string object_select_statement = generatorObject.ConstructSelectStatement(textBox_object_select_statement.Text);

            string select_statement_for_display = textBox_object_select_statement.Text;
            //String select_statement_for_display_string_array = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            string select_statement_for_display_string_array = textBox_object_select_statement.Text;
            //String object_select_statement = select_statement_for_display_string_array;

            string object_datetime_format = textBox_object_datetime_format.Text;
            string object_date_format = textBox_object_date_format.Text;
            string object_time_format = textBox_object_time_format.Text;
            string object_where_statement = generatorObject.ConstructSelectStatement(textBox_object_where_statement.Text);

            char object_active = checkBox_object_active.Checked ? 'Y' : 'N';

            string object_load_type = comboBox_object_load_type.SelectedItem.ToString();
            string object_fieldstoload_statement = generatorObject.ConstructSelectStatement(textBox_object_fieldstoload_statement.Text);
            string object_reorganization = textBox_object_reorganization.Text;
            string object_transformation_statement = generatorObject.ConstructSelectStatement(textBox_object_transformation_statement.Text);
            string object_target_extraction_folder = textBox_object_target_extraction_folder.Text;
            string object_target_extraction_filename = textBox_object_target_extraction_filename.Text;

            generatorObject newItem = new generatorObject(object_name, object_reload_minutes, object_comment, object_primary_key, select_statement_for_display_string_array,
                object_datetime_format, object_date_format, object_time_format, object_where_statement, object_active, object_load_type, object_fieldstoload_statement, object_reorganization,
                object_transformation_statement, object_target_extraction_folder, object_target_extraction_filename, select_statement_for_display, select_statement_for_display_string_array);

            //LIST_OBJECTS.Add(newItem);

            ListViewItem ListItem = (ListViewItem)newItem;
            listView_all_objects.Items.Add(ListItem);

            listview_check_colors(listView_all_objects);
            if (listView_all_objects.Items.Count > 0)
            {
                listView_all_objects.Items[listView_all_objects.Items.Count - 1].Selected = true;
                listView_all_objects.Select();
            }
        }
        private void createTransformationItem()
        {
            //if (validate_control(this.Controls.OfType<TextBox>(), ""))
            //{
            //    return;
            //}

            //if (this.textBox_transformation_name.Text == "")
            //{
            //    MessageBox.Show("Name of the object must be filled!");
            //    return;
            //}

            //if (!check_select_statement(textBox_transformation_statement.Text.Trim().ToUpper()))
            //{
            //    MessageBox.Show("SELECT statement must not contain STAR (*)! Please insert columns from database!");
            //    return;
            //}

            //String object_name = new Random().Next().ToString();
            string transformation_name = textBox_transformation_name.Text;

            string transformation_primary_key = textBox_transformation_primary_key.Text;
            string transformation_statement = generatorObject.ConstructSelectStatement(textBox_transformation_statement.Text);

            //String transformation_statement_for_display = this.textBox_transformation_statement.Text;
            //String select_statement_for_display_string_array = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            //String transformation_statement_for_display_string_array = this.textBox_transformation_statement.Text;
            //String object_select_statement = select_statement_for_display_string_array;

            string additional_transformation_number_of_days = textBox_additional_transformation_number_of_days.Text;
            string additional_transformation_number_of_months = textBox_additional_transformation_number_of_months.Text;
            string additional_transformation_number_of_years = textBox_additional_transformation_number_of_years.Text;
            string additional_transformation_where_statement = generatorObject.ConstructSelectStatement(textBox_additional_transformation_where_statement.Text);
            string transformation_active = checkBox_object_active.Checked ? "Y" : "N";
            string transformation_incremental = checkBox_transformation_incremental.Checked ? "Y" : "N";
            string additional_transformation_split_parameters = textBox_additional_transformation_split_parameters.Text;
            string transformation_source_folder = textBox_transformation_source_folder.Text;
            string transformation_split_parameter = generatorObject.ConstructSelectStatement(textBox_transformation_split_parameter.Text);
            string transformation_source_filename = textBox_transformation_source_filename.Text;
            string transformation_target_folder = textBox_transformation_target_folder.Text;
            string transformation_target_filename = textBox_transformation_target_filename.Text;

            transformationObject newItem = new transformationObject(transformation_name, transformation_active, transformation_incremental, transformation_statement,
                transformation_split_parameter, transformation_primary_key, additional_transformation_split_parameters, additional_transformation_where_statement,
                additional_transformation_number_of_days, additional_transformation_number_of_months, additional_transformation_number_of_years, transformation_source_folder,
                transformation_source_filename, transformation_target_folder, transformation_target_filename);

            //LIST_OBJECTS.Add(newItem);

            ListViewItem ListItem = (ListViewItem)newItem;
            listViewAllTransformations.Items.Add(ListItem);

            listview_check_colors(listViewAllTransformations);
            if (listViewAllTransformations.Items.Count > 0)
            {
                listViewAllTransformations.Items[listViewAllTransformations.Items.Count - 1].Selected = true;
                listViewAllTransformations.Select();
            }
        }
        private void createAggregationItem()
        {
            //if (validate_control(this.Controls.OfType<TextBox>(), ""))
            //{
            //    return;
            //}

            //if (this.textBox_transformation_name.Text == "")
            //{
            //    MessageBox.Show("Name of the object must be filled!");
            //    return;
            //}

            //if (!check_select_statement(textBox_transformation_statement.Text.Trim().ToUpper()))
            //{
            //    MessageBox.Show("SELECT statement must not contain STAR (*)! Please insert columns from database!");
            //    return;
            //}

            //String object_name = new Random().Next().ToString();
            string aggregationName = textBoxAggregationName.Text;
            string aggregationPrimaryKey = textBoxAggregationPrimaryKey.Text;

            string aggregationSelectStatement = generatorObject.ConstructSelectStatement(textBoxAggregationSelectStatement.Text);
            string aggregationWhereStatement = generatorObject.ConstructSelectStatement(textBoxAggregationWhereStatement.Text);
            string aggregationConcatenateStatement = generatorObject.ConstructSelectStatement(textBoxAggregationConcatenateStatement.Text);

            string aggregationByDay = checkBoxAggregationByDay.Checked ? "Y" : "N";
            string aggregationByWeek = checkBoxAggregationByWeek.Checked ? "Y" : "N";
            string aggregationByMonth = checkBoxAggregationByMonth.Checked ? "Y" : "N";
            string aggregationByYear = checkBoxAggregationByYear.Checked ? "Y" : "N";

            string aggregationActive = checkBoxAggregationActive.Checked ? "Y" : "N";
            string aggregationIncremental = checkBoxAggregationIncremental.Checked ? "Y" : "N";

            string aggregationNumberOfMonths = numericUpDownAggregationNumberOfMonths.Value.ToString();
            string aggregationByProcedure = textBoxAggregationProcedure.Text;

            string aggregationSourceFolder = textBoxAggregationSourceFolder.Text;
            string aggregationSourceFilename = textBoxAggregationSourceFilename.Text;
            string aggregationTargetFolder = textBoxAggregationTargetFolder.Text;
            string aggregationTargetFilename = textBoxAggregationTargetFilename.Text;

            aggregationObject newItem = new aggregationObject(aggregationName, aggregationActive, aggregationIncremental, aggregationByYear, aggregationByMonth, aggregationByWeek,
                aggregationByDay, aggregationNumberOfMonths, aggregationByProcedure, aggregationSelectStatement, aggregationWhereStatement, aggregationPrimaryKey,
                aggregationConcatenateStatement, aggregationSourceFolder, aggregationSourceFilename, aggregationTargetFolder, aggregationTargetFilename);

            //LIST_OBJECTS.Add(newItem);

            ListViewItem ListItem = (ListViewItem)newItem;
            listViewAllAggregations.Items.Add(ListItem);

            listview_check_colors(listViewAllAggregations);
            if (listViewAllAggregations.Items.Count > 0)
            {
                listViewAllAggregations.Items[listViewAllAggregations.Items.Count - 1].Selected = true;
                listViewAllAggregations.Select();
            }
        }

        private void updateGeneratorItem()
        {
            if (textBox_object_name.Text == "") // check how to fusion into single method this and create/ same for Transofmration 
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            generatorObject obj = new generatorObject();

            obj.Object_name = textBox_object_name.Text;
            obj.Object_reload_minutes = textBox_object_reload_minutes.Text;
            obj.Object_comment = textBox_object_comment.Text;
            obj.Object_primary_key = textBox_object_primary_key.Text;
            obj.select_statement_for_display = textBox_object_select_statement.Text;
            //obj.Object_select_statement = this.textBox_object_select_statement.Text;
            obj.Object_select_statement = generatorObject.ConstructSelectStatement(textBox_object_select_statement.Text);
            obj.Object_datetime_format = textBox_object_datetime_format.Text;
            obj.Object_date_format = textBox_object_date_format.Text;
            obj.Object_time_format = textBox_object_time_format.Text;
            obj.Object_where_statement = generatorObject.ConstructSelectStatement(textBox_object_where_statement.Text);
            obj.Object_active = checkBox_object_active.Checked ? 'Y' : 'N';
            obj.Object_load_type = comboBox_object_load_type.SelectedItem.ToString();
            obj.Object_fieldstoload_statement = generatorObject.ConstructSelectStatement(textBox_object_fieldstoload_statement.Text);
            obj.Object_reorganization = textBox_object_reorganization.Text;
            obj.Object_transformation_statement = generatorObject.ConstructSelectStatement(textBox_object_transformation_statement.Text);
            obj.Object_target_extraction_folder = textBox_object_target_extraction_folder.Text;
            obj.Object_target_extraction_filename = textBox_object_target_extraction_filename.Text;
            obj.Select_statement_for_display_string_array = textBox_object_select_statement.Text;

            listView_all_objects.Items[listView_all_objects.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors(listView_all_objects);
        }
        private void updateTransformationItem()
        {
            if (textBox_transformation_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            transformationObject obj = new transformationObject();

            obj.Transformation_name = textBox_transformation_name.Text;
            obj.Transformation_primary_key = textBox_transformation_primary_key.Text;
            obj.Transformation_statement = textBox_transformation_statement.Text;
            //obj.Object_select_statement = this.textBox_object_select_statement.Text;
            obj.Transformation_statement = generatorObject.ConstructSelectStatement(textBox_transformation_statement.Text);
            obj.Additional_transformation_number_of_days = textBox_additional_transformation_number_of_days.Text;
            obj.Additional_transformation_number_of_months = textBox_additional_transformation_number_of_months.Text;
            obj.Additional_transformation_number_of_years = textBox_additional_transformation_number_of_years.Text;
            obj.Additional_transformation_where_statement = generatorObject.ConstructSelectStatement(textBox_additional_transformation_where_statement.Text);
            obj.Transformation_active = checkBox_transformation_active.Checked ? "Y" : "N";
            obj.Transformation_incremental = checkBox_transformation_incremental.Checked ? "Y" : "N";
            obj.Additional_transformation_split_parameters = textBox_additional_transformation_split_parameters.Text;
            obj.Transformation_source_folder = textBox_transformation_source_folder.Text;
            obj.Transformation_split_parameter = generatorObject.ConstructSelectStatement(textBox_transformation_split_parameter.Text);
            obj.Transformation_source_folder = textBox_transformation_target_folder.Text;
            obj.Transformation_source_filename = textBox_transformation_source_filename.Text;
            obj.Transformation_target_folder = textBox_transformation_target_folder.Text;
            obj.Transformation_target_filename = textBox_transformation_target_filename.Text;

            listViewAllTransformations.Items[listViewAllTransformations.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors(listViewAllTransformations);
        }
        private void updateAggregationItem()
        {
            if (textBoxAggregationName.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            string aggregationName = textBoxAggregationName.Text;
            string aggregationPrimaryKey = textBoxAggregationPrimaryKey.Text;

            string aggregationSelectStatement = generatorObject.ConstructSelectStatement(textBoxAggregationSelectStatement.Text);
            string aggregationWhereStatement = generatorObject.ConstructSelectStatement(textBoxAggregationWhereStatement.Text);
            string aggregationConcatenateStatement = generatorObject.ConstructSelectStatement(textBoxAggregationConcatenateStatement.Text);

            string aggregationByDay = checkBoxAggregationByDay.Checked ? "Y" : "N";
            string aggregationByWeek = checkBoxAggregationByWeek.Checked ? "Y" : "N";
            string aggregationByMonth = checkBoxAggregationByMonth.Checked ? "Y" : "N";
            string aggregationByYear = checkBoxAggregationByYear.Checked ? "Y" : "N";

            string aggregationActive = checkBoxAggregationActive.Checked ? "Y" : "N";
            string aggregationIncremental = checkBoxAggregationIncremental.Checked ? "Y" : "N";

            string aggregationNumberOfMonths = numericUpDownAggregationNumberOfMonths.Value.ToString();
            string aggregationByProcedure = textBoxAggregationProcedure.Text;

            string aggregationSourceFolder = textBoxAggregationSourceFolder.Text;
            string aggregationSourceFilename = textBoxAggregationSourceFilename.Text;
            string aggregationTargetFolder = textBoxAggregationTargetFolder.Text;
            string aggregationTargetFilename = textBoxAggregationTargetFilename.Text;

            aggregationObject newItem = new aggregationObject(aggregationName, aggregationActive, aggregationIncremental, aggregationByYear, aggregationByMonth, aggregationByWeek,
                aggregationByDay, aggregationNumberOfMonths, aggregationByProcedure, aggregationSelectStatement, aggregationWhereStatement, aggregationPrimaryKey,
                aggregationConcatenateStatement, aggregationSourceFolder, aggregationSourceFilename, aggregationTargetFolder, aggregationTargetFilename);


            listViewAllAggregations.Items[listViewAllAggregations.SelectedItems[0].Index] = (ListViewItem)newItem;

            listview_check_colors(listViewAllAggregations);
        }

        private void createGeneratorXml()
        {
            //TO DO validation
            try
            {
                if (textBox_file_name.Text != "" && toolStripTextBox_folder_path.Text != "")
                {
                    archive_file(textBox_file_name.Text, toolStripTextBox_folder_path.Text);

                    XmlTextWriter writer = new XmlTextWriter(toolStripTextBox_folder_path.Text + "\\" + textBox_file_name.Text, Encoding.UTF8);

                    writer.WriteStartDocument();

                    writer.Formatting = Formatting.Indented;

                    writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                    writer.WriteStartElement("datasource");

                    writer.WriteStartElement("datasource_name");
                    if (toolStripComboBox_loaded_datasources.SelectedIndex != -1) // moze se skratiti
                    {
                        writer.WriteString(toolStripComboBox_loaded_datasources.SelectedItem.ToString());
                    }
                    else
                    {
                        writer.WriteString(" ");
                    }
                    writer.WriteFullEndElement(); //pise pun tag kad zatvara <ABC></ABC>

                    writer.WriteStartElement("objects");

                    foreach (ListViewItem list_item in listView_all_objects.Items)
                    {
                        generatorObject item = (generatorObject)list_item;
                        writer.WriteStartElement("object_id");
                        writer.Formatting = Formatting.None;
                        writer.WriteComment(XMLBuilder.CommentBuilder.ItemCommentBuilder(item));
                        writer.Formatting = Formatting.Indented;
                        var properties = item.GetType().GetProperties();
                        foreach (var property in properties)
                        {
                            if (property.Name != "Select_statement_for_display_string_array") // za sada je hardcodded. morma da nadjem resenje kako da ne ucitavam ovaj property jer ne treba da se upisuje u xml.
                            {
                                writer.WriteStartElement(property.Name.ToLower());
                                if (property.GetValue(item).ToString() != "")
                                {
                                    if (property.Name == "Object_select_statement" || property.Name == "Object_where_statement"
                                        || property.Name == "Object_fieldstoload_statement" || property.Name == "Object_transformation_statement") //moze se skratiti?
                                    {
                                        writer.WriteString(write_multiline_statement(property.GetValue(item).ToString())); //dodati, 1x tab 2x space za SELECT deo skripte
                                    }
                                    else
                                    {
                                        writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
                                    }
                                    //writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
                                }
                                else
                                {
                                    writer.WriteString(" ");
                                }

                                writer.WriteFullEndElement(); //pise pun tag kad zatvara <ABC></ABC>
                            }
                        }
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.WriteEndDocument();

                    writer.Close();

                    MessageBox.Show("File successfully saved!");
                }
                else
                {
                    MessageBox.Show("Enter folder path and filename!");
                    return;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Please enter correct directory!");
                return;
            }
        }
        private void createTranformationXml()
        {
            //TO DO validation
            try
            {
                if (textBox_file_name_2.Text != "" && toolStripTextBox_folder_path.Text != "")
                {

                    archive_file(textBox_file_name_2.Text, toolStripTextBox_folder_path.Text);

                    XmlTextWriter writer = new XmlTextWriter(toolStripTextBox_folder_path.Text + "\\" + textBox_file_name_2.Text, Encoding.UTF8);

                    writer.WriteStartDocument();

                    writer.Formatting = Formatting.Indented;

                    writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                    writer.WriteStartElement("transformations");

                    //writer.WriteStartElement("datasource_name");
                    //if (comboBox_loaded_datasources.SelectedIndex != -1)
                    //{
                    //    writer.WriteString(comboBox_loaded_datasources.SelectedItem.ToString());
                    //}
                    //else
                    //{
                    //    writer.WriteString(" ");
                    //}
                    //writer.WriteFullEndElement(); //pise pun tag kad zatvara <ABC></ABC>

                    foreach (ListViewItem list_item in listViewAllTransformations.Items)
                    {
                        transformationObject item = (transformationObject)list_item;
                        writer.WriteStartElement("transformation_id");
                        writer.Formatting = Formatting.None;
                        writer.WriteComment(XMLBuilder.CommentBuilder.ItemCommentBuilder(item));
                        writer.Formatting = Formatting.Indented;
                        var properties = item.GetType().GetProperties();
                        foreach (var property in properties)
                        {
                            writer.WriteStartElement(property.Name.ToLower());
                            if (property.GetValue(item).ToString() != "")
                            {
                                if (property.Name == "Transformation_statement") //moze se skratiti
                                {
                                    writer.WriteString(write_multiline_statement(property.GetValue(item).ToString())); //dodati, 1x tab 2x space za SELECT deo skripte
                                }
                                else
                                {
                                    writer.WriteString(property.GetValue(item).ToString().Trim()); //dodati, 1x tab 2x space za SELECT deo skripte
                                }
                                //writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
                            }
                            else
                            {
                                writer.WriteString(" ");
                            }
                            writer.WriteFullEndElement(); //pise pun tag kad zatvara <ABC></ABC>
                        }
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();

                    writer.WriteEndDocument();

                    writer.Close();

                    MessageBox.Show("File successfully saved!");
                }
                else
                {
                    MessageBox.Show("Enter folder path and filename!");
                    return;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Please enter correct directory!");
                return;
            }
        }
        private void createAggregationXml()
        {
            //TO DO validation
            try
            {
                if (textBoxAggregationFileName.Text != "" && toolStripTextBox_folder_path.Text != "")
                {

                    archive_file(textBoxAggregationFileName.Text, toolStripTextBox_folder_path.Text);

                    XmlTextWriter writer = new XmlTextWriter(toolStripTextBox_folder_path.Text + "\\" + textBoxAggregationFileName.Text, Encoding.UTF8);

                    writer.WriteStartDocument();

                    writer.Formatting = Formatting.Indented;

                    writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                    writer.WriteStartElement("aggregations");

                    //writer.WriteStartElement("datasource_name");
                    //if (comboBox_loaded_datasources.SelectedIndex != -1)
                    //{
                    //    writer.WriteString(comboBox_loaded_datasources.SelectedItem.ToString());
                    //}
                    //else
                    //{
                    //    writer.WriteString(" ");
                    //}
                    //writer.WriteFullEndElement(); //pise pun tag kad zatvara <ABC></ABC>

                    foreach (ListViewItem list_item in listViewAllAggregations.Items)
                    {
                        aggregationObject item = (aggregationObject)list_item;
                        writer.WriteStartElement("aggregation_id");
                        writer.Formatting = Formatting.None;
                        writer.WriteComment(XMLBuilder.CommentBuilder.ItemCommentBuilder(item));
                        writer.Formatting = Formatting.Indented;
                        var properties = item.GetType().GetProperties();
                        foreach (var property in properties)
                        {
                            writer.WriteStartElement(property.Name.ToLower());
                            if (property.GetValue(item).ToString() != "")
                            {
                                if (property.Name == "aggregation_select_statement" || property.Name == "aggregation_where_statement" || property.Name == "aggregation_concatenation_statement") //moze se skratiti
                                {
                                    writer.WriteString(write_multiline_statement(property.GetValue(item).ToString())); //dodati, 1x tab 2x space za SELECT deo skripte
                                }
                                else
                                {
                                    writer.WriteString(property.GetValue(item).ToString().Trim()); //dodati, 1x tab 2x space za SELECT deo skripte
                                }
                                //writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
                            }
                            else
                            {
                                writer.WriteString(" ");
                            }
                            writer.WriteFullEndElement(); //pise pun tag kad zatvara <ABC></ABC>
                        }
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();

                    writer.WriteEndDocument();

                    writer.Close();

                    MessageBox.Show("File successfully saved!");
                }
                else
                {
                    MessageBox.Show("Enter folder path and filename!");
                    return;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Please enter correct directory!");
                return;
            }
        }

        private void test_statement()
        {
            if (toolStripComboBox_loaded_datasources.SelectedIndex == -1)
            {
                MessageBox.Show("Please select datasource", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<object> object_list = new List<object>();

            string query_string = textBox_object_select_statement.Text;
            if (query_string.Contains("$(object_fieldstoload_statement)"))
            {
                query_string.Replace("$(object_fieldstoload_statement)", textBox_object_fieldstoload_statement.Text);
            }

            if (!string.IsNullOrEmpty(textBox_object_where_statement.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Object_where_statement not empty! Would you like to execute test query with it?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (query_string.ToUpper().Contains("WHERE"))
                    {
                        query_string += " " + textBox_object_where_statement.Text.Trim();
                    }
                    else if (!query_string.ToUpper().Contains("WHERE"))
                    {
                        query_string += " WHERE " + textBox_object_where_statement.Text.Trim();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                object_list = _controller.return_database_query((datasource)toolStripComboBox_loaded_datasources.SelectedItem, query_string);

                string message = null;
                foreach (var item in object_list)
                {
                    message += item + " ";
                }
                MessageBox.Show("Number of records: " + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//ovde ce se pojaviti bug ako se pretrazuje baza a ima WHERE u nazivu polja. Trebalo bi da se izmeni tako sto ce se query_statement pretvoriti u cist tekst bez \n\t itd.

        private void ObjectCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit the application?", "XML Configurator", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private static void archive_file(string filename, string folder_path)
        {
            if (folder_path.Last() != '\\')
            {
                folder_path += '\\';
            }
            if (System.IO.File.Exists(folder_path + filename))
            {
                System.IO.Directory.CreateDirectory(folder_path + "\\Archive");
                System.IO.File.Copy(folder_path + "\\" + filename, folder_path + "\\Archive\\" + filename.Replace(".xml", "_") + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xml");
            }
        }

        private void button_select_columns_Click(object sender, EventArgs e)
        {
            //_0202_PopupColumns popup = new _0202_PopupColumns((generator_object_id)listView_all_objects.SelectedItems[0]);
            //popup.Visible = true;
        }

        public void OnConnectionListUpdated(object source, EventArgs e)
        {
            populateComboBox();
            Console.WriteLine("ComboBox repopulated!");
        }

        //private void textBox_object_select_statement_TextChanged(object sender, EventArgs e)
        //{
        //    CheckKeyword(textBox_object_select_statement ,"SELECT", Color.Purple, 0);
        //    CheckKeyword(textBox_object_select_statement, "if", Color.Green, 0);
        //}

        private void CheckKeyword(RichTextBox RichTextBox, string word, Color color, int startIndex) //ovo treba proveriti kako se moze iskoristiti da se menja boja kljucnih reci. Trenutno se ne korsiti
        {
            if (RichTextBox.Text.ToUpper().Contains(word.ToUpper()))
            {
                int index = -1;
                int selectStart = RichTextBox.SelectionStart;

                while ((index = RichTextBox.Text.ToUpper().IndexOf(word.ToUpper(), (index + 1))) != -1)
                {
                    RichTextBox.Select((index + startIndex), word.ToUpper().Length);
                    RichTextBox.SelectionColor = color;
                    RichTextBox.Select(selectStart, 0);
                    RichTextBox.SelectionColor = Color.Black;
                }
            }
        }

        private void buttonNextAggregation_Click(object sender, EventArgs e)
        {
            nextTabAggregation();
        }

        private void nextTabAggregation()
        {
            {
                if (listViewAllAggregations.Items.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Aggregation list already contains objects. Do you want to remove them and add objects defined in transformation object list?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        List<ListViewItem> object_list = new List<ListViewItem>();
                        foreach (ListViewItem item in listViewAllTransformations.Items)
                        {
                            object_list.Add((ListViewItem)(aggregationObject)(transformationObject)item);
                        }
                        listViewAllAggregations.Items.Clear();
                        listViewAllAggregations.Items.AddRange(object_list.ToArray());
                        tabControl.SelectedTab = tabAggregation;
                    }
                    else if (dr == DialogResult.No)
                    {
                        tabControl.SelectedTab = tabAggregation;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    List<ListViewItem> object_list = new List<ListViewItem>();
                    foreach (ListViewItem item in listViewAllTransformations.Items)
                    {
                        object_list.Add((ListViewItem)(aggregationObject)(transformationObject)item);
                    }
                    listViewAllAggregations.Items.Clear();
                    listViewAllAggregations.Items.AddRange(object_list.ToArray());
                    tabControl.SelectedTab = tabAggregation;
                }
            }
        }

        private void listViewAllAggregations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAllAggregations.SelectedItems.Count != 0)
            {
                var obj = (aggregationObject)listViewAllAggregations.SelectedItems[0];
                textBoxAggregationName.Text = obj.aggregation_name;
                textBoxAggregationPrimaryKey.Text = obj.aggregation_primary_key;

                textBoxAggregationSelectStatement.Text = ""; //obrisem prvo pre nego sto pocne da pise tekst. dodje do dupliranja zbog +=
                foreach (var item in obj.aggregation_select_statement)
                {
                    textBoxAggregationSelectStatement.Text += item;
                }
                textBoxAggregationWhereStatement.Text = ""; //obrisem prvo pre nego sto pocne da pise tekst. dodje do dupliranja zbog +=
                foreach (var item in obj.aggregation_where_statement)
                {
                    textBoxAggregationWhereStatement.Text += item;
                }
                textBoxAggregationConcatenateStatement.Text = ""; //obrisem prvo pre nego sto pocne da pise tekst. dodje do dupliranja zbog +=
                foreach (var item in obj.aggregation_concatenation_statement)
                {
                    textBoxAggregationSelectStatement.Text += item;
                }

                checkBoxAggregationByDay.Checked = obj.aggregation_by_day.ToUpper() == "Y" ? true : false;
                checkBoxAggregationByWeek.Checked = obj.aggregation_by_week.ToUpper() == "Y" ? true : false;
                checkBoxAggregationByMonth.Checked = obj.aggregation_by_month.ToUpper() == "Y" ? true : false;
                checkBoxAggregationByYear.Checked = obj.aggregation_by_year.ToUpper() == "Y" ? true : false;
                checkBoxAggregationActive.Checked = obj.aggregation_active.ToUpper() == "Y" ? true : false;
                checkBoxAggregationIncremental.Checked = obj.aggregation_incremental.ToUpper() == "Y" ? true : false;
                int result;
                int.TryParse(obj.aggregation_number_of_months, out result);
                numericUpDownAggregationNumberOfMonths.Value = result;

                textBoxAggregationSourceFolder.Text = obj.aggregation_source_folder;
                textBoxAggregationSourceFilename.Text = obj.aggregation_source_filename;
                textBoxAggregationTargetFolder.Text = obj.aggregation_target_folder;
                textBoxAggregationTargetFilename.Text = obj.aggregation_target_filename;

                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", true);
            }
            else
            {
                textBox_transformation_name.Text = null;
                textBox_transformation_primary_key.Text = null;
                textBox_transformation_statement.Text = null;
                textBox_additional_transformation_number_of_days.Text = null;
                textBox_additional_transformation_number_of_months.Text = null;
                textBox_additional_transformation_number_of_years.Text = null;
                textBox_additional_transformation_where_statement.Text = null;
                checkBox_object_active.Checked = false;
                textBox_additional_transformation_split_parameters.Text = null;
                textBox_transformation_source_folder.Text = null;
                textBox_transformation_split_parameter.Text = null;
                textBox_transformation_source_filename.Text = null;
                textBox_transformation_target_folder.Text = null;

                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", false);
            }
        }

        private void button_list_item_move_up_3_Click(object sender, EventArgs e)
        {
            if (listViewAllAggregations.Items.Count > 0)
            {
                var currentIndex = listViewAllAggregations.SelectedItems[0].Index;
                var item = listViewAllAggregations.SelectedItems[0];
                if (currentIndex > 0)
                {
                    listViewAllAggregations.Items.RemoveAt(currentIndex);
                    listViewAllAggregations.Items.Insert(currentIndex - 1, item);
                    listViewAllAggregations.Select();
                }
            }
        }

        private void button_list_item_move_down_3_Click(object sender, EventArgs e)
        {
            if (listViewAllAggregations.Items.Count > 0)
            {
                var currentIndex = listViewAllAggregations.SelectedItems[0].Index;
                var item = listViewAllAggregations.SelectedItems[0];
                if (currentIndex < listViewAllAggregations.Items.Count - 1)
                {
                    listViewAllAggregations.Items.RemoveAt(currentIndex);
                    listViewAllAggregations.Items.Insert(currentIndex + 1, item);
                    listViewAllAggregations.Select();
                }
            }
        }

        private void button_delete_list_item_3_Click(object sender, EventArgs e)
        {
            if (listViewAllAggregations.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove " + listViewAllAggregations.SelectedItems[0].ToString() + " from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    var currentIndex = listViewAllAggregations.SelectedItems[0].Index;
                    if (currentIndex != 0)
                    {
                        listViewAllAggregations.Items[currentIndex - 1].Selected = true; //ako izbrisani element nije prvi u listi, selektuj prethodni element 
                    }
                    else if (currentIndex != listViewAllAggregations.Items.Count - 1)
                    {
                        listViewAllAggregations.Items[currentIndex + 1].Selected = true; //ako je izbrisani element prvi u listi, selektuj sledecti element
                    }
                    listViewAllAggregations.Items.RemoveAt(currentIndex);
                    listViewAllAggregations.Select();
                }
                else
                {
                    return;
                }
            }
        }

        private void button_remove_all_listviewitems_3_Click(object sender, EventArgs e)
        {
            if (listViewAllAggregations.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove all items from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listViewAllAggregations.Items.Clear();
                }
                else
                {
                    return;
                }
            }
        }

        private void button_set_all_active_3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewAllAggregations.Items.Count; i++)
            {
                ListViewItem item = listViewAllAggregations.Items[i];
                aggregationObject object_item = (aggregationObject)item;
                object_item.aggregation_active = "Y";
                item = (ListViewItem)object_item;
                listViewAllAggregations.Items[i] = item;
            }
            listview_check_colors(listViewAllAggregations);
        }

        private void button_set_all_notactive_3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewAllAggregations.Items.Count; i++)
            {
                ListViewItem item = listViewAllAggregations.Items[i];
                aggregationObject object_item = (aggregationObject)item;
                object_item.aggregation_active = "N";
                item = (ListViewItem)object_item;
                listViewAllAggregations.Items[i] = item;
            }
            listview_check_colors(listViewAllAggregations);
        }
    }
}