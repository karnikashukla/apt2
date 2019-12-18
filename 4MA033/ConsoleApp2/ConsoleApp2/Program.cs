using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Area
    {
        const double pi = 3.14;

        public void area(double r)
        {
            double a;
            a = pi * r * r;

            Console.WriteLine("Area of circle is  : "+a);
        }
        public void area(double l, double w)
        {
            double a;
            a = l * w;

            Console.WriteLine("Area of rectangle is  : " + a);
        }
        public void area(double bb, double hh,int i)
        {
            double a;
            a = (bb * hh)/2;

            Console.WriteLine("Area of triangle is  : " + a);
        }
        public void area(double aa, int i)
        {
            double a;
            a = aa*aa;

            Console.WriteLine("Area of square is  : " + a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Area obj = new Area();
            Console.WriteLine("Enter radius of a circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            obj.area(radius);

            Console.WriteLine("Enter length of rectangle : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width of a rectangle : ");
            double width = Convert.ToDouble(Console.ReadLine());
            obj.area(length,width);

            Console.WriteLine("Enter base of triangle : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of triangle : ");
            double h = Convert.ToDouble(Console.ReadLine());

            obj.area(b,h,0);

            Console.WriteLine("Enter side of square : ");
            double s = Convert.ToDouble(Console.ReadLine());

            obj.area(s,0);
        }
    }
}
