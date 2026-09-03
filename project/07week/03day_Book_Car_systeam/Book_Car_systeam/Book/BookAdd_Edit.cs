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
    public partial class BookAdd_Edit : Form
    {
        private mysql Mysql=new mysql("test");
        private string Title {  get; set; }
        private string Id { get; set; }
        public BookAdd_Edit()
        {
            InitializeComponent();
        }

        public BookAdd_Edit(string title)
        {
            InitializeComponent();
            label1.Text = "图书"+title;
            button1.Text = title;
            this.Title = title;
        }

        public BookAdd_Edit(string title,string id)
        {
            InitializeComponent();
            label1.Text = "图书" + title;
            button1.Text = title;
            this.Title = title;
            this.Id = id;
        }






    }
}
