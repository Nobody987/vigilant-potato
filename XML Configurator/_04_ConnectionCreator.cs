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
                Controls.Remove(item);
                Refresh();
            }
            datasource ds = new datasource();

            list_controls = GUIBuilder.GenerateLabelsAndTextBoxes(12, 41, 400, 300, ds.GetType().GetProperties());
            foreach (Control control in list_controls)
            {
                Controls.Add(control);
                //if (control is TextBox)
                //{
                //    control.KeyPress += controlKeyPressed;
                //}
            }
            loadConnections();
            Refresh();
        }

        public _04_ConnectionCreator(string datasourceName)
        {
            InitializeComponent();
            datasource ds = new datasource(datasourceName, null, null, null, null, null, null, null, null, null);

            list_controls = GUIBuilder.GenerateLabelsAndTextBoxes(12, 41, 400, 300, ds.GetType().GetProperties());
            foreach (Control control in list_controls)
            {
                Controls.Add(control);
                //if (control is TextBox)
                //{
                //    control.KeyPress += controlKeyPressed;
                //}
            }
            loadConnections();
            addToList(datasourceName);
            listBox_connections.SelectedIndex = listBox_connections.Items.Count - 1;
            Refresh();
        }

        //private void controlKeyPressed(object sender, EventArgs e)
        //{
            //var textBox = (TextBox)sender;

            //datasource ds = (datasource)listBox_connections.SelectedItem;
            //var props = new List<PropertyInfo>(ds.GetType().GetProperties());

            //foreach (PropertyInfo prop in props)
            //{
            //    if (prop.Name == textBox.Name)
            //    {
            //        prop.SetValue(ds, textBox.Text);
            //        break;
            //    }
            //}
            //list_datasource[list_datasource.IndexOf(ds)] = ds;
        //}

        private void button_load_connections_Click(object sender, EventArgs e)
        {
            loadConnections();
            //listBox_connections.Items.AddRange(list_datasource.ToArray());
        }

        private void loadConnections()
        {
            list_datasource = new BindingList<datasource>(datasource.read_datasource_file());
            listBox_connections.DataSource = list_datasource;
        }

        private void listBox_connections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_connections.SelectedItem != null)
            {
                datasource ds = (datasource)listBox_connections.SelectedItem;

                var props = new List<PropertyInfo>(ds.GetType().GetProperties());

                ClearTextBox();

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
            }
            else
            {
                foreach (Control item in list_controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            Refresh();
        }

        private void ClearTextBox()
        {
            foreach (Control item in list_controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            Refresh();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to remove selected connection?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                list_datasource.RemoveAt(listBox_connections.SelectedIndex);
                listBox_connections_SelectedIndexChanged(this, null);
            }
            else return;
        }

        private void button_add_to_list_Click(object sender, EventArgs e)
        {
            //addToList();
            //listBox_connections.DataSource();
        }

        private void addToList(string datasourceName)
        {
            datasource ds = new datasource(datasourceName, null, null, null, null, null, null, null, null, null);
            list_datasource.Add(ds);
            //IList<PropertyInfo> props = new List<PropertyInfo>(ds.GetType().GetProperties());

            //foreach (var control in list_controls)
            //{
            //    if (control is TextBox)
            //    {
            //        foreach (PropertyInfo prop in props)
            //        {
            //            if (control.Name == prop.Name)
            //            {
            //                prop.SetValue(ds, control.Text);
            //            }
            //        }
            //    }
            //}

            //listBox_connections.Items.Add(ds);
            Refresh();
        }

        private void button_create_new_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            addToList("New Connection");
            listBox_connections.SelectedIndex = listBox_connections.Items.Count - 1;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            datasource ds = (datasource)listBox_connections.SelectedItem;
            var props = new List<PropertyInfo>(ds.GetType().GetProperties());

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

                writer.WriteComment(CommentBuilder.comment);

                writer.WriteStartElement("datasources");

                foreach (var list_item in listBox_connections.Items)
                {
                    datasource item = (datasource)list_item;
                    writer.WriteStartElement("datasource");
                    writer.Formatting = Formatting.None;
                    writer.WriteComment(CommentBuilder.ItemCommentBuilder(item));
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

                OnConnectionListUpdated(); //calls update on all subscribers
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

        public event EventHandler ConnectionListUpdated;

        protected virtual void OnConnectionListUpdated()
        {
            ConnectionListUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
