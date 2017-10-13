using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[n];
            int a; int s = 0; int c = 0;
            for (a = 1; a < n; a++)
            {
                s = 0;
                for (int i = 1; i <=n; i++)
                {
                    if (a % i == 0) s = s + i;

                }
                sum[a] = s;
            }
            for (int j = 1; j <= n / 2; j++)
            {
                for (int i = j; i < n; i++)
                {
                    if (i + j > n) break;
                    if (sum[j]==sum[i] && sum[j]==i+j)
                    {
                      
                        Console.Write($"{j} {i}",j,i);
                        Console.WriteLine();
                         c = 1;
                    }
                }
            }
            if (c != 1) Console.WriteLine("no");
        }
    }
}
