using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XML_Configurator.DataModel;
using System.Xml;
using System.Drawing;
using XML_Configurator.DatabaseConnect;

namespace XML_Configurator
{
    public partial class _02_ObjectCreator : Form
    {
        List<load_types> list_load_types;
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
            comboBox_object_load_type.Items.AddRange(load_types.read_load_types_file().ToArray());
            comboBox_object_load_type.SelectedIndex = 0;
            toolStripComboBox_loaded_datasources.Items.AddRange(datasource.read_datasource_file().ToArray());

            populate_listview_all_objects();
            if (listView_all_objects.SelectedItems.Count == 0)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_update_object", false);
            }
            textBox_file_name.Text = "XML_FILE.xml";
            toolStripTextBox_folder_path.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void populate_listview_all_objects()
        {
            if (loaded_tables != null) //ovo se koristi kada se pravi novi xml, tj prosledjena je lista, pa mora da se popuni listview
            {
                foreach (database_table item in loaded_tables)
                {
                    populate_fields(loaded_tables, loaded_tables.IndexOf(item));
                    create_generator_item();
                }
            }
            loaded_tables = null;
        }

        private void populate_fields(List<database_table> loaded_tables, int index)
        {
            textBox_object_name.Text = loaded_tables[index].ToString();
            textBox_object_comment.Text = loaded_tables[index].ToString();

            textBox_object_primary_key.Text = null;

            for (int i = 0; i < loaded_tables[index].Columns_nullable.Count(); i++)
            {
                if (!loaded_tables[index].Columns_nullable[i].Equals("YES") && !loaded_tables[index].Columns_nullable[i].Equals("Y"))
                {
                    if (string.IsNullOrEmpty(textBox_object_primary_key.Text))
                    {
                        textBox_object_primary_key.Text += loaded_tables[index].Columns[i].ToString();
                    }
                    else
                    {
                        textBox_object_primary_key.Text += " & '_' & " + loaded_tables[index].Columns[i].ToString();
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

            for (int i = 0; i < loaded_tables[index].Columns.Count; i++)
            {
                transformation_builder.AppendLine(statement_builder(loaded_tables[index].ToString(), loaded_tables[index].Columns[i], loaded_tables[index].Columns_types[i]));
            }
            transformation_builder.Remove(transformation_builder.ToString().LastIndexOf(','), 1);
            textBox_object_transformation_statement.Text = transformation_builder.ToString();

            ///////////////////////////////////////////////////////////
            //  Fields to load Statement
            ///////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////
            //  Transformation Statement
            ///////////////////////////////////////////////////////////

            StringBuilder fields_to_load_builder = new StringBuilder();

            for (int i = 0; i < loaded_tables[index].Columns.Count; i++)
            {
                if (loaded_tables[index].Columns[i] != loaded_tables[index].Columns.Last())
                {
                    fields_to_load_builder.AppendLine(loaded_tables[index].Columns[i].ToString() + ",\t");
                }
                else
                {
                    fields_to_load_builder.AppendLine(loaded_tables[index].Columns[i].ToString() + "\t");
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

        private string statement_builder(string table_name, string column_name, string data_type)
        {
            switch (data_type.ToUpper())
            {
                case "INT": return "NUM(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "DECIMAL": return "NUM(" + column_name + ", '#.##') AS " + table_name + "." + column_name + ",";
                case "NVARCHAR": return "TEXT(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "VARCHAR": return "TEXT(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "VARCHAR2": return "TEXT(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "NUMBER": return "NUM(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "NUMERIC": return "NUM(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "DATE": return "DATE(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "TIME": return "TIME(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "VARBINARY": return "TEXT(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "CHARACTER": return "TEXT(" + column_name + ") AS " + table_name + "." + column_name + ",";
                case "DATETIME": return "TIMESTAMP(" + column_name + ") AS " + table_name + "." + column_name + ",";

                //default: return "UNKNOWN TYPE " + data_type + " FOR COLUMN " + column_name + ",";
                default: return column_name + " AS " + table_name + "." + column_name + ",";
            }
        }

        private string write_multiline_statement(string v)
        {
            string return_string = "";
            string[] string_array = v.Trim().Replace("\t", "").Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
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
            string word = text.Substring(text.LastIndexOf("SELECT"), text.IndexOf("FROM"));
            if (word.Contains('*'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validate_control(IEnumerable<TextBox> control_collection, string v)
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

            if (number_of_errors > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            generator_object_id obj = new generator_object_id();

            obj.Object_name = textBox_object_name.Text;
            obj.Object_reload_minutes = textBox_object_reload_minutes.Text;
            obj.Object_comment = textBox_object_comment.Text;
            obj.Object_primary_key = textBox_object_primary_key.Text;
            obj.select_statement_for_display = textBox_object_select_statement.Text;
            //obj.Object_select_statement = this.textBox_object_select_statement.Text;
            obj.Object_select_statement = generator_object_id.ConstructSelectStatement(textBox_object_select_statement.Text);
            obj.Object_datetime_format = textBox_object_datetime_format.Text;
            obj.Object_date_format = textBox_object_date_format.Text;
            obj.Object_time_format = textBox_object_time_format.Text;
            obj.Object_where_statement = generator_object_id.ConstructSelectStatement(textBox_object_where_statement.Text);
            if (checkBox_object_active.Checked)
            {
                obj.Object_active = 'Y';
            }
            else
            {
                obj.Object_active = 'N';
            }
            obj.Object_load_type = comboBox_object_load_type.SelectedItem.ToString();
            obj.Object_fieldstoload_statement = generator_object_id.ConstructSelectStatement(textBox_object_fieldstoload_statement.Text);
            obj.Object_reorganization = textBox_object_reorganization.Text;
            obj.Object_transformation_statement = generator_object_id.ConstructSelectStatement(textBox_object_transformation_statement.Text);
            obj.Object_target_extraction_folder = textBox_object_target_extraction_folder.Text;
            obj.Object_target_extraction_filename = textBox_object_target_extraction_filename.Text;
            obj.Select_statement_for_display_string_array = textBox_object_select_statement.Text;

            listView_all_objects.Items[listView_all_objects.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors(listView_all_objects);
        }

        private void add_autocomplete_function(List<database_table> loaded_tables, int selectedIndex)
        {
            string[] arr = loaded_tables[selectedIndex].Columns.ToArray();
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
                generator_object_id obj = (generator_object_id)listView_all_objects.SelectedItems[0];
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
                textBox_object_where_statement.Text = obj.Object_where_statement; //ovde treba srediti da se formatira koa i select
                if (char.ToUpper(obj.Object_active) == 'Y')
                {
                    checkBox_object_active.Checked = true;
                }
                else
                {
                    checkBox_object_active.Checked = false;
                }
                if (obj.Object_load_type == "FULL")
                {
                    comboBox_object_load_type.SelectedItem = "FULL";
                }
                else
                {
                    comboBox_object_load_type.SelectedItem = "DELTA";
                }
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
                comboBox_object_load_type.SelectedItem = "FULL";
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
            if (listView_all_transformations.SelectedItems.Count != 0)
            {
                transformator_object_id obj = (transformator_object_id)listView_all_transformations.SelectedItems[0];
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

                if (obj.Transformation_active.ToUpper() == "Y")
                {
                    checkBox_object_active.Checked = true;
                }
                else
                {
                    checkBox_object_active.Checked = false;
                }
                if (obj.Transformation_incremental.ToUpper() == "Y")
                {
                    checkBox_transformation_incremental.Checked = true;
                }
                else
                {
                    checkBox_transformation_incremental.Checked = false;
                }

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
            next_tab_transformation();
        }

        private void next_tab_transformation()
        {
            List<ListViewItem> object_list = new List<ListViewItem>();
            foreach (ListViewItem item in listView_all_objects.Items)
            {
                object_list.Add((ListViewItem)(transformator_object_id)(generator_object_id)item);
            }
            listView_all_transformations.Items.AddRange(object_list.ToArray());
            tabControl.SelectedTab = tabTransformation;
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
                generator_object_id object_item = (generator_object_id)item;
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
                generator_object_id object_item = (generator_object_id)item;
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
            if (listView_all_transformations.Items.Count > 0)
            {
                var currentIndex = listView_all_transformations.SelectedItems[0].Index;
                var item = listView_all_transformations.SelectedItems[0];
                if (currentIndex > 0)
                {
                    listView_all_transformations.Items.RemoveAt(currentIndex);
                    listView_all_transformations.Items.Insert(currentIndex - 1, item);
                    listView_all_transformations.Select();
                }
            }
        }
        private void button_list_item_move_down_2_Click(object sender, EventArgs e)
        {
            if (listView_all_transformations.Items.Count > 0)
            {
                var currentIndex = listView_all_transformations.SelectedItems[0].Index;
                var item = listView_all_transformations.SelectedItems[0];
                if (currentIndex < listView_all_transformations.Items.Count - 1)
                {
                    listView_all_transformations.Items.RemoveAt(currentIndex);
                    listView_all_transformations.Items.Insert(currentIndex + 1, item);
                    listView_all_transformations.Select();
                }
            }
        }
        private void button_delete_list_item_2_Click(object sender, EventArgs e)
        {
            if (listView_all_transformations.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove " + listView_all_transformations.SelectedItems[0].ToString() + " from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    var currentIndex = listView_all_transformations.SelectedItems[0].Index;
                    if (currentIndex != 0)
                    {
                        listView_all_transformations.Items[currentIndex - 1].Selected = true; //ako izbrisani element nije prvi u listi, selektuj prethodni element 
                    }
                    else if (currentIndex != listView_all_transformations.Items.Count - 1)
                    {
                        listView_all_transformations.Items[currentIndex + 1].Selected = true; //ako je izbrisani element prvi u listi, selektuj sledecti element
                    }
                    listView_all_transformations.Items.RemoveAt(currentIndex);
                    listView_all_transformations.Select();
                }
                else
                {
                    return;
                }
            }
        }
        private void button_remove_all_listviewitems_2_Click(object sender, EventArgs e)
        {
            if (listView_all_transformations.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove all items from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listView_all_transformations.Items.Clear();
                }
                else
                {
                    return;
                }
            }
        }
        private void button_set_all_active_2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_all_transformations.Items.Count; i++)
            {
                ListViewItem item = listView_all_transformations.Items[i];
                generator_object_id object_item = (generator_object_id)item;
                object_item.Object_active = 'Y';
                item = (ListViewItem)object_item;
                listView_all_transformations.Items[i] = item;
            }
            listview_check_colors(listView_all_transformations);
        }
        private void button_set_all_notactive_2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_all_transformations.Items.Count; i++)
            {
                ListViewItem item = listView_all_transformations.Items[i];
                generator_object_id object_item = (generator_object_id)item;
                object_item.Object_active = 'N';
                item = (ListViewItem)object_item;
                listView_all_transformations.Items[i] = item;
            }
            listview_check_colors(listView_all_transformations);
        }
        #endregion
        #endregion

        #region toolstrip

        private void toolStripButton_load_sample_object_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                load_sample_generator_object();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                load_sample_transformation_object();
            }
        }

        private void toolStripButton_create_object_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                create_generator_item();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                create_transformation_item();
            }
        }

        private void toolStripButton_update_object_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                update_generator_item();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                update_transformation_item();
            }
        }

        private void toolStripButton_create_xml_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabGenerator)
            {
                create_generator_xml();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                create_tranformation_xml();
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
                load_generator_xml();
            }
            else if (tabControl.SelectedTab == tabTransformation)
            {
                load_transformation_xml();
            }
        }

        #endregion

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
                update_tab_gui(tabControl.SelectedTab);
        }

