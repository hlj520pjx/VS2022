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

namespace _04day
{
    public partial class Form2 : Form
    {
        private int maxlength = 10;
        private string[] arr = ["1111", "2222", "3333", "112233", "113322", "332211"];
        
        public Form2()
        {
            InitializeComponent();
            init();
            
        }

        private void init()
        {
            textBox1.TextChanged += textBox1_TextChanged;

            textBox2.TextChanged += TextBox2_TextChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            listBox1.Items.AddRange(arr);

            textBox3.TextChanged += TextBox3_TextChanged;

        }
        //密码强度检测
        private void TextBox3_TextChanged(object? sender, EventArgs e)
        {
            string res = (sender as TextBox).Text;
            int num = 0;
            if (Regex.IsMatch(res, @"\d")) num++;
            if (Regex.IsMatch(res, @"[a-z]")) num++;
            if (Regex.IsMatch(res, @"[A-Z]")) num++;
            if (num == 1)
            {
                label6.Text = "弱";
                label6.ForeColor = Color.Red;
            }
            else if (num == 2)
            {
                label6.Text = "中";
                label6.ForeColor = Color.Blue;
            }
            else if (num == 3)
            {
                label6.Text = "强";
                label6.ForeColor = Color.Green;
            }
            else label6.Text = "请重新输入！！！";
            if(textBox3.Text.Length == 0)
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }   
            

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selpan.Text = listBox1.SelectedItem.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string keywords = tb.Text;
            List<string> list = arr.ToList().FindAll(item => item.Contains(keywords));
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.ToArray());
        }

        //限制输入个数
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb =sender as TextBox;
            if(textBox1.Text.Length >= maxlength)
            {
                label2.Visible = true;
                string con = textBox1.Text.Substring(0, maxlength);
                tb.Text = con;
                textBox1.SelectionStart = maxlength;

            }
            else
            {
                label2.Visible = false;
            }
        }







    }
}
