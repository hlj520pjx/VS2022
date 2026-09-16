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
using static AntdUI.Win32;
using static System.Windows.Forms.AxHost;

namespace Book_Car_systeam.Book
{
    public partial class main : Form
    {
        private Mysql mysql = new Mysql("test");
        public main()
        {
            InitializeComponent();
            bookshow();
            table1.CellButtonClick += Table1_CellButtonClick;
        }

        private async void bookshow()
        {
            string sql = "select * from book";
            await mysql.ConHandler(sql, Cmd =>
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                table1.DataSource = dt;
                ShowColumn();//展示修改后的图书表
                return true;
            });
        }
        //****************************************************************************************8
        private void button1_Click(object sender, EventArgs e)
        {
            BookAdd_Edit BE=new BookAdd_Edit("新增");
            BE.Show();
            this.Hide();
            BE.FormClosing += (object? sender, FormClosingEventArgs e)=> { this.Show();bookshow(); };
        }


        //Table按钮点击后调用各种功能函数函数
        private void Table1_CellButtonClick(object sender, AntdUI.TableButtonEventArgs e)
        {

            System.Data.DataRow Bookrow=e.Record as System.Data.DataRow;

            if(e.Btn.Text=="编辑")
            {
                BookAdd_Edit BA = new BookAdd_Edit("编辑", Bookrow["id"].ToString());
                BA.Show();
                this.Hide();
                BA.FormClosing += (object? sender, FormClosingEventArgs e) => { this.Show(); bookshow(); };
            }
            else if(e.Btn.Text=="借阅"|| e.Btn.Text == "归还")
            {
                Return_Borrow(e.Btn.Text, Bookrow["id"].ToString(), Bookrow["is_borrow"].ToString());
            }
            else if( e.Btn.Text=="删除")
            {
                Delete(Bookrow["id"].ToString());
            }
        }

        

        //"1":已借阅  "2":在书架
        private async void Return_Borrow(string Text,string id,string state)
        {
            if(Text=="借阅"&&state=="1")
            {
                MessageBox.Show("图书已借出！！！");
                return;
            }
            else if(Text=="归还"&&state=="2")
            {
                MessageBox.Show("图书已归还！！！");
                return;
            }
            string sq1 = "update book  set  is_borrow=@is_borrow where id=@id";

            await mysql.ConHandler(sq1, Cmd => 
            {
                Cmd.Parameters.AddWithValue("@id",id);
                string isborrow = state == "1" ? "2" : "1";
                Cmd.Parameters.AddWithValue("@is_borrow", isborrow);
                int row=Cmd.ExecuteNonQuery();
                if(row>0)
                {
                    MessageBox.Show(Text+"成功！！！");
                    bookshow();
                }
                else
                {
                    MessageBox.Show(Text + "失败！！！");
                    
                }
                return true;
            });
                
        }
        //删除行函数
        private async void Delete(string id)
        {
            DialogResult Del = AntdUI.Modal.open(new AntdUI.Modal.Config(this, "删除提示", "你确定要删除吗", AntdUI.TType.Warn)
            {
                OkText = "删除"
            });
            if (Del == DialogResult.No) return;

            string sql = "delete from book where id=@id";
            await mysql.ConHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@id",id);
                int row =Cmd.ExecuteNonQuery();
                if(row>0)
                {
                    MessageBox.Show("删除成功！！！");
                    bookshow();
                }
                else
                {
                    MessageBox.Show("删除失败！！！");
                    
                }
                return true;
            });
        }


        //**********************************************************************************************
        //表格单元配置
        private async void ShowColumn()
        {
            table1.Columns.Clear();
            table1.Bordered = true;
            table1.Radius=10;
            table1.Columns = new AntdUI.ColumnCollection()//把列集合传到table1的列属性中
            {
                //Render可以看做是单元格的内容显示器，“=>”箭头指向的内容就是单元格内要显示的内容
                //val：这一格原本的原始数据  cel：单元格对象本身  rowIndex:行下标
                new AntdUI.Column("id","编号"){Render=(object val,object cel,int rowIndex)=> rowIndex+1},////不需要手动填写的就用Render让它自动添加内容
                new AntdUI.Column("name","书名"),
                new AntdUI.Column("author","作者"),
                new AntdUI.Column("price","价格"),
                new AntdUI.Column("label","标签"),
                new AntdUI.Column("is_borrow","借阅"){Render=(object val,object cel,int Index)=> val.ToString()=="1"?"已借阅":"在书架"},
            };

            //给表格添加一个带按钮的操作列
            var HandlerCol = new AntdUI.Column("handler", "操作");
            HandlerCol.SetAlign();//设置列内容的对齐方式，一般默认是居中，让按钮在格子里整齐排列。
            HandlerCol.Render = (object val, object cel, int Index) =>
            {
                var btnarr = new AntdUI.CellLink[]
                {
                    new AntdUI.CellButton("edit","编辑",AntdUI.TTypeMini.Default),
                    new AntdUI.CellButton("delete","删除",AntdUI.TTypeMini.Default),
                };
                return btnarr;
            };
            table1.Columns.Add(HandlerCol);
            //



            var ReBorCol = new AntdUI.Column("resort", "书籍操作");
            ReBorCol.SetAlign();
            ReBorCol.Render = (object val, object cel, int Index) =>
            {
                var ReBorarr = new AntdUI.CellLink[]
                {
                    new AntdUI.CellButton("return","归还",AntdUI.TTypeMini.Default),
                    new AntdUI.CellButton("borrow","借阅",AntdUI.TTypeMini.Default),
                };
                return ReBorarr;
            };
            table1.Columns.Add (ReBorCol);

            /*Render虽然它的类型是委托（Func），但它本质上还是一个变量，Render属性的类型是 Func<object, object, int, object>
            所以它必然有一个返回值，这里有一个隐晦的知识点：当箭头 => 后面直接跟一个值或计算公式（没有 { }包裹时，这个表达式
            的结果自动作为返回值返回给调用方，就不用写return,这也算是lambda语句的简写了*/




        }


    }
}
