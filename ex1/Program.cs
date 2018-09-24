using System;
using System.IO;

namespace ex1
{
    class Program
    {
        private const string Path = "text.txt";

        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine($"Longest word is: {LongestWord(Path)}");
                Console.WriteLine($"Number of words in file: {Count(Path)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private static string LongestWord(string path)
        {
            // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadToEnd();
                string[] words = line.Split(' ');
                string longest = words[0];
                foreach (var item in words)
                {
                    if (item.Length > longest.Length)
                    {
                        longest = item;
                    }
                }
                return longest;
            }

        }

        private static int Count(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadToEnd();
                string[] words = line.Split(' ');
                return words.Length;
            }
        }
    }
}
