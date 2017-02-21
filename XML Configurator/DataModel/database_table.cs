using System.Collections.Generic;

namespace XML_Configurator.DataModel
{
    public class database_table
    {
        string table_name;
        List<column_object> list_column_objects;
        //List<string> columns;
        //List<string> columns_types;
        //List<string> columns_nullable;


        public database_table(string table_name, List<string> columns, List<string> column_types, List<string> columns_nullable)
        {
            List_column_objects = new List<column_object>();
            Table_name = table_name;
            for (int i = 0; i < columns.Count; i++)
            {
                column_object column = new column_object(columns[i], column_types[i], columns_nullable[i]);
                List_column_objects.Add(column);
            }
        }

        public database_table()
        {
            table_name = null;
            List_column_objects = new List<column_object>();
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

        internal List<column_object> List_column_objects
        {
            get
            {
                return list_column_objects;
            }

            set
            {
                list_column_objects = value;
            }
        }

        public override string ToString()
        {
            return table_name;
        }

        //public static explicit operator database_table(ListViewItem v)
        //{
        //    return new database_table(v.SubItems.)
        //}
    }
}
