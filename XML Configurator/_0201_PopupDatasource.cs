using System.ComponentModel;
using System.Windows.Forms;
using XML_Configurator.DataModel;

namespace XML_Configurator
{
    public partial class _0201_PopupDatasource : Form
    {
        //_02_ObjectCreator caller;
        BindingList<datasource> list_datasource;
        public datasource return_datasource;

        public _0201_PopupDatasource(_02_ObjectCreator caller)
        {
            //this.caller = caller;
            InitializeComponent();
            list_datasource = new BindingList<datasource>(datasource.read_datasource_file());
            listBox_datasources.DataSource = list_datasource;
        }

        public _0201_PopupDatasource(_05_TransformatorCreator caller)
        {
            //this.caller = caller;
            InitializeComponent();
            list_datasource = new BindingList<datasource>(datasource.read_datasource_file());
            listBox_datasources.DataSource = list_datasource;
        }
        public _0201_PopupDatasource()
        {
            InitializeComponent();
            list_datasource = new BindingList<datasource>(datasource.read_datasource_file());
            listBox_datasources.DataSource = list_datasource;
        }

        private void listBox_datasources_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            return_datasource = (datasource)listBox_datasources.SelectedItem;
        }
    }
}
