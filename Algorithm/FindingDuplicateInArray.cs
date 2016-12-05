using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class FindingDuplicateInArray
    {
        public static void FindingDuplicateInArray(int[] array)
        {
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();
        }
    }
}
