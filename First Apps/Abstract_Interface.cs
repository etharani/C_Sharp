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
    public partial class Abstract_Interface : Form
    {
        public Abstract_Interface()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            E obj=new E();
            MessageBox.Show(obj.getX().ToString(),"X");
            MessageBox.Show(obj.getY().ToString(), "Y");
            MessageBox.Show(obj.display().ToString(), "override");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            I ob = new I();
            ob.getIA();
            ob.getIB();
        }
    }
}
