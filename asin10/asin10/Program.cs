using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1:Area of Square");
                Console.WriteLine("2:Area of Circle");
                Console.WriteLine("3:Area of Rectangle");
                Console.WriteLine("4:Exit");
                Console.Write("Enter your choise: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 4) break;
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter Side of Square : ");
                        int s = Convert.ToInt32(Console.ReadLine());
                        double ar = s * s;
                        Console.Write("Area of Square is : " + ar);
                        break;
                    case 2:
                        Console.Write("Enter Radius of Circle : ");
                        int r = Convert.ToInt32(Console.ReadLine());
                        double arc = r * Math.PI * r;
                        Console.Write("Area of Circle is : " + arc);
                        break;
                    case 3:
                        Console.Write("Enter Height of Square : ");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Breadth of Square : ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        double arr = h * b;
                        Console.Write("Area of Rectangle is : " + arr);
                        break;
                    default:
                        Console.Write("Invalid Choise.");
                        break;

                }
            }
        }
    }
}
