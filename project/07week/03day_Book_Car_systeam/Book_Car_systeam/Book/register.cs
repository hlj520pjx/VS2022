using AntdUI;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Car_systeam.Book
{
    public partial class register : Form
    {
        private Mysql mysql=new Mysql("test");
        public register()
        {
            InitializeComponent();
            inputNumber1.Minimum = 20;
            inputNumber1.Maximum = 120;
            select1.Items = ["01班", "02班", "03班", "04班"];
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username=input1.Text.Trim();
            if(!Regex.IsMatch(username,@"^[a-zA-Z0-9]{4,15}$"))
            {
                MessageBox.Show("用户名有误！！！");
                return;
            }


            string pwd=input2.Text.Trim();
            if(pwd.Length <6||pwd.Length>15 )
            {
                MessageBox.Show("密码格式错误！！！");
                return;
            }
            if(pwd!=input3.Text.Trim())
            {
                MessageBox.Show("两次密码不一致！！！");
                return;
            }

            int age=(int)inputNumber1.Value;
            string gender = radioButton1.Checked ? "男" : "女";
            if(select1.SelectedValue==null)
            {
                MessageBox.Show("班级未选择！！！");
                return;
            }

            string banji=select1.SelectedValue.ToString();

            //判断是否已经注册
            string sql = "select * from user where username=@username";
            bool isname = await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader=Cmd.ExecuteReader();
                bool istrue=reader.Read();
                if (istrue) return false;
                return true;
            });

            if(!isname)
            {
                MessageBox.Show("用户已存在！！！");
                return;
            }


            string Sql = "insert into user(username,password,age,gender,banji) value(@username,@password,@age,@gender,@banji)";

            await mysql.ConHandler(Sql, Cmd =>
             {
                 Cmd.Parameters.AddWithValue("@username", username);
                 Cmd.Parameters.AddWithValue("@password", pwd);
                 Cmd.Parameters.AddWithValue("@age", age);
                 Cmd.Parameters.AddWithValue("@gender", gender);
                 Cmd.Parameters.AddWithValue("@banji", banji);
                 
                 int row = Cmd.ExecuteNonQuery();
                 if(row>0)
                 {
                     MessageBox.Show("注册成功！！！");
                     this.Close();
                 }
                 else
                 {
                     MessageBox.Show("注册失败，请重试！！！");
                 }

                  return true;
             });

            











        }
    }
}
