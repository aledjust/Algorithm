using System;
using System.Linq;

namespace Algorithm
{
    public class Triangle
    {
        public static void Segitiga(int n)
        {
            int a, b;

            for (a = 1; a <= n; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Segitiga2(int n)
        {
            int a, b;

            for (a = 1; a <= n; a++)
            {
                for (b = a; b <= n; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void Segitiga3(int n)
        {
            int a, b, c;

            for (a = 1; a <= n; a++)
            {
                for (b = a; b < n; b++)
                {
                    Console.Write(" ");
                }

                for (c = 1; c <= a; c++)
                    Console.Write("*");

                Console.WriteLine();
            }

        }
    }
}
