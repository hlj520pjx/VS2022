namespace form
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
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text=="打开")
            {
                pictureBox1.Image = Image.FromFile(@"./images/on.png");
                btn.Text = "关闭";
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"./images/off.png");
                btn.Text = "打开";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
