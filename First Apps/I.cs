using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
    class I:IA,IB
  {

        int p;
        int q;
        public I()
        {
            this.p = 89;
            this.q = 77;
        }
        public void getIA()
        {
            MessageBox.Show(this.q.ToString());
        }
        public void getIB()
        {
            MessageBox.Show(this.p.ToString());
        }
    }
}
