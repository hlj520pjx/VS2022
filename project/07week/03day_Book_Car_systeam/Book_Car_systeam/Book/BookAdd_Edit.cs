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
    public partial class BookAdd_Edit : Form
    {
        private string Title { get; set; }
        private string Id { get; set; }

        private Mysql mysql = new Mysql("test");
        public BookAdd_Edit()
        {
            InitializeComponent();
        }

        //重载构造函数（新增）
        public BookAdd_Edit(string title)
        {
            InitializeComponent();
            this.Title = title;
            button1.Text = title;
            label1.Text = "图书" + title;
        }

        //重载构造函数（编辑）
        public BookAdd_Edit(string title, string id)
        {
            InitializeComponent();
            this.Title = title;
            button1.Text = title;
            label1.Text = "图书" + title;
            this.Id = id;

            datashow();//数据回显
        }

        //编辑回显
        private async void datashow()
        {
            string sql = "select * from book where id=@id";
            await mysql.ConHandler(sql, Cmd => 
            {
                Cmd.Parameters.AddWithValue("@id", Id);

                MySqlDataReader reader=Cmd.ExecuteReader();
                bool isread=reader.Read();
                if(!isread)
                {
                    MessageBox.Show("图书不存在！！！");
                    this.Close();
                    return false;
                }
                input1.Text = reader.GetString("name");
                input2.Text = reader.GetString("author");
                inputNumber1.Value = reader.GetDecimal("price");
                input3.Text = reader.GetString("label").Replace("|","\n");

                return true;
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Name=input1.Text;
            string Author=input2.Text;
            double Price=double.Parse(inputNumber1.Text);
            string Label=input3.Text;

            string sql = "";
            if(this.Title=="新增")
            {
                sql = "insert into book(name,author,price,label) value(@name,@author,@price,@label)";
            }
            else
            {
                sql = "update book set name=@name,author=@author,price=@price,label=@label where id=@id";
            }

            await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@name", Name);
                Cmd.Parameters.AddWithValue("@author", Author);
                Cmd.Parameters.AddWithValue("@price", Price);
                Cmd.Parameters.AddWithValue("@label", Label);
                if(this.Title=="编辑") Cmd.Parameters.AddWithValue("@id", Id);

                int row=Cmd.ExecuteNonQuery();
                if(row>0)
                {
                    MessageBox.Show(this.Title+"成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this.Title + "失败");
                    
                }
                return true;

            });
        }
    }
}
