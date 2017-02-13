using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XML_Configurator.DataModel
{
    [Serializable]
    public class transformator_object_id
    {
        string transformation_name;
        string transformation_active;
        string transformation_incremental;
        string transformation_statement;
        string transformation_split_parameter;
        string transformation_primary_key;
        string additional_transformation_split_parameters;
        string additional_transformation_where_statement;
        string additional_transformation_number_of_days;
        string additional_transformation_number_of_months;
        string additional_transformation_number_of_years;
        string transformation_source_folder;
        string transformation_source_filename;
        string transformation_target_folder;
        string transformation_target_filename;

        public transformator_object_id()
        {

        }

        public transformator_object_id(string transformation_name, string transformation_active, string transformation_incremental, string transformation_statement, string transformation_split_parameter, string transformation_primary_key, string additional_transformation_split_parameters, string additional_transformation_where_statement, string additional_transformation_number_of_days, string additional_transformation_number_of_months, string additional_transformation_number_of_years, string transformation_source_folder, string transformation_source_filename, string transformation_target_folder, string transformation_target_filename)
        {
            this.transformation_name = transformation_name;
            this.transformation_active = transformation_active;
            this.transformation_incremental = transformation_incremental;
            this.transformation_statement = transformation_statement;
            this.transformation_split_parameter = transformation_split_parameter;
            this.transformation_primary_key = transformation_primary_key;
            this.additional_transformation_split_parameters = additional_transformation_split_parameters;
            this.additional_transformation_where_statement = additional_transformation_where_statement;
            this.additional_transformation_number_of_days = additional_transformation_number_of_days;
            this.additional_transformation_number_of_months = additional_transformation_number_of_months;
            this.additional_transformation_number_of_years = additional_transformation_number_of_years;
            this.transformation_source_folder = transformation_source_folder;
            this.transformation_source_filename = transformation_source_filename;
            this.transformation_target_folder = transformation_target_folder;
            this.transformation_target_filename = transformation_target_filename;
        }

        public override string ToString()
        {
            return transformation_name;
        }

        public string Transformation_name
        {
            get
            {
                return transformation_name;
            }

            set
            {
                transformation_name = value;
            }
        }

        public string Transformation_active
        {
            get
            {
                return transformation_active;
            }

            set
            {
                transformation_active = value;
            }
        }

        public string Transformation_incremental
        {
            get
            {
                return transformation_incremental;
            }

            set
            {
                transformation_incremental = value;
            }
        }

        public string Transformation_statement
        {
            get
            {
                return transformation_statement;
            }

            set
            {
                transformation_statement = value;
            }
        }

        public string Transformation_split_parameter
        {
            get
            {
                return transformation_split_parameter;
            }

            set
            {
                transformation_split_parameter = value;
            }
        }

        public string Transformation_primary_key
        {
            get
            {
                return transformation_primary_key;
            }

            set
            {
                transformation_primary_key = value;
            }
        }

        public string Additional_transformation_split_parameters
        {
            get
            {
                return additional_transformation_split_parameters;
            }

            set
            {
                additional_transformation_split_parameters = value;
            }
        }

        public string Additional_transformation_where_statement
        {
            get
            {
                return additional_transformation_where_statement;
            }

            set
            {
                additional_transformation_where_statement = value;
            }
        }

        public string Additional_transformation_number_of_days
        {
            get
            {
                return additional_transformation_number_of_days;
            }

            set
            {
                additional_transformation_number_of_days = value;
            }
        }

        public string Additional_transformation_number_of_months
        {
            get
            {
                return additional_transformation_number_of_months;
            }

            set
            {
                additional_transformation_number_of_months = value;
            }
        }

        public string Additional_transformation_number_of_years
        {
            get
            {
                return additional_transformation_number_of_years;
            }

            set
            {
                additional_transformation_number_of_years = value;
            }
        }

        public string Transformation_source_folder
        {
            get
            {
                return transformation_source_folder;
            }

            set
            {
                transformation_source_folder = value;
            }
        }

        public string Transformation_source_filename
        {
            get
            {
                return transformation_source_filename;
            }

            set
            {
                transformation_source_filename = value;
            }
        }

        public string Transformation_target_folder
        {
            get
            {
                return transformation_target_folder;
            }

            set
            {
                transformation_target_folder = value;
            }
        }

        public string Transformation_target_filename
        {
            get
            {
                return transformation_target_filename;
            }

            set
            {
                transformation_target_filename = value;
            }
        }

        public static explicit operator transformator_object_id(ListViewItem v)
        {
            return new transformator_object_id(v.SubItems[0].Text.ToString(), v.SubItems[1].Text.ToString(), v.SubItems[2].Text.ToString(), v.SubItems[3].Text.ToString(), v.SubItems[4].Text.ToString(), v.SubItems[5].Text.ToString(), v.SubItems[6].Text.ToString(), v.SubItems[7].Text.ToString(), v.SubItems[8].Text.ToString(), v.SubItems[9].Text.ToString(), v.SubItems[10].Text.ToString(), v.SubItems[11].Text.ToString(), v.SubItems[12].Text.ToString(), v.SubItems[13].Text.ToString(), v.SubItems[14].Text.ToString());
        }

        public static explicit operator transformator_object_id(generator_object_id v)
        {
            string source_filename = "";
            string source_folder = "";
            string target_filename = "";
            string target_folder = "";
            try
            {
                string source_folder_remove_prefix = v.Object_target_extraction_filename.Substring(v.Object_target_extraction_filename.LastIndexOf('\\') + 1);
                if (source_folder_remove_prefix.Contains('$'))
                {
                    source_filename = source_folder_remove_prefix.Substring(0, source_folder_remove_prefix.IndexOf('$')) + '*';
                }
                else
                {
                    source_filename = source_folder_remove_prefix;
                }
                source_folder = "..\\15 - Interface\\" + v.Object_target_extraction_folder + '\\' + v.Object_target_extraction_filename.Substring(0, v.Object_target_extraction_filename.LastIndexOf('\\'));
                target_filename = v.Object_target_extraction_folder;
                target_folder = "..\\15 - Interface\\" + v.Object_target_extraction_folder + "\\90 - CUBES"; 
            }
            catch (Exception e)
            {
                MessageBox.Show("Error converting generator to transformation object \n " + e);
            }

            //string source_folder = v.Object_target_extraction_filename.Substring(v.Object_target_extraction_filename.LastIndexOf('\\')+1);
            return new transformator_object_id(v.Object_name, v.Object_active.ToString(), null, v.Object_transformation_statement, null, v.Object_primary_key, null, null, null, null, null, source_folder, source_filename, target_folder, target_filename);
        }

        public static explicit operator ListViewItem(transformator_object_id v)
        {
            List<string> List_Variables = new List<string>();
            List_Variables.Add(v.transformation_name);
            List_Variables.Add(v.transformation_active);
            List_Variables.Add(v.transformation_incremental);
            List_Variables.Add(v.transformation_statement);
            List_Variables.Add(v.transformation_split_parameter);
            List_Variables.Add(v.transformation_primary_key);
            List_Variables.Add(v.additional_transformation_split_parameters);
            List_Variables.Add(v.additional_transformation_where_statement);
            List_Variables.Add(v.additional_transformation_number_of_days);
            List_Variables.Add(v.additional_transformation_number_of_months);
            List_Variables.Add(v.additional_transformation_number_of_years);
            List_Variables.Add(v.transformation_source_folder);
            List_Variables.Add(v.transformation_source_filename);
            List_Variables.Add(v.transformation_target_folder);
            List_Variables.Add(v.transformation_target_filename);
            return new ListViewItem(List_Variables.ToArray());
        }
    }
}
