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
    public partial class Masterform : Form
    {
      //  string n;
        public Masterform( )
        {
            InitializeComponent();
            
        // textb3.Text = n;
         
            
        }

   
        private void Masterform_Load(object sender, EventArgs e)
        {
            //textb3.Text = this.n;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Firstform obj=new Firstform();
            obj.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           string num = text1.Text;
           string num1 = text2.Text;
           Calculator obj1;
           obj1=new Calculator(num,num1,this);
            
            obj1.ShowDialog();  
        }

        internal void receiveData(string newno)
        {
         //   n=newno;
            

        }

        private void textb3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
