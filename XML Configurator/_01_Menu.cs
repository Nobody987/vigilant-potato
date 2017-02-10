using System;
using System.Windows.Forms;

namespace XML_Configurator
{
    public partial class _01_Menu : Form
    {
        public _01_Menu()
        {
            InitializeComponent();
        }

        private void button_create_connection_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form Form = new _04_ConnectionCreator();
            Form.Visible = true;
        }

        private void button_object_creator_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form Form = new _02_ObjectCreator(null, new DataModel.datasource(), null);
            Form.Visible = true;
        }

        private void button_database_connection_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form Form = new _03_DatabaseConnector(null);
            Form.Visible = true;
        }

        private void button_load_types_Click(object sender, EventArgs e)
        {
            _05_LoadType lt = new _05_LoadType();
            lt.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _06_data_types t = new _06_data_types();
            t.Visible = true;
        }
    }
}
