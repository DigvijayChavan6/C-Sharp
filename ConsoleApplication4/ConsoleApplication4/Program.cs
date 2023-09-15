using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
   public  class sumofdigit
    {
        public static int add(int n)
        {
            int sum = 0;
            int rem;

            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number::");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum =sumofdigit.add(n);

            Console.WriteLine("The sum of digit is::" + sum);

            Console.ReadLine();
        }
    }
}
