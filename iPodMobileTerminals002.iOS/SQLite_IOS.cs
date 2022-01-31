using System;
using System.IO;
using iPodMobileTerminals002.iOS;
using iPodMobileTerminals002.Models;
using SQLite;
using Xamarin.Forms;

/*[assembly:Dependency(typeof(SQLite_IOS))]
namespace iPodMobileTerminals002.iOS
{
    class SQLite_IOS : ISQLite
    {
        SQLiteConnection con;

        public SQLiteConnection GetConnectionWithCreateDatabase()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            SQLiteConnection database = new SQLiteConnection(path);
            database.CreateTable<MajorCategory>();
            return database;
        }

    }
}*/
