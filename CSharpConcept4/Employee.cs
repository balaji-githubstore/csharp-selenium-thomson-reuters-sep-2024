using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept4
{
    //class Employee
    //{
    //    int empNo;
    //    Employee(int empNo)
    //    {
    //        this.empNo = empNo;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Employee emp = new Employee(101);
    //        Console.WriteLine(emp.empNo);
    //    }
    //}

    //class Output
    //{
    //    int a;
    //    int b;

    //    public void meth(int i, int j)
    //    {
    //        i++;
    //        j++;
    //    }
    //}
    //class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        Output obj = new Output();
    //        int a = 10;
    //        int b = 20;
    //        obj.meth(a, b);
    //        Console.WriteLine(a + " " + b);
    //    }

    //}
    class Overload
    {
        public int x;
        public int y;

        public void add(int a)
        {
            x = a + 1;
        }

        public void add(int a, int b)
        {
            x = a + 2;
        }
    }
    class Overload_methods
    {
        public static void Main(String[] args)
        {
            Overload obj = new Overload();
            int a = 0;
            obj.add(6);
            Console.WriteLine(obj.x);
        }
    }
}
