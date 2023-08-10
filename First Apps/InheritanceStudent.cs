using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Apps
{
      public class InheritanceStudent
    {
        int id;
        String name;
        // Method Overloading
        public void setStudent()
        {
            this.id = 101;
            this.name = "Malli";
        }
        public void setStudent(int id)
        {
            this.id = id;
            this.name = "Ranitha";
        }
        public void setStudent(String name)
        {
            this.id = 1001;
            this.name = name;
        }
        public void setStudent(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public void setStudent(String name, int id)
        {
            this.id = id;
            this.name = name;
        }
        public void getStudent()
        {
            MessageBox.Show("Student ID:" + this.id + "\nStudent Name:" + this.name,"Student Details");

        }
        // Constructor Overloading
        public InheritanceStudent()
        {
            this.id = 108;
            this.name = "Yathu";
        }
        public InheritanceStudent(int id)
        {
            this.id = id;
            this.name = "Thivi";
        }
        public InheritanceStudent(String name)
        {
            this.id = 191;
            this.name = name;
        }
        public InheritanceStudent(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public InheritanceStudent(String name, int id)
        {
            this.id = id;
            this.name = name;
        }
    }
}
