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
    public partial class Newcalculator : Form
    {
        public Newcalculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(num1.Text, out n1).ToString());


            if (!double.TryParse(num1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show(double.TryParse(num2.Text, out n2).ToString());
            if (!double.TryParse(num2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ans.Text = (n1 + n2).ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(num1.Text, out n1).ToString());


            if (!double.TryParse(num1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show(double.TryParse(num2.Text, out n2).ToString());
            if (!double.TryParse(num2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ans.Text = (n1 - n2).ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(num1.Text, out n1).ToString());


            if (!double.TryParse(num1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show(double.TryParse(num2.Text, out n2).ToString());
            if (!double.TryParse(num2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ans.Text = (n1 * n2).ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                num1.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(num1.Text, out n1).ToString());


            if (!double.TryParse(num1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show(double.TryParse(num2.Text, out n2).ToString());
            if (!double.TryParse(num2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ans.Text = (n1 / n2).ToString();
        }

        private void num1_Enter(object sender, EventArgs e)
        {
            num1.BackColor = Color.Yellow;
        }

        private void num1_Leave(object sender, EventArgs e)
        {
            num1.BackColor = Color.White;
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
