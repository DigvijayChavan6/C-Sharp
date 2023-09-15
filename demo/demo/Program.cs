using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static int my(int one,int two,int three)
        {
            int i = 1,t=0,h=0,mx=0;
            while (one != 0) {
                int a = one % 10;
                int b = two % 10;
                int c = three % 10;
                if (i == 4) t = a;
                if (i == 3) h = b;
                if (mx < c) mx = c;
                one /= 10;
                two /= 10;
                three /= 10;
                i++;
            }
            return t*h-mx;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number having 4 digits first : ");
            int on = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number having 4 digits first : ");
            int tw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number having 4 digits first : ");
            int th = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Password is : "+ my(on, tw, th));
            Console.ReadLine();
        }
    }
}
