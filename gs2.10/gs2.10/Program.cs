using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gs2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                int a = n % 2;
                Console.Write(a.ToString());
                n = n / 2;
            }
        }
    }
}
