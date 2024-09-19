using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        private int empId;
        public string empName;
        public double empSalary;
        private string empPerformance;
        public static string companyName;

        //Constructor 
        public Employee()
        {
            Console.WriteLine("Object created!!!");
            Console.WriteLine("Launch browser");
        }
        public Employee(int empId)
        {
            Console.WriteLine("Object created!!!");
            Console.WriteLine("Launch browser");
            this.empId = empId;
        }

        public Employee(int empId,string empName)
        {
            Console.WriteLine("Object created!!!");
            Console.WriteLine("Launch browser");
            this.empId = empId;
            this.empName = empName;
        }

        public Employee(string empName, int empId)
        {
            Console.WriteLine("Object created!!!");
            Console.WriteLine("Launch browser");
            this.empId = empId;
            this.empName = empName;
        }

        public int EmpId
        {
            get 
            { 
                return empId; 
            }
            set
            {
                if (value > 100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine("Currently employee id is 0. Please provide value more than 100");
                }
            }
        }

        //set property should validate and accept empPerformance only if it A or B or C
        public string EmpPerformance
        {
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("B"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Enter Performance either A or B or C");
                }
            }
        }

        public void DisplayEmployeeDetail()
        {
            //int empId = 999;
            Console.WriteLine("Employee Id: " + this.empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + this.empSalary);
            Console.WriteLine("Employee Performance: " + empPerformance);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("------------------------------------------------");
        }

        //AllocateBonus
        public void AllocateBonus()
        {
            if(empPerformance !=null)
            {
                if (empPerformance.Equals("A"))
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }
            }
        }

        //public static Employee GetInstance()
        //{
        //    Employee e=new Employee();
        //    return e;
        //}

        public static void PrintEmpId(Employee emp)
        {
            Console.WriteLine(emp.empId);
            Console.WriteLine(emp.empName);
        }
    }
}
