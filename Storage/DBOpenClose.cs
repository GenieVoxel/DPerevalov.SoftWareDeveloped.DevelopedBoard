using System;
using System.Data.SQLite;
using System.IO;

namespace DPerevalov.SoftWareDeveloped.Storage
{
    //string baseName = "CompanyWorkers.db";
    public class DBOpenCloseBase
    {
        
        private SQLiteConnection connectBD;
        public static void DBOpen()
        {
            string baseName = "CompanyWorkers.db";
            string path = Directory.GetCurrentDirectory();
            // если базы данных нету, то создаем
            if (!File.Exists(@path + "/" + baseName))
            {
                // создать БД, по указанному пути содаётся пустой файл базы данных
                SQLiteConnection.CreateFile(@baseName);

                // создаем таблицу БД
                // в строке указывается к какой базе подключаемся
                using (SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + path + "/" + baseName + "; Version=3;"))
                {
                    // строка запроса, который надо будет выполнить
                    // и создать таблицу, если её нет
                    string commandText = "CREATE TABLE CompanyTable" +
                        "(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "name VARCHAR(20)," +
                        "namegroup VARCHAR(10)," +
                        "salaryrate INTEGER," +
                        "date DATA," +
                        "namesubordination VARCHAR(20)," +
                        "namesubordinate VARCHAR(20))";
                    SQLiteCommand Command = new SQLiteCommand(commandText, ConnectDB);
                    // открыть соединение с БД
                    ConnectDB.Open();
                    // выполнить запрос
                    Command.ExecuteNonQuery();
                }

            }
        }

        public static void DBClose()
        {
            string baseName = "CompanyWorkers.db";
            string path = Directory.GetCurrentDirectory();
            //Закрыть соединение с БД
            using (SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + path + "/" + baseName + "; Version=3;"))
            {
                ConnectDB.Close();
            }
        }

    }
}
