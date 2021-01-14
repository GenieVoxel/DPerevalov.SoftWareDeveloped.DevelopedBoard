using System;
using System.Data.SQLite;
using System.IO;

namespace DPerevalov.SoftWareDeveloped.Storage
{
    public class DBOpenCloseBase
    {
        // Объявление (public static)???

        public static string baseName = "CompanyWorkers.db";
        public static string path = Directory.GetCurrentDirectory();
         
        public static void DBOpen()
        {
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
                        "date DATE," +
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
            //Закрыть соединение с БД
            using (SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + path + "/" + baseName + "; Version=3;"))
            {
                ConnectDB.Close();
            }
        }

        public static void DBAdd(string name, string namegroup, int salaryrate, DateTime date, string namesuardinate)
        {
            // Производим запись в БД
            //if (name != "" && namegroup != "" && salaryrate != 0 && namesuardinate != "" )
            //{
                using (SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + path + "/" + baseName + "; Version=3;"))
                {
                    SQLiteCommand CMD = ConnectDB.CreateCommand();
                    CMD.CommandText = "insert into CompanyTable (name, namegroup, salaryrate, date, namesuardinate) values " +
                        "(@Name, @Namegroup, @Salaryrate, @Date, @Namesuardinate)";
                    CMD.Parameters.Add("@Name", System.Data.DbType.String).Value = name.ToUpper();
                    CMD.Parameters.Add("@Namegroup", System.Data.DbType.String).Value = namegroup.ToUpper();
                    CMD.Parameters.Add("@Salaryrate", System.Data.DbType.Int32).Value = salaryrate;
                    CMD.Parameters.Add("@Date", System.Data.DbType.Date).Value = date;
                    CMD.Parameters.Add("@Namesuardinate", System.Data.DbType.String).Value = namesuardinate.ToUpper();
                    CMD.ExecuteNonQuery();
                }
                
            //}
        }

    }
}
