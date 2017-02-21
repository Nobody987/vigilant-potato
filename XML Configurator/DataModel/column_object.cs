namespace XML_Configurator.DataModel
{
    class column_object
    {
        string column_name;
        string column_nullable;
        string column_data_type;
        string column_primary_key;
        string column_transformation;

        public override string ToString()
        {
            return column_name;
        }

        public column_object(string column_name, string column_data_type, string column_nullable)
        {
            Column_name = column_name;
            Column_nullable = column_nullable;
            Column_data_type = column_data_type;
            column_primary_key = "";
            column_transformation = "";
        }

        public string Column_name
        {
            get
            {
                return column_name;
            }

            set
            {
                column_name = value;
            }
        }

        public string Column_primary_key
        {
            get
            {
                return column_primary_key;
            }

            set
            {
                column_primary_key = value;
            }
        }

        public string Column_data_type
        {
            get
            {
                return column_data_type;
            }

            set
            {
                column_data_type = value;
            }
        }

        public string Column_transformation
        {
            get
            {
                return column_transformation;
            }

            set
            {
                column_transformation = value;
            }
        }

        public string Column_nullable
        {
            get
            {
                return column_nullable;
            }

            set
            {
                column_nullable = value;
            }
        }
    }
}
