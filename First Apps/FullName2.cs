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
    public partial class FullName2 : Form
    {
        // after create clz   FullName n;
        // after create clz   public FullName2(FullName na)
        public FullName2()
        {
            // after create clz   n = na;
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            // after create clz    string fullname =n.AddFullname("Tharani", "Easwaranathan");
            FullNameHelper obj1=new FullNameHelper();
            string fullname = obj1.AddFullname("Tharani", "Easwaranathan");
            MessageBox.Show(fullname);
          
        }

        private void FullName2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FullNameHelper.FormClose(e, "Are you sure to close form2?");
        }
    }
}
