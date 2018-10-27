using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Puzzler 3
        static int divide(int a, int b)
        {
          // if (b == 0) return 0; 
          if (b == 0) {throw new DivideByZeroException();}

            return a / b;
        }
        
        //Puzzler 2
       static void foo()
        {
            foo();
        }
        
        //Puzzler 1
        static int min(int a, int b)
        {
            if (a < b)
            return a;
            else 
            return b;
        }
        
        static void Main(string[] args)
        {
            foo();
            Console.ReadKey();
        }
    }
}
