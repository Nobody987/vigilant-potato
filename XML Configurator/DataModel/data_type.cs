using System;
using System.Collections.Generic;
using System.Xml;

namespace XML_Configurator.DataModel
{
    class data_type
    {
        string data_type_name;
        string data_type_return_value;

        public data_type(string data_type_name, string data_type_return_value)
        {
            Data_type_name = data_type_name;
            Data_type_return_value = data_type_return_value;
        }

        public data_type()
        {
            data_type_name = "";
            data_type_return_value = "";
        }

        public string Data_type_name
        {
            get
            {
                return data_type_name;
            }

            set
            {
                data_type_name = value;
            }
        }

        public string Data_type_return_value
        {
            get
            {
                return data_type_return_value;
            }

            set
            {
                data_type_return_value = value;
            }
        }

        public static List<data_type> read_data_type_file() //izmeniti, nije konacna verzija. potrebno je proveriti koji je tip konekcije da bi se znalo sta se loaduje. ovo treba uraditi na neki logican nacin, mozda nasledjivanjem ili tako nesto slicno. 
        {
            List<data_type> list_data_type = new List<data_type>();

            XmlDocument document = new XmlDocument();
            document.Load(@"..\..\Include\data_types.xml");
            XmlNodeList nodes = document.SelectNodes("/data_types/data_type");
            foreach (XmlNode data_type_node in nodes)
            {
                if (data_type_node.NodeType != XmlNodeType.Comment)
                {
                    data_type data_type = new data_type();
                    try
                    {
                        data_type.data_type_name = data_type_node["data_type_name"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        data_type.data_type_return_value = data_type_node["data_type_return_value"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    list_data_type.Add(data_type);
                }
            }
            return list_data_type;
        }
    }
}
