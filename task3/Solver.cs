using System;
using System.Collections.Generic;

namespace task3
{
    public class Solver
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Stack<int> stack = new Stack<int>();

            foreach (var item in input)
            {
                if(int.TryParse(item, out int num))
                {
                    stack.Push(num);
                }
                else
                {
                    int second = stack.Pop();
                    int first = stack.Pop();

                    switch (item)
                    {
                        case "+":
                            stack.Push(first + second);
                            break;
                        case "-":
                            stack.Push(first - second);
                            break;
                        case "*":
                            stack.Push(first * second);
                            break;
                        case "/":
                            stack.Push(first / second);
                            break;
                    }
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}