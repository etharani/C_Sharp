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
    public partial class Firstform : Form
    {
        public Firstform()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string n1 = "12";
            string n2 = "10";
            string msg = string.Format("no1 : {0}  no2 : {1}", n1, n2);
            MessageBox.Show("Welcome #C",msg);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome #C", "Information");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome #C", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome \n #C", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            var name1 = 10;
            MessageBox.Show(name1.ToString());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string name = tex1.Text;
            MessageBox.Show(name);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            var first = tex3.Text;
            MessageBox.Show(first.ToString());
        }

        private void Firstform_Load(object sender, EventArgs e)
        {

        }
    }
}
