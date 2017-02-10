using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_Configurator.DatabaseConnect;
using XML_Configurator.DataModel;

namespace XML_Configurator
{
    public class _00_Controller
    {
        static _00_Controller _controller;

        private _00_Controller() { }

        public static _00_Controller _instance
        {
            get
            {
                if (_controller == null)
                {
                    _controller = new _00_Controller();
                }
                return _controller;
            }
        }

        internal List<object> return_database_query(datasource datasource, string query_string)
        {
            List<object> return_objects = new List<object>();

            try
            {
                if (datasource.Datasource_connection_type == "SQLSERVER")
                {
                    return return_objects = API_database_connector.database_query_SQLSERVER(datasource, query_string);
                }
                else if (datasource.Datasource_connection_type == "ODBC")
                {
                    return return_objects = API_database_connector.database_query_ODBC(datasource, datasource.Datasource_library, query_string);
                }
                else if (datasource.Datasource_connection_type == "OLEDB")
                {
                    return return_objects = API_database_connector.database_query_OLEDB(datasource, datasource.Datasource_library, query_string);
                }
                else
                {
                    throw new Exception("Unknown connection type! \n'" + datasource.Datasource_connection_type + "'"); //not supported database
                }
            }
            catch (Exception ex)
            {
                Exception e = new Exception("Error occurred while executing test query \n\n" + ex.Message);
                throw e;
            }
        }

        internal List<string> return_database_schema(datasource datasource)
        {
            List<string> list_database_table = new List<string>();

            try
            {
                if (datasource.Datasource_connection_type.ToUpper() == "SQLSERVER")
                {
                    return list_database_table = API_database_connector.database_schema_SQLSERVER(datasource);
                }
                else if (datasource.Datasource_connection_type.ToUpper() == "ODBC")
                {
                    return list_database_table = API_database_connector.database_schema_ODBC(datasource);
                }
                else if (datasource.Datasource_connection_type.ToUpper() == "OLEDB")
                {
                    return list_database_table = API_database_connector.database_schema_OLEDB(datasource);
                }
                else
                {
                    throw new Exception("Unknown connection type! \n'" + datasource.Datasource_connection_type + "'"); //not supported database
                }
            }
            catch (Exception ex)
            {
                Exception e = new Exception("Error occurred while executing schema load query \n\n" + ex.Message);
                throw e;
            }
        }

        internal ResultSetInstance[][] return_database_tables(datasource datasource, List<database_table> list_selected_tables)
        {
            try
            {
                if (datasource.Datasource_connection_type.ToUpper() == "SQLSERVER")
                {
                    return API_database_connector.database_table_SQLSERVER(datasource, list_selected_tables);
                }

                else if (datasource.Datasource_connection_type.ToUpper() == "ODBC")
                {
                    return API_database_connector.database_table_ODBC(datasource, datasource.Datasource_catalog, list_selected_tables);
                }

                else if (datasource.Datasource_connection_type.ToUpper() == "OLEDB")
                {
                    return API_database_connector.database_table_OLEDB(datasource, datasource.Datasource_catalog, list_selected_tables);
                }
                else
                {
                    throw new Exception("Unknown connection type! \n'" + datasource.Datasource_connection_type + "'"); //not supported database
                }
            }
            catch (Exception ex)
            {
                Exception e = new Exception("Error occurred while executing schema load query \n\n" + ex.Message);
                throw e;
            }
        }

        internal List<ResultSetInstance> return_database_tables(datasource datasource, string table_name)
        {
            try
            {
                List<ResultSetInstance> list_table_columns = new List<ResultSetInstance>();
                if (datasource.Datasource_connection_type.ToUpper() == "SQLSERVER")
                {
                    return list_table_columns = API_database_connector.database_table_SQLSERVER(datasource, table_name);
                }

                else if (datasource.Datasource_connection_type.ToUpper() == "ODBC")
                {
                    return list_table_columns = API_database_connector.database_table_ODBC(datasource, datasource.Datasource_catalog, table_name);
                }

                else if (datasource.Datasource_connection_type.ToUpper() == "OLEDB")
                {
                    return list_table_columns = API_database_connector.database_table_OLEDB(datasource, datasource.Datasource_catalog, table_name);
                }
                else
                {
                    throw new Exception("Unknown connection type! \n'" + datasource.Datasource_connection_type + "'"); //not supported database
                }
            }
            catch (Exception ex)
            {
                Exception e = new Exception("Error occurred while executing schema load query \n\n" + ex.Message);
                throw e;
            }
        }

    }
}
