using System;
using System.Windows.Forms;

namespace XML_Configurator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Database db = new Database();
            //db.import_xml_database();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _01_Menu());
            //Application.Run(new Connection());                      //za pravljenje novih konekcija
            //Application.Run(new DatabaseConnector());             //konekcija ka bazi, download tabela i polja
            //Application.Run(new ObjectCreator(null, new DataModel.datasource(), new DatabaseConnector()));             //kreiranje XML-a
            //Application.Run(new ObjectCreator(null));             //kreiranje XML-a
            //Application.Run(new ObjectCreator_NEW(null));             //testiranje dinamickih dodavanja textboxova
            //Application.Run(new ObjectCreator_TEST_SELECT(null));             //testiranje dinamickih dodavanja textboxova
        }
    }
}