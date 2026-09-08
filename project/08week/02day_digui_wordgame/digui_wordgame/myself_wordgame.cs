using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digui_wordgame
{
    public partial class myself_wordgame : Form
    {
        private System.Windows.Forms.Timer GlobalTimer = new();
        private int score ;
        private List<Labeltimer> listlabeltimer = new();
        private Random random = new Random();
        public myself_wordgame()
        {
            InitializeComponent();
            this.Shown += Gameinit;//窗口展开后就进行初始化
        }

        private void Gameinit(object sender, EventArgs e)
        {
            GlobalTimer.Interval = 1000;
            GlobalTimer.Tick += (object sender, EventArgs e) => Setword();
            this.KeyPreview = true;//让窗体监听键盘(让键盘按键起作用)
            this.ActiveControl = null;//让窗体本身没有任何子控件获得焦点，只是取消初始焦点
            this.KeyUp += Form_KeyUp;
        }

        //*************************************************************************************
        private void Form_KeyUp(object? sender, KeyEventArgs e)
        {
            for(int i = 0; i < listlabeltimer.Count; i++)
            {
                if (Enum.TryParse(listlabeltimer[i].Lab.Text,true,out Keys res))//listlabeltimer[i].Lab.Text为列表里面第i个的文本的内容
                {                                                               //true代表忽略大小写
                    if (res != e.KeyCode) continue;                             //把内容转换成Keys类型的res
                    panel1.Controls.Remove(listlabeltimer[i].Lab);
                    listlabeltimer[i].Timer.Stop();
                    listlabeltimer.RemoveAt(i);
                    label2.Text=(++score).ToString();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            label2.Text = "0";
            GlobalTimer.Start();

        }


        //为新建的类的属性进行初始化
        private void Setword()
        {
            //新建一个文字对象然后设置属性
            Label lab= new Label();
            lab.Text = ((char)random.Next(65,91)).ToString();
            lab.Size = new Size(30,30);
            lab.Location = new Point(random.Next(panel1.Width - 30), 0);//面板宽度-文本宽度=文本随机出现的X坐标
            lab.TextAlign = ContentAlignment.MiddleCenter;//文字在文本框居中
            lab.Font = new Font("微软雅黑",14F,FontStyle.Bold,GraphicsUnit.Point);
            panel1.Controls.Add(lab);

            //新建子定时器用于下落
            System.Windows.Forms.Timer Tm = new System.Windows.Forms.Timer();
            Tm.Interval = 10;
            Tm.Tick+=(object sender, EventArgs e) =>worddown(lab);
            Tm.Start();

            //Labeltimer llab=new Labeltimer(lab,Tm);
            listlabeltimer.Add(new Labeltimer(lab, Tm));
        }

        private void worddown(Label llab)
        {
            llab.Top += 2;
            if (llab.Top >= panel1.Height - 30)
            {
                //先停掉所有的定时器
                GlobalTimer.Stop();
                listlabeltimer.ForEach(item=>item.Timer.Stop());
                //再清除面板和列表里的内容
                panel1.Controls.Clear();
                listlabeltimer.Clear();
                MessageBox.Show("游戏结束！！！");
            }
        }
    }


    //新建一个类对象，里面包含文本和定时器属性
    public class Labeltimer
    {
        public Label Lab = new();
        public System.Windows.Forms.Timer Timer=new();
        public Labeltimer(Label lab, System.Windows.Forms.Timer timer)
        {
            this.Lab = lab;
            this.Timer = timer;
        }
    }  
}
