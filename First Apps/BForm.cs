using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    internal class BForm:AForm
    {
        public Int32 b;
        public Int32 a = 30;
        public BForm()
        {
            this.b = 25;
        }
        public Int32  getb()
        {           
           return this.b;
        }
      /*  public Int32 geta()
        {
            return this.a; // output 10

        }
      */


     /*   public Int32 geta()
           {
          
            return 14;  // output 14
            }
     */
       public Int32  geta()
        {
           // Int32 a = 14;//local variable
          //  return this.a;
              return base.a;
          //   return a;
         //   return base.geta(); 
       }
    }
}
