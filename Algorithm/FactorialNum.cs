using System;
using System.Linq;

namespace Algorithm
{
    public class FactorialNum
    {
        public static void FactorialNum()
        {
            int h = 1;
            Console.WriteLine("Input value N! = ");

            int n = int.Parse(Console.In.ReadLine());

            Console.WriteLine(n + "! = ");

            for (int i = 1; i <= n; i++)
            {
                h = h * i;
                Console.Write(n - (n - i));
                if (i != n)
                    Console.Write("*");


            }
            Console.WriteLine();
            Console.Write(n + "! = ");
            Console.WriteLine(h);
        }
    }
}
