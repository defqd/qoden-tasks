using System;

namespace task1
{
    public class HashTable
    {
        private readonly int _size;
        private ListNode[] _values;

        public HashTable(int n)
        {
            _size = n;
            _values = new ListNode[_size];
        }
        public void Insert(int newValue)
        {
            int hash = newValue % _size;

            if (_values[hash] == null)
            {
                _values[hash] = new ListNode();
            }

            _values[hash].Insert(newValue);
        }

        public void PrintHashTable()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write($"{i}: ");

                if (_values[i] != null)
                {
                    _values[i].GetNode();
                }

                Console.WriteLine();
            }
        }
    }
}