using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    internal class InheritanceC:InheritanceB
    {
        int c;
       
    //    public InheritanceC(int y,int x) :base(y,x)
        public InheritanceC(int z, int y, int x) : base(y, x)
        {
            
            this.c = 55;
        }
        public int getC()
        {
            return this.c;
        }

        public override int getABC1()
        {
            int u = base.getABC1();
            MessageBox.Show(u.ToString(), "A");
            return this.c;
        }
    }
}
