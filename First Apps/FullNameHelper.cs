using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    internal class FullNameHelper
    {
       public Boolean textBoxVal(TextBox tx, string ms)
        // 2_method  Boolean textBoxVal(TextBox tx)
        {

            if (string.IsNullOrEmpty(tx.Text))
            {
                MessageBox.Show(ms);
                // 2_method   MessageBox.Show("Plase Enter Name");
                tx.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public string AddFullname(string fn, string ln)
        {
            string fname = fn;
            string lname = ln;
            string add = fname + lname;
            return add;
        }

        // public static void FormClose(FormClosingEventArgs e)
        // ovvoru formum close seyum pothu athanudaiya name varuthal kile ullathu
        public static void FormClose(FormClosingEventArgs e, string mes)
        {
            //   DialogResult dialogR = MessageBox.Show("Are you sure to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            // ovvoru formum close seyum pothu athanudaiya name varuthal kile ullathu 
            DialogResult dialogR = MessageBox.Show(mes, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); if (dialogR == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
}
}
