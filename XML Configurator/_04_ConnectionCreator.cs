using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using XML_Configurator.DataModel;
using XML_Configurator.XMLBuilder;

namespace XML_Configurator
{
    public partial class _04_ConnectionCreator : Form
    {
        List<Control> list_controls = new List<Control>();
        BindingList<datasource> list_datasource;

        public _04_ConnectionCreator()
        {
            InitializeComponent();
            foreach (Control item in list_controls)
            {
                this.Controls.Remove(item);
                this.Refresh();
            }
            datasource ds = new datasource();

            list_controls = GUIBuilder.GenerateLabelsAndTextBoxes(12, 41, 400, 300, ds.GetType().GetProperties());
            foreach (Control control in list_controls)
            {
                this.Controls.Add(control);
            }

            this.Refresh();
        }

        private void button_load_connections_Click(object sender, EventArgs e)
        {
            list_datasource = new BindingList<datasource>(datasource.read_datasource_file());
            listBox_connections.DataSource = list_datasource;
            //listBox_connections.Items.AddRange(list_datasource.ToArray());
        }

        private void listBox_connections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_connections.SelectedItem != null)
            {
                datasource ds = (datasource)listBox_connections.SelectedItem;

                IList<PropertyInfo> props = new List<PropertyInfo>(ds.GetType().GetProperties());

                clear_all_controls();

                foreach (PropertyInfo prop in props)
                {
                    object propValue = prop.GetValue(ds, null);
                    foreach (var control in list_controls)
                    {
                        if (control.Name == prop.Name && propValue != null)
                        {
                            control.Text = propValue.ToString();
                        }
                    }
                }
                this.Refresh();
            }
            else
            {
                foreach (Control item in list_controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        this.Refresh();
                    }
                }
            }
        }

        private void clear_all_controls()
        {
            foreach (Control item in list_controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            this.Refresh();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            list_datasource.RemoveAt(listBox_connections.SelectedIndex);
            listBox_connections_SelectedIndexChanged(this, null);
            //listBox_connections.SelectedItem = null;
            //this.Refresh();
        }

        private void button_add_to_list_Click(object sender, EventArgs e)
        {
            datasource ds = new datasource();
            IList<PropertyInfo> props = new List<PropertyInfo>(ds.GetType().GetProperties());

            foreach (var control in list_controls)
            {
                if (control is TextBox)
                {
                    foreach (PropertyInfo prop in props)
                    {
                        if (control.Name == prop.Name)
                        {
                            prop.SetValue(ds, control.Text);
                        }
                    }
                }
            }

            //listBox_connections.Items.Add(ds);
            list_datasource.Add(ds);
            this.Refresh();
            //listBox_connections.DataSource();
        }

        private void button_create_new_Click(object sender, EventArgs e)
        {
            clear_all_controls();
            listBox_connections.SelectedItems.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            datasource ds = (datasource)listBox_connections.SelectedItem;
            IList<PropertyInfo> props = new List<PropertyInfo>(ds.GetType().GetProperties());

            foreach (var control in list_controls)
            {
                if (control is TextBox)
                {
                    foreach (PropertyInfo prop in props)
                    {
                        if (control.Name == prop.Name)
                        {
                            prop.SetValue(ds, control.Text);
                        }
                    }
                }
            }
            list_datasource[list_datasource.IndexOf(ds)] = ds;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string folder_path = @"..\..\Include\";
                string filename = @"datasource_parameters.xml";

                System.IO.Directory.CreateDirectory(folder_path + @"\Archive");
                System.IO.File.Copy(folder_path + @"\" + filename, folder_path + @"\Archive\" + filename.Replace(".xml", "_") + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xml");

                XmlTextWriter writer = new XmlTextWriter(folder_path + @"\" + filename, Encoding.UTF8);

                writer.WriteStartDocument();

                writer.Formatting = Formatting.Indented;

                writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                writer.WriteStartElement("datasources");

                foreach (var list_item in listBox_connections.Items)
                {
                    datasource item = (datasource)list_item;
                    writer.WriteStartElement("datasource");
                    writer.Formatting = Formatting.None;
                    writer.WriteComment(XMLBuilder.CommentBuilder.ItemCommentBuilder(item));
                    writer.Formatting = Formatting.Indented;
                    var properties = item.GetType().GetProperties();
                    foreach (var property in properties)
                    {
                        writer.WriteStartElement(property.Name.ToLower());
                        //if (!string.IsNullOrEmpty(property.GetValue(item).ToString()))
                        if (property.GetValue(item) != null && property.GetValue(item).ToString() != "")
                        {
                            writer.WriteString(property.GetValue(item).ToString());
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
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Please enter correct directory!");
                return;
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("General Error!");
            //    return;
            //}
        }
    }
}
