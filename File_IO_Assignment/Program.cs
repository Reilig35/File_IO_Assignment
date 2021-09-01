using System;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number:\n");
            var userInput = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\will2\source\repos\File_IO_Assignment\File_IO_Assignment\log.txt", true))
            {
                file.WriteLine(userInput);
            }

            var text = File.ReadAllText(@"C:\Users\will2\source\repos\File_IO_Assignment\File_IO_Assignment\log.txt");
            Console.WriteLine(text);
        }
    }
}
