using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    internal class HB:HA
    {
        int hb;
        public HB(int hb,int ha):base(ha)
        {

            // this.hb = 90;
            this.hb = hb;
        }
        public int getHB()
        {
            return this.hb;
        }

        public override int getOHA()
        {
            int b=base.getOHA();
            MessageBox.Show(b.ToString(),"A");
            return this.hb;
        }
    }
}
