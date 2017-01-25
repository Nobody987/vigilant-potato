using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Odbc;
using XML_Configurator.DataModel;
using XML_Configurator.XMLBuilder;
using XML_Configurator.DatabaseConnect;

namespace XML_Configurator
{

    //REWORK TABLE LOAD
    //
    //

    public partial class _03_DatabaseConnector : Form
    {
        datasource ds = new datasource();
        List<database_table> list_selected_tables;
        List<Control> list_controls = new List<Control>();
        List<string> list_database_table = new List<string>();
        _02_ObjectCreator OC;
        _00_Controller _controller;

        public _03_DatabaseConnector(_02_ObjectCreator OC)
        {
            _controller = _00_Controller._instance;
            InitializeComponent();
            InitializeComboBox();
            comboBox_connection_type.SelectedIndex = 0;
            this.OC = OC;
        }

        private void InitializeComboBox()
        {
            List<datasource> datasource_list = datasource.read_datasource_file();
            comboBox_connection_type.DataSource = datasource_list;
        }

        private void button_database_connect_Click(object sender, EventArgs e) //dodati metodu koja ce da popuni list box nezavisno od toga koji je tip konekcije
        {
            try
            {
                ds = (datasource)comboBox_connection_type.SelectedItem;

                list_database_table = _controller.return_database_schema(ds);
                listBox_database_tables.Items.Clear();
                foreach (string table in list_database_table)
                {
                    listBox_database_tables.Items.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_extract_table_definition_Click(object sender, EventArgs e) //ovde treba malo srediti kod, ima duplikata
        {
            datasource ds = (datasource)comboBox_connection_type.SelectedItem;
            list_selected_tables = new List<database_table>();
            treeView_table_columns.Nodes.Clear();
            foreach (string item in listBox_database_tables.SelectedItems)
            {
                list_selected_tables.Add(new database_table(listBox_database_tables.Items[listBox_database_tables.Items.IndexOf(item)].ToString(), new List<string>(), new List<string>(), new List<string>()));
            }

            try
            {
                for (int i = 0; i < list_selected_tables.Count; i++)            //          PREPRAVITI DA CITA METODU SAMO JEDNOM, PROSLEDJUJE LISTU UMESTE ELEMENATA LISTE. SQL radi za svaki element pojedinacno
                {
                    database_table item = list_selected_tables[i];
                    List<ResultSet> list_table_columns = _controller.return_database_tables(ds, item.ToString()); List<string> ls = new List<string>(); //pravim listu koju cu da dodam u tree. sadrzi column_name : data_type
                    foreach (ResultSet rs in list_table_columns)
                    {
                        item.Columns.Add(rs.COLUMN_NAME); // dodaju se kolone za svaku tabelu i to ce se ucitati u sledecoj formi
                        item.Columns_types.Add(rs.DATA_TYPE);
                        item.Columns_nullable.Add(rs.IS_NULLABLE);
                        ls.Add(rs.COLUMN_NAME + " : " + rs.DATA_TYPE);
                    }
                    addIntoTreeView(item.ToString(), ls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addIntoTreeView(string item, List<string> list_table_columns)
        {
            treeView_table_columns.Nodes.Add(item, item);
            foreach (string column in list_table_columns)
            {
                treeView_table_columns.Nodes[item].Nodes.Add(column);
            }
            treeView_table_columns.ExpandAll();
        }

        private void button_save_table_definition_Click(object sender, EventArgs e)
        {
            if (OC == null)
            {
                this.Hide();
                OC = new _02_ObjectCreator(list_selected_tables, ds, this);
                OC.Visible = true;
            }
            else
            {
                this.Hide();
                OC.add_database_objects(list_selected_tables, ds, this);
                OC.Show();
            }
        }

        private void comboBox_connection_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in list_controls)
            {
                this.Controls.Remove(item);
                this.Refresh();
            }
            datasource ds = (datasource)comboBox_connection_type.SelectedItem;
            list_controls = GUIBuilder.GenerateLabelsAndTextBoxes(600, 14, 1000, 370, ds.get_properties_and_values());

            foreach (Control item in list_controls)
            {
                this.Controls.Add(item);
            }
            this.Refresh();
        }

        private void textBox_search_loaded_tables_TextChanged(object sender, EventArgs e)
        {
            {
                string search_string = textBox_search_loaded_tables.Text.ToUpper();

                listBox_database_tables.Items.Clear();
                if (!string.IsNullOrEmpty(search_string))
                {
                    foreach (var item in list_database_table)
                    {
                        if (item.ToString().ToUpper().Contains(search_string))
                            if (search_string.All(item.ToString().ToUpper().Contains))
                            {
                                listBox_database_tables.Items.Add(item);
                            }
                    }
                }
                else
                {
                    listBox_database_tables.Items.AddRange(list_database_table.ToArray());
                }
            }
        }
    }
}
