using System;
using System.Collections.Generic;

namespace StringReverseStack
{
    class Program
    {
        //enter a string from the keyboard and prints the string in reverse order, EX: typed in "Hello", get back "olleH"
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence or numbers");
            string input = Console.ReadLine();
            char[] combinedInput = input.ToCharArray();
            string[] combinedString = new string[combinedInput.Length];
            for (int i = 0; i < combinedInput.Length; i++)
            {
                combinedString[i] = combinedInput[i].ToString();
            }
            Console.WriteLine($"combinedString length: {combinedString.Length}");
            Console.WriteLine();
            Console.WriteLine($"the reversed version of {input} is {Reverser(combinedString)}");
        }

        static string Reverser(string[] combinedString)
        {
            
            Stack<string> stack = new Stack<string>(combinedString);
            int length = stack.Count;
            string[] reversedArray = new string[stack.Count];
            string reversedResult = string.Empty;
            
            for (int i = 0; i < length; i++ )
            {
                reversedArray[i] = stack.Pop();
            }
            reversedResult = string.Join("", reversedArray);
            return reversedResult;
        }
    }
}
