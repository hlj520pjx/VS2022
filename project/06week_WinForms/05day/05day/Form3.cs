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
    //新建一个颜色类方便调用颜色名字和颜色本身
    public class backcolor
    {
        public string name;
        public Color Bccolor;
        public backcolor(string name, Color Bccolor)
        {
            this.name = name;
            this.Bccolor = Bccolor;
        }

    }
    public partial class Form3 : Form
    {
        private List<backcolor> data=new ();
        public Form3()
        {
            InitializeComponent();
            init();
        }
   private void init()
        {
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            data.AddRange
           ([ 
                new backcolor("红",Color.Red),
                new backcolor("橙",Color.Orange),
                new backcolor("黄",Color.Yellow),
                new backcolor("绿",Color.Green),
                new backcolor("青",Color.Gray),
                new backcolor("蓝",Color.Blue),
                new backcolor("紫",Color.Purple),
            ]);
            comboBox1.Items.AddRange(data.Select(item => item.name).ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string res=(sender as ComboBox).SelectedItem.ToString();

            Color bc=data.Find(item=>item.name==res).Bccolor;

            this.BackColor = bc;
            
        }
    }

    
    
}
