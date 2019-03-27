using System;
using System.Linq;

namespace _30DaysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }

        public static int Solution(int[] A)
        {
            var result = 1;
            var orderedArray = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < orderedArray.Count() - 1; i++)
            {
                if ((orderedArray[i] + 1) != orderedArray[i + 1])
                    return orderedArray[i] + 1;
            }

            return result;
        }
    }

    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }


        public void computeDifference()
        {
            var test = elements.OrderBy(x => x);

            maximumDifference = test.Last() - test.First();
        }
    } // End of Difference Class
}
