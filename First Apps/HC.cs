using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    internal class HC:HA
    {
        int hc;
        public HC(int hc,int ha):base(ha)
        {

            //  this.hc= 65;
            this.hc = hc;
        }
        public int getHC()
        {
            return this.hc;
        }

        public override int getOHA1()
        {
            int c = base.getOHA();
            MessageBox.Show(c.ToString(), "A");
            return this.hc;
        }
    }
}
