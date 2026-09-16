using AntdUI;
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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }
        private Mysql mysql = new Mysql("test");
        private async void button1_Click(object sender, EventArgs e)
        {
            string card = input1.Text;
            string Type = input2.Text;
            string Price= input3.Text;

            string sql = "insert into car(card,type,status,price) value(@card,@type,@status,@price)";
            
            await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@card", card);
                Cmd.Parameters.AddWithValue("@type", Type);
                Cmd.Parameters.AddWithValue("@status", 1);
                Cmd.Parameters.AddWithValue("@price", Price);
                

                int row = Cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show( "新增成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增失败");

                }
                return true;

            });
        }
    }
}
