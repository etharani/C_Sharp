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
    public partial class DllStudent1 : Form
    {
        StudentDLL s1;
        public DllStudent1()
        {
            InitializeComponent();
             
        }
        public  Int32 total;
        public double average;
        public String result;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            s1 = new StudentDLL(Convert.ToInt32(tid.Text), tname.Text, Convert.ToInt32(tage.Text));
            s1.studentSetData(Convert.ToInt32(tid.Text), tname.Text, Convert.ToInt32(tage.Text));
            s1.studentSetMark(Convert.ToInt32(tmaths.Text), Convert.ToInt32(ttamil.Text), Convert.ToInt32(tenglish.Text));
            this.total = s1.studentCalTotal();
            this.average = s1.studentCalAverage(total);
            this.result = s1.studentGetResult(average);

            DllStudent2 f2 = new DllStudent2(s1);
            f2.ShowDialog();    

        }
    }
}
