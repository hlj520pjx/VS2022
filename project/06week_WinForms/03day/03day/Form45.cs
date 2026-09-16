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

namespace _03day
{
    public partial class Form45 : Form
    {
        public Form45()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            textBox1.Leave += textBox1_Leave;
            textBox1.GotFocus += textBox1_Gotfocus;

            textBox2.Leave += textBox2_Leave;
            textBox2.GotFocus += textBox2_Gotfocus;

            button1.Leave += button1_Leave;
            button1.GotFocus += button1_GotFocus;
        }

        private void textBox1_Gotfocus(object sender, EventArgs e)
        {
            labF.Visible = false;
            labT.Visible = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string con = (sender as TextBox).Text;
            if (Regex.IsMatch(con, @"1[1-9]\d{9}"))
            {
                labT.Visible = true;
            }
            else
            {
                labF.Visible = true;
            }
        }

        private void textBox2_Gotfocus(object sender, EventArgs e)
        {
            TextBox tb= sender as TextBox;
            tb.BackColor = Color.Yellow;
            tb.ForeColor = Color.White;
            tb.BorderStyle = BorderStyle.Fixed3D;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.BackColor = Color.White;
            tb.ForeColor = Color.Black;
            tb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            
        }

        private void button1_GotFocus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Yellow;
            btn.ForeColor = Color.Blue;
            
        }


    }
}
