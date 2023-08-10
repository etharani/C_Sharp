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
    public partial class AddStudent : Form
    {
        Student stu;
        Int32 m1;
        Int32 m2;
        Int32 m3;
        Int32 tot;
        double ave;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Student stu = new Student();
            //Int32 m1 = Convert.ToInt32(texmark1.Text);
            //Int32 m2 = Convert.ToInt32(texmark2.Text);
            //Int32 m3 = Convert.ToInt32(texmark3.Text);
            // stu.setMarks(m1, m2, m3);----- method2
            //stu.setMarks(Convert.ToInt32(texmark1.Text), Convert.ToInt32(texmark2.Text), Convert.ToInt32(texmark3.Text));--- method1
            // Int32 tot=stu.calcTotal();
            // MessageBox.Show(tot.ToString());

            //-------------------------------------
          //stu = new Student();
          //m1 = Convert.ToInt32(texmark1.Text);
          //m2 = Convert.ToInt32(texmark2.Text);
         // m3 = Convert.ToInt32(texmark3.Text);
         // stu.setMarks(m1, m2, m3);
         // tot = stu.calcTotal();
         //MessageBox.Show(tot.ToString());

            //  ---------this------------
            this.stu = new Student();
            this.m1 = Convert.ToInt32(texmark1.Text);
            this.m2= Convert.ToInt32(texmark2.Text);
            this.m3 = Convert.ToInt32(texmark3.Text);
            stu.setMarks(m1, m2, m3);
            this.tot = this.stu.calcTotal();
            MessageBox.Show(this.tot.ToString());



        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Student stu = new Student;
            //stu.setMarks(Convert.ToInt32(texmark1.Text), Convert.ToInt32(texmark2.Text), Convert.ToInt32(texmark3.Text));
            //Int32 tot = stu.calcTotal();
            //  double ave=stu.calcAvg(tot);
            //MessageBox.Show(ave.ToString());

            //-------------------------------
         // btn2_Click(sender, e);// ithai podamal viddalum ave varum , ithai poddal tot vantha pinne ave varum
         // tot = stu.calcTotal();
         // ave = stu.calcAvg(tot);
         // MessageBox.Show(ave.ToString());

            //---------------- this----
            this.tot=this.stu.calcTotal();
            this.ave = this.stu.calcAvg(this.tot);
            MessageBox.Show(this.ave.ToString());
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.stu=new Student();
            this.stu.setStudentData(Convert.ToInt32 (texid.Text),texfname.Text,texlname.Text);
            MessageBox.Show(this.stu.id.ToString());
        }
    }
}
