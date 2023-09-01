using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, N;
            Console.WriteLine("Enter your age:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You are Indian enter 1 if not then enter 0:");
            N = Int32.Parse(Console.ReadLine());
            if (N == 1)
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible for Vote");
                }
                else
                {
                    Console.WriteLine("You are NOT eligible for Vote");
                }
            }
            else
            {
                Console.WriteLine("You are NOT eligible for Vote");
            }
            Console.ReadLine();
        }
    }
}
