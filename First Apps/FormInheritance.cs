using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace First_Apps
{
    public partial class FormInheritance : Form
    {
        public FormInheritance()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            InheritanceA obja=new InheritanceA(25);
            int x = obja.getA();
            MessageBox.Show(x.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InheritanceB objb = new InheritanceB(45,60);
            int x1 = objb.getA();
            int y = objb.getB();
            MessageBox.Show(x1.ToString(),"A");
            MessageBox.Show(y.ToString(),"B");
        }

        private void btnc_Click(object sender, EventArgs e)
        {

            //  InheritanceC objc = new InheritanceC(67,78);
            InheritanceC objc = new InheritanceC(34,67, 78);
            int z = objc.getC();
            int x2 = objc.getA();
            int y2 = objc.getB();
            MessageBox.Show(z.ToString(),"C");
            MessageBox.Show(x2.ToString(),"A");
            MessageBox.Show(y2.ToString(),"B");
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            HA a = new HA(50);
            int s = a.getHA();
            MessageBox.Show(s.ToString());
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            HB b = new HB(67,88);
            int t = b.getHB();
            int s1 = b.getHA();
            MessageBox.Show(t.ToString(),"B");
            MessageBox.Show(s1.ToString(),"A");
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            HC c = new HC(24,18);
            int v = c.getHC();
            int s2 = c.getHA();
            MessageBox.Show(v.ToString(),"C");
            MessageBox.Show(s2.ToString(),"A");
        }

        private void btnOA_Click(object sender, EventArgs e)
        {
            InheritanceA ora = new InheritanceA(15);
            int x = ora.getABC();
            MessageBox.Show(x.ToString());
        }

        private void btnOB_Click(object sender, EventArgs e)
        {
            InheritanceB orb = new InheritanceB(48, 69);
            int x1 = orb.getABC();
            MessageBox.Show(x1.ToString(), "B");
        }

        private void btnOC_Click(object sender, EventArgs e)
        {
            InheritanceC orc = new InheritanceC(77, 66, 44);
            int x2 = orc.getABC1();
            int y2 = orc.getB();
            MessageBox.Show(x2.ToString(), "C");
            MessageBox.Show(y2.ToString(), "B");
        }

        private void btnOHA_Click(object sender, EventArgs e)
        {
            HA a1 = new HA(57);
            int s1 = a1.getOHA();
            MessageBox.Show(s1.ToString());
        }

        private void btnOHB_Click(object sender, EventArgs e)
        {
            HB b1 = new HB(17, 28);
            int s2 = b1.getOHA();
            MessageBox.Show(s2.ToString(), "B");       
        }

        private void btnOHC_Click(object sender, EventArgs e)
        {
            HC c1 = new HC(94, 68);
            int s3 = c1.getOHA1();
            MessageBox.Show(s3.ToString(), "C");
        }

        private void btnMOL1_Click(object sender, EventArgs e)
        {
            InheritanceStudent s1 = new InheritanceStudent();
            s1.setStudent();
            s1.getStudent();

        }

        private void btnMOL2_Click(object sender, EventArgs e)
        {
            InheritanceStudent s1 = new InheritanceStudent();
            s1.setStudent(100);
            s1.getStudent();
        }

        private void btnMOL3_Click(object sender, EventArgs e)
        {
            InheritanceStudent s1 = new InheritanceStudent();
            s1.setStudent("Kithu");
            s1.getStudent();
        }

        private void btnMOL4_Click(object sender, EventArgs e)
        {
            InheritanceStudent s1 = new InheritanceStudent();
            s1.setStudent(10,"Ayan");
            s1.getStudent();
        }

        private void btnMOL5_Click(object sender, EventArgs e)
        {
            InheritanceStudent s1 = new InheritanceStudent();
            s1.setStudent("Esan",11);
            s1.getStudent();
        }

        private void btnCOL1_Click(object sender, EventArgs e)
        {
            InheritanceStudent s2 = new InheritanceStudent();
            s2.getStudent();
        }

        private void btnCOL2_Click(object sender, EventArgs e)
        {
            InheritanceStudent s2 = new InheritanceStudent(999);
            s2.getStudent();
        }

        private void btnCOL3_Click(object sender, EventArgs e)
        {
            InheritanceStudent s2 = new InheritanceStudent("Thurai");
            s2.getStudent();
        }

        private void btnCOL4_Click(object sender, EventArgs e)
        {
            InheritanceStudent s2 = new InheritanceStudent(104,"Uthaya");
            s2.getStudent();
        }

        private void btnCOL5_Click(object sender, EventArgs e)
        {
            InheritanceStudent s2 = new InheritanceStudent("Rasvi",105);
            s2.getStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            details d = new details();
            MessageBox.Show(d.name);
        }
    }
}
