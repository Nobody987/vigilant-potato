using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_Configurator.DatabaseConnect;

namespace XML_Configurator
{
    class ConnectionString
    {
        List<string> list_of_parametars;

        public override string ToString()
        {
            return list_of_parametars.ToString();
        }
    }
}