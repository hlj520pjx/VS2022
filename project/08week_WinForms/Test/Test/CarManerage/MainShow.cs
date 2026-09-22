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
    public partial class MainShow : Form
    {
        private Mysql mysql = new Mysql("test");
        public MainShow()
        {
            InitializeComponent();
            carshow();
            table1.CellButtonClick += Table1_CellButtonClick;
            
        }

        private void Table1_CellButtonClick(object sender, AntdUI.TableButtonEventArgs e)
        {
            System.Data.DataRow Bookrow = e.Record as System.Data.DataRow;

            Borrow_Return borrow_Return = new Borrow_Return(Bookrow["id"].ToString());
            borrow_Return.Show();
        }

        private async void carshow()
        {
            string sql = "select * from car";
            await mysql.ConHandler(sql, Cmd =>
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                carShowColumn();
                table1.DataSource = dt;
                return true;
            });
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Show();
            this.Hide();
            car.FormClosing += (object? sender, FormClosingEventArgs e) => this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
            user.FormClosing += (object? sender, FormClosingEventArgs e) => this.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();



        }

        private async void button4_Click(object sender, EventArgs e)
        {
            
        }

        private async void carShowColumn()
        {
            table1.Columns.Clear();
            table1.Bordered = true;
            table1.Radius = 10;
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号"){Render=(object val,object cel,int rowIndex)=> rowIndex+1},
                new AntdUI.Column("card","车牌号"),
                new AntdUI.Column("type","车辆类型"),
                new AntdUI.Column("status","车辆状态"){Render=(object val,object cel,int Index)=> val.ToString()=="1"?"未出租":"已出租"},
                new AntdUI.Column("price","车辆小时收费"),
                
            };

            var HandlerCol = new AntdUI.Column("handler", "操作");
            HandlerCol.SetAlign();
            HandlerCol.Render = (object val, object cel, int Index) =>
            {
                var btnarr = new AntdUI.CellLink[]
                {
                    new AntdUI.CellButton("zuche","租车",AntdUI.TTypeMini.Default),
                    new AntdUI.CellButton("huanche","还车",AntdUI.TTypeMini.Default),
                };
                return btnarr;
            };
            table1.Columns.Add(HandlerCol);

           


        }
    }
}
