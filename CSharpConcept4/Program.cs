using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.CSharpConcept
{
    public class Program
    {

        static void Maine(string[] args)
        {
            // string[] colors = { "Red", "Yellow", "Green" };

            //// Console.WriteLine(colors[0]);

            // //for (int i = 0; i < colors.Length; i++)
            // //{
            // //    Console.WriteLine(colors[i]);
            // //}

            // foreach(string color in colors)
            // {
            //     Console.WriteLine(color);
            // }

            string[] colors = { "Red", "Yellow", "Green" };

            foreach (string color in colors)
            {
                if (color.ToLower().Equals("red"))
                {
                    Console.WriteLine(color);
                }
                else
                {
                    Console.WriteLine(color);
                }

                break;
            }
        }
    }
}


