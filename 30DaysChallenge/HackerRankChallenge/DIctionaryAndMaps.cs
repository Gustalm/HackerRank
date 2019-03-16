using System;
using System.Collections.Generic;

namespace _30DaysChallenge
{
    class DIctionaryAndMaps
    {
        static void Main2(String[] args)
        {
            int inputTimes = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < inputTimes; i++)
            {
                var keyValuePair = Console.ReadLine().GetAddressRow();
                dictionary.Add(keyValuePair.Key, keyValuePair.Value);
            }

            var query = "a";
            while (!string.IsNullOrEmpty(query))
            {
                query = Console.ReadLine();
                if (!string.IsNullOrEmpty(query))
                    if (dictionary.TryGetValue(query, out var result))
                        Console.WriteLine($"{query}={result}");
                    else
                        Console.WriteLine("Not found");
            }
        }
    }

    public static class StringExtension
    {
        public static KeyValuePair<string, int> GetAddressRow(this string value)
        {
            var splittedValues = value.Split(' ');
            return new KeyValuePair<string, int>(splittedValues[0], Convert.ToInt32(splittedValues[1]));
        }
    }
}
