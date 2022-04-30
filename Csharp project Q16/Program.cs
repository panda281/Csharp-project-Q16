using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if(1<= input && input <= 3)
            {
                
                Console.WriteLine("{0}",input * 10);
            }
            else if (4 <= input && input <= 6)
            {
                Console.WriteLine("{0}", input * 100);
            }
            else if (7 <= input && input <= 9)
            {
                Console.WriteLine("{0}", input * 1000);
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
