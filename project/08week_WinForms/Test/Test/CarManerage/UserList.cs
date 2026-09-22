using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.CarManerage
{
    public partial class UserList : Form
    {
        private Mysql mysql = new Mysql("test");
        public UserList()
        {
            InitializeComponent();
            usershow();
        }
        private async void usershow()
        {
            string sql = "select * from user_info";
            await mysql.ConHandler(sql, Cmd =>
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                userShowColumn();
                table1.DataSource = dt;
                return true;
            });
        }

        private async void userShowColumn()
        {
            table1.Columns.Clear();
            table1.Bordered = true;
            table1.Radius = 10;
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号"){Render=(object val,object cel,int rowIndex)=> rowIndex+1},
                new AntdUI.Column("name","姓名"),
                new AntdUI.Column("id_card","身份证"),
                new AntdUI.Column("reg_time","注册时间"),
                new AntdUI.Column("gender","性别"),
                new AntdUI.Column("tel","电话号码"),
                new AntdUI.Column("motto","座右铭"),

            };

            


        }
    }
}
