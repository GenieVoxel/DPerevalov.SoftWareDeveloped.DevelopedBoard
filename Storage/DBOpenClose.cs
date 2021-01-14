using System;
using System.Data.SQLite;
using System.IO;

namespace DPerevalov.SoftWareDeveloped.Storage
{
    public class DBOpen
    {
        public DBOpen()
        {
            string baseName = "CompanyWorkers.db";
        // если базы данных нету, то создаем
            if (!File.Exists(baseName))
            {
            // создать базу данных, по указанному пути содаётся пустой файл базы данных
            SQLiteConnection.CreateFile(baseName);
            }

         }
    }
}
