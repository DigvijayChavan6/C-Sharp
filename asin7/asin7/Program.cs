using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int mx = (a < b) ?  b :  a;
            Console.Write("Max number is : " + mx);
            Console.ReadLine();
        }
    }
}
