using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Height of Triangle : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Base of Triangle : ");
            int b = Convert.ToInt32(Console.ReadLine());
            double area = .5 * h * b ;
            Console.Write("Area is : " + area);
            Console.ReadLine();
        }
    }
}
