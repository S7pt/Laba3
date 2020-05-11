using System;
using System.IO;

namespace _3._3
{
    class Program
    {
        static void RewriteDataOutput(string inPath,string outPath)
        {
            string text =File.ReadAllText(inPath);
            string[] textArray = text.Split(" ");
            int words = textArray.Length;
            text = "";
           for(int i = 0; i < words; i++)
            {
                for(int indexOfLetter = 0; indexOfLetter < textArray[i].Length-1; indexOfLetter++)
                {
                    if (textArray[i][indexOfLetter] == textArray[i][indexOfLetter + 1])
                    {
                        textArray[i] = "";
                        continue;
                    }
                }
                text += " " + textArray[i];
            }
            text=text.Remove(0, 1);
            StreamWriter fileWriter = new StreamWriter(outPath);
            fileWriter.WriteLine("Count of words given is "+words);
            fileWriter.Write("Words remained after filtering: "+text);
            fileWriter.Close();
        }
        static void Main(string[] args)
        {
            string fileInPath = "D://input.txt";
            string fileOutPath= "D://output.txt";
            RewriteDataOutput(fileInPath, fileOutPath);
        }
    }
}
