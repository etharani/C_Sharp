using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    abstract class D
    {
        public int p;
      public  D()
        {
            this.p = 45;
        }
        public abstract int display();

        public int getX()
        {
            return this.p;
        }
    }
}
