using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    internal class Student
    {
        public Int32 id;
        public string firstname;
        public string lastname;
        public Int32 m1;
        public Int32 m2;
        public Int32 m3;
       

        // Int32 id;
        // string  firstname;
     // string lastname;
     // Int32 m1;
     // Int32 m2;
    //  Int32 m3;
        public void setStudentData(Int32 id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public void getStudentData()
        {
            Console.WriteLine("Student ID:" + id);
            Console.WriteLine("Student First name:" + firstname);
            Console.WriteLine("Student Last name:" + lastname);
           // string f1 = getFullName();
           // Console.WriteLine("Student Full Name:" + getFullName());
          //  Console.WriteLine("Student Full Name:" + f1);
        }
        public void setMarks(Int32 m1, Int32 m2, Int32 m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public Int32 calcTotal()
        {
            Int32 total = this.m1 + this.m2 + this.m3;
            return total;
        }
        public double calcAvg(Int32 t)
        {
            double avg = t / 3.0;
            return avg;
        }

    }
}
