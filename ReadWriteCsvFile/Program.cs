using SharedClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteCsvFile
{
    class Program
    {
        private static List<Person> persons = new List<Person>();

        static void Main(string[] args)
        {

            string content = "Micke;Wessen;34;Orebro";
            CsvService.WriteToFile(@"C:\Users\Micke\Desktop\EC-WIN20\Files\persons.csv", content);
            var persons = CsvService.ReadFromFile(@"C:\Users\Micke\Desktop\EC-WIN20\Files\persons.csv");

            foreach(var person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} in {person.Age} yeards old and live in {person.City}");
            }
        }

    }
}
