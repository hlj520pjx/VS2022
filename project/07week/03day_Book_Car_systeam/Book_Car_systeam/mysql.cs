using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Car_systeam
{
    internal class Mysql
    {
        public string Server { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; }
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";

        private string ConnStr { get; set; }

        public Mysql(string database)
        {
            this.Database = database;
        }

        public async Task<bool> ConHandler(string sql,Func<MySqlCommand,bool>Handler)
        {
            ConnStr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
            using (MySqlConnection Connection=new MySqlConnection(ConnStr))
            {
                await Connection.OpenAsync();
                using (MySqlCommand Cmd=new MySqlCommand(sql, Connection))
                {
                    return Handler(Cmd);
                }
            }
        }
    }
}
