namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }


        public void init()
        {
            textBox1.Text = "ETCH-01";
            comboBox1.Text = "蚀刻设备";
            checkBox1.Checked = true;
            radioButton1.Checked = true;
            numericUpDown1.Value = 80;

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            label6.Text = "未运行";
            label6.ForeColor = Color.Black;
            label8.Text = "未连接";
            label8.ForeColor = Color.Black;

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;


            Label[] arr = new Label[7];
            for (int i = 0; i < 7; i++)
            {
                arr[i] = new Label();
                arr[i].ForeColor = Color.Blue;
                arr[i].Size = new Size(300, 30);

            }
            string state = checkBox1.Checked == true ? "启用" : "未启用";
            arr[0].Text = "参数已应用";
            arr[1].Text = "设备名称：" + textBox1.Text;
            arr[2].Text = "设备类型：" + comboBox1.Text;
            arr[3].Text = "运行模式：" + radioButton1.Text;
            arr[4].Text = "温度报警：" + $"{state}";
            arr[5].Text = "温度上限：" + $"{numericUpDown1.Value.ToString()}";
            arr[6].Text = "";
            flowLayoutPanel1.Controls.AddRange(arr);




        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            label6.Text = "运行中";
            label6.ForeColor = Color.Green;
            label8.Text = "已连接";
            label8.ForeColor = Color.Green;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;

            Label[] arr = new Label[2];
            for (int i = 0; i < 2; i++)
            {
                arr[i] = new Label();
                arr[i].ForeColor = Color.Blue;
                arr[i].Size = new Size(300, 30);
            }
            arr[0].Text = "设备已启动";
            arr[1].Text = "";
            flowLayoutPanel1.Controls.AddRange(arr);
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            label6.Text = "已停止";
            label6.ForeColor = Color.Red;
            label8.Text = "未连接";
            label8.ForeColor = Color.Gray;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;

            Label[] arr = new Label[2];
            for (int i = 0; i < 2; i++)
            {
                arr[i] = new Label();
                arr[i].ForeColor = Color.Blue;
                arr[i].Size = new Size(300, 30);
            }
            arr[0].Text = "设备已停止";
            arr[1].Text = "";
            flowLayoutPanel1.Controls.AddRange(arr);
        }

        
    }
}
