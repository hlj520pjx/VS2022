namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 F2= new Form2();
            F2.Show();
            this.Hide();
            F2.FormClosing += (object? sender, FormClosingEventArgs e) =>  this.Show();
        }

       
    }
}
