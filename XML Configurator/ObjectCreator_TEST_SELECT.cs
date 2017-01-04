using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XML_Configurator.DataModel;
using System.Xml;
using System.Drawing;

namespace XML_Configurator
{
    public partial class ObjectCreator_TEST_SELECT : Form
    {
        List<object_id> LIST_OBJECTS;
        List<database_table> loaded_tables;
        //        List<object_id> selected_tables;

        public ObjectCreator_TEST_SELECT(List<database_table> loaded_tables)
        {
            this.loaded_tables = loaded_tables;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LIST_OBJECTS = new List<object_id>();
            comboBox_objecl_load_type.Items.AddRange(typeof(Metadata.OBJECT_LOAD_TYPE).GetEnumNames());
            comboBox_objecl_load_type.SelectedIndex = 0;

            if (loaded_tables != null) //ovo se koristi kada se pravi novi xml
            {
                populate_loaded_objects(loaded_tables);
                populate_fields(loaded_tables, 0);
            }
            if (listView_all_objects.SelectedItems.Count == 0)
            {
                button_update_object.Enabled = false;
            }

            textBox_file_name.Text = "XML_FILE.xml";
            textBox_folder_path.Text = AppDomain.CurrentDomain.BaseDirectory;

        }

        private void populate_fields(List<database_table> loaded_tables, int index)
        {
            textBox_object_name.Text = loaded_tables[index].ToString();
            textBox_object_comment.Text = loaded_tables[index].ToString();
            textBox_object_primary_key.Text = null;

            StringBuilder sb = new StringBuilder().AppendLine("SELECT");

            foreach (string column in loaded_tables[index].Columns)
            {
                sb.AppendLine("\t" + column);
            }
            sb.Append("FROM " + loaded_tables[index].ToString());
            textBox_object_select_statement.Text = sb.ToString();

            checkBox_object_active.Checked = true;
            comboBox_objecl_load_type.SelectedIndex = 0;
            textBox_object_target_extraction_folder.Text = loaded_tables[index].ToString();
            textBox_object_target_extraction_filename.Text = @"10 - DELTA\" + loaded_tables[index].ToString() + "_FullRefresh";
        }

        private void populate_loaded_objects(List<database_table> loaded_tables)
        {
            listBox_loaded_tables.DataSource = loaded_tables.ToList();
        }

