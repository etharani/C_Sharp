using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    internal class Mark:Student1
    {
     public    Int32 m1, m2, m3;
        public void setMarks(Int32 m1, Int32 m2, Int32 m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public Int32 calcTotal()
        {
            Int32 Total = this.m1 + this.m2 + this.m3;
            return Total;
        }
        public double calcAvg()
        {
            
            return (m1+m2+m3)/3.0;
        }
        public void displayData()
        {
            
            Console.WriteLine("Marks1: " + this.m1);
            Console.WriteLine("Marks2: " + this.m2);
            Console.WriteLine("Marks3: " + this.m3);
            Int32 TotalMark = calcTotal();
            Console.WriteLine("Total Marks: " + TotalMark);
            double AvgMarks = calcAvg();
            Console.WriteLine("Average Marks: " + AvgMarks);

        }
    }
}
