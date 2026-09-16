using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            init();
        }
        public string[] adr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        public void init()
        {
            pictureBox1.Image = Image.FromFile(adr[0]);
            tableLayoutPanel1.Controls[0].BackColor = Color.Yellow;
            tableLayoutPanel1.Controls[0].ForeColor = Color.Blue;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tableLayoutPanel1.Controls[i].Click+= button_Click;
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tableLayoutPanel1.Controls[i].BackColor = Color.DarkGray;
                tableLayoutPanel1.Controls[i].ForeColor = Color.White;
            }
            Button btn = (Button)sender;
            btn.BackColor= Color.Yellow;
            btn.ForeColor= Color.Blue;
            int index= tableLayoutPanel1.Controls.IndexOf(btn);
            pictureBox1.Image = Image.FromFile(adr[index]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