        private void BUTTON_CREATE_XML_Click(object sender, EventArgs e)
        {

            //TO DO validation
            string filename;
            string folder_path;

            try
            {
                if (textBox_file_name.Text != "" && textBox_folder_path.Text != "")
                {
                    filename = textBox_file_name.Text;
                    folder_path = textBox_folder_path.Text;

                    XmlTextWriter writer = new XmlTextWriter(folder_path + @"\" + filename, Encoding.UTF8);

                    writer.WriteStartDocument();

                    writer.Formatting = Formatting.Indented;

                    writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                    writer.WriteStartElement("datasource");

                    writer.WriteStartElement("objects");

                    foreach (ListViewItem list_item in listView_all_objects.Items)
                    {
                        object_id item = (object_id)list_item;
                        writer.WriteStartElement("object_id");
                        writer.Formatting = Formatting.None;
                        writer.WriteComment(item.Object_name);
                        writer.Formatting = Formatting.Indented;
                        var properties = item.GetType().GetProperties();
                        foreach (var property in properties)
                        {
                            writer.WriteStartElement(property.Name.ToLower());
                            if (property.GetValue(item).ToString() != "")
                            {
                                if (property.Name == "Object_select_statement")
                                {
                                    writer.WriteString("\r\n\t\t");
                                    writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
                                    writer.WriteString("\r\n\t  ");
                                }
                                else
                                {
                                    writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
                                }
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

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BUTTON_CREATE_OBJECT_Click(object sender, EventArgs e)
        {
            if (this.textBox_object_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            //String object_name = new Random().Next().ToString();
            String object_name = this.textBox_object_name.Text;

            String object_reload_minutes = this.textBox_object_reload_minutes.Text;
            String object_comment = this.textBox_object_comment.Text;
            String object_primary_key = this.textBox_object_primary_key.Text;
            String object_select_statement = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            String select_statement_for_display = this.textBox_object_select_statement.Text;
            String select_statement_for_display_string_array = this.textBox_object_select_statement.Text;

            String object_datetime_format = this.textBox_object_datetime_format.Text;
            String object_date_format = this.textBox_object_date_format.Text;
            String object_time_format = this.textBox_object_time_format.Text;
            String object_where_statement = this.textBox_object_where_statement.Text;
            char object_active;
            if (this.checkBox_object_active.Checked)
            {
                object_active = 'Y';
            }
            else
            {
                object_active = 'N';
            }
            String object_load_type = this.comboBox_objecl_load_type.SelectedItem.ToString();
            String object_fieldstoload_statement = this.textBox_object_fieldstoload_statement.Text;
            String object_reorganization = this.textBox_object_reorganization.Text;
            String object_transformation_statement = this.textBox_object_transformation_statement.Text;
            String object_target_extraction_folder = this.textBox_object_target_extraction_folder.Text;
            String object_target_extraction_filename = this.textBox_object_target_extraction_filename.Text;

            object_id newItem = new object_id(object_name, object_reload_minutes, object_comment, object_primary_key, object_select_statement, object_datetime_format, object_date_format, object_time_format, object_where_statement, object_active, object_load_type, object_fieldstoload_statement, object_reorganization, object_transformation_statement, object_target_extraction_folder, object_target_extraction_filename, select_statement_for_display, select_statement_for_display_string_array.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries));

            //LIST_OBJECTS.Add(newItem);

            ListViewItem ListItem = (ListViewItem)newItem;
            listView_all_objects.Items.Add(ListItem);

            listview_check_colors();
            if (listView_all_objects.Items.Count > 0)
            {
                listView_all_objects.Items[listView_all_objects.Items.Count - 1].Selected = true;
                listView_all_objects.Select();
            }
        }

        private void listview_check_colors()
        {
            foreach (ListViewItem item in listView_all_objects.Items)
            {
                if (item.SubItems[1].Text.ToUpper() == "N")
                {
                    item.ForeColor = Color.Red;
                }
            }
        }

        private void RefreshGraphic(ListBox listBox_all_objects)
        {
            //foreach (object_id item in listBox_all_objects.Items)
            //{
            //    if (char.ToUpper(item.Object_active) == 'N')
            //    {
            //        listBox_all_objects.Items[listBox_all_objects.Items.IndexOf(item)].
            //    }
            //}
            throw new NotImplementedException();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSaveLocation.ShowDialog() == DialogResult.OK)
            {
                this.textBox_folder_path.Text = folderBrowserDialogSaveLocation.SelectedPath;
            }
        }
        private void folderBrowserDialogSaveLocation_HelpRequest(object sender, EventArgs e)
        {
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
            if (this.textBox_object_name.Text == "")
            {
                MessageBox.Show("Name of the object must be filled!");
                return;
            }
            object_id obj = new object_id();

            obj.Object_name = this.textBox_object_name.Text;
            obj.Object_reload_minutes = this.textBox_object_reload_minutes.Text;
            obj.Object_comment = this.textBox_object_comment.Text;
            obj.Object_primary_key = this.textBox_object_primary_key.Text;
            obj.select_statement_for_display = this.textBox_object_select_statement.Text;
            obj.Object_select_statement = this.textBox_object_select_statement.Text;
            //obj.Object_select_statement = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            obj.Object_datetime_format = this.textBox_object_datetime_format.Text;
            obj.Object_date_format = this.textBox_object_date_format.Text;
            obj.Object_time_format = this.textBox_object_time_format.Text;
            obj.Object_where_statement = this.textBox_object_where_statement.Text;
            if (this.checkBox_object_active.Checked)
            {
                obj.Object_active = 'Y';
            }
            else
            {
                obj.Object_active = 'N';
            }
            obj.Object_load_type = this.comboBox_objecl_load_type.SelectedItem.ToString();
            obj.Object_fieldstoload_statement = this.textBox_object_fieldstoload_statement.Text;
            obj.Object_reorganization = this.textBox_object_reorganization.Text;
            obj.Object_transformation_statement = this.textBox_object_transformation_statement.Text;
            obj.Object_target_extraction_folder = this.textBox_object_target_extraction_folder.Text;
            obj.Object_target_extraction_filename = this.textBox_object_target_extraction_filename.Text;

            listView_all_objects.Items[listView_all_objects.SelectedItems[0].Index] = (ListViewItem)obj;

            listview_check_colors();
        }

        private void button_load_xml_Click(object sender, EventArgs e)
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
                        object_id object_id_instance = new object_id();
                        object_id_instance.Object_name = new_object.ChildNodes[1].InnerText;
                        object_id_instance.Object_reload_minutes = new_object.ChildNodes[2].InnerText;
                        object_id_instance.Object_comment = new_object.ChildNodes[3].InnerText;
                        object_id_instance.Object_primary_key = new_object.ChildNodes[4].InnerText;
                        object_id_instance.Object_select_statement = new_object.ChildNodes[5].InnerText.Trim();
                        object_id_instance.select_statement_for_display = new_object.ChildNodes[5].InnerText;
                        object_id_instance.Object_datetime_format = new_object.ChildNodes[6].InnerText;
                        object_id_instance.Object_date_format = new_object.ChildNodes[7].InnerText;
                        object_id_instance.Object_time_format = new_object.ChildNodes[8].InnerText;
                        object_id_instance.Object_where_statement = new_object.ChildNodes[9].InnerText;
                        object_id_instance.Object_active = Char.Parse(new_object.ChildNodes[10].InnerText);
                        object_id_instance.Object_load_type = new_object.ChildNodes[11].InnerText;
                        object_id_instance.Object_fieldstoload_statement = new_object.ChildNodes[12].InnerText;
                        object_id_instance.Object_reorganization = new_object.ChildNodes[13].InnerText;
                        object_id_instance.Object_transformation_statement = new_object.ChildNodes[14].InnerText;
                        object_id_instance.Object_target_extraction_folder = new_object.ChildNodes[15].InnerText;
                        object_id_instance.Object_target_extraction_filename = new_object.ChildNodes[16].InnerText;

                        ListViewItem ListItem = (ListViewItem)object_id_instance;
                        listView_all_objects.Items.Add(ListItem);

                        listview_check_colors();
                        if (listView_all_objects.Items.Count > 0)
                        {
                            listView_all_objects.Items[0].Selected = true;
                            listView_all_objects.Select();
                        }
                    }
                }
                textBox_file_name.Text = openFileDialogLocation.FileName.Substring(openFileDialogLocation.FileName.LastIndexOf('\\') + 1);
                textBox_folder_path.Text = openFileDialogLocation.FileName.Substring(0, openFileDialogLocation.FileName.LastIndexOf('\\'));
            }
        }

        private void listBox_loaded_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_loaded_tables.SelectedItem != null)
            {
                populate_fields(loaded_tables, listBox_loaded_tables.SelectedIndex); //proveriti da li se moze optimizovati, npr da se ne prosledjuje cela lista nego samo element liste
            }
        }

