using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Car_systeam.Book
{
    public partial class main : Form
    {
        private Mysql mysql = new Mysql("test");
        public main()
        {
            InitializeComponent();
            bookshow();
        }

        public async void bookshow()
        {
            string sql = "select * from book";
            await mysql.ConHandler(sql, Cmd =>
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                table1.DataSource = dt;
                return true;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAdd_Edit BE=new BookAdd_Edit("新增");
            BE.Show();
            this.Hide();
            BE.FormClosing += (object? sender, FormClosingEventArgs e)=> { this.Show();bookshow(); };
        }

        
    }
}
