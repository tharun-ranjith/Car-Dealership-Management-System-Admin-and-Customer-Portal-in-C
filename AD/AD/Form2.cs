using AD.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm cus3 = new OrderForm();
            cus3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchCarForm cus1 = new SearchCarForm();
            cus1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchCarpartsFom cus2 = new SearchCarpartsFom();
            cus2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewOrderForm cus4 = new ViewOrderForm();
            cus4.Show();
            this.Hide();

        }
    }
}
