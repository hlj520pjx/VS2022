using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01day_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           //第一步先获取画图对象
           Graphics drawpic = e.Graphics;
            //第二步配置抗锯齿（让线变得圆滑）
            drawpic.SmoothingMode= SmoothingMode.AntiAlias;

            ////创建画笔，用于画图（包含颜色，线条宽度等参数）
            //using (Pen penred=new Pen(Color.Red,2))
            //{
            //    //画矩形Rectangle(画笔，X坐标，Y坐标，宽，高)
            //    drawpic.DrawRectangle(penred,10,10,120,80);

            //    //画直线g.DrawLine(pen, x1, y1, x2, y2);
            //    drawpic.DrawLine(penred,10,300,200,300);
            //}

            ////用笔刷画半透明蓝色矩形
            //using (Brush blueBrush = new SolidBrush(Color.FromArgb(80, 0, 120, 255)))//Color.FromArgb(不透明度, 红, 绿, 蓝)
            //{
            //    drawpic.FillRectangle(blueBrush,150, 10,120,80);
            //}

            ////画空心圆（椭圆，宽高相等就是圆）
            //using (Pen penred = new Pen(Color.Blue, 2))
            //{
            //    drawpic.DrawEllipse(penred, 10, 100, 120, 120);
            //}

            ////画文字（文字被视为“实心图形”而不是“线条”。所以用笔刷）
            //using (Brush brushText = new SolidBrush(Color.Black))
            //using (Font font = new Font("微软雅黑",12))
            //using (StringFormat sf = new StringFormat())//文字居中
            //{
            //    sf.Alignment = StringAlignment.Center;
            //    sf.LineAlignment = StringAlignment.Center;
            //                                                  //  x  y
            //    drawpic.DrawString("我爱pjx", font, brushText,300,20);//如果要文字居中就多加一个参数
            //}

            ////画多边形先建立N个顶点
            //Point[] points = {
            //    new Point(300,200),
            //    new Point(400,200),
            //    new Point(350,300),
            //    new Point(250,300),
            //};
            //using (Pen pen=new Pen(Color.Red,2))
            //{
            //    //再通过画笔连起来
            //    drawpic.DrawPolygon(pen, points);
            //}


            //画实心圆   SolidBrush是实心画刷
            using (Brush yuan=new SolidBrush(Color.Red))
            {
                //参数含义分别是：(画刷, 外接矩形左上角X, 外接矩形左上角Y, 外接矩形宽度, 外接矩形高度)。这个是圆在矩形里面
                drawpic.FillEllipse(yuan,20,20,60,60);
            }


            // 三个顶点：上、左下、右下
            Point[] triPoints =
            {
                new Point(100,30),   //顶点1 顶部
                new Point(50,120),   //顶点2 左下角
                new Point(150,120)   //顶点3 右下角
            };
            Point[] triPoints2 =
            {
                new Point(200,30),   //顶点1 顶部
                new Point(150,120),   //顶点2 左下角
                new Point(250,120)   //顶点3 右下角
            };
            // 空心
            using (Pen pen = new Pen(Color.Black, 2))
            {
                drawpic.DrawPolygon(pen, triPoints);
            }
            // 实心
            using (SolidBrush brush = new SolidBrush(Color.DarkRed))
            {
                drawpic.FillPolygon(brush, triPoints2);
            }



        }
    }
}
