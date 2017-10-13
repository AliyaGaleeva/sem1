using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gs1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a != 0)
            {
                Console.Write(a.ToString());
                Console.Write("x^2");
            }
            if (b<0)
            {
                Console.Write(b.ToString());
                Console.Write("x");
            }
            if (b>0)
            {
                Console.Write("+");
                Console.Write(b.ToString());
                Console.Write("x");
            }
            if (c < 0) Console.Write(c.ToString());
            if (c>0)
            {
                Console.Write("+");
                Console.Write(c.ToString());
            }

        }
    }
}
