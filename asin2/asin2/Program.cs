using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int avg = (a + b + c) / 3;
            Console.Write("Average of three numbers is : "+avg);
            Console.ReadLine();
        }
    }
}
