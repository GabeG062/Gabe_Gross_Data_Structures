using System;
using System.Collections.Generic;
namespace BinaryNumbersQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            int n = GetInt(" ",1, 100);
            queue.Enqueue("1");
            for (int i = 1; i <= n; i++)
            {
                string next = queue.Dequeue();
                queue.Enqueue(next + "0");
                queue.Enqueue(next + "1");
                Console.WriteLine(next);
            }
            Console.ReadLine();
        }

        public static int GetInt(string label, int min, int max)
        {
            bool isInt = false; 
            int number = min - 1;

            do
            {
                Console.Write(String.Format("Enter a positive integer number between {0} and {1} for {2}", min, max, label));
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            }
            while (!(isInt && number >= min && number <= max));
            
            return number;
        }
        /*
         * set up an equation that checks what the current value of the input,
         * then start multiplying a base value of 1 by 2 until it equals or is greater than input
         * for each time this happens, add another digit to the Queue
         * 
         * make a secondary equation to determine if the digit in the queue would be 0 or 1
         */
        public static int Binary(int input)
        {
            int starter = 1;
            
            while (starter < input)
            {
                starter = starter * 2;
            }
            return starter;
        }
    }
}
