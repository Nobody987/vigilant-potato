using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XML_Configurator.DataModel;
using System.Xml;
using System.Drawing;
using XML_Configurator.XMLBuilder;

namespace XML_Configurator
{
    public partial class ObjectCreator_NEW : Form
    {
        List<object_id> LIST_OBJECTS;
        List<database_table> loaded_tables;
        //        List<object_id> selected_tables;

        public ObjectCreator_NEW(List<database_table> loaded_tables)
        {
            this.loaded_tables = loaded_tables;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LIST_OBJECTS = new List<object_id>();
            listView_all_objects.DataSource = LIST_OBJECTS;
            this.VScroll = true;
            List<TextBox> list_text_boxes = initializeGUI();
            if (loaded_tables != null) //ovo se koristi kada se pravi novi xml
            {
                populate_loaded_objects(loaded_tables);
                populate_fields(loaded_tables, 0);
            }
        }

        private void populate_fields(List<database_table> loaded_tables, int index)
        {
            //textBox_object_name.Text = loaded_tables[index].ToString();
            //textBox_object_comment.Text = loaded_tables[index].ToString();
            //textBox_object_primary_key.Text = null;

            //StringBuilder sb = new StringBuilder().AppendLine("SELECT");

            //foreach (string column in loaded_tables[index].Columns)
            //{
            //    sb.AppendLine("\t" + column);
            //}
            //sb.Append("FROM " + loaded_tables[index].ToString());
            //textBox_object_select_statement.Text = sb.ToString();

            //checkBox_object_active.Checked = true;
            //comboBox_objecl_load_type.SelectedIndex = 0;
            //textBox_object_target_extraction_folder.Text = loaded_tables[index].ToString();
            //textBox_object_target_extraction_filename.Text = @"10 - DELTA\" + loaded_tables[index].ToString() + "_FullRefresh";
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

            if (true)
            {
                filename = textBox_file_name.Text;
                folder_path = textBox_folder_path.Text;
            }


            XmlTextWriter writer = new XmlTextWriter(folder_path + @"\" + filename, Encoding.UTF8);

            writer.WriteStartDocument();

            writer.Formatting = Formatting.Indented;

            writer.WriteComment(XMLBuilder.CommentBuilder.comment);

            writer.WriteStartElement("datasource");

            writer.WriteStartElement("objects");

            foreach (object_id item in LIST_OBJECTS)
            {
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
                        writer.WriteString(property.GetValue(item).ToString()); //dodati, 1x tab 2x space za SELECT deo skripte
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
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            ObjectCreator.ActiveForm.Close();
        }

        private void BUTTON_CREATE_OBJECT_Click(object sender, EventArgs e)
        {
            //String object_name = this.textBox_object_name.Text;
            //int object_reload_minutes = Int32.Parse(this.textBox_object_reload_minutes.Text);
            //String object_comment = this.textBox_object_comment.Text;
            //String object_primary_key = this.textBox_object_primary_key.Text;
            //String object_select_statement = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            //String select_statement_for_display = this.textBox_object_select_statement.Text;
            //String object_datetime_format = this.textBox_object_datetime_format.Text;
            //String object_date_format = this.textBox_object_date_format.Text;
            //String object_time_format = this.textBox_object_time_format.Text;
            //String object_where_statement = this.textBox_object_where_statement.Text;
            //char object_active;
            //if (this.checkBox_object_active.Checked)
            //{
            //    object_active = 'Y';
            //}
            //else
            //{
            //    object_active = 'N';
            //}
            //String object_load_type = this.comboBox_objecl_load_type.SelectedItem.ToString();
            //String object_fieldstoload_statement = this.textBox_object_fieldstoload_statement.Text;
            //String object_reorganization = this.textBox_object_reorganization.Text;
            //String object_transformation_statement = this.textBox_object_transformation_statement.Text;
            //String object_target_extraction_folder = this.textBox_object_target_extraction_folder.Text;
            //String object_target_extraction_filename = this.textBox_object_target_extraction_filename.Text;

            //object_id newItem = new object_id(
            //    object_name, object_reload_minutes, object_comment, object_primary_key, object_select_statement, object_datetime_format, object_date_format, object_time_format, object_where_statement, object_active, object_load_type, object_fieldstoload_statement, object_reorganization, object_transformation_statement, object_target_extraction_folder, object_target_extraction_filename, select_statement_for_display
            //    );

            //LIST_OBJECTS.Add(newItem);
            //listView_all_objects.DataSource = null;
            //listView_all_objects.DataSource = LIST_OBJECTS.ToList();
            ////            listView_all_objects.DrawItem += new DrawItemEventHandler(listView_all_objects_check_active_status);
            ////            Controls.Add(listView_all_objects);
            ////           listView_all_objects_check_active_status(listView_all_objects);
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
        private void listView_all_objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView_all_objects.SelectedItem != null)
            //{
            //    object_id obj = listView_all_objects.SelectedItem as object_id;
            //    this.textBox_object_name.Text = obj.Object_name;
            //    this.textBox_object_reload_minutes.Text = obj.Object_reload_minutes.ToString();
            //    this.textBox_object_comment.Text = obj.Object_comment;
            //    this.textBox_object_primary_key.Text = obj.Object_primary_key;
            //    //               this.textBox_object_select_statement.Text = obj.select_statement_for_display;
            //    this.textBox_object_select_statement.Text = display_formatted_text(obj.select_statement_for_display);
            //    this.textBox_object_datetime_format.Text = obj.Object_datetime_format;
            //    this.textBox_object_date_format.Text = obj.Object_date_format;
            //    this.textBox_object_time_format.Text = obj.Object_time_format;
            //    this.textBox_object_where_statement.Text = obj.Object_where_statement;
            //    if (obj.Object_active == 'Y')
            //    {
            //        this.checkBox_object_active.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox_object_active.Checked = false;
            //    }
            //    if (obj.Object_load_type == "FULL")
            //    {
            //        this.comboBox_objecl_load_type.SelectedItem = "FULL";
            //    }
            //    else
            //    {
            //        this.comboBox_objecl_load_type.SelectedItem = "DELTA";
            //    }
            //    this.textBox_object_fieldstoload_statement.Text = obj.Object_fieldstoload_statement;
            //    this.textBox_object_reorganization.Text = obj.Object_reorganization;
            //    this.textBox_object_transformation_statement.Text = obj.Object_transformation_statement;
            //    this.textBox_object_target_extraction_folder.Text = obj.Object_target_extraction_folder;
            //    this.textBox_object_target_extraction_filename.Text = obj.Object_target_extraction_filename;
            //}
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
            //object_id obj = listView_all_objects.SelectedItem as object_id;

            //obj.Object_name = this.textBox_object_name.Text;
            //obj.Object_reload_minutes = Int32.Parse(this.textBox_object_reload_minutes.Text);
            //obj.Object_comment = this.textBox_object_comment.Text;
            //obj.Object_primary_key = this.textBox_object_primary_key.Text;
            //obj.select_statement_for_display = this.textBox_object_select_statement.Text;
            //obj.Object_select_statement = object_id.ConstructSelectStatement(this.textBox_object_select_statement);
            //obj.Object_datetime_format = this.textBox_object_datetime_format.Text;
            //obj.Object_date_format = this.textBox_object_date_format.Text;
            //obj.Object_time_format = this.textBox_object_time_format.Text;
            //obj.Object_where_statement = this.textBox_object_where_statement.Text;
            //if (this.checkBox_object_active.Checked)
            //{
            //    obj.Object_active = 'Y';
            //}
            //else
            //{
            //    obj.Object_active = 'N';
            //}
            //obj.Object_load_type = this.comboBox_objecl_load_type.SelectedItem.ToString();
            //obj.Object_fieldstoload_statement = this.textBox_object_fieldstoload_statement.Text;
            //obj.Object_reorganization = this.textBox_object_reorganization.Text;
            //obj.Object_transformation_statement = this.textBox_object_transformation_statement.Text;
            //obj.Object_target_extraction_folder = this.textBox_object_target_extraction_folder.Text;
            //obj.Object_target_extraction_filename = this.textBox_object_target_extraction_filename.Text;

            //listView_all_objects.DataSource = null;
            //listView_all_objects.DataSource = LIST_OBJECTS.ToList();
            //listView_all_objects.SelectedItem = obj;

            ////listView_all_objects.DrawItem += new DrawItemEventHandler(ListBox_DrawItem);   //NE RADI
            ////listView_all_objects.Refresh();
        }

        private void button_load_xml_Click(object sender, EventArgs e)
        {
            if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
            {
                //this.textBox_folder_path.Text = openFileDialogLocation.FileName;
                Console.WriteLine(openFileDialogLocation.FileName.ToString());

                //XmlSerializer serializer = new XmlSerializer(typeof(DataModel.object_id));
                //StreamReader reader = new StreamReader(openFileDialogLocation.FileName.ToString());

                //object_id new_object = (object_id)serializer.Deserialize(reader);

                XmlDocument document = new XmlDocument();
                document.Load(openFileDialogLocation.FileName.ToString());
                XmlNode node = document.DocumentElement.SelectSingleNode("/datasource/objects");
                foreach (XmlNode object_id in node)
                {
                    object_id object_id_instance = new object_id();
                    object_id_instance.Object_name = object_id.ChildNodes[1].InnerText;
                    object_id_instance.Object_reload_minutes = object_id.ChildNodes[2].InnerText;
                    object_id_instance.Object_comment = object_id.ChildNodes[3].InnerText;
                    object_id_instance.Object_primary_key = object_id.ChildNodes[4].InnerText;
                    object_id_instance.Object_select_statement = object_id.ChildNodes[5].InnerText;
                    object_id_instance.select_statement_for_display = object_id.ChildNodes[5].InnerText;
                    object_id_instance.Object_datetime_format = object_id.ChildNodes[6].InnerText;
                    object_id_instance.Object_date_format = object_id.ChildNodes[7].InnerText;
                    object_id_instance.Object_time_format = object_id.ChildNodes[8].InnerText;
                    object_id_instance.Object_where_statement = object_id.ChildNodes[9].InnerText;
                    object_id_instance.Object_active = Char.Parse(object_id.ChildNodes[10].InnerText);
                    object_id_instance.Object_load_type = object_id.ChildNodes[11].InnerText;
                    object_id_instance.Object_fieldstoload_statement = object_id.ChildNodes[12].InnerText;
                    object_id_instance.Object_reorganization = object_id.ChildNodes[13].InnerText;
                    object_id_instance.Object_transformation_statement = object_id.ChildNodes[14].InnerText;
                    object_id_instance.Object_target_extraction_folder = object_id.ChildNodes[15].InnerText;
                    object_id_instance.Object_target_extraction_filename = object_id.ChildNodes[16].InnerText;

                    LIST_OBJECTS.Add(object_id_instance);
                    listView_all_objects.DataSource = null;
                    listView_all_objects.DataSource = LIST_OBJECTS.ToList();

                    //foreach (XmlElement object_elements in object_id.OfType<XmlElement>())
                    //{
                    //    Console.WriteLine(object_elements.InnerText);
                    //    object_id_instance.Object_name = object_elements.InnerText;
                    //}
                    //                    Console.WriteLine(object_id.SelectSingleNode("/datasource/objects/object_id/object_name").InnerText);
                }
            }
        }

        private void listBox_loaded_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_loaded_tables.SelectedItem != null)
            {
                populate_fields(loaded_tables, listBox_loaded_tables.SelectedIndex);
            }
        }

