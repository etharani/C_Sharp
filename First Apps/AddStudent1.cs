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
    public partial class AddStudent1 : Form
    {
        Int32 id;
        Int32 m1;
        Int32 m2;
        Int32 m3;
        Int32 tot;
        double ave;
        string fname;
        string lname;
        public AddStudent1()
        {
            InitializeComponent();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            Mark marks = new Mark();
           if (!int.TryParse(teid.Text, out marks.id))
            {
                MessageBox.Show("please enter the id in correct format", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teid.Focus();
                teid.BackColor = Color.Red;
                return;
            }
            teid.BackColor = Color.White;
           if (string.IsNullOrEmpty(tefname.Text))
            {
                MessageBox.Show("please enter the first name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tefname.Focus();
                tefname.BackColor = Color.Red;
                return;

            }
            tefname.BackColor = Color.White;
           if (string.IsNullOrEmpty(telname.Text))
            {
                MessageBox.Show("please enter the last name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                telname.Focus();
                telname.BackColor = Color.Red;
                return;

            }
            telname.BackColor = Color.White;
            if (!int.TryParse(temark1.Text, out marks.m1))
            {
                MessageBox.Show("please enter the marks1 in correct ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temark1.Focus();
                temark1.BackColor = Color.Red;
                return;
            }
            temark1.BackColor = Color.White;
            if (!int.TryParse(temark2.Text, out marks.m2))
            {
                MessageBox.Show("please enter the marks2 in correct", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temark2.Focus();
                temark2.BackColor = Color.Red;
                return;
            }
            temark2.BackColor = Color.White;
            if (!int.TryParse(temark3.Text, out marks.m3))
            {
                MessageBox.Show("please enter the marks3 in correct", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temark3.Focus();
                temark3.BackColor = Color.Red;
                return;
            }
            
            id = Convert.ToInt32(teid.Text);
            fname = tefname.Text;
            lname = telname.Text;
            m1 = Convert.ToInt32(temark1.Text);
            m2 = Convert.ToInt32(temark2.Text);
            m3 = Convert.ToInt32(temark3.Text);
            temark3.BackColor = Color.White;
            marks.setStudentData(this.id, this.fname, this.lname);
            marks.setMarks(this.m1, this.m2, this.m3);
            marks.calcTotal();
            marks.calcAvg();
            MessageBox.Show("total is" + marks.calcTotal());
          //  MessageBox.Show("average is" + marks.calcAvg(t));
        
        
    
}

        private void but3_Click(object sender, EventArgs e)
        {
            Mark marks = new Mark();
            marks.setMarks(this.m1, this.m2, this.m3);
            marks.calcTotal();
            MessageBox.Show("average is" + marks.calcAvg());
        }

        private void but1_Click(object sender, EventArgs e)
        {
          
        }

        private void teid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
