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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            label1.MouseEnter += labeMouseEnter;
            label1.MouseLeave += MouseLeave;
            this.MouseMove += move;
        }

        private void move(object sender, EventArgs e)
        {
            MouseEventArgs ev=(MouseEventArgs)e;
            label2.Text = $"窗口X: {ev.X.ToString()}";
            label3.Text = $"窗口X: {ev.Y.ToString()}";
        }
        private void labeMouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            label1.Font = new Font("Microsoft YaHei UI", 12F, GraphicsUnit.Point);
        }
    }
}
