using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poker_backend.Database
{
    public class Db
    {
        private string uri = "Data Source="+ Environment.CurrentDirectory + "\\Database\\database.db";

        public void SaveToDatabase(string userName, string gameName)
        {
            using var con = new SQLiteConnection(uri);
            con.Open();
            using var cmd = new SQLiteCommand(con);

            //cmd.CommandText = @"CREATE TABLE games(id INTEGER PRIMARY KEY, user_name TEXT, game_name TEXT)";
            //cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO games(user_name, game_name) VALUES('"+ userName +"','" + gameName + "')";
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
