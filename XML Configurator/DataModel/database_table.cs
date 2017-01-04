using System.Collections.Generic;

namespace XML_Configurator.DataModel
{
    public class database_table
    {
        string table_name;
        List<string> columns;
        List<string> columns_types;
        List<string> columns_nullable;


        public database_table(string table_name, List<string> columns, List<string> column_types, List<string> columns_nullable)
        {
            Table_name = table_name;
            Columns = columns;
            Columns_types = column_types;
            Columns_nullable = columns_nullable;
        }

        public database_table()
        {
            table_name = null;
            columns = new List<string>();
            Columns_types = new List<string>();
            Columns_nullable = new List<string>();
        }

        public string Table_name
        {
            get
            {
                return table_name;
            }

            set
            {
                table_name = value;
            }
        }

        public List<string> Columns
        {
            get
            {
                return columns;
            }

            set
            {
                columns = value;
            }
        }

        public List<string> Columns_types
        {
            get
            {
                return columns_types;
            }

            set
            {
                columns_types = value;
            }
        }

        public List<string> Columns_nullable
        {
            get
            {
                return columns_nullable;
            }

            set
            {
                columns_nullable = value;
            }
        }

        public override string ToString()
        {
            return table_name;
        }
    }
}
