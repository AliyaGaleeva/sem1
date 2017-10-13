using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gs3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                for (int i = 1; i < n; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    if ((i%2==0 && num<0) ||(i%2==1 && num > 0))
                    {
                        Console.WriteLine("no");
                        a = 0;
                        break;
                    }

                }
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    if ((i % 2 == 0 && num > 0) || (i % 2 == 1 && num < 0))
                    {
                        Console.WriteLine("no");
                        a = 0;
                        break;
                    }

                }
            }
            if (a == 1) Console.WriteLine("yes");
        }
    }
}
