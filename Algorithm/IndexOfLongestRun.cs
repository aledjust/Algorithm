using System;
using System.Linq;

namespace Algorithm
{
    public class IndexOfLongestRun
    {
        public static int IndexOfLongestRun(string n)
        {
            int bestIndex = 0, bestScore = 0, currIndex = 0;
            for (var i = 0; i < n.Length; ++i)
            {
                if (n[i] == n[currIndex])
                {
                    if (bestScore < i - currIndex)
                    {
                        bestIndex = currIndex;
                        bestScore = i - currIndex;
                    }
                }
                else
                {
                    currIndex = i;
                }
            }
            return bestIndex;
        }
    }
}
