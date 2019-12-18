using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class minmax
    {
        public void getMinMax(int[] arr,int size)
        {
            int min = new int();
            min=arr[0];
            for (int i=1; i < size; i++)
            {
                if (arr[i] < min )
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum of array is : "+min);

            int max = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum of array is : " + max);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            minmax obj = new minmax();

            
            int n,i;

            Console.WriteLine("How many elements you want to enter ?");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Enter elements of an array : ");

            for (i = 0 ; i < n ; i++)
            {
               a[i]= Convert.ToInt32(Console.ReadLine());
            }
            obj.getMinMax(a,n);
        }
    }
}
