using System;
using System.Data.SQLite;
using System.IO;

namespace DPerevalov.SoftWareDeveloped.Storage
{
    public class DBOpenCloseBase
    {

        // Метод для проверки и создания БД и таблицы
        public static void DBOpen()
        {
            SQLiteConnection baseConnect;
            SQLiteCommand baseCmd;
            String baseName = "CompanyWorkers.db";

            baseConnect = new SQLiteConnection();
            baseCmd = new SQLiteCommand();

            if (!File.Exists(baseName))
            {
                //Создаем БД
                SQLiteConnection.CreateFile(@baseName);

                //Создаем таблицу
                // в строке указывается к какой базе подключаемся
                using (SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + baseName + "; Version=3;"))
                {
                    // Создаем пустую таблицу
                    string commandText = "CREATE TABLE CompanyTable" +
                        "(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "name TEXT," +
                        "namegroup TEXT," +
                        "salaryrate TEXT," +
                        "date TEXT," +
                        "namesubordination TEXT," +
                        "namesubordinate TEXT)";
                    SQLiteCommand Command = new SQLiteCommand(commandText, ConnectDB);

                    // открыть соединение с БД
                    ConnectDB.Open();

                    // выполнить запрос
                    Command.ExecuteNonQuery();

                    // Закрыть БД
                    baseConnect.Close();
                }
            }
        }

        public static void DBClose()
        {
            //
        }

        // Метод для записи в БД
        public static void DBAdd(string name, string namegroup, string salaryrate, string date, string namesubordinate)
        {
            SQLiteConnection baseConnect;
            SQLiteCommand baseCmd;
            String baseName = "CompanyWorkers.db";
            String namesubordination = "";

            baseConnect = new SQLiteConnection();
            baseCmd = new SQLiteCommand();

            // Открыть БД
            // Открыть таблицу
            SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + baseName + "; Version=3;");
            baseConnect = new SQLiteConnection("Data Source=" + baseName + ";Version=3;");

            baseConnect.Open();
            baseCmd.Connection = baseConnect;

            // Записать данные
            baseCmd.CommandText = "INSERT INTO CompanyTable (name, namegroup, salaryrate, date, namesubordination, namesubordinate) " +
                            "VALUES ('" + name + "' , '" + namegroup + "' , '" + salaryrate + "' , '" + date + "' , '"
                            + namesubordination + "' , '" + namesubordinate + "')";
            baseCmd.ExecuteNonQuery();

            // Закрыть БД
            baseConnect.Close();
        }

        // Метод для редактирования
        public static void DBEdit(int id, string name, string namegroup, string salaryrate, string date, string namesubordinate)
        {
            //
        }
    }
}
