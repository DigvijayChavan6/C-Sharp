using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 2 == 0) ? "Even" : "Odd");
            Console.Read();
        }
    }
}
