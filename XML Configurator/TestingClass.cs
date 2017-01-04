using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Configurator
{
    class TestingClass
    {

        public static void WriteXML()
        {
            DataModel.generator_object_id overview = new DataModel.generator_object_id();
            DataModel.generator_object_id overview1 = new DataModel.generator_object_id();
            overview.Object_comment = "Serialization Overview";
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(DataModel.generator_object_id));

            var path = @"C:\Users\slobodan.sredojevic\Desktop\VS Projects\XML Configurator\XML Configurator\bin\Debug" + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }
    }
}
