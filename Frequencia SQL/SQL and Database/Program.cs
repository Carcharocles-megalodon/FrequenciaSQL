using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SQL_and_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "C:/Users/Geral/source/repos/APAI/FrequenciaSQL/Tabelas.sql";
            string[] queries = File.ReadAllText(sql).Split("---");
            RunSQLType(queries);
            string file = "SQLFrequencia.db";
            //mude este string em baixo
            Reader(sql);
            if (!File.Exists(file)) 
            {
                SQLiteConnection.CreateFile(file);
            }
        }

        private static void RunSQLType(string[] queries)
        {

        }
        public static List<string> Reader(string file)
        {
            List<string> lines = new List<string>();

            using StreamReader reader_ = new StreamReader(file);
            while (!reader_.EndOfStream)
            {
                string line = reader_.ReadLine();
                lines.Add(line);
            }

            return lines;
        }
    }
}
