using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void CalArea(float a, float b);
namespace ConsoleApp1
{
    class Program
    {
        const double pi = 3.14;
        public static void Rectangle(float hh, float ww)
        {
            double a;
            a = hh * ww;
            Console.WriteLine("Area of Rectangle is : {0}",a);
        }
        public static void Circle(float rr, float ii)
        {
            double a;
            a = pi * rr * rr;
            Console.WriteLine("Area of Circle is : {0}", a);
        }
        static void Main(string[] args)
        {
            CalArea rect = new CalArea(Rectangle);
            CalArea cir = new CalArea(Circle);
            float h, w, r;
            Console.WriteLine("Enter height of a rectangle : ");
            h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter width of a rectangle : ");
            w = Convert.ToSingle(Console.ReadLine());
            rect(h,w);
            Console.WriteLine("Enter radius of a circle : ");
            r = Convert.ToSingle(Console.ReadLine());
            cir(r,0);
        }
    }
}
