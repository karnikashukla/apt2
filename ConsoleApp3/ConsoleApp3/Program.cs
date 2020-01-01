using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void Event_Handler(string S);
namespace ConsoleApp3
{
    class Program
    {
        public event Event_Handler Firt_Event;

        public class Demo
        {
            public void MyEvent()
            {
                Console.WriteLine("String is modified.!");
            }
            public static void modify(string s1)
            {
                Console.WriteLine("Enter any character to replace : ");
                string s3 = Console.ReadLine();
                Console.WriteLine("Enter new character to replace : ");
                string s2 = Console.ReadLine();
                Console.WriteLine("New String is : " + s1.Replace(s3, s2));

            }
            static void Main(string[] args)
            {
                Demo obj = new Demo();
                Event_Handler eve = new Event_Handler(modify);
                Console.WriteLine("Enter any string : ");
                string s = Console.ReadLine();
                eve(s);
                obj.MyEvent();
            }
        }
    }
}