        private void button_delete_list_item_Click(object sender, EventArgs e)
        {
            if (listView_all_objects.SelectedItems.Count > 0)
            {
                var currentIndex = listView_all_objects.SelectedItems[0].Index;
                listView_all_objects.Items.RemoveAt(currentIndex);
                listView_all_objects.Select();
            }
        }

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

        private void listBox_loaded_tables_DoubleClick(object sender, EventArgs e)
        {
            BUTTON_CREATE_OBJECT_Click(null, null);
        }

        private void listBox_loaded_tables_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)                 // Enter key pressed
            {
                BUTTON_CREATE_OBJECT_Click(null, null);
            }
        }

        private void listView_all_objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_all_objects.SelectedItems.Count != 0)
            {
                object_id obj = (object_id)listView_all_objects.SelectedItems[0];
                this.textBox_object_name.Text = obj.Object_name;
                this.textBox_object_reload_minutes.Text = obj.Object_reload_minutes.ToString();
                this.textBox_object_comment.Text = obj.Object_comment;
                this.textBox_object_primary_key.Text = obj.Object_primary_key;
                this.textBox_object_select_statement.Text = obj.Object_select_statement;
                //this.textBox_object_select_statement.Text = obj.Object_select_statement.Replace("\n", "\r\n");
                //this.textBox_object_select_statement.Text = display_formatted_text(obj.select_statement_for_display);
                this.textBox_object_datetime_format.Text = obj.Object_datetime_format;
                this.textBox_object_date_format.Text = obj.Object_date_format;
                this.textBox_object_time_format.Text = obj.Object_time_format;
                this.textBox_object_where_statement.Text = obj.Object_where_statement;
                if (char.ToUpper(obj.Object_active) == 'Y')
                {
                    this.checkBox_object_active.Checked = true;
                }
                else
                {
                    this.checkBox_object_active.Checked = false;
                }
                if (obj.Object_load_type == "FULL")
                {
                    this.comboBox_objecl_load_type.SelectedItem = "FULL";
                }
                else
                {
                    this.comboBox_objecl_load_type.SelectedItem = "DELTA";
                }
                this.textBox_object_fieldstoload_statement.Text = obj.Object_fieldstoload_statement;
                this.textBox_object_reorganization.Text = obj.Object_reorganization;
                this.textBox_object_transformation_statement.Text = obj.Object_transformation_statement;
                this.textBox_object_target_extraction_folder.Text = obj.Object_target_extraction_folder;
                this.textBox_object_target_extraction_filename.Text = obj.Object_target_extraction_filename;

                button_update_object.Enabled = true;
            }
            else
            {
                this.textBox_object_name.Text = null;
                this.textBox_object_reload_minutes.Text = null;
                this.textBox_object_comment.Text = null;
                this.textBox_object_primary_key.Text = null;
                this.textBox_object_select_statement.Text = null;
                this.textBox_object_datetime_format.Text = null;
                this.textBox_object_date_format.Text = null;
                this.textBox_object_time_format.Text = null;
                this.textBox_object_where_statement.Text = null;
                this.checkBox_object_active.Checked = false;
                this.comboBox_objecl_load_type.SelectedItem = "FULL";
                this.textBox_object_fieldstoload_statement.Text = null;
                this.textBox_object_reorganization.Text = null;
                this.textBox_object_transformation_statement.Text = null;
                this.textBox_object_target_extraction_folder.Text = null;
                this.textBox_object_target_extraction_filename.Text = null;

                button_update_object.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_remove_all_listviewitems_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_all_objects.Items)
            {
                listView_all_objects.Items.Remove(item);
            }
        }

        private void button_load_sample_object_Click(object sender, EventArgs e)
        {
            this.textBox_object_name.Text = "ARTIC01L";
            this.textBox_object_reload_minutes.Text = "30";
            this.textBox_object_comment.Text = "ARTIC01L";
            this.textBox_object_primary_key.Text = "ARCODI & '_' & ARCOME";
            this.textBox_object_select_statement.Text = "SELECT \r\n* \r\nFROM ARTIC01L";
            this.textBox_object_datetime_format.Text = "YYYYMMDDhhmmss";
            this.textBox_object_date_format.Text = "YYYYMMDD";
            this.textBox_object_time_format.Text = "hhmmss";
            this.textBox_object_where_statement.Text = "length(trim(ARACTY)) = 0 AND length(trim(ARDESC)) <> 0 AND ARCODI <> 'PDE'";
            this.checkBox_object_active.Checked = true;
            this.comboBox_objecl_load_type.SelectedItem = "FULL";
            this.textBox_object_fieldstoload_statement.Text = "";
            this.textBox_object_reorganization.Text = "";
            this.textBox_object_transformation_statement.Text = "*";
            this.textBox_object_target_extraction_folder.Text = "ARTIC01L";
            this.textBox_object_target_extraction_filename.Text = @"10 - DELTA\ARTIC01L_FullRefresh";
        }
    }
}