using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XML_Configurator.XMLBuilder;

namespace XML_Configurator
{
    public partial class TESTForm : Form
    {
        public TESTForm()
        {
            InitializeComponent();
            this.VScroll = true;
            List<TextBox> list_text_boxes = initializeGUI();
            Console.WriteLine(list_text_boxes[3].Text);
        }

        private List<TextBox> initializeGUI()
        {
            List<TextBox> list_text_boxes = new List<TextBox>();
            List<string> list_objects = GUIBuilder.loadXML();
            int x = 0;
            int y = 0;
            foreach (string obj in list_objects)
            {
                if (obj.ToString() == "object_select_statement")
                {
                    //Adding label
                    Label lx = new Label();
                    lx.Text = obj.ToString();
                    lx.Top = x + 20;
                    lx.Left = y + 20;
                    lx.Width = 200;
                    //Adding textbox
                    TextBox tx = new TextBox();
                    tx.Text = x.ToString();
                    tx.Top = x + 20;
                    tx.Left = y + 200;
                    tx.Width = 300;
                    tx.Height = 150;
                    tx.Multiline = true;
                    tx.ScrollBars = ScrollBars.Vertical;
                    x += 160;

                    this.Controls.Add(tx);
                    this.Controls.Add(lx);
                    list_text_boxes.Add(tx);
                }
                else
                {
                    //Adding label
                    Label lx = new Label();
                    lx.Text = obj.ToString();
                    lx.Top = x + 20;
                    lx.Left = y + 20;
                    lx.Width = 200;
                    //Adding textbox
                    TextBox tx = new TextBox();
                    tx.Text = x.ToString();
                    tx.Top = x + 20;
                    tx.Left = y + 200;
                    tx.Width = 300;
                    x += 30;

                    this.Controls.Add(tx);
                    this.Controls.Add(lx);
                    list_text_boxes.Add(tx);
                }
            }
            return list_text_boxes;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {

        }
    }
}