        private void update_tab_gui(TabPage selected_tab) //TODO dodati da se updateuje i update object button; trenutno ne radi kada se doda item u jedan tab, aktivira se na svim tabovima. treba da se proveri da li ima itema u listview-u
        {
            if (selected_tab == tabTransformation)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_execute_test_statement", false);
                enable_disable_toolstrip_item(toolStripMain, "toolStripLabel_database", false);
                enable_disable_toolstrip_item(toolStripMain, "toolStripComboBox_loaded_datasources", false);
            }
            else if (selected_tab == tabGenerator)
            {
                enable_disable_toolstrip_item(toolStripMain, "toolStripButton_execute_test_statement", true);
                enable_disable_toolstrip_item(toolStripMain, "toolStripLabel_database", true);
                enable_disable_toolstrip_item(toolStripMain, "toolStripComboBox_loaded_datasources", true);
            }
        }

        private void load_generator_xml()
        {
            try
            {
                if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem item in listView_all_objects.Items)
                    {
                        listView_all_objects.Items.Remove(item);
                    }
                    Console.WriteLine(openFileDialogLocation.FileName.ToString());
                    XmlDocument document = new XmlDocument();
                    document.Load(openFileDialogLocation.FileName.ToString());

                    XmlNode node = document.DocumentElement.SelectSingleNode("/datasource/objects");
                    foreach (XmlNode new_object in node)
                    {
                        if (new_object.NodeType != XmlNodeType.Comment)
                        {
                            generator_object_id object_id_instance = new generator_object_id();
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
                                object_id_instance.Object_select_statement = generator_object_id.ConstructSelectStatement(new_object["object_select_statement"].InnerText);

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
                                object_id_instance.Object_where_statement = generator_object_id.ConstructSelectStatement(new_object["object_where_statement"].InnerText);

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
                                object_id_instance.Object_fieldstoload_statement = generator_object_id.ConstructSelectStatement(new_object["object_fieldstoload_statement"].InnerText);

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
                                object_id_instance.Object_transformation_statement = generator_object_id.ConstructSelectStatement(new_object["object_transformation_statement"].InnerText);

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
                            if (listView_all_objects.Items.Count > 0)
                            {
                                listView_all_objects.Items[0].Selected = true;
                                listView_all_objects.Select();
                            }
                        }
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
        private void load_transformation_xml()
        {
            try
            {
                if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem item in listView_all_transformations.Items)
                    {
                        listView_all_transformations.Items.Remove(item);
                    }
                    Console.WriteLine(openFileDialogLocation.FileName.ToString());
                    XmlDocument document = new XmlDocument();
                    document.Load(openFileDialogLocation.FileName.ToString());

                    XmlNode node = document.DocumentElement.SelectSingleNode("/transformations");
                    foreach (XmlNode new_object in node)
                    {
                        if (new_object.NodeType != XmlNodeType.Comment)
                        {
                            transformator_object_id object_id_instance = new transformator_object_id();
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
                                object_id_instance.Transformation_statement = generator_object_id.ConstructSelectStatement(new_object["transformation_statement"].InnerText);

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
                            listView_all_transformations.Items.Add(ListItem);

                            listview_check_colors(listView_all_transformations);
                            if (listView_all_transformations.Items.Count > 0)
                            {
                                listView_all_transformations.Items[0].Selected = true;
                                listView_all_transformations.Select();
                            }
                        }
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
        private void load_sample_generator_object()
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
        private void load_sample_transformation_object()
        {
            textBox_transformation_name.Text = "PSAVEAK";
            textBox_transformation_primary_key.Text = "PSAVEAK_AKKONZ & '_' & PSAVEAK_AKFIRM & '_' & PSAVEAK_AKAPN";
            textBox_transformation_statement.Text =
                @"		*,
                date(date#(PSAVEAK_AKDTDI,'YYYYMMDD'), 'DD.MM.YYYY')	AS PSAVEAK_AKDTDI_DATUM,
		        time(time#(Right(trim('000000' &amp; PSAVEAK_AKTIDI),6),'hhmmss'), 'hh:mm:ss') as PSAVEAK_AKTIDI_TIME,
		        1 as NEW_FIELD";
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
        private void create_generator_item()
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
            String object_name = textBox_object_name.Text;

            String object_reload_minutes = textBox_object_reload_minutes.Text;
            String object_comment = textBox_object_comment.Text;
            String object_primary_key = textBox_object_primary_key.Text;
            String object_select_statement = generator_object_id.ConstructSelectStatement(textBox_object_select_statement.Text);

            String select_statement_for_display = textBox_object_select_statement.Text;
            //String select_statement_for_display_string_array = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            String select_statement_for_display_string_array = textBox_object_select_statement.Text;
            //String object_select_statement = select_statement_for_display_string_array;

            String object_datetime_format = textBox_object_datetime_format.Text;
            String object_date_format = textBox_object_date_format.Text;
            String object_time_format = textBox_object_time_format.Text;
            String object_where_statement = generator_object_id.ConstructSelectStatement(textBox_object_where_statement.Text);
            char object_active;
            if (checkBox_object_active.Checked)
            {
                object_active = 'Y';
            }
            else
            {
                object_active = 'N';
            }
            String object_load_type = comboBox_object_load_type.SelectedItem.ToString();
            String object_fieldstoload_statement = generator_object_id.ConstructSelectStatement(textBox_object_fieldstoload_statement.Text);
            String object_reorganization = textBox_object_reorganization.Text;
            String object_transformation_statement = generator_object_id.ConstructSelectStatement(textBox_object_transformation_statement.Text);
            String object_target_extraction_folder = textBox_object_target_extraction_folder.Text;
            String object_target_extraction_filename = textBox_object_target_extraction_filename.Text;

            generator_object_id newItem = new generator_object_id(object_name, object_reload_minutes, object_comment, object_primary_key, select_statement_for_display_string_array, object_datetime_format, object_date_format, object_time_format, object_where_statement, object_active, object_load_type, object_fieldstoload_statement, object_reorganization, object_transformation_statement, object_target_extraction_folder, object_target_extraction_filename, select_statement_for_display, select_statement_for_display_string_array);

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
        private void create_transformation_item()
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
            String transformation_name = textBox_transformation_name.Text;

            String transformation_primary_key = textBox_transformation_primary_key.Text;
            String transformation_statement = generator_object_id.ConstructSelectStatement(textBox_transformation_statement.Text);

            //String transformation_statement_for_display = this.textBox_transformation_statement.Text;
            //String select_statement_for_display_string_array = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            //String transformation_statement_for_display_string_array = this.textBox_transformation_statement.Text;
            //String object_select_statement = select_statement_for_display_string_array;

            String additional_transformation_number_of_days = textBox_additional_transformation_number_of_days.Text;
            String additional_transformation_number_of_months = textBox_additional_transformation_number_of_months.Text;
            String additional_transformation_number_of_years = textBox_additional_transformation_number_of_years.Text;
            String additional_transformation_where_statement = generator_object_id.ConstructSelectStatement(textBox_additional_transformation_where_statement.Text);
            String transformation_active;
            if (checkBox_object_active.Checked)
            {
                transformation_active = "Y";
            }
            else
            {
                transformation_active = "N";
            }
            String transformation_incremental;
            if (checkBox_transformation_incremental.Checked)
            {
                transformation_incremental = "Y";
            }
            else
            {
                transformation_incremental = "N";
            }

            String additional_transformation_split_parameters = textBox_additional_transformation_split_parameters.Text;
            String transformation_source_folder = textBox_transformation_source_folder.Text;
            String transformation_split_parameter = generator_object_id.ConstructSelectStatement(textBox_transformation_split_parameter.Text);
            String transformation_source_filename = textBox_transformation_source_filename.Text;
            String transformation_target_folder = textBox_transformation_target_folder.Text;
            String transformation_target_filename = textBox_transformation_target_filename.Text;

            transformator_object_id newItem = new transformator_object_id(transformation_name, transformation_active, transformation_incremental, transformation_statement, transformation_split_parameter, transformation_primary_key, additional_transformation_split_parameters, additional_transformation_where_statement, additional_transformation_number_of_days, additional_transformation_number_of_months, additional_transformation_number_of_years, transformation_source_folder, transformation_source_filename, transformation_target_folder, transformation_target_filename);

            //LIST_OBJECTS.Add(newItem);

            ListViewItem ListItem = (ListViewItem)newItem;
            listView_all_transformations.Items.Add(ListItem);

            listview_check_colors(listView_all_transformations);
            if (listView_all_transformations.Items.Count > 0)
            {
                listView_all_transformations.Items[listView_all_transformations.Items.Count - 1].Selected = true;
                listView_all_transformations.Select();
            }
        }
        private void update_generator_item()
        {
            if (textBox_object_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            generator_object_id obj = new generator_object_id();

            obj.Object_name = textBox_object_name.Text;
            obj.Object_reload_minutes = textBox_object_reload_minutes.Text;
            obj.Object_comment = textBox_object_comment.Text;
            obj.Object_primary_key = textBox_object_primary_key.Text;
            obj.select_statement_for_display = textBox_object_select_statement.Text;
            //obj.Object_select_statement = this.textBox_object_select_statement.Text;
            obj.Object_select_statement = generator_object_id.ConstructSelectStatement(textBox_object_select_statement.Text);
            obj.Object_datetime_format = textBox_object_datetime_format.Text;
            obj.Object_date_format = textBox_object_date_format.Text;
            obj.Object_time_format = textBox_object_time_format.Text;
            obj.Object_where_statement = generator_object_id.ConstructSelectStatement(textBox_object_where_statement.Text);
            if (checkBox_object_active.Checked)
            {
                obj.Object_active = 'Y';
            }
            else
            {
                obj.Object_active = 'N';
            }
            obj.Object_load_type = comboBox_object_load_type.SelectedItem.ToString();
            obj.Object_fieldstoload_statement = generator_object_id.ConstructSelectStatement(textBox_object_fieldstoload_statement.Text);
            obj.Object_reorganization = textBox_object_reorganization.Text;
            obj.Object_transformation_statement = generator_object_id.ConstructSelectStatement(textBox_object_transformation_statement.Text);
            obj.Object_target_extraction_folder = textBox_object_target_extraction_folder.Text;
            obj.Object_target_extraction_filename = textBox_object_target_extraction_filename.Text;
            obj.Select_statement_for_display_string_array = textBox_object_select_statement.Text;

            listView_all_objects.Items[listView_all_objects.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors(listView_all_objects);
        }
        private void update_transformation_item()
        {
            if (textBox_transformation_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            transformator_object_id obj = new transformator_object_id();

            obj.Transformation_name = textBox_transformation_name.Text;
            obj.Transformation_primary_key = textBox_transformation_primary_key.Text;
            obj.Transformation_statement = textBox_transformation_statement.Text;
            //obj.Object_select_statement = this.textBox_object_select_statement.Text;
            obj.Transformation_statement = generator_object_id.ConstructSelectStatement(textBox_transformation_statement.Text);
            obj.Additional_transformation_number_of_days = textBox_additional_transformation_number_of_days.Text;
            obj.Additional_transformation_number_of_months = textBox_additional_transformation_number_of_months.Text;
            obj.Additional_transformation_number_of_years = textBox_additional_transformation_number_of_years.Text;
            obj.Additional_transformation_where_statement = generator_object_id.ConstructSelectStatement(textBox_additional_transformation_where_statement.Text);
            if (checkBox_object_active.Checked)
            {
                obj.Transformation_active = "Y";
            }
            else
            {
                obj.Transformation_active = "N";
            }
            if (checkBox_transformation_incremental.Checked)
            {
                obj.Transformation_incremental = "Y";
            }
            else
            {
                obj.Transformation_incremental = "N";
            }
            obj.Additional_transformation_split_parameters = textBox_additional_transformation_split_parameters.Text;
            obj.Transformation_source_folder = textBox_transformation_source_folder.Text;
            obj.Transformation_split_parameter = generator_object_id.ConstructSelectStatement(textBox_transformation_split_parameter.Text);
            obj.Transformation_source_folder = textBox_transformation_target_folder.Text;
            obj.Transformation_source_filename = textBox_transformation_source_filename.Text;
            obj.Transformation_target_folder = textBox_transformation_target_folder.Text;
            obj.Transformation_target_filename = textBox_transformation_target_filename.Text;

            listView_all_transformations.Items[listView_all_transformations.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors(listView_all_transformations);
        }
        private void create_generator_xml()
        {
            //TO DO validation
            string filename;
            string folder_path;

            try
            {
                if (textBox_file_name.Text != "" && toolStripTextBox_folder_path.Text != "")
                {
                    filename = textBox_file_name.Text;
                    folder_path = toolStripTextBox_folder_path.Text;

                    archive_file(filename, folder_path);

                    XmlTextWriter writer = new XmlTextWriter(folder_path + @"\" + filename, Encoding.UTF8);

                    writer.WriteStartDocument();

                    writer.Formatting = Formatting.Indented;

                    writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                    writer.WriteStartElement("datasource");

                    writer.WriteStartElement("datasource_name");
                    if (toolStripComboBox_loaded_datasources.SelectedIndex != -1)
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
                        generator_object_id item = (generator_object_id)list_item;
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
                                    if (property.Name == "Object_select_statement" || property.Name == "Object_where_statement" || property.Name == "Object_fieldstoload_statement" || property.Name == "Object_transformation_statement")
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
        private void create_tranformation_xml()
        {
            //TO DO validation
            string filename;
            string folder_path;

            try
            {
                if (textBox_file_name.Text != "" && toolStripTextBox_folder_path.Text != "")
                {
                    filename = textBox_file_name.Text;
                    folder_path = toolStripTextBox_folder_path.Text;

                    archive_file(folder_path, filename);

                    XmlTextWriter writer = new XmlTextWriter(folder_path + @"\" + filename, Encoding.UTF8);

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

                    foreach (ListViewItem list_item in listView_all_transformations.Items)
                    {
                        transformator_object_id item = (transformator_object_id)list_item;
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
                                if (property.Name == "Transformation_statement")
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
            datasource datasource = (datasource)toolStripComboBox_loaded_datasources.SelectedItem;
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
                object_list = _controller.return_database_query(datasource, query_string);

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
                System.IO.Directory.CreateDirectory(folder_path + @"\Archive");
                System.IO.File.Copy(folder_path + @"\" + filename, folder_path + @"\Archive\" + filename.Replace(".xml", "_") + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xml");
            }
        }
    }
}