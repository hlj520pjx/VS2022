using AntdUI;
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
    public partial class Borrow_Return : Form
    {
        private Mysql mysql = new Mysql("test");
        private string Id { get; set; }
        public Borrow_Return()
        {
            InitializeComponent();
            datashow();

        }
        public Borrow_Return(string id)
        {
            InitializeComponent();
            this.Id = id;
            datashow();
            selectData();

        }

        private async Task datashow()
        {
            string sql = "select * from car where id=@id";
            await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@id", Id);

                MySqlDataReader reader = Cmd.ExecuteReader();
                bool isread = reader.Read();
                if (!isread)
                {
                    MessageBox.Show("车辆不存在！！！");
                    this.Close();
                    return false;
                }

                input1.Text = reader.GetString("card");
                input2.Text = reader.GetString("type");


                return true;
            });
        }

        private async Task selectData()
        {
            string sql = "select id, name from user_info";

            await mysql.ConHandler(sql, Cmd =>
            {
                MySqlDataReader reader = Cmd.ExecuteReader();

                select1.Items.Clear();
                while (reader.Read())
                {
                    string name = reader.GetString("name");
                    int id = reader.GetInt32("id");

                    select1.Items.Add(new AntdUI.SelectItem(name, id));
                }
                return true;
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (select1.SelectedValue == null)
            {
                MessageBox.Show("请先选择租车客户！", "提示");
                return;
            }
        }
    }
}
