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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {

            Allcheck.CheckStateChanged += Allcheck_CheckStateChanged;

            foreach (Control item in panel1.Controls) (item as CheckBox).CheckedChanged += item_Checked;
        }

        private void item_Checked(object sender, EventArgs e)
        {
            List<Control> list = panel1.Controls.OfType<Control>().ToList();
            bool all=list.All(item=>(item as CheckBox).Checked==true);
            bool any=list.Any(item=>(item as CheckBox).Checked==true);

            if(all)
            {
                Allcheck.CheckState = CheckState.Checked;
            }
            else
            {
                Allcheck.CheckState = any ? CheckState.Indeterminate : CheckState.Unchecked;
            }

        }

        private void Allcheck_CheckStateChanged(object sender, EventArgs e)
        {
            bool ischeck=Allcheck.CheckState==CheckState.Checked?true:false;
            if(Allcheck.CheckState!= CheckState.Indeterminate)
            {
                foreach (Control item in panel1.Controls) (item as CheckBox).Checked = ischeck;
            }
        }
    }
}
