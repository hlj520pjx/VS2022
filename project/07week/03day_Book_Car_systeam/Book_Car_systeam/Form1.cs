using Book_Car_systeam.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Car_systeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AntdUI.Config.ShowInWindow = true;
            登录状态ToolStripMenuItem.Text = "未登录";
            退出ToolStripMenuItem.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (登录状态ToolStripMenuItem.Text == "已登录")
            {
                main MA = new main();
                MA.Show();
                this.Hide();
                MA.FormClosing += (object? sender, FormClosingEventArgs e)=> this.Show();
            }
            else
            {
                AntdUI.Message.warn(this, "未登录，请在左上角登录或注册！！！", autoClose: 1);
            }
        }


        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
            lg.LoginMark += Lg_LoginMark;
            lg.FormClosing += (object? sender, FormClosingEventArgs e)=>this.Show();
        }

        private void Lg_LoginMark(string obj)
        {
            登录状态ToolStripMenuItem.Text=obj;
            if(obj=="已登录")
            {
                
                登录ToolStripMenuItem.Visible= false;
                退出ToolStripMenuItem.Visible=true;
            }
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register rg = new register();
            rg.Show();
            this.Hide();
            rg.FormClosing += (object? sender, FormClosingEventArgs e) => this.Show();
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            登录状态ToolStripMenuItem.Text = "未登录";
            登录ToolStripMenuItem.Visible = true;
            退出ToolStripMenuItem.Visible=false;
            MessageBox.Show("退出成功！！！");
        }
    }
}
