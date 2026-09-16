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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private Mysql mysql = new Mysql("test");
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = input1.Text;
            string idcard = input2.Text;
            string reg_time =DateTime.Now.ToString();
            string gender = input3.Text;
            string tel = input4.Text;
            string motoo = input5.Text;

            string sql = "insert into user_info(name,id_card,reg_time,gender,tel,motto) value(@name,@id_card,@reg_time,@gender,@tel,@motto)";

            await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@name", name);
                Cmd.Parameters.AddWithValue("@id_card", idcard);
                Cmd.Parameters.AddWithValue("@reg_time", reg_time);
                Cmd.Parameters.AddWithValue("@gender", gender);
                Cmd.Parameters.AddWithValue("@tel", tel);
                Cmd.Parameters.AddWithValue("@motto", motoo);


                int row = Cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("新增成功");
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
