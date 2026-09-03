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
    public partial class BookShow : Form
    {
        private mysql Mysql { get; set; } = new mysql("test");
        public BookShow()
        {
            InitializeComponent();
            showdata();
        }

        private void showdata()
        {
            Mysql.ConHander("select * from book", myCoMM =>
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(myCoMM);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                table1.DataSource = dt;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAdd_Edit BE=new BookAdd_Edit("新增");
            this.Hide();
            BE.Show();
            BE.FormClosing += BE_FormClosing
                ;
        }

        private void BE_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
