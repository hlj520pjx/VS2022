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

namespace _07week02day
{
    public partial class mysql : Form
    {
        private string ConnStr = "server=127.0.0.1;port=3306;database=9_1test;uid=root;pwd=root;charset=utf8";
        public mysql()
        {
            InitializeComponent();
            Fun();
        }

        //条件查询
        private void button1_Click(object sender, EventArgs e)
        {
            string res = input1.Text;

            //建立MySQL链接
            using (MySqlConnection MysqlConn = new MySqlConnection(ConnStr))
            {
                //打开链接
                MysqlConn.Open();
                //编写MySQL语句
                string sql = "select * from user where username=@username";

                using (MySqlCommand Conn = new MySqlCommand(sql, MysqlConn))
                {
                    //给语句填充参数
                    Conn.Parameters.AddWithValue("@username", res);

                    //需要展示在窗体上就写，更改数据库不用写
                    //*****************************************************************
                    MySqlDataAdapter ada = new MySqlDataAdapter(Conn);

                    DataTable dt = new DataTable();

                    ada.Fill(dt);

                    dataGridView1.DataSource = dt;
                    //*****************************************************************
                }

            }
        }

        //聚合查询
        private void button2_Click(object sender, EventArgs e)
        {
            //建立MySQL链接
            using (MySqlConnection MysqlConn = new MySqlConnection(ConnStr))
            {
                //打开链接
                MysqlConn.Open();
                //编写MySQL语句
                //string sql = "select count(*) from user ";
                //string sql = "select count(*) from user where gender='女'";
                string sql = "select * from user where id=1000";

                using (MySqlCommand Conn = new MySqlCommand(sql, MysqlConn))
                {
                    //给语句填充参数
                    //Conn.Parameters.AddWithValue("@username", res);

                    //ExecuteScalar:获得聚合查询的结果
                    //Object res = Conn.ExecuteScalar();
                    //label2.Text = res.ToString();

                    //读取获得的结果
                    MySqlDataReader read = Conn.ExecuteReader();

                    bool abc = read.Read();
                    label2.Text = abc.ToString();
                }

            }
        }
        //增删改
        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection MysqlConn = new MySqlConnection(ConnStr))
            {
                MysqlConn.Open();
                //string sql = "delete set user gender='女'，age=18 where id=between 1 and 3";
                string Sql = "update user set gender='男',age=age+1 where id = 1";

                using (MySqlCommand con = new MySqlCommand(Sql, MysqlConn))
                {
                    //检测有多少行更新
                    int row = con.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("成功");
                    }
                    else
                    {
                        MessageBox.Show("失败");
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Fun();
        }



        private void Fun()
        {
            //接入数据库，把表中的信息提取出来
            using (MySqlConnection MysqlConn = new MySqlConnection(ConnStr))
            {
                MysqlConn.Open();

                string sql = "select * from user";

                using (MySqlCommand Conn = new MySqlCommand(sql, MysqlConn))
                {
                    MySqlDataAdapter ada = new MySqlDataAdapter(Conn);

                    DataTable dt = new DataTable();

                    ada.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }
        }

        
    }
}
