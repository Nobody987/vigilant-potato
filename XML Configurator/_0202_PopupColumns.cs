using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
