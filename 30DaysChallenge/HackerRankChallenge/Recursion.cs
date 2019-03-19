using System;
using System.Linq;

namespace _30DaysChallenge
{
    class Recursion
    {
        // Complete the factorial function below.
        static int factorial(int n)
        {
            var result = 0;
            for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine("i: " + i);
                result = result == 0 ? n * i : result * i;
            }
            int[] scores = { 1, 2, 3 };
            scores.Average();

            return result;
        }
    }
}
