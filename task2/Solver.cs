using System;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    public class Solver
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var result = WordFrequency(input);

            Print(result);
        }
		
        public static Dictionary<string, int> WordFrequency(string[] input)
        {
            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 1);
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            dictionary = dictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return dictionary;
        }

        public static void Print(Dictionary<string, int> dictionary)
        {
            int maxWordLength = dictionary.Keys.OrderByDescending(x => x.Length).First().Length;

            double maxCountDots = dictionary.Values.OrderByDescending(x => x).First();

            foreach (var item in dictionary)
            {
                for (int i = item.Key.Length; i < maxWordLength; i++)
                {
                    Console.Write("_");
                }

                Console.Write($"{item.Key} ");

                double newCountDots = Math.Round(10.0d * item.Value / maxCountDots, MidpointRounding.AwayFromZero);

                for (int i = 0; i < newCountDots; i++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }
        }
    }
}