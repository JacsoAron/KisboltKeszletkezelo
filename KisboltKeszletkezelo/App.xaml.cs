using System.Configuration;
using System.Data;
using System.Windows;

namespace KisboltKeszletkezelo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string database = "kisbolt.db";
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string databasePath = System.IO.Path.Combine(path, database);
    }

}
