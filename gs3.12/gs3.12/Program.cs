using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gs3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int min = int.Parse(Console.ReadLine());
            count++;
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0) break;
                else
                {
                    if (a < min)
                    {
                        min = a;
                        count = 0;
                    }
                    if (a == min) count++;
                }
            }
            Console.WriteLine(count.ToString());
        }
    }
}
