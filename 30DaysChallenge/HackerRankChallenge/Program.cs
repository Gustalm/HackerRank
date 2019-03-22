using System;
using System.Collections.Generic;
using System.Linq;

namespace _30DaysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solution(new int[] { 1, 1, 2, 2, 3 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Solution(int[] A)
        {
            var group = A.GroupBy(x => x);
            return group.Select(x => new { x.Key, Count = x.Count()}).FirstOrDefault(x => x.Count <= 1).Key;
        }
    }
}
