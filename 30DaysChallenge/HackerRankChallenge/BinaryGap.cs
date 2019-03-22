using System;
using System.Linq;

namespace _30DaysChallenge
{
    class BinaryGap
    {
        static void Main2(string[] args)
        {
            var value = Convert.ToInt32(11111);
            var highestBinaryGapy = GetHighestBinaryGap(value);

            Console.WriteLine(highestBinaryGapy);
            Console.ReadLine();
        }

        static int GetHighestBinaryGap(int number)
        {
            string binaryString = Convert.ToString(number, 2);
            Console.WriteLine(binaryString);
            var arrayBinary = Convert.ToString(number, 2).Select(x => (int)Char.GetNumericValue(x)).ToArray();
            var binaryIndexes = arrayBinary.Select((value, index) => new { value, index }).Where(x => x.value == 1).Select(x => x.index).ToArray();
            var result = CalculateBinaryGapIndexes(binaryIndexes);

            return result;
        }

        private static int CalculateBinaryGapIndexes(int[] indexes)
        {
            var highestGap = 0;
            for (int i = 0; i < indexes.Length - 1; i++)
            {
                var currentGap = (indexes[i + 1] - indexes[i]) - 1;
                highestGap = highestGap > currentGap ? highestGap : currentGap;
            }

            return highestGap;
        }
    }
}
