using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.Formulae
{
    public class Area
    {
        public static double AreaOfCirle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        //AreaOfTriangle
        public static double AreaOfTriangle(double baseValue, double height)
        {
            return (baseValue * height) / 2;
        }

        public static string GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public void Quit()
        {

        }

    }
}
