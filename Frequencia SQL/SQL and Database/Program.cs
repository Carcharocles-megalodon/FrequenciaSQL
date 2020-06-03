using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.SQLite;

namespace SQL_and_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            RunIDbType(queries);
        }

        private static void RunIDbType(string[] queries)
        {
            using SqliteConnection connection = new SqliteConnection();
        }
    }
}
