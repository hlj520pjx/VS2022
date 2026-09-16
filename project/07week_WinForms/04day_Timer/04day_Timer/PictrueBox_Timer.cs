using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04day_Timer
{
    public partial class PictrueBox_Timer : Form
    {
        private System.Windows.Forms.Timer Mytimer {  get; set; }
        public PictrueBox_Timer()
        {
            InitializeComponent();
            Show();
            Timer();
        }

        internal void Timer()
        {
            Mytimer = new System.Windows.Forms.Timer();
            Mytimer.Interval = 1000;
            Mytimer.Tick += (object sender, EventArgs e) => Show();
            Mytimer.Start();
            
        }

        internal void Show()
        {
            DateTime dt= DateTime.Now;

            //var hour= dt.Hour;
            //string str1 = hour.ToString();
            //var minute = dt.Minute;
            //string str2 = minute.ToString();
            //var second = dt.Second;
            //string str3 = second.ToString();
            //string Constr = str1.PadLeft(2, '0') + str2.PadLeft(2, '0') + str3.PadLeft(2, '0');

            var hour = dt.Hour.ToString();
            var minute = dt.Minute.ToString();
            var second = dt.Second.ToString();
            string Constr = hour.PadLeft(2, '0') + minute.PadLeft(2, '0') + second.PadLeft(2, '0');




            PictureBox[] picBox = new PictureBox[] {
                pictureBox1,pictureBox2,pictureBox4,
                pictureBox5,pictureBox7,pictureBox8,
             };

            for (int i = 0; i < picBox.Length; i++)
            {
                picBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picBox[i].Image = Image.FromFile(@"./images/" + Constr[i] + ".png");
            }
        }






    }
}
