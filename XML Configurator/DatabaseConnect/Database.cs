using System;
using System.Xml;
using XML_Configurator.DataModel;

namespace XML_Configurator
{
    class Databasea //proveriti da li ovo treba da se koristi jos uvek
    {
        string datasource_name;
        string datasource_username;
        string datasource_password;
        bool datasource_encrypted_credentials;
        string datasource_connection_type;
        string datasource_library;

        public Databasea(string datasource_name, string datasource_username, string datasource_password, bool datasource_encrypted_credentials, string datasource_connection_type, string datasource_library)
        {
            this.datasource_name = datasource_name;
            this.datasource_username = datasource_username;
            this.datasource_password = datasource_password;
            this.datasource_encrypted_credentials = datasource_encrypted_credentials;
            this.datasource_connection_type = datasource_connection_type;
            this.datasource_library = datasource_library;
        }

        public Databasea()
        {
            this.datasource_name = null;
            this.datasource_username = null;
            this.datasource_password = null;
            this.datasource_encrypted_credentials = false;
            this.datasource_connection_type = null;
            this.datasource_library = null;
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

        public bool Datasource_encrypted_credentials
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

        public Databasea import_xml_database()
        {
            XmlDocument document = new XmlDocument();
            document.Load(Metadata.Datasource_parameters + "datasource_parameters.xml");  //radi. nastaviti ako je najbolje resenje
            return null;
        }
    }
}