using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace XML_Configurator.DataModel
{
    public class datasource
    {
        string connection_string;
        string datasource_name;
        string datasource_database;
        string datasource_username;
        string datasource_password;
        string datasource_encrypted_credentials;
        string datasource_connection_type;
        string datasource_library;
        string datasource_catalog;
        string database_ip_address;

        public datasource()
        {
        }

        public datasource(string connection_string, string datasource_name, string datasource_database, string datasource_username, string datasource_password, string datasource_encrypted_credentials, string datasource_connection_type, string datasource_library, string datasource_catalog, string database_ip_address)
        {
            this.connection_string = connection_string;
            this.datasource_name = datasource_name;
            this.datasource_database = datasource_database;
            this.datasource_username = datasource_username;
            this.datasource_password = datasource_password;
            this.datasource_encrypted_credentials = datasource_encrypted_credentials;
            this.datasource_connection_type = datasource_connection_type;
            this.datasource_library = datasource_library;
            this.datasource_catalog = datasource_catalog;
            this.database_ip_address = database_ip_address;
        }

        public string Connection_string
        {
            get
            {
                return connection_string;
            }

            set
            {
                connection_string = value;
            }
        }

        public string Datasource_name
        {
            get
            {
                return datasource_name;
            }

            set
            {
                datasource_name = value;
            }
        }

        public static explicit operator datasource(ListView.SelectedListViewItemCollection v)
        {
            return new datasource();
        }

        public string Database_ip_address
        {
            get
            {
                return database_ip_address;
            }

            set
            {
                database_ip_address = value;
            }
        }

        public string Datasource_username
        {
            get
            {
                return datasource_username;
            }

            set
            {
                datasource_username = value;
            }
        }

        public string Datasource_password
        {
            get
            {
                return datasource_password;
            }

            set
            {
                datasource_password = value;
            }
        }

        public string Datasource_encrypted_credentials
        {
            get
            {
                return datasource_encrypted_credentials;
            }

            set
            {
                datasource_encrypted_credentials = value;
            }
        }

        public string Datasource_connection_type
        {
            get
            {
                return datasource_connection_type;
            }

            set
            {
                datasource_connection_type = value;
            }
        }

        public string Datasource_library
        {
            get
            {
                return datasource_library;
            }

            set
            {
                datasource_library = value;
            }
        }

        public string Datasource_catalog
        {
            get
            {
                return datasource_catalog;
            }

            set
            {
                datasource_catalog = value;
            }
        }

        public string Datasource_database
        {
            get
            {
                return datasource_database;
            }

            set
            {
                datasource_database = value;
            }
        }

        public static List<datasource> read_datasource_file() //izmeniti, nije konacna verzija. potrebno je proveriti koji je tip konekcije da bi se znalo sta se loaduje. ovo treba uraditi na neki logican nacin, mozda nasledjivanjem ili tako nesto slicno. 
        {
            List<datasource> list_datasource = new List<datasource>();

            XmlDocument document = new XmlDocument();
            document.Load(@"..\..\Include\datasource_parameters.xml");
            XmlNodeList nodes = document.SelectNodes("/datasources/datasource");
            foreach (XmlNode datasource in nodes)
            {
                if (datasource.NodeType != XmlNodeType.Comment)
                {
                    datasource datasource_instance = new datasource();
                    try
                    {
                        datasource_instance.datasource_name = datasource["datasource_name"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_username = datasource["datasource_username"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_password = datasource["datasource_password"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_encrypted_credentials = datasource["datasource_encrypted_credentials"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_library = datasource["datasource_library"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_connection_type = datasource["datasource_connection_type"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.database_ip_address = datasource["database_ip_address"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_catalog = datasource["datasource_catalog"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    try
                    {
                        datasource_instance.datasource_database = datasource["datasource_database"].InnerText;
                    }
                    catch (NullReferenceException)
                    {
                    }
                    list_datasource.Add(datasource_instance);
                }
            }

            return list_datasource;
        }

        public string[,] get_properties_and_values()
        {//opisati rad metode i verovatno pomeriti u engine
            Type type = typeof(datasource);

            PropertyInfo[] item_array = type.GetProperties();

            string[,] array_of_strings = new string[type.GetProperties().Length, 2];

            for (int i = 0; i < type.GetProperties().Length; i++)
            {
                if (item_array[i].Name != null && item_array[i].GetValue(this) != null)
                {
                    array_of_strings[i, 0] = item_array[i].Name;
                    array_of_strings[i, 1] = item_array[i].GetValue(this).ToString();
                }
            }

            return array_of_strings;
        }

        public override string ToString()
        {
            return Datasource_name;
        }

        public string Construct_Connection_String()
        {
            return null;
        }
    }
}
