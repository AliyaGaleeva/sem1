using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            A = A % 10;
            if (A==0 || B==0) Console.WriteLine("0");
            if (A == 1) Console.WriteLine("1");
            if (A==2) 
            {
                if ( B%4==0) Console.WriteLine("6");
                if ( B % 4 == 1) Console.WriteLine("2");
                if ( B % 4 == 2) Console.WriteLine("4");
                if ( B % 4 == 3) Console.WriteLine("8");
            }
            if (A == 3)
            {
                if (B % 4 == 0) Console.WriteLine("1");
                if (B % 4 == 1) Console.WriteLine("3");
                if (B % 4 == 2) Console.WriteLine("9");
                if (B % 4 == 3) Console.WriteLine("7");
            }
            if (A == 4)
            {
                if (B % 2 == 0) Console.WriteLine("6");
                if (B % 2 == 1) Console.WriteLine("4");
            }
            if (A == 5) Console.WriteLine("5");
            if (A == 6) Console.WriteLine("6");
            if (A == 7)
            {
                if (B % 4 == 0) Console.WriteLine("1");
                if (B % 4 == 1) Console.WriteLine("7");
                if (B % 4 == 2) Console.WriteLine("9");
                if (B % 4 == 3) Console.WriteLine("3");
            }
            if (A == 8)
            {
                if (B % 4 == 0) Console.WriteLine("6");
                if (B % 4 == 1) Console.WriteLine("8");
                if (B % 4 == 2) Console.WriteLine("4");
                if (B % 4 == 3) Console.WriteLine("2");
            }
            if (A == 9)
            {
                if (B % 2 == 0) Console.WriteLine("1");
                if (B % 2 == 1) Console.WriteLine("9");
            }


        }
    }
}
