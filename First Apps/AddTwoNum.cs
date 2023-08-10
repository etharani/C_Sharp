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
    public partial class AddTwoNum : Form
    {
        public AddTwoNum()
        {
            InitializeComponent();
        }
        Boolean textBoxValidation(TextBox txt, string msg)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show(msg);
                txt.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        Boolean textBoxValidation2(TextBox txt, String msg)

        {
            int n1;
            if (!int.TryParse(txt.Text, out n1))
            {
                MessageBox.Show(msg);
                txt.Clear();
                txt.Focus();
                return false;
            }
            else
            {

                return true;
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {

            //----------------1-Method---------------------------
            /*     if (textBoxValidation(text1,"Plase Enter First Number"))
                 {
                     if(textBoxValidation(text2, "Plase Enter Second Number"))
                     {
                         int add = AddFunction(Convert.ToInt32(text1.Text), Convert.ToInt32(text2.Text));
                         MessageBox.Show(add.ToString()); 
                     }
                 } **/

            //-------------------------2-Method---------------------
            
            if (!textBoxValidation(text1, "Plase Enter First Number"))
            {
                return;
            }
            if (!textBoxValidation(text2, "Plase Enter Second Number"))
            {
                return;
            }

            if (!textBoxValidation2(text1, "Plase Enter First Number"))
            {
                return;
            }
            if (!textBoxValidation2(text2, "Plase Enter Second Number"))
            {
                return;
            }

            int add = AddFunction(Convert.ToInt32(text1.Text), Convert.ToInt32(text2.Text));
           MessageBox.Show(add.ToString());

      }
    private int AddFunction(int N1, int N2)
        {
            int n1 = N1;
            int n2 = N2;
            int add = n1 + n2;
            return add;
        }

    }
}
