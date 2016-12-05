using System;
using System.Linq;

namespace Algorithm
{
    public class PrimaNumber
    {
        public static void PrimaNumber()
        {
            Console.Write("Masukkan batas atas bilangan prima : ");
            //inisialisasi
            bool prima = true;
            int bilangan = int.Parse(Console.ReadLine());

            if (bilangan >= 2)
            {
                //loop hingga batas bilangan tercapai
                for (int i = 2; i <= bilangan; i++)
                {
                    //loop mulai dari 2 ke i
                    for (int j = 2; j < i; j++)
                    {
                        //bukan blangan prima jika i habis dibagi j
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }
                    //jika bilangan == prima
                    if (prima)
                        Console.WriteLine("bilangan " + i + " adalah Prima");
                    prima = true;
                }
            }
            else Console.WriteLine("tidak ada bilangan prima");
            Console.ReadLine();
        }
    }
}
