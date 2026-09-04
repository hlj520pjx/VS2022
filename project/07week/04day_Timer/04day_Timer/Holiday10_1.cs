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
    public partial class Holiday10_1 : Form
    {
        private System.Windows.Forms.Timer MyTimer { get; set; }
        public Holiday10_1()
        {
            InitializeComponent();
            Timer();

        }

        public void Timer()
        {
            MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += (object sender, EventArgs e) => show();
            MyTimer.Start();
            show();
        }

        public void show()
        {
            TimeSpan date = DateTime.Parse("2026-10-1 0:0:0") - DateTime.Now;
            day.Text = Math.Floor(date.TotalDays).ToString();
            hour.Text = Math.Floor(date.TotalHours % 24).ToString();
            miunte.Text = Math.Floor(date.TotalMinutes % 60).ToString();
            second.Text = Math.Floor(date.TotalSeconds % 60).ToString();
        }

        
    }
}
