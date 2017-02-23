using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OracleClient;
using System.Data.SqlClient;
using XML_Configurator.DataModel;

namespace XML_Configurator.DatabaseConnect
{
    static class API_database_connector
    {
        //establishing connection
        #region
        private static SqlConnection database_open_connection_SQLSERVER(datasource datasource)
        {
            string connectionString = null;
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            //builder["Data Source"] = "testwcm.fiege.com,1434";
            builder["Data Source"] = datasource.Database_ip_address + ",1434";
            builder["Initial Catalog"] = datasource.Datasource_catalog;
            builder["User ID"] = datasource.Datasource_username;
            builder["Password"] = datasource.Datasource_password;
            connectionString = builder.ConnectionString;
            Console.Write(builder.ConnectionString);
            //}

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private static OdbcConnection database_open_connection_ODBC(datasource datasource)
        {
            //            string String_Format = null;

            //#pragma warning disable CS0618 // Type or member is obsolete
            //            OracleConnection connection = new OracleConnection();
            //#pragma warning restore CS0618 // Type or member is obsolete

            //            String_Format = "Data Source={0};User ID={1};Password={2};";
            //            //String_Format = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.64.88.205)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = FWDIE1P.tgos.de)));" + "User Id=GOBABYGO;Password=comeback;";

            //            string system = datasource.Datasource_name;
            //            string username = datasource.Datasource_username;
            //            string password = datasource.Datasource_password;

            //            string ConnectionString = string.Format(String_Format, system.ToString(), username.ToString(), password.ToString());

            //            connection.ConnectionString = ConnectionString;
            //            connection.Open();
            //            //return connection;
            //            return true;


            string String_Format = null;

            OdbcConnection connection = new OdbcConnection();

            String_Format = "DSN={0};UID={1};PWD={2};";

            string system = datasource.Datasource_name;
            string username = datasource.Datasource_username;
            string password = datasource.Datasource_password;

            string ConnectionString = string.Format(String_Format, system.ToString(), username.ToString(), password.ToString());

            Console.WriteLine(ConnectionString);

            connection.ConnectionString = ConnectionString;
            connection.Open();
            return connection;
        }
#pragma warning disable CS0618 // Type or member is obsolete
        private static OracleConnection database_open_connection_OLEDB(datasource datasource)
#pragma warning restore CS0618 // Type or member is obsolete
        {
            string String_Format = null;

            OracleConnection connection = new OracleConnection();

            String_Format = "Data Source={0};User ID={1};Password={2};";
            //String_Format = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.64.88.205)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = FWDIE1P.tgos.de)));" + "User Id=GOBABYGO;Password=comeback;";

            string system = datasource.Datasource_name;
            string username = datasource.Datasource_username;
            string password = datasource.Datasource_password;

            string ConnectionString = string.Format(String_Format, system.ToString(), username.ToString(), password.ToString());

            connection.ConnectionString = ConnectionString;
            connection.Open();
            return connection;
        }

        #endregion

        //extract metadata of tables
        #region
        internal static List<string> database_schema_SQLSERVER(datasource datasource)
        {
            List<string> list_database_table = new List<string>();
            SqlConnection connection = database_open_connection_SQLSERVER(datasource);

            SqlCommand command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" + datasource.Datasource_library + "'", connection);

            Console.WriteLine(command.CommandText);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["TABLE_NAME"].ToString());
                list_database_table.Add(reader["TABLE_NAME"].ToString());
            }
            return list_database_table;
        }

        internal static List<string> database_schema_ODBC(datasource datasource)
        {
            List<string> list_database_table = new List<string>();
            OdbcConnection connection = database_open_connection_ODBC(datasource);
            OdbcCommand command;

            if (datasource.Datasource_database.ToUpper() == "ORACLE")
            {
                command = new OdbcCommand("SELECT TO_CHAR(TABLE_NAME) AS TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + datasource.Datasource_library + "'", connection);//mora to_char, baca overflow ex
                                                                                                                                                                        //                command = new OdbcCommand("SELECT TO_CHAR(TABLE_NAME) AS TABLE_NAME FROM ALL_TABLES WHERE TABLE_NAME = 'XXAZP'", connection);//mora to_char, baca overflow ex
            }
            else
            {
                command = new OdbcCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" + datasource.Datasource_library + "'", connection);
            }

            Console.WriteLine(command.CommandText);

            OdbcDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["TABLE_NAME"].ToString());
                list_database_table.Add(reader["TABLE_NAME"].ToString());
            }

