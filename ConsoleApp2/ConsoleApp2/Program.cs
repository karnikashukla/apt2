using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate string string_op(string s);
namespace ConsoleApp2
{
    class Program
    {
        public static String Concate_Str(string ss)
        {
            Console.WriteLine("Enter another string : ");
            string s2 = Console.ReadLine();
            string s3 = String.Concat(ss,s2);
            return s3;
        }
        public static String Reverse_Str(string ss)
        {
            string c = new string(ss.ToCharArray().Reverse().ToArray());
            return c;
        }

        static void Main(string[] args)
        {
            string_op op1 = new string_op(Concate_Str);
            string_op op2 = new string_op(Reverse_Str);
            string_op op3,op4,op5;
            Console.WriteLine("Enter one string : ");
            string s1 = Console.ReadLine();
            string con = op1(s1);
            Console.WriteLine("Concated string is : {0}",con);
            string rev = op2(s1);
            Console.WriteLine("Reversed string is : {0}", rev);
            op4 = Concate_Str;
            op5 = Reverse_Str;
            op3 = op4 + op5;
            Console.WriteLine("Combined Delegate is : {0}",op3);
            Console.ReadKey();
        }
    }
}
