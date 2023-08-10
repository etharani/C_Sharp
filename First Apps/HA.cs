using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    internal class HA
    {
        int ha;
        public HA(int ha)
        {

            // this.ha = 45;
            this.ha = ha;
        }
        public int getHA()
        {
            return this.ha;
        }

        public virtual int getOHA()
        {
            return this.ha;
        }

        public virtual int getOHA1()
        {
            return this.ha;
        }
    }
}
