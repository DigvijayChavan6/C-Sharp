using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class mathapp
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int c = mathapp.Add(12, 23);
            Console.WriteLine("The sum is:" + c);
            int d = mathapp.sub(24, 23);
            Console.WriteLine("The sub is:" + d);
            Console.ReadLine();
        }
    }
}
