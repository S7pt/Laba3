using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _3._1
{
    class Program
    {
         static string ToLowerRegister(string inputString)
        {
            inputString = inputString.ToLower();
            return inputString;
        }
        static void PrintWordsWithEvenNumberOfLetters(string inputString)
        {
            string[] editedString = inputString.Split(" ");
            foreach(var element in editedString)
            {
                int counter = element.Length;
                if (counter % 2 == 0)
                {
                    Console.WriteLine(element);
                }
            }
        }

        
         static void Main(string[] args)
        {
            Console.WriteLine("Type any string:");
           string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("1.");
            Console.WriteLine(ToLowerRegister(input));
            Console.WriteLine("2.");
            PrintWordsWithEvenNumberOfLetters(input);
 }
}}

