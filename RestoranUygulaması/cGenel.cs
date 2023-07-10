using DevExpress.ClipboardSource.SpreadsheetML;

namespace RestoranUygulaması
{
    internal class cGenel
    {
       // public string constring = ("Data Source=.\\SQLEXPRESS;Initial Catalog = Restoran; Integrated Security = True");
        public string constring=System.IO.File.ReadAllText(@"C:\Adres.txt");

        public static string ButtonValue;
        public static string ButtonName;
    }
}
