using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    public partial class Product : Form
    {
        ProductDetails things;
        public Product()
        {
            InitializeComponent();
          
        }

        Boolean tBoxVal(TextBox t, string m)
        
        {

            if (string.IsNullOrEmpty(t.Text))
            {
                MessageBox.Show(m);
                t.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pset_Click(object sender, EventArgs e)
        {
            if (!tBoxVal(id, "Plase Enter Product Id"))
            {
                return;
            }
            if (!tBoxVal(name, "Plase Enter Product Name"))
            {
                return;
            }
            if (!tBoxVal(price, "Plase Enter Product Price"))
            {
                return;
            }
            if (!tBoxVal(quantity, "Plase Enter Product Quantity"))
            {
                return;
            }
           
            MessageBox.Show("Details okay");
            things = new ProductDetails(Convert.ToInt32(id.Text), name.Text, Convert.ToInt32(price.Text), Convert.ToInt32(quantity.Text));

        }

        private void pget_Click(object sender, EventArgs e)
        {

            string pdata = things.GetData();
            MessageBox.Show(pdata);
        }

        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogR = MessageBox.Show("Are you sure to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogR == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
