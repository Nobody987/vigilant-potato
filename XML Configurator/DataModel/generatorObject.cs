using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XML_Configurator.DataModel
{
    [Serializable]
    public class generatorObject
    {
        string object_name;
        string object_reload_minutes;
        string object_comment;
        string object_primary_key;
        string object_select_statement;
        string object_datetime_format;
        string object_date_format;
        string object_time_format;
        string object_where_statement;
        char object_active;
        string object_load_type;
        string object_fieldstoload_statement;
        string object_reorganization;
        string object_transformation_statement;
        string object_target_extraction_folder;
        string object_target_extraction_filename;
        public string select_statement_for_display; //ovaj atribut je public da se u XML ne bi uzimao kao property jer ne treba da se ispisuje
        string[] select_statement_for_display_string_array; //ovaj atribut je public da se u XML ne bi uzimao kao property jer ne treba da se ispisuje
        //string internal_filename; //koristi se za prebicavanje u transformation object

        public override string ToString()
        {
            return object_name;
        }

        public string Object_name
        {
            get
            {
                return object_name;
            }

            set
            {
                object_name = value;
            }
        }

        public string Object_reload_minutes
        {
            get
            {
                return object_reload_minutes;
            }

            set
            {
                object_reload_minutes = value;
            }
        }

        public string Object_comment
        {
            get
            {
                return object_comment;
            }

            set
            {
                object_comment = value;
            }
        }

        public string Object_primary_key
        {
            get
            {
                return object_primary_key;
            }

            set
            {
                object_primary_key = value;
            }
        }

        public string Object_select_statement
        {
            get
            {
                return object_select_statement;
            }

            set
            {
                object_select_statement = value;
            }
        }

        public string Object_datetime_format
        {
            get
            {
                return object_datetime_format;
            }

            set
            {
                object_datetime_format = value;
            }
        }

        public string Object_date_format
        {
            get
            {
                return object_date_format;
            }

            set
            {
                object_date_format = value;
            }
        }

        public string Object_time_format
        {
            get
            {
                return object_time_format;
            }

            set
            {
                object_time_format = value;
            }
        }

        public string Object_where_statement
        {
            get
            {
                return object_where_statement;
            }

            set
            {
                object_where_statement = value;
            }
        }

        public char Object_active
        {
            get
            {
                return object_active;
            }

            set
            {
                object_active = value;
            }
        }

        public string Object_load_type
        {
            get
            {
                return object_load_type;
            }

            set
            {
                object_load_type = value;
            }
        }

        public string Object_fieldstoload_statement
        {
            get
            {
                return object_fieldstoload_statement;
            }

            set
            {
                object_fieldstoload_statement = value;
            }
        }

        public static string ConstructSelectStatement(string statement_text) // nepotreban in parametar, bolje string. proveriti da li moze
        {
            //textBox_object_select_statement.Text = textBox_object_select_statement.Text.Trim();
            //String object_select_statement = null;
            //for (int Line = 0; Line < textBox_object_select_statement.Lines.Count(); Line++)
            //{
            //    if (!string.IsNullOrEmpty(textBox_object_select_statement.Lines[Line].Trim()))
            //    {
            //        object_select_statement = object_select_statement + textBox_object_select_statement.Lines[Line].Trim() + '\r' + '\n';
            //    }
            //}
            //object_select_statement = object_select_statement + '\r' + '\n';
            //return object_select_statement;

            string[] array_statement_text = statement_text.Trim().Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);

            string object_select_statement = null;
            for (int Line = 0; Line < array_statement_text.Count(); Line++)
            {
                object_select_statement = object_select_statement + array_statement_text[Line].Trim() + '\r' + '\n';
            }
            object_select_statement = object_select_statement + '\r' + '\n';
            return object_select_statement;
        }

        public string Object_reorganization
        {
            get
            {
                return object_reorganization;
            }

            set
            {
                object_reorganization = value;
            }
        }

        public string Object_transformation_statement
        {
            get
            {
                return object_transformation_statement;
            }

            set
            {
                object_transformation_statement = value;
            }
        }

        public string Object_target_extraction_folder
        {
            get
            {
                return object_target_extraction_folder;
            }

            set
            {
                object_target_extraction_folder = value;
            }
        }

        public string Object_target_extraction_filename
        {
            get
            {
                return object_target_extraction_filename;
            }

            set
            {
                object_target_extraction_filename = value;
            }
        }

        public string Select_statement_for_display_string_array
        {
            get
            {
                string return_string = null;

                foreach (string item in select_statement_for_display_string_array)
                {
                    if (item.ToUpper().Trim().Contains("SELECT")) //Sve ostalo
                    {
                        return_string += "\r\n" + item.Trim();
                    }
                    else if (item.ToUpper().Trim().Contains("FROM")) //FROM
                    {
                        return_string += "\r\n" + item.Trim();
                    }
                    else if (item.ToUpper().Trim().Contains("WHERE")) //WHERE
                    {
                        return_string += "\r\n" + item.Trim();
                    }
                    else //SELECT
                    {
                        return_string += "\r\n\t" + item.Trim();
                    }
                }
                return return_string.TrimStart();
            }

            set
            {
                select_statement_for_display_string_array = value.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public generatorObject()
        {
            this.object_name = "Default";
            this.object_reload_minutes = "Default";
            this.object_comment = "Default";
            this.object_primary_key = "Default";
            this.object_select_statement = "Default";
            this.object_datetime_format = "Default";
            this.object_date_format = "Default";
            this.object_time_format = "Default";
            this.object_where_statement = "Default";
            this.object_active = 'N';
            this.object_load_type = "Default";
            this.object_fieldstoload_statement = "Default";
            this.object_reorganization = "Default";
            this.object_transformation_statement = "Default";
            this.object_target_extraction_folder = "Default";
            this.object_target_extraction_filename = "Default";
            this.select_statement_for_display = object_select_statement;
        }

        public generatorObject(string object_name, string object_reload_minutes, string object_comment, string object_primary_key, string object_select_statement, string object_datetime_format, string object_date_format, string object_time_format, string object_where_statement, char object_active, string object_load_type, string object_fieldstoload_statement, string object_reorganization, string object_transformation_statement, string object_target_extraction_folder, string object_target_extraction_filename, string select_statement_for_display, string select_statement_for_display_string_array)
        {
            this.object_name = object_name;
            this.object_reload_minutes = object_reload_minutes;
            this.object_comment = object_comment;
            this.object_primary_key = object_primary_key;
            //this.object_select_statement = object_select_statement;
            this.object_select_statement = select_statement_for_display_string_array;
            this.object_datetime_format = object_datetime_format;
            this.object_date_format = object_date_format;
            this.object_time_format = object_time_format;
            this.object_where_statement = object_where_statement;
            this.object_active = object_active;
            this.object_load_type = object_load_type;
            this.object_fieldstoload_statement = object_fieldstoload_statement;
            this.object_reorganization = object_reorganization;
            this.object_transformation_statement = object_transformation_statement;
            this.object_target_extraction_folder = object_target_extraction_folder;
            this.object_target_extraction_filename = object_target_extraction_filename;
            this.select_statement_for_display = select_statement_for_display;
            this.Select_statement_for_display_string_array = select_statement_for_display_string_array;
        }

        public static explicit operator generatorObject(ListViewItem v)
        {
            return new generatorObject(v.SubItems[0].Text.ToString(), v.SubItems[3].Text.ToString(), v.SubItems[4].Text.ToString(), v.SubItems[5].Text.ToString(), v.SubItems[6].Text.ToString(), v.SubItems[7].Text.ToString(), v.SubItems[8].Text.ToString(), v.SubItems[9].Text.ToString(), v.SubItems[10].Text.ToString(), char.Parse(v.SubItems[1].Text.ToString()), v.SubItems[2].Text.ToString(), v.SubItems[11].Text.ToString(), v.SubItems[12].Text.ToString(), v.SubItems[13].Text.ToString(), v.SubItems[14].Text.ToString(), v.SubItems[15].Text.ToString(), v.SubItems[16].Text.ToString(), v.SubItems[17].Text.ToString());

            //return new object_id(v.SubItems[0].Text.ToString(), v.SubItems[2].Text.ToString(), v.SubItems[3].Text.ToString(), v.SubItems[4].Text.ToString(), v.SubItems[5].Text.ToString(), v.SubItems[6].Text.ToString(), v.SubItems[7].Text.ToString(), v.SubItems[8].Text.ToString(), v.SubItems[9].Text.ToString(), char.Parse(v.SubItems[1].Text.ToString()), v.SubItems[10].Text.ToString(), v.SubItems[11].Text.ToString(), v.SubItems[12].Text.ToString(), v.SubItems[13].Text.ToString(), v.SubItems[14].Text.ToString(), v.SubItems[15].Text.ToString(), v.SubItems[16].Text.ToString(), v.SubItems[17].Text.ToString());
        }

        public static explicit operator ListViewItem(generatorObject v)
        {
            //List<string> List_Variables = new List<string>();
            //List_Variables.Add(v.object_name);
            //List_Variables.Add(v.object_active.ToString());
            //List_Variables.Add(v.object_reload_minutes.ToString());
            //List_Variables.Add(v.object_comment);
            //List_Variables.Add(v.object_primary_key);
            ////List_Variables.Add(v.object_select_statement);
            //List_Variables.Add(v.Select_statement_for_display_string_array); 
            //List_Variables.Add(v.object_datetime_format);
            //List_Variables.Add(v.object_date_format);
            //List_Variables.Add(v.object_time_format);
            //List_Variables.Add(v.object_where_statement);
            //List_Variables.Add(v.object_load_type);
            //List_Variables.Add(v.object_fieldstoload_statement);
            //List_Variables.Add(v.object_reorganization);
            //List_Variables.Add(v.object_transformation_statement);
            //List_Variables.Add(v.object_target_extraction_folder);
            //List_Variables.Add(v.object_target_extraction_filename);
            //List_Variables.Add(v.select_statement_for_display);
            //List_Variables.Add(v.Select_statement_for_display_string_array.ToString());
            List<string> List_Variables = new List<string>();
            List_Variables.Add(v.object_name);
            List_Variables.Add(v.object_active.ToString());
            List_Variables.Add(v.object_load_type);
            List_Variables.Add(v.object_reload_minutes.ToString());
            List_Variables.Add(v.object_comment);
            List_Variables.Add(v.object_primary_key);
            //List_Variables.Add(v.object_select_statement);
            List_Variables.Add(v.Select_statement_for_display_string_array);
            List_Variables.Add(v.object_datetime_format);
            List_Variables.Add(v.object_date_format);
            List_Variables.Add(v.object_time_format);
            List_Variables.Add(v.object_where_statement);
            List_Variables.Add(v.object_fieldstoload_statement);
            List_Variables.Add(v.object_reorganization);
            List_Variables.Add(v.object_transformation_statement);
            List_Variables.Add(v.object_target_extraction_folder);
            List_Variables.Add(v.object_target_extraction_filename);
            List_Variables.Add(v.select_statement_for_display);
            List_Variables.Add(v.Select_statement_for_display_string_array.ToString());
            return new ListViewItem(List_Variables.ToArray());
        }
    }
}
