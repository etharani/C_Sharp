using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
   internal class InheritanceA
    {
        int a;
       
        //  public InheritanceA()
        public InheritanceA(int x)
        {
           // no parameter this.a = 10;
           this.a = x;
        }
        
        public int getA()
        {
            return this.a;
        }
        
        // Method Overriding
        public virtual int getABC()
        {
            return this.a;
        }
        public virtual int getABC1()
        {
            
            return this.a;
        }

     

    }
}
