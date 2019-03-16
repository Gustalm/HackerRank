using System;
using System.Collections.Generic;

namespace _30DaysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Convert.ToString(int.MaxValue, 2);
            Console.WriteLine(result);
            var aox = result.ToCharArray();
            var result2 = aox.GetMaxConsecutiveValue('1');
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }


    public static class ArrayExtension
    {
        public static int GetMaxConsecutiveValue(this char[] obj, char value)
        {
            var highestConsecutiveSoFar = 0;
            var highestOnLoop = 0;
            for (int i = 0; i <= obj.Length - 1; i++)
            {
                if (highestOnLoop == 0 && obj[i] == value)
                {
                    highestOnLoop++;
                    if (obj.Length == 1)
                        highestConsecutiveSoFar = highestOnLoop;

                    continue;
                }

                if ((obj[i - 1] == obj[i] && obj[i] == value)|| (obj[i] == value && highestOnLoop == 0))
                    highestOnLoop++;
                else
                {
                    highestConsecutiveSoFar = highestOnLoop > highestConsecutiveSoFar ? highestOnLoop : highestConsecutiveSoFar;
                    highestOnLoop = 0;
                }

                if (i == obj.Length - 1)
                    highestConsecutiveSoFar = highestOnLoop > highestConsecutiveSoFar ? highestOnLoop : highestConsecutiveSoFar;
            }

            return highestConsecutiveSoFar;
        }
    }
}
