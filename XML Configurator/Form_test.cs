using System.Windows.Forms;

namespace XML_Configurator
{
    public partial class Form_test : Form
    {

        public Form_test()
        {

            InitializeComponent();

            //tableLayoutPanel1 = new TableLayoutPanel();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button ae = new Button();
                    ae.Text = "aasd";
                    ae.Name = "asd";
                    ae.Visible = true;
                    tableLayoutPanel1.Controls.Add(ae, i, j);
                }
            }
        }
    }
}
