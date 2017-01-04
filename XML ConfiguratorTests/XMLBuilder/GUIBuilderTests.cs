using Microsoft.VisualStudio.TestTools.UnitTesting;
using XML_Configurator.XMLBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Configurator.XMLBuilder.Tests
{
    [TestClass()]
    public class GUIBuilderTests
    {
        [TestMethod()]
        public void loadXMLTest()
        {
            List<string> ls = new List<string>();
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\slobodan.sredojevic\Desktop\VS Projects\XML Configurator\XML Configurator\bin\Debug\TEMPLATE_TO_LOAD.xml");
            XmlNode node = document.DocumentElement.SelectSingleNode("/datasource/objects");
            foreach (XmlNode object_id in node)
            {
                foreach (XmlNode parameter in object_id.ChildNodes)
                {
                    if (parameter.NodeType != XmlNodeType.Comment)
                    {
                        ls.Add(parameter.Name);
                    }
                }
            }
        }
    }
}