using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius of Circle: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double area = r *Math.PI * r;
            Console.Write("Area is : " + area);
            Console.ReadLine();
        }
    }
}
