using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Car_systeam
{
    internal class mysql
    {
        public string Server { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; } 
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";
        private string Constr { get; set; }

        public mysql(string database)
        {
            this.Database = database;
        }

        public async void ConHander(string sql,Action<MySqlCommand> Mysqlfun)//参数2是一个无返回值、参数类型为MySqlCommand的方法
        {
            Constr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
            using (MySqlConnection myCon= new MySqlConnection(Constr))
            {
               await myCon.OpenAsync();
                using (MySqlCommand myCoMM = new MySqlCommand(sql, myCon))
                {
                   Mysqlfun(myCoMM);
                }
            }
        }
        


    }
}
