using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XML_Configurator.DataModel
{
    class aggregationObject
    {
        public string aggregation_name { get; set; }
        public string aggregation_active { get; set; }
        public string aggregation_incremental { get; set; }
        public string aggregation_by_year { get; set; }
        public string aggregation_by_month { get; set; }
        public string aggregation_by_week { get; set; }
        public string aggregation_by_day { get; set; }
        public string aggregation_number_of_months { get; set; }
        public string aggregation_by_procedure { get; set; }
        public string aggregation_select_statement { get; set; }
        public string aggregation_where_statement { get; set; }
        public string aggregation_primary_key { get; set; }
        public string aggregation_concatenation_statement { get; set; }
        public string aggregation_source_folder { get; set; }
        public string aggregation_source_filename { get; set; }
        public string aggregation_target_folder { get; set; }
        public string aggregation_target_filename { get; set; }

        public aggregationObject()
        {

        }

        public aggregationObject(string aggregation_name, string aggregation_active, string aggregation_incremental, string aggregation_by_year, string aggregation_by_month, string aggregation_by_week, string aggregation_by_day, string aggregation_number_of_months, string aggregation_by_procedure, string aggregation_select_statement, string aggregation_where_statement, string aggregation_primary_key, string aggregation_concatenation_statement, string aggregation_source_folder, string aggregation_source_filename, string aggregation_target_folder, string aggregation_target_filename)
        {
            this.aggregation_name = aggregation_name;
            this.aggregation_active = aggregation_active;
            this.aggregation_incremental = aggregation_incremental;
            this.aggregation_by_year = aggregation_by_year;
            this.aggregation_by_month = aggregation_by_month;
            this.aggregation_by_week = aggregation_by_week;
            this.aggregation_by_day = aggregation_by_day;
            this.aggregation_number_of_months = aggregation_number_of_months;
            this.aggregation_by_procedure = aggregation_by_procedure;
            this.aggregation_select_statement = aggregation_select_statement;
            this.aggregation_where_statement = aggregation_where_statement;
            this.aggregation_primary_key = aggregation_primary_key;
            this.aggregation_concatenation_statement = aggregation_concatenation_statement;
            this.aggregation_source_folder = aggregation_source_folder;
            this.aggregation_source_filename = aggregation_source_filename;
            this.aggregation_target_folder = aggregation_target_folder;
            this.aggregation_target_filename = aggregation_target_filename;
        }

        public override string ToString()
        {
            return aggregation_name;
        }

        public static explicit operator aggregationObject(ListViewItem v)
        {
            return new aggregationObject(v.SubItems[0].Text.ToString(), v.SubItems[1].Text.ToString(), v.SubItems[2].Text.ToString(), v.SubItems[3].Text.ToString(), v.SubItems[4].Text.ToString(), v.SubItems[5].Text.ToString(), v.SubItems[6].Text.ToString(), v.SubItems[7].Text.ToString(), v.SubItems[8].Text.ToString(), v.SubItems[9].Text.ToString(), v.SubItems[10].Text.ToString(), v.SubItems[11].Text.ToString(), v.SubItems[12].Text.ToString(), v.SubItems[13].Text.ToString(), v.SubItems[14].Text.ToString(), v.SubItems[15].Text.ToString(), v.SubItems[16].Text.ToString());
        }

        public static explicit operator aggregationObject(transformationObject v)
        {
            try
            {
                string source_filename = v.Transformation_target_filename;
                string source_folder = v.Transformation_target_folder;
                string target_filename = v.Transformation_name + "_$(vCurrentParam)";
                string target_folder = "..\\35 - QVD Aggregated";
                return new aggregationObject(v.Transformation_name, v.Transformation_active, "N", "N", "N", "N", "N", "0", null, "*", "", v.Transformation_primary_key, "", source_folder, source_filename, target_folder, target_filename);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error converting transformation to aggregation object \n " + e);
                return new aggregationObject();
            }

            //string source_folder = v.Object_target_extraction_filename.Substring(v.Object_target_extraction_filename.LastIndexOf('\\')+1);
        }

        public static explicit operator ListViewItem(aggregationObject v)
        {
            List<string> List_Variables = new List<string>();
            List_Variables.Add(v.aggregation_name);
            List_Variables.Add(v.aggregation_active);
            List_Variables.Add(v.aggregation_incremental);
            List_Variables.Add(v.aggregation_by_year);
            List_Variables.Add(v.aggregation_by_month);
            List_Variables.Add(v.aggregation_by_week);
            List_Variables.Add(v.aggregation_by_day);
            List_Variables.Add(v.aggregation_number_of_months);
            List_Variables.Add(v.aggregation_by_procedure);
            List_Variables.Add(v.aggregation_select_statement);
            List_Variables.Add(v.aggregation_where_statement);
            List_Variables.Add(v.aggregation_primary_key);
            List_Variables.Add(v.aggregation_concatenation_statement);
            List_Variables.Add(v.aggregation_source_folder);
            List_Variables.Add(v.aggregation_source_filename);
            List_Variables.Add(v.aggregation_target_folder);
            List_Variables.Add(v.aggregation_target_filename);
            return new ListViewItem(List_Variables.ToArray());
        }
    }
}
