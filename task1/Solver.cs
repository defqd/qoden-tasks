using System;

namespace task1
{
    public class Solver
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            HashTable hashTable = new HashTable(N);

            string input = Console.ReadLine();

            var numbers = input.Split(' ');

            foreach (var number in numbers)
            {
                var value = Convert.ToInt32(number);
                hashTable.Insert(value);
            }

            hashTable.PrintHashTable();
        }
    }
}