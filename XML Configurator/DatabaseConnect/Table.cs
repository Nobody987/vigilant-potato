using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Configurator.DatabaseConnect
{
    class Table
    {
        int column_id;
        string column;
        string type;

        public Table(int column_id, string column, string type)
        {
            this.column_id = column_id;
            this.column = column;
            this.type = type;
        }

        public int Column_id
        {
            get
            {
                return column_id;
            }

            set
            {
                column_id = value;
            }
        }

        public string Column
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
