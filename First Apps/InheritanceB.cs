using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    internal class InheritanceB:InheritanceA
    {
        //  public int b;
        int b;
       // public InheritanceB()
         public InheritanceB(int y,int x):base(x)
        {
           // no parameter  this.b = 15;
           this.b = y;
        }
        public int getB()
        {
            return this.b;
        }

        public override int getABC()
        {
            int s=base.getABC();
            MessageBox.Show(s.ToString(),"A");
            return this.b;
        }
    }
}
