using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[5][];

            
            jagged_arr[0] = new int[] { 1, 5, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };
            jagged_arr[4] = new int[] { 50, 45, 85, 14, 58 };
            for (int i = 0; i < jagged_arr.Length; i++)
            {

                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Array.Sort(jagged_arr[i]);
                }
           
            }
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                System.Console.Write("Row({0}): ", i);
                for (int j= 0; j < jagged_arr[i].Length; j++)
                {
                    System.Console.Write("{0} ", jagged_arr[i][j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
