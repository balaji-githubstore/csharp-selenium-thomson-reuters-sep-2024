using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.Formulae;

namespace CSharpConcept2
{
    public class Program
    {
        static void Main(string[] args)
        {

            int radius = 10;

            double result = Area.AreaOfCirle(10);
            Console.WriteLine(result);

            result = Area.AreaOfCirle(20);
            Console.WriteLine(result);

            Console.WriteLine(Area.AreaOfCirle(30));

            //load all non-static fields in memory
            Area obj=new Area();

            double output = obj.AreaOfRectangle(10, 2.5);
            Console.WriteLine(output);

            Console.WriteLine(Area.AreaOfTriangle(25,1));

            string name=Area.GetAuthorName();
            Console.WriteLine(name);

            obj.Quit();
        }
    }
}
