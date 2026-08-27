using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03day
{
    public partial class Form89 : Form
    {
        public Form89()
        {
            InitializeComponent();
            init();
           
        }

        private void init()
        {
            textBox1.KeyUp += textBox1_KeyUp;
            textBox1.KeyPress += textBox1_KeyPress;
            this.KeyDown += KeyTest_KeyDown;//要想实现ESC键退出必须清空窗体的控件

        }

        //弹出文本框的文本弹窗
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(textBox1.Text, "O(∩_∩)O哈哈~");
            }
           
        }
        //拦截除了数字的输入
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!(e.KeyChar>='0'&& e.KeyChar <= '9'))
            {
                e.Handled = true;
            }
            

        }
        //按下ESC键关闭窗口
        private void KeyTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        
    }
}
