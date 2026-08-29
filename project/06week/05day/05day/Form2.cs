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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            price.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            times.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            price.Items.AddRange("升序","降序");
            times.Items.AddRange("升序","降序");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb=(sender as ComboBox);
            if(cb.Name=="price")
            {
                if(cb.SelectedItem.ToString()=="升序")
                {
                    MessageBox.Show("按价格升序");
                }
                else
                {
                    MessageBox.Show("按价格降序");
                }
            }
            else
            {
                if (cb.SelectedItem.ToString() == "升序")
                {
                    MessageBox.Show("按时间升序");
                }
                else
                {
                    MessageBox.Show("按时间降序");
                }
            }
        }
    }
}
