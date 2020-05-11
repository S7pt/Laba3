using System;
using System.IO;

namespace _3._2
{
    class Program
    {
        static void FromFileTextEditor(string path)
        {
            string text = File.ReadAllText(path);
            string[] textToWorkWith = text.Split(" ");
            int lettersCount = textToWorkWith[0].Length;
            Console.WriteLine("Your surname has {0} letters", lettersCount);
            for(int i = 0; i < textToWorkWith[0].Length; i++)
            {
                Console.WriteLine(textToWorkWith[0][i]);
            }
            int ageToPlus = int.Parse(textToWorkWith[1]);
            ageToPlus += 10;
            Console.WriteLine();
            Console.WriteLine(ageToPlus);
        }
        static void Main(string[] args)
        {
            string path = @"D:\Task.txt";
            FromFileTextEditor(path);
        }
    }
}
