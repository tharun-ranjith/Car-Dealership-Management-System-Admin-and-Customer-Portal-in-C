using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD.Customer
{
    public partial class SearchCarForm : Form
    {
        public SearchCarForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Og2 = new Form2();
            Og2.Show();
            this.Hide();
        }
    }
}
