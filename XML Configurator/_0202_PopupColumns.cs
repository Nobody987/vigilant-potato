using System.Windows.Forms;
using XML_Configurator.DataModel;

namespace XML_Configurator
{
    public partial class _0202_PopupColumns : Form
    {
        public _0202_PopupColumns(database_table dt)
        {
            InitializeComponent();
            foreach (column_object item in dt.List_column_objects)
            {
            }
        }
    }
}
