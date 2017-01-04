using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace XML_Configurator
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            add_combobox_drivers(this.comboBox_drivers);
        }

        private void add_combobox_drivers(ComboBox comboBox_drivers)
        {
            comboBox_drivers.Items.AddRange(new object[] {
            "iSeries Access ODBC Driver",
            "Oracle in OraClient11g_home1",
            "PostgreSQL Unicode(x64)",
            "IBM INFORMIX ODBC DRIVER (x64-bit)",
            "SQL Server"});
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread_1 = new Thread(Move_button_1);
            Thread thread_2 = new Thread(Move_button_2);

            thread_1.Start();
            thread_2.Start();
        }

        private void Move_button_1()
        {
            for (int i = 30; i < 200; i += 40)
            {
                //button1.Location = new Point(i, i);
                //Refresh();
                Thread.Sleep(100);
            }
        }
        private void Move_button_2()
        {
            for (int j = 300; j > 20; j -= 40)
            {
                Thread.Sleep(100);
            }
        }
    }
}
