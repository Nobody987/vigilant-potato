using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_Configurator.XMLBuilder
{
    public static class GUIBuilder
    {
        public static List<string> loadXML()
        {
            List<string> ls = new List<string>();
            XmlDocument document = new XmlDocument();
            document.Load(@"..\Debug\text.xml");
            XmlNode node = document.DocumentElement.SelectSingleNode("/datasource/objects/object_id");
            foreach (XmlNode parameter in node.ChildNodes)
            {
                if (parameter.NodeType != XmlNodeType.Comment)
                {
                    ls.Add(parameter.Name);
                }
            }
            return ls;
        }

        public static List<Control> GenerateLabelsAndTextBoxes(int startX, int startY, int MaxX, int MaxY, PropertyInfo[] propertyInfo)
        {
            List<Control> controls = new List<Control>();

            int x = startX;
            int y = startY;
            int width = MaxX - startX - 40;
            for (int i = 0; i < propertyInfo.GetLength(0); i++)
            {
                if (propertyInfo[i] != null)
                {
                    {
                        //Adding label
                        Label lx = new Label();
                        lx.Text = propertyInfo[i].Name;
                        lx.Left = x;
                        lx.Top = y;
                        lx.Width = 170;

                        controls.Add(lx);
                        //Adding textbox
                        TextBox tx = new TextBox();
                        tx.Name = propertyInfo[i].Name;
                        tx.Text = "";
                        tx.Left = lx.Left + lx.Width + 20;
                        tx.Top = lx.Top;
                        tx.Width = width - lx.Width;
                        y += 30;

                        controls.Add(tx);
                    }
                }
            }
            return controls;
        }

        public static List<Control> GenerateLabelsAndTextBoxes(int startX, int startY, int MaxX, int MaxY, string[,] array_objects)
        {//opisati rad metode
            List<Control> controls = new List<Control>();

            int x = startX;
            int y = startY;
            int width = MaxX - startX - 40;
            for (int i = 0; i < array_objects.GetLength(0); i++)
            {
                if (array_objects[i, 0] != null)
                {
                    //if (array_objects[i, 0].ToString() == "object_select_statement")
                    //{
                    //    //Adding label
                    //    Label lx = new Label();
                    //    lx.Text = array_objects[i, 0].ToString();
                    //    lx.Left = x;
                    //    lx.Top = y;
                    //    lx.Width = 170;
                    //    //Adding textbox
                    //    TextBox tx = new TextBox();
                    //    tx.Text = array_objects[i, 1].ToString();
                    //    tx.Left = x;
                    //    tx.Top = y;
                    //    tx.Width = width - lx.Width;
                    //    tx.Height = 150;
                    //    tx.Multiline = true;
                    //    tx.ScrollBars = ScrollBars.Vertical;
                    //    y += 160;

                    //    sender.Controls.Add(tx);
                    //    sender.Controls.Add(lx);
                    //    list_text_boxes.Add(tx);
                    //}
                    //else
                    {
                        //Adding label
                        Label lx = new Label();
                        lx.Text = array_objects[i, 0].ToString();
                        lx.Left = x;
                        lx.Top = y;
                        lx.Width = 170;

                        controls.Add(lx);
                        //Adding textbox
                        TextBox tx = new TextBox();
                        tx.Text = array_objects[i, 1].ToString();
                        tx.Left = lx.Left + lx.Width + 20;
                        tx.Top = lx.Top;
                        tx.Width = width - lx.Width;
                        y += 30;

                        controls.Add(tx);
                    }
                }
            }
            return controls;
        }

        public static List<Control> GenerateLabelsAndTextBoxes(int startX, int startY, int MaxX, int MaxY, string object_name)
        {//opisati rad metode
            List<Control> controls = new List<Control>();

            int x = startX;
            int y = startY;
            int width = MaxX - startX - 40;
            {
                //Adding label
                Label lx = new Label();
                lx.Text = object_name.ToString();
                lx.Left = x;
                lx.Top = y;
                lx.Width = 170;

                controls.Add(lx);
                //Adding textbox
                TextBox tx = new TextBox();
                tx.Text = "";
                tx.Left = lx.Left + lx.Width + 20;
                tx.Top = lx.Top;
                tx.Width = width - lx.Width;
                y += 30;

                controls.Add(tx);

            }
            return controls;
        }
    }
}
