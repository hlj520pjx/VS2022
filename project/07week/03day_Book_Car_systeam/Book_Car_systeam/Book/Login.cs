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

namespace Book_Car_systeam.Book
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Mysql mysql = new Mysql("test");
        public event Action<string> LoginMark;

        private async void button1_Click(object sender, EventArgs e)
        {
            string Name = input1.Text;
            string pwd = input2.Text;
            if (Name.Trim() == "" | pwd.Trim() == "")
            {
                MessageBox.Show("用户密码不能为空！！！");
                return;
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("请勾选二刺猿协议！！！");
                return;

            }

            string sql = "select * from user where username=@username and password=@password";
            await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@username", Name);
                Cmd.Parameters.AddWithValue("@password", pwd);

                MySqlDataReader Reader = Cmd.ExecuteReader();
                bool isLogin = Reader.Read();
                if (isLogin)
                {
                    MessageBox.Show("登陆成功！！！");
                    LoginMark.Invoke("已登录");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登陆失败！！！");
                    LoginMark.Invoke("未登录");
                    this.Close();
                }

                return true;

            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register rg = new register();
            rg.Show();
            this.Hide();
            rg.FormClosing += (object? sender, FormClosingEventArgs e) => this.Show();

        }
    }
}
