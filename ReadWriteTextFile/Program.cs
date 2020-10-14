using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteToFile("textfile.txt", "My name is Micke Wessén and I am 34 years old and live in Örebro. ");
            WriteToFile("textfile.txt", "My brothers name is Samuel Wessén. ");
            ReadFromFile("textfile.txt");
        }


        private static void WriteToFile(string filename, string content)
        {
            File.AppendAllText(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\{filename}", content);
        }

        private static void ReadFromFile (string filename)
        {
            var content = File.ReadAllText(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\{filename}");
            Console.WriteLine(content);
        }

    }
}
