namespace _04day_Timer
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer MyTimer { get; set; }
        public int n = 0;
        public Form1()
        {
            InitializeComponent();
            
            MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = 500;
            MyTimer.Tick += (object sender, EventArgs e) =>
            {
                n++;
                label1.Text = n.ToString();
            };
            MyTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 0;
            label1.Text = n.ToString();
        }
    }
}
