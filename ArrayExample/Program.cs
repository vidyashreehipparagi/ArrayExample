using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[7] { "John", "Games", "Milton", "Ruee", "Radha", "Harry", "Shruti" };
            string[] sub = new string[7] { "ab", "bc", "cd", "de", "re", "ee", "qw" };
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);

            }
            Array.Sort(str);
            Console.WriteLine("________________-After Sort_____________");
            foreach (string values in str)
            {
                Console.WriteLine(values);
            }
            Array.Reverse(str);
            Console.WriteLine("--------------------After Reverse---------");
            foreach(string values in str)
            {
                Console.WriteLine(values);
            }
            
            
                Array.Copy(str,3,sub,4,5);
            Console.WriteLine("=======");
            
                foreach(string values in str)
                {
                    Console.WriteLine(sub);
                }
            }
        }
    }

