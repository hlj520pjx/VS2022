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
    public partial class lunbotu : Form
    {
        private int index = 0;
        private List<Button> list = new();
        private string[] arr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        public lunbotu()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
            Label[] lab = [label1, label2];
            list.AddRange(button1, button2, button3);
            foreach (Button Btn in list) Btn.Click += Btn_Click;
            foreach (Label Lab in lab) Lab.Click += Lab_Click;
            lunbo();

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            index = list.IndexOf(sender as Button);
            lunbo();
            
        }

        private void Lab_Click(object sender, EventArgs e)
        {
            Label labx = (sender as Label);
            if (labx.Text == ">")
            {
                index = (index == arr.Length - 1) ? 0 : ++index;
                lunbo();

            }
            else
            {
                index = (index == 0) ? arr.Length - 1 : --index;
                lunbo();
            }
        }
        private void lunbo()
        {
            pictureBox1.Image = Image.FromFile(arr[index]);
            list.ForEach(btn =>
            {
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.Black;
            });
            list[index].BackColor = Color.Yellow;
            list[index].ForeColor = Color.White;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
