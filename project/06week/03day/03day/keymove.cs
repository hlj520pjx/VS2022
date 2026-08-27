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
    public partial class keymove : Form
    {
        private int speed = 15;
        private DateTime StartTime { get; set; }
        private bool flag = true;
        private int n = 0;
        public keymove()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            this.KeyDown += Keymove_KeyDown;
            this.KeyUp += Keymove_KeyUp;
        }

        private void Keymove_KeyUp(object sender, KeyEventArgs e)
        {
            flag = true;
            DateTime Endtime= DateTime.Now;
            TimeSpan res = Endtime - StartTime;
            label3.Text = res.TotalMilliseconds.ToString();
            label1.Text = n.ToString();
        }

        private void Keymove_KeyDown(object sender, KeyEventArgs e)
        {
            if(flag==true)
            {
                n++;
                StartTime = DateTime.Now;
                flag = false;   
            }

            Point bl = panel1.Location;

            int height=this.Height;
            int width=this.Width;

            int panHeight=panel1.Height;
            int panWidth=panel1.Width;

            int xMax = width - panWidth;
            int yMax = height - panHeight;

            switch(e.KeyCode)
            {
                case Keys.W:
                    bl.Y-=speed;
                    if(bl.Y <= 0 )bl.Y = 0;
                    break;
                case Keys.S:
                    bl.Y += speed;
                    if (bl.Y >= yMax) bl.Y = yMax;
                    break;
                case Keys.A:
                    bl.X -= speed;
                    if (bl.X <= 0) bl.X = 0;
                    break;
                case Keys.D:
                    bl.X += speed;
                    if (bl.X >= xMax) bl.X = xMax;
                    break;
            }
            panel1.Location = bl;


        }

       
        
    }
}
