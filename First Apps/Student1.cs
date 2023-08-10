using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    internal class Student1
    {
      public   Int32 id;
      public   string firstName;
      public    string lastName;

        public void setStudentData(Int32 id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
     /*   public void displayData()
        {
            Console.WriteLine("Student ID: " + this.id);
            Console.WriteLine("Student First Name: " + this.firstName);
            Console.WriteLine("Student Last Name: " + this.lastName);
        }*/
    }
}
