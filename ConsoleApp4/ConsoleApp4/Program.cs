using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        class FileOperations
        {
            public void write()
            {
                StreamWriter sw = new StreamWriter("D://hello.txt");

                Console.WriteLine("Write something in file : ");
                String str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
            }
            public void Read()
            {
                StreamReader sr = new StreamReader("D://hello.txt");
                Console.WriteLine("Content of file is : ");
                string str1 = sr.ReadLine();
                if(str1 != null)
                {
                    Console.WriteLine(str1);
                    str1 = sr.ReadLine();
                }
                Console.ReadLine();

                sr.Close();
            }
        }
        static void Main(string[] args)
        {
            FileOperations obj = new FileOperations();
            obj.write();
            obj.Read();
            Console.ReadKey();
        }
    }
}
