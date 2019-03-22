using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30DaysChallenge
{
    public class RorateArray
    {
        public static int[] Solution(int[] A, int K)
        {
            var lastIndex = A.Length - 1;

            if (A.Length == 0)
                return A;

            for (int i = 1; i <= K; i++)
            {
                var array = A.ToList();

                array.Insert(0, array[array.Count - 1]);
                array.RemoveAt(array.Count - 1);

                A = array.ToArray();
            }

            return A;
        }
    }
}
