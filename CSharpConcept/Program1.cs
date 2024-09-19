using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.CSharpConcept
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone!!!");
            Console.WriteLine("Welcome to the Session!!!");

            sbyte a = 100; //a is reserved for sbyte. 1 byte or 8 bits 
            byte b = 100; //b is reserved for byte. 1 byte or 8 bits
            short c = 100; //2 byte or 16 bits 
            int d = 100; //4 byte or 32 bits

            //1000 students --> byte --> 8000 bits of memory
            //1000 students --> int --> 32000 bits of memory 
            long l = 88343848384L; //64 bits

            float e= 1.2F;//4 byte or 32 bits
            double f = 1.2;//64 bits

            char k = '#';//16 bits
            bool g = true;

            Console.WriteLine(a);
            Console.WriteLine(k);

            string myName = "bala"; //4*16 bits

            Console.WriteLine(myName);
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.Length);

            //40,30,69,78,99

            int[] numbers=new int[5]; //5*32 bits 
            numbers[0] = 40;
            numbers[1] = 30;
            numbers[2] = 69;
            numbers[3] = 78;
            numbers[4] = 99;

            Console.WriteLine(numbers);
            Console.WriteLine(numbers[1]);

            double[] numbers2 = new double[2]; //2*64 bits
            numbers2[0] = 90.9; 
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[1]);

            //create an array to store - red,green,yellow
            string[] colors=new string[3];
            colors[0] = "red"; //3*16 bits
            colors[1] = "green";//5*16 bits
            colors[2] = "yellow";//6*16 bits

           // colors[1] = "blue";
            
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);

            string[] colors1 = { "red", "green", "yellow" };
        }
    }
}
