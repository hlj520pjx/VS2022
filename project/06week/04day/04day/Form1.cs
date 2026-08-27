namespace _04day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            textBox1.KeyPress += TextBox1_KeyPress;

            //放大控件
            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.MouseLeave += Panel1_MouseLeave;

            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
        }

        private void Button1_MouseLeave(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGray;
            label2.Visible = false;
        }

        private void Button1_MouseEnter(object? sender, EventArgs e)
        {
           Button btn=sender as Button;
            btn.BackColor = Color.DarkBlue;
            label2.Visible = true;
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel pan=sender as Panel;
            pan.Size = new Size(100,100);
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            Panel pan = sender as Panel;
            pan.Size = new Size(300, 300);
        }

        private void TextBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            //限制删除backspace
            if(e.KeyChar ==(char)8)
            {
                e.Handled = true;
            }
        }

        
    }
}
