using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
     class E:D
    {
        int q;
        int p = 23;
       public E()
        {
            this.q = 33;
        }
     
        public override int display()
        {
            // return this.p;
            return base.p;
        }
        public int getY()
        {
            return this.q;
        }

    }
}
