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
    public partial class InheritanceForm : Form
    {
        public InheritanceForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BForm obj1 = new BForm();
            Int32 c1 =obj1.getb();
            Int32 c2 = obj1.geta();
            MessageBox.Show(c1.ToString(),"Bb");
            MessageBox.Show(c2.ToString(), "Ab");
        }
    }
}
