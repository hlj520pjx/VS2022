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
    public partial class Form67 : Form
    {
        public Form67()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            comboBox1.Leave += comboBox1_Leave;
            comboBox1.GotFocus += comboBox1_GotFocus;

            textBox2.Leave += textBox2_Leave;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = false;
        }
        private void comboBox1_GotFocus(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb2 = (sender as TextBox);
            string con = tb2.Text;
            if(!string.IsNullOrEmpty(con)) label1.Visible=false;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox tb2 = (sender as TextBox);
            string con = tb2.Text;
            if (string.IsNullOrEmpty(con))
            {
                tb2.Focus();
                label1.Visible = true;
            }
        }
    }
}
