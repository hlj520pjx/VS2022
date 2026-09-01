namespace _07week02day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task<int> t1 = Task.Run(() =>
            {
                return 100;
            });
        }
    }
}
