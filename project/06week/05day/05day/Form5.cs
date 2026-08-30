using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05day
{

    public partial class Form5 : Form
    {
        private Point adr;
        public Form5()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            rebtn.Click += rebtn_Click;

            button1.MouseDown += Button1_MouseDown;
            
            button1.MouseUp += Button1_MouseUp;
        }

        private void Button1_MouseDown(object? sender, MouseEventArgs e)
        {
            button1.MouseMove += Button1_MouseMove;
            adr =e.Location;
        }
        private void Button1_MouseMove(object? sender, MouseEventArgs e)
        {
            //鼠标光标与控件的相对坐标  转换为  鼠标光标与电脑屏幕的相对坐标
            Point mousrc = button1.PointToScreen(e.Location);

            //鼠标光标与电脑屏幕的相对坐标 - 鼠标光标与控件的相对坐标 = 屏幕与控件的相对坐标
            mousrc.Offset(-adr.X, -adr.Y);

            //把屏幕与控件的坐标减去当前窗体左上角在屏幕上的位置，从而得到控件在窗体内的相对坐标
            Point forcon =this.PointToClient(mousrc);

            if (forcon.X <= 0) forcon.X = 0;
            if (forcon.Y <= 0) forcon.Y = 0;
            int xmax=this.Width-button1.Width;
            int ymax=this.Height-button1.Height;
            if (forcon.X >= xmax) forcon.X = xmax;
            if (forcon.Y >= ymax) forcon.Y = ymax;

            button1.Location = forcon;


        }
        private void Button1_MouseUp(object? sender, MouseEventArgs e)
        {
            button1.MouseMove -= Button1_MouseMove;
        }

        

        

        private void rebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
