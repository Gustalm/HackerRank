using System;
using System.Collections.Generic;

namespace _30DaysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];


            arr[0] = Array.ConvertAll("1 1 1 0 0 0".Split(" "), arrTemp => Convert.ToInt32(arrTemp));
            arr[1] = Array.ConvertAll("0 1 0 0 0 0".Split(" "), arrTemp => Convert.ToInt32(arrTemp));
            arr[2] = Array.ConvertAll("1 1 1 0 0 0".Split(" "), arrTemp => Convert.ToInt32(arrTemp));
            arr[3] = Array.ConvertAll("0 0 2 4 4 0".Split(" "), arrTemp => Convert.ToInt32(arrTemp));
            arr[4] = Array.ConvertAll("0 0 0 2 0 0".Split(" "), arrTemp => Convert.ToInt32(arrTemp));
            arr[5] = Array.ConvertAll("0 0 1 2 4 0".Split(" "), arrTemp => Convert.ToInt32(arrTemp));

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            var sum = GetHighestSum(arr);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int GetHighestSum(int[][] arr)
        {
            var maxSum = 0;

            for (int line = 0; line <= arr.GetLength(0) - 3; line++)
            {
                for (int column = 0; column <= arr[line].Length - 3; column++)
                {
                    var sum = arr[line][column] + arr[line][column + 1] + arr[line][column + 2];
                    sum += arr[line + 1][column + 1];
                    sum += arr[line + 2][column] + arr[line + 2][column + 1] + arr[column + 2][line];

                    maxSum = sum > maxSum ? sum : maxSum;
                }
            }

            return maxSum;
        }
    }
}
