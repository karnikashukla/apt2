using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            int count=1;
            string[] str = new string[10];
            Console.WriteLine("How many strings you want to enter ?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of an array : ");
            for (i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Array elements are : ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(str[i]);
            }

            for (i = 0; i < n; i++)
            {
                for (int j = i+1; j < n ; j++)
                {
                     if (str[i] == str[j])
                    {
                        count = count + 1;
                        Console.WriteLine(str[j]+" is duplicate, occurs "+count+" times.");
                    }
                                       
                }
           
            }


        }
    }
}
