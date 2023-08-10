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
    public partial class Calculator : Form
    {
        string a = null;
        Masterform fir1 =null;
        public Calculator(string number, string number1,Masterform fir)

        {
            InitializeComponent();
            this.a = number;
            text2.Text = number1;
            fir1 = fir;
        }

     
        private void btn2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(text1.Text);
            b = Convert.ToInt32(text2.Text);
            c = a - b;
            text3.Text = c.ToString();
            fir1.textb3.Text = c.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=Convert.ToInt32(text1.Text);
            b=Convert.ToInt32(text2.Text);
            c = a + b;
            text3.Text = c.ToString();
            fir1.textb3.Text = c.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(text1.Text);
            b = Convert.ToInt32(text2.Text);
            c = a * b;
            text3.Text = c.ToString();
            fir1.textb3.Text = c.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(text1.Text);
            b = Convert.ToInt32(text2.Text);
            c = a / b;
            text3.Text = c.ToString();
            fir1.textb3.Text = c.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
           text1.Text = this.a;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // string n1 = text3.Text;
             //  Masterform rec = new Masterform();
           //    rec.receiveData(text3.Text);
         
        //    this.Hide();
            
        }

        private void text3_TextChanged(object sender, EventArgs e)
        {
            //  string n1 = text3.Text;
            
            // ret.ShowDialog();

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
