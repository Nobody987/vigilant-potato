using System.Windows.Forms;
using XML_Configurator.DataModel;

namespace XML_Configurator
{
    public partial class _0202_PopupColumns : Form
    {
        private static _0202_PopupColumns instance;
        public database_table databaseTable { get; set; }

        public static _0202_PopupColumns Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new _0202_PopupColumns();
                }
                return instance;
            }
        }

        private _0202_PopupColumns()
        {
            databaseTable = new database_table();
        }

        public void PopupColumns(database_table dt)
        {
            InitializeComponent();
            foreach (column_object item in dt.List_column_objects)
            {
                checkedListBox.Controls.Add(new Control(item.ToString()));
            }
        }
    }
}
