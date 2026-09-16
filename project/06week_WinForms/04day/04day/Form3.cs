using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04day
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            textBox1.TextChanged += textBox1_TextChanged;

            textBox2.TextChanged += TextBox2_TextChanged;
        }

        private void TextBox2_TextChanged(object? sender, EventArgs e)
        {
            TextBox tb=sender as TextBox;
            string res=tb.Text;
            res=res.ToUpper();
            tb.Text=res;
            tb.SelectionStart=res.Length;
        }

        //千分位分割
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb =sender as TextBox;
            string con = tb.Text;

            if(string.IsNullOrEmpty(con) ) return;

            con = con.Replace(",","");
            int res=int.Parse(con);
            string str=res.ToString("#,#");
            tb.Text = str;
            tb.SelectionStart = str.Length;
        }
    }
}
