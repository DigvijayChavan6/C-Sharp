using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Side of Square : ");
            int s = Convert.ToInt32(Console.ReadLine());
            int area = s * s;
            Console.Write("Area of Square is : "+area);
            Console.ReadLine();
        }
    }
}
