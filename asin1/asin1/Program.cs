 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1:Addition");
                Console.WriteLine("2:Subtraction");
                Console.WriteLine("3:Multiplication");
                Console.WriteLine("4:Division");
                Console.WriteLine("5:Remainder");
                Console.WriteLine("6:Exit");
                Console.Write("Enter your choise: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 6) break;
                int r=0, a, b;
                Console.Write("Enter First Number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter First Number: ");
                b = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        r = a + b;
                        break;
                    case 2:
                        r = a - b;
                        break;
                    case 3:
                        r = a * b;
                        break;
                    case 4:
                        r = a / b;
                        break;
                    case 5:
                        r = a % b;
                        break;
                    default:
                        Console.Write("Invalid Choise.");
                        break;

                }
                Console.Write("Answer is : "+r);
            }
        }
    }
}