        private void button_delete_list_item_Click(object sender, EventArgs e)
        {
            LIST_OBJECTS.RemoveAt(listView_all_objects.SelectedIndex);
            listView_all_objects.DataSource = null;
            listView_all_objects.DataSource = LIST_OBJECTS.ToList();
        }

        private void button_list_item_move_up_Click(object sender, EventArgs e)
        {
            if (listView_all_objects.SelectedIndex == 0)
            {
                return;
            }

            int old_index = listView_all_objects.SelectedIndex;
            int new_index = listView_all_objects.SelectedIndex - 1;

            object_id old_object = LIST_OBJECTS[old_index];
            object_id new_object = LIST_OBJECTS[new_index];

            LIST_OBJECTS.RemoveAt(old_index);
            LIST_OBJECTS.RemoveAt(new_index);

            LIST_OBJECTS.Insert(new_index, old_object);
            LIST_OBJECTS.Insert(old_index, new_object);

            listView_all_objects.DataSource = null;
            listView_all_objects.DataSource = LIST_OBJECTS.ToList();
            //            listView_all_objects.SelectedItem = new_index; //dodati da se automatski selektuje novi index
        }

        private void button_list_item_move_down_Click(object sender, EventArgs e) //ispraviti
        {
            if (listView_all_objects.SelectedIndex == LIST_OBJECTS.Count - 1)
            {
                return;
            }

            int old_index = listView_all_objects.SelectedIndex;
            int new_index = listView_all_objects.SelectedIndex + 1;

            object_id old_object = LIST_OBJECTS[old_index];
            object_id new_object = LIST_OBJECTS[new_index];

            LIST_OBJECTS.RemoveAt(old_index);
            LIST_OBJECTS.RemoveAt(new_index);

            LIST_OBJECTS.Insert(new_index, old_object);
            LIST_OBJECTS.Insert(old_index, new_object);

            listView_all_objects.DataSource = null;
            listView_all_objects.DataSource = LIST_OBJECTS.ToList();
            //            listView_all_objects.SelectedItem = new_index; //dodati da se automatski selektuje novi index
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

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based 
            // on the index of the item to draw.
            myBrush = Brushes.Red;

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            e.Graphics.DrawString(listView_all_objects.Items[listView_all_objects.SelectedIndex].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }           //NE RADI
        private List<TextBox> initializeGUI()
        {
            List<TextBox> list_text_boxes = new List<TextBox>();
            List<string> list_objects = GUIBuilder.loadXML();
            int x = 110;
            int y = 0;
            foreach (string obj in list_objects)
            {
                if (obj.ToString() == "object_select_statement")
                {
                    //Adding label
                    Label lx = new Label();
                    lx.Text = obj.ToString();
                    lx.Top = x + 20;
                    lx.Left = y + 20;
                    lx.Width = 200;
                    //Adding textbox
                    TextBox tx = new TextBox();
                    tx.Text = x.ToString();
                    tx.Top = x + 20;
                    tx.Left = y + 200;
                    tx.Width = 300;
                    tx.Height = 150;
                    tx.Multiline = true;
                    tx.ScrollBars = ScrollBars.Vertical;
                    x += 160;

                    this.Controls.Add(tx);
                    this.Controls.Add(lx);
                    list_text_boxes.Add(tx);
                }
                else
                {
                    //Adding label
                    Label lx = new Label();
                    lx.Text = obj.ToString();
                    lx.Top = x + 20;
                    lx.Left = y + 20;
                    lx.Width = 200;
                    //Adding textbox
                    TextBox tx = new TextBox();
                    tx.Text = x.ToString();
                    tx.Top = x + 20;
                    tx.Left = y + 200;
                    tx.Width = 300;
                    x += 30;

                    this.Controls.Add(tx);
                    this.Controls.Add(lx);
                    list_text_boxes.Add(tx);
                }
            }
            return list_text_boxes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialogLocation.ShowDialog() == DialogResult.OK)
            {
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
                        object_id_instance.select_statement_for_display = new_object.ChildNodes[5].InnerText.Trim();
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
                    }
                }
                textBox_file_name.Text = openFileDialogLocation.FileName.Substring(openFileDialogLocation.FileName.LastIndexOf('\\') + 1);
                textBox_folder_path.Text = openFileDialogLocation.FileName.Substring(0, openFileDialogLocation.FileName.LastIndexOf('\\'));
            }
        }
    }
}