            return list_database_table;
        }

        internal static List<string> database_schema_OLEDB(datasource datasource)
        {
            List<string> list_database_table = new List<string>();
            OracleConnection connection = database_open_connection_OLEDB(datasource);

            OracleCommand command = new OracleCommand("SELECT TO_CHAR(TABLE_NAME) AS TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + datasource.Datasource_library + "'", connection);//mora to_char, baca overflow ex

            Console.WriteLine(command.CommandText);

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["TABLE_NAME"].ToString());
                list_database_table.Add(reader["TABLE_NAME"].ToString());
            }

            return list_database_table;
        }
        #endregion

        //extract metadata of columns
        #region
        internal static List<ResultSetInstance> database_table_SQLSERVER(datasource ds, string table_name)
        {
            List<ResultSetInstance> list_table_columns = new List<ResultSetInstance>();

            SqlConnection connection = database_open_connection_SQLSERVER(ds);
            SqlCommand command = new SqlCommand("select COLUMN_NAME, DATA_TYPE, IS_NULLABLE from information_schema.columns where table_name = '" + table_name + "'; ", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ResultSetInstance rs = new ResultSetInstance();
                rs.COLUMN_NAME = reader["COLUMN_NAME"].ToString();
                rs.DATA_TYPE = reader["DATA_TYPE"].ToString();
                rs.IS_NULLABLE = reader["IS_NULLABLE"].ToString();
                list_table_columns.Add(rs);
            }
            reader.Close();
            return list_table_columns;
        } //should be obsolete
        internal static ResultSetInstance[][] database_table_SQLSERVER(datasource datasource, List<database_table> list_selected_tables)
        {
            ResultSetInstance[][] array_tables = new ResultSetInstance[list_selected_tables.Count][];

            SqlConnection connection = database_open_connection_SQLSERVER(datasource);
            foreach (database_table table in list_selected_tables)
            {
                List<ResultSetInstance> array_table_columns = new List<ResultSetInstance>();

                SqlCommand command = new SqlCommand("select COLUMN_NAME, DATA_TYPE, IS_NULLABLE from information_schema.columns where table_name = '" + table + "'; ", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ResultSetInstance rs = new ResultSetInstance();
                    rs.COLUMN_NAME = reader["COLUMN_NAME"].ToString();
                    rs.DATA_TYPE = reader["DATA_TYPE"].ToString();
                    rs.IS_NULLABLE = reader["IS_NULLABLE"].ToString();
                    array_table_columns.Add(rs);
                }
                reader.Close();
                array_tables[list_selected_tables.IndexOf(table)] = array_table_columns.ToArray();
            }
            return array_tables;
        }

        internal static List<ResultSetInstance> database_table_ODBC(datasource ds, string schema_name, string table_name)
        {
            List<ResultSetInstance> list_table_columns = new List<ResultSetInstance>();

            OdbcConnection connection = database_open_connection_ODBC(ds);
            OdbcCommand command = new OdbcCommand("select COLUMN_NAME, DATA_TYPE, IS_NULLABLE from information_schema.columns where table_schema = '" + schema_name + "' and table_name = '" + table_name + "'", connection);
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ResultSetInstance rs = new ResultSetInstance();
                rs.COLUMN_NAME = reader["COLUMN_NAME"].ToString();
                rs.DATA_TYPE = reader["DATA_TYPE"].ToString();
                rs.IS_NULLABLE = reader["IS_NULLABLE"].ToString();
                list_table_columns.Add(rs);
            }
            return list_table_columns;
        } //should be obsolete
        internal static ResultSetInstance[][] database_table_ODBC(datasource ds, string schema_name, List<database_table> list_selected_tables)
        {
            ResultSetInstance[][] array_tables = new ResultSetInstance[list_selected_tables.Count][];

            OdbcConnection connection = database_open_connection_ODBC(ds);
            foreach (database_table table in list_selected_tables)
            {
                List<ResultSetInstance> array_table_columns = new List<ResultSetInstance>();

                OdbcCommand command = new OdbcCommand("select COLUMN_NAME, DATA_TYPE, IS_NULLABLE from information_schema.columns where table_schema = '" + schema_name + "' and table_name = '" + table + "'", connection);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ResultSetInstance rs = new ResultSetInstance();
                    rs.COLUMN_NAME = reader["COLUMN_NAME"].ToString();
                    rs.DATA_TYPE = reader["DATA_TYPE"].ToString();
                    rs.IS_NULLABLE = reader["IS_NULLABLE"].ToString();
                    array_table_columns.Add(rs);
                }
                reader.Close();
                array_tables[list_selected_tables.IndexOf(table)] = array_table_columns.ToArray();
            }
            return array_tables;
        }

        internal static List<ResultSetInstance> database_table_OLEDB(datasource ds, string schema_name, string table_name)
        {
            List<ResultSetInstance> list_table_columns = new List<ResultSetInstance>();

            OracleConnection connection = database_open_connection_OLEDB(ds);
            OracleCommand command = new OracleCommand("SELECT COLUMN_NAME, DATA_TYPE, NULLABLE FROM ALL_TAB_COLUMNS WHERE OWNER = '" + schema_name + "' and TABLE_NAME = '" + table_name + "'", connection);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ResultSetInstance rs = new ResultSetInstance();
                rs.COLUMN_NAME = reader["COLUMN_NAME"].ToString();
                rs.DATA_TYPE = reader["DATA_TYPE"].ToString();
                rs.IS_NULLABLE = reader["NULLABLE"].ToString();
                list_table_columns.Add(rs);
            }
            return list_table_columns;
        } //should be obsolete
        internal static ResultSetInstance[][] database_table_OLEDB(datasource ds, string schema_name, List<database_table> list_selected_tables)
        {
            ResultSetInstance[][] array_tables = new ResultSetInstance[list_selected_tables.Count][];

            OracleConnection connection = database_open_connection_OLEDB(ds);
            foreach (database_table table in list_selected_tables)
            {
                List<ResultSetInstance> array_table_columns = new List<ResultSetInstance>();

                OracleCommand command = new OracleCommand("SELECT COLUMN_NAME, DATA_TYPE, NULLABLE FROM ALL_TAB_COLUMNS WHERE OWNER = '" + schema_name + "' and TABLE_NAME = '" + table + "'", connection);
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ResultSetInstance rs = new ResultSetInstance();
                    rs.COLUMN_NAME = reader["COLUMN_NAME"].ToString();
                    rs.DATA_TYPE = reader["DATA_TYPE"].ToString();
                    rs.IS_NULLABLE = reader["NULLABLE"].ToString();
                    array_table_columns.Add(rs);
                }
                reader.Close();
                array_tables[list_selected_tables.IndexOf(table)] = array_table_columns.ToArray();
            }
            return array_tables;
        }
        #endregion

        //run sample queries
        #region
        public static List<object> database_query_SQLSERVER(datasource ds, string query)
        {
            string query_reformated = reformat_string_to_query_number_of_rows(query);
            if (query_reformated.ToUpper().Contains("UPDATE") || query_reformated.ToUpper().Contains("DELETE")) //ovo treba prepraviti, mozda postoji polje sa ovim nazivima. Podeliti po recima, onda purge-ovati \t\n\r
            {
                throw new Exception("ERROR! Query must not contain UPDATE or DELETE");
            }

            SqlConnection connection = database_open_connection_SQLSERVER(ds);
            SqlCommand command = new SqlCommand(query_reformated, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<object> result = new List<object>();

            while (reader.Read())
            {
                string i = reader[0].ToString();
                result.Add(i);
            }
            return result;
        }

        public static List<object> database_query_ODBC(datasource ds, string schema_name, string query)
        {
            string query_reformated = reformat_string_to_query_number_of_rows(query);
            if (query_reformated.ToUpper().Contains("UPDATE") || query_reformated.ToUpper().Contains("DELETE")) //ovo treba prepraviti, mozda postoji polje sa ovim nazivima. Podeliti po recima, onda purge-ovati \t\n\r
            {
                throw new Exception("ERROR! Query must not contain UPDATE or DELETE");
            }

            OdbcConnection connection = database_open_connection_ODBC(ds);
            OdbcCommand command = new OdbcCommand(query_reformated, connection);
            OdbcDataReader reader = command.ExecuteReader();

            List<object> result = new List<object>();

            while (reader.Read())
            {
                string i = reader[0].ToString();
                result.Add(i);
            }
            return result;
        }

        public static List<object> database_query_OLEDB(datasource ds, string schema_name, string query)
        {
            string query_reformated = reformat_string_to_query_number_of_rows(query);
            if (query_reformated.ToUpper().Contains("UPDATE") || query_reformated.ToUpper().Contains("DELETE")) //ovo treba prepraviti, mozda postoji polje sa ovim nazivima. Podeliti po recima, onda purge-ovati \t\n\r
            {
                throw new Exception("ERROR! Query must not contain UPDATE or DELETE");
            }

            OracleConnection connection = database_open_connection_OLEDB(ds);
            OracleCommand command = new OracleCommand(query_reformated, connection);
            OracleDataReader reader = command.ExecuteReader();

            List<object> result = new List<object>();

            while (reader.Read())
            {
                string i = reader[0].ToString();
                result.Add(i);
            }
            return result;
        }
        #endregion

        //reformation of string
        internal static string reformat_string_to_query_number_of_rows(string query)
        {
            query = query.Replace("\n", " ");
            query = query.Replace("\t", " ");
            query = query.Replace("\r", " ");

            string word = query.Substring(query.LastIndexOf("FROM")); //substring posle FROM, mozda postoji u where uslov

            string return_string = "SELECT COUNT(*) ";
            return_string += word;

            return return_string;
        }
    }
}
