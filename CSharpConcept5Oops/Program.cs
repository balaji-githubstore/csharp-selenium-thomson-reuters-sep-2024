using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept5Oops
{
    class Father
    {
        public int fAge = 60;

        public Father(int fAge)
        {
            this.fAge = fAge;
            Console.WriteLine("father constructor"+ fAge);
        }

        public void FatherStyle()
        {
            Console.WriteLine("father style");
        }
    }
    class Son : Father
    {
        public int sAge = 20;

        public Son(int a, int b) : base(a)
        {
            Console.WriteLine("Son Constructor" + b);
        }

        public void SonStyle()
        {
            //base.FatherStyle();
            Console.WriteLine("son style");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Father father = new Father();
            //Console.WriteLine(father.fAge);
            //father.FatherStyle();

            Son son = new Son(65,25);

            Console.WriteLine(son.fAge);
            Console.WriteLine(son.sAge);

            son.FatherStyle();
            son.SonStyle();

        //}
    }
}
