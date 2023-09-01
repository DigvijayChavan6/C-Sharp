using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius of Circle: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double peri = 2 * Math.PI * r;
            Console.Write("Perimeter is : "+peri);
            Console.ReadLine();
        }
    }
}
