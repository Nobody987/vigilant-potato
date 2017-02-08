using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Configurator.DataModel
{
    class load_types
    {
        string load_type_name;
        string load_type_file_prefix;
        string load_type_file_sufix;

        public override string ToString()
        {
            return Load_type_name;
        }

        public string Load_type_name
        {
            get
            {
                return load_type_name;
            }

            set
            {
                load_type_name = value;
            }
        }

        public string Load_type_file_prefix
        {
            get
            {
                return load_type_file_prefix;
            }

            set
            {
                load_type_file_prefix = value;
            }
        }

        public string Load_type_file_sufix
        {
            get
            {
                return load_type_file_sufix;
            }

            set
            {
                load_type_file_sufix = value;
            }
        }

        public load_types(string load_type_name, string load_type_file_prefix, string load_type_file_sufix)
        {
            this.Load_type_name = load_type_name;
            this.Load_type_file_prefix = load_type_file_prefix;
            this.Load_type_file_sufix = load_type_file_sufix;
        }
        public load_types()
        {
            this.Load_type_name = "";
            this.Load_type_file_prefix = "";
            this.Load_type_file_sufix = "";
        }

        public static List<load_types> read_load_types_file() //izmeniti, nije konacna verzija. potrebno je proveriti koji je tip konekcije da bi se znalo sta se loaduje. ovo treba uraditi na neki logican nacin, mozda nasledjivanjem ili tako nesto slicno. 
        {
            List<load_types> list_load_types = new List<load_types>();

            XmlDocument document = new XmlDocument();
            document.Load(@"..\..\Include\load_types.xml");
            XmlNodeList nodes = document.SelectNodes("/load_types/load_type");
            foreach (XmlNode load_type_node in nodes)
            {
                if (load_type_node.NodeType != XmlNodeType.Comment)
                {
                    load_types load_type = new load_types();
                    try
                    {
                        load_type.load_type_name = load_type_node["load_type_name"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        load_type.load_type_file_prefix = load_type_node["load_type_file_prefix"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        load_type.load_type_file_sufix = load_type_node["load_type_file_sufix"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    list_load_types.Add(load_type);
                }
            }

            return list_load_types;
        }
    }
}
