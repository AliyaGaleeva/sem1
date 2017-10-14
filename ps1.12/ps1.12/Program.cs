using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double a3 = double.Parse(Console.ReadLine());
            double c1, c2, z1, z2, y, x;
            c1 = (y1 - y2) / (x2 - x1);
            c2 = (y1 - y3) / (x3 - x1);
            z1 = (y2 * y2 - y1 * y1 + a1 * a1 - a2 * a2 + x2 * x2 - x1 * x1) / 2 / (x2 - x1);
            z2= (y3 * y3 - y1 * y1 + a1 * a1 - a3 * a3 + x3 * x3 - x1 * x1) / 2 / (x3 - x1);
            y = (z2 - z1) / (c1 - c2);
            x = Math.Sqrt(a1 * a1 - (y - y1) * (y - y1)) + x1;
            Console.WriteLine($"x={x}  y={y}", x, y);
        }
    }
}
