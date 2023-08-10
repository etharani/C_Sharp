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
    public partial class FullName : Form
    {
        Employee emp;
        public FullName()
        {
           InitializeComponent();
            emp = new Employee();
        }

     /*3,4 Method
      Boolean textBoxVal(TextBox tx,string ms)
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
     */

            private void Save_Click(object sender, EventArgs e)
        {
            //--------------1-Method-------------------------
            /*      if (string.IsNullOrEmpty(tbox1.Text)) {
                  MessageBox.Show("Plase Enter First Name");
                  tbox1.Focus();
                  return;
                  }
                  if (string.IsNullOrEmpty(tbox2.Text))
                  {
                  MessageBox.Show("Plase Enter Last Name");
                  tbox2.Focus();
                  return;
                  }
                  string  addfull = AddFullname(tbox1.Text,tbox2.Text);
                  MessageBox.Show(addfull);
            */

            //----------------2-Method--------------------------
            /*    textBoxVal(tbox1);
                textBoxVal(tbox2);
                string addfull = AddFullname(tbox1.Text, tbox2.Text);
                MessageBox.Show(addfull);
            */

            //----------------3-Method---------------------------
            /*    if (textBoxVal(tbox1,"Plase Enter First Name"))
                {
                    if(textBoxVal(tbox2, "Plase Enter Last Name"))
                    {
                    string addfull = AddFullname(tbox1.Text, tbox2.Text);
                    MessageBox.Show(addfull);
               }

                } 
            */

            // ----------------4-Method----------------------------

            // fullname helper clz  after crate 

            FullNameHelper obj = new FullNameHelper();


            if (!obj.textBoxVal(tbox1, "Plase Enter First Name"))
            {
                return;
            }
            if (!obj.textBoxVal(tbox2, "Plase Enter Last Name"))
            {
                return;
            }
            string addfull = obj.AddFullname(tbox1.Text, tbox2.Text);
            MessageBox.Show(addfull);

        }

     /*
        public string AddFullname(string fn,string ln)
        {
            string fname = fn;
            string lname = ln;
            string  add = fname+lname;
            return add;
        }
     */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            /* form closing seytha pin intha method tevalla  
                 DialogResult dialogR = MessageBox.Show("Are you sure to close?", "Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dialogR == DialogResult.Yes)
                {
                    this.Close();
                }
            */
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        // after create clz    FullName2 name = new FullName2(this);
            FullName2 name = new FullName2();
            name.ShowDialog();  
        }
        /*
         //  fullname helper clzl new method create ana pin tevala
    private void FullName_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogR = MessageBox.Show("Are you sure to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogR == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        */

        private void FullName_FormClosing(object sender, FormClosingEventArgs e)
        {
            FullNameHelper.FormClose(e, "Are you sure to close form1?");

        }

        private void set_Click(object sender, EventArgs e)
        {
           
            emp.SetData(Convert.ToInt32(eid.Text), ename.Text, Convert.ToInt32(eage.Text));
            
        }

        private void get_Click(object sender, EventArgs e)
        {
            
            string edata = emp.GetData();
            MessageBox.Show(edata);
        }
    }
}
