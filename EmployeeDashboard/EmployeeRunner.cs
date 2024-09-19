using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "TR";

            Employee emp1=new Employee(101);
            Employee emp2=new Employee(102);
            Employee emp3=new Employee(103);
            Employee emp4 = new Employee(104, "kevin");
            Employee emp5 = new Employee("", 9);
            //Employee emp4= Employee.GetInstance();

            

            emp1.EmpId = -101;  //set property
            emp1.empName = "saul";
            emp1.empSalary = 9000;
            emp1.EmpPerformance = "B";

            emp2.EmpId = 102;
            emp2.empName = "peter";
            emp2.empSalary = 7000;
            emp2.EmpPerformance = "A";

            emp1.DisplayEmployeeDetail();
            emp2.DisplayEmployeeDetail();
            emp3.DisplayEmployeeDetail();

            emp1.AllocateBonus();
            emp2.AllocateBonus();
            emp3.AllocateBonus();

            emp1.DisplayEmployeeDetail();
            emp2.DisplayEmployeeDetail();
            emp3.DisplayEmployeeDetail();
            //emp4.DisplayEmployeeDetail();

            Employee.PrintEmpId(emp2);

            Console.WriteLine(emp1.EmpId); //get property
            //Console.WriteLine(emp1.EmpPerformance);

            //Employee.PrintEmpId(emp4);

            //Employee.GetInstance().DisplayEmployeeDetail();
        }
    }
}
