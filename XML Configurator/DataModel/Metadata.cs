using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Configurator.DataModel
{
    static class Metadata
    {
        //public enum OBJECT_LOAD_TYPE
        //{
        //    FULL,
        //    DELTA
        //    //FULL_WITH_DATE,
        //    //FULL_WITH_DATE_HOUR,
        //    //FULL_WITH_TIMESTAMP,
        //    //INCREMENTAL_WITH_DATE,
        //    //INCREMENTAL_WITH_MONTH,
        //    //INCREMENTAL_WITH_YEAR
        //}

        private static string datasource_parameters = @"..\Debug\";

        public static string Datasource_parameters
        {
            get
            {
                return datasource_parameters;
            }

            set
            {
                datasource_parameters = value;
            }
        }
    }
}
