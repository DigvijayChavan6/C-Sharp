using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asin8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for -ve and +ve: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if(p<0) Console.WriteLine("Number is -ve ");
            else Console.WriteLine("Number is +ve ");
            Console.WriteLine("Enter First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int mx = (a < b) ? b : a;
            Console.WriteLine("Max number is : " + mx);
            Console.WriteLine("Enter year for leap or not : ");
            int lea = Convert.ToInt32(Console.ReadLine());
            if(lea%4==0) Console.WriteLine("Year is Leap");
            else Console.WriteLine("Year is NOT Leap");
            Console.ReadLine();
        }
    }
}
