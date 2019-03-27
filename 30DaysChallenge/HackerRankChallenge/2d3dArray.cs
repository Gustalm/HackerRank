using System;

namespace _30DaysChallenge
{
    class _2d3dArray
    {
        static void Main2(string[] args)
        {
            int[][] arr = new int[6][];


            arr[0] = Array.ConvertAll("-1 -1 0 -9 -2 -2".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            arr[1] = Array.ConvertAll("-2 -1 -6 -8 -2 -5".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            arr[2] = Array.ConvertAll("-1 -1 -1 -2 -3 -4".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            arr[3] = Array.ConvertAll("-1 -9 -2 -4 -4 -5".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            arr[4] = Array.ConvertAll("-7 -3 -3 -2 -9 -9".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            arr[5] = Array.ConvertAll("-1 -3 -1 -2 -4 -5".Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            var sum = GetHighestSum(arr);

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int GetHighestSum(int[][] arr)
        {
            var maxSum = -int.MaxValue;
            for (int column = 0; column < arr.GetLength(0) - 2; column++)
            {
                for (int line = 0; line < arr[column].Length - 2; line++)
                {
                    var sum = arr[line][column] + arr[line][column + 1] + arr[line][column + 2];
                    sum += arr[line + 1][column + 1];
                    sum += arr[line + 2][column] + arr[line + 2][column + 1] + arr[line + 2][column + 2];

                    maxSum = sum > maxSum ? sum : maxSum;
                }
            }

            return maxSum;
        }
    }
}
