using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    public class Employee
    {
        String empName;
        Int32 empId;
        Int32 emAge;

        //defalut constructor
        public Employee()
        {
            String empName;
            Int32 empId;
            Int32 emAge;
        }

        // parameter constructor
        public Employee(Int32 id,String name,Int32 age)
        {
             empName = name;
             empId = id;
             emAge = age;
        }
        /*
        -------------- this keyword  ---------------------------
        public Employee(Int32 empId, String empName, Int32 emAge)
        {
             this.empName =empName ;
             this.empId =empId ;
            Int32 emAge =emAge;
        }
        */
        public void SetData(Int32 id,String name , Int32 age)
        {
            empId = id;
            empName = name;
            emAge = age;
        }

       public string GetData()
        {
            return "Employee Id: "+empId+"\nEmployee Name:"+empName+"\nEmployee Age:"+emAge;
           
        }

    }
}
