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
            int a = 1;
            int b = 101;
            if (a < b)
            {
                a = 2 * a;
            }
        else 
            {
                b = a;
            }
            System.Console.WriteLine("Значение а = {0}, Значение b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
