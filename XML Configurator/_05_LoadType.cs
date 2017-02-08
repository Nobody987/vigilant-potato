using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XML_Configurator.DataModel;
using XML_Configurator.XMLBuilder;

namespace XML_Configurator
{
    public partial class _05_LoadType : Form
    {
        List<load_types> list_load_types;

        public _05_LoadType()
        {
            InitializeComponent();
            reload_grid_view();
        }

        private void reload_grid_view()
        {
            List<load_types> list_load_types = load_from_file();
            dataGridView.Rows.Clear();
            foreach (load_types item in list_load_types)
            {
                dataGridView.Rows.Add(new string[3] { item.Load_type_name, item.Load_type_file_prefix, item.Load_type_file_sufix });
            }
            refresh_grid_view();
        }

        private List<load_types> load_from_file()
        {
            List<load_types> list_load_types = new List<load_types>(load_types.read_load_types_file());
            return list_load_types;
        }

        private void refresh_grid_view()
        {
            setRowNumber();
        }

        private void setRowNumber()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
            }
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            refresh_grid_view();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            refresh_grid_view();
        }

        private void toolStripButton_reload_file_Click(object sender, EventArgs e)
        {
            reload_grid_view();
        }

        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            list_load_types = new List<load_types>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index == dataGridView.NewRowIndex)
                {
                    continue;
                }

                string name = null;
                string prefix = null;
                string sufix = null;

                if (row.Cells[0].Value != (null))
                {
                    name = row.Cells[0].Value.ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Please enter name for load type!");
                    return;
                }
                if (row.Cells[1].Value != (null))
                {
                    prefix = row.Cells[1].Value.ToString().Trim();
                }
                if (row.Cells[2].Value != (null))
                {
                    sufix = row.Cells[2].Value.ToString().Trim();
                }

                list_load_types.Add(new load_types(name, prefix, sufix));
            }
            save_to_xml();
        }

        private void save_to_xml()
        {
            try
            {
                string folder_path = @"..\..\Include\";
                string filename = @"load_types.xml";

                System.IO.Directory.CreateDirectory(folder_path + @"\Archive");
                System.IO.File.Copy(folder_path + @"\" + filename, folder_path + @"\Archive\" + filename.Replace(".xml", "_") + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xml");

                XmlTextWriter writer = new XmlTextWriter(folder_path + @"\" + filename, Encoding.UTF8);

                writer.WriteStartDocument();

                writer.Formatting = Formatting.Indented;

                writer.WriteComment(XMLBuilder.CommentBuilder.comment);

                writer.WriteStartElement("load_types");

                foreach (load_types list_item in list_load_types)
                {
                    writer.WriteStartElement("load_type");
                    writer.Formatting = Formatting.None;
                    writer.WriteComment(XMLBuilder.CommentBuilder.ItemCommentBuilder(list_item));
                    writer.Formatting = Formatting.Indented;
                    var properties = list_item.GetType().GetProperties();
                    foreach (var property in properties)
                    {
                        writer.WriteStartElement(property.Name.ToLower());
                        //if (!string.IsNullOrEmpty(property.GetValue(item).ToString()))
                        if (property.GetValue(list_item) != null && property.GetValue(list_item).ToString() != "")
                        {
                            writer.WriteString(property.GetValue(list_item).ToString());
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
        }

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e) //ovo sredjuje situaciju u kojoj je celija focusirana i klikne se na save ali se promene ne cuvaju. Cuvaju se tek posto dodje do un-focus od celije
        {
            if (dataGridView.IsCurrentCellDirty)
            {
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
