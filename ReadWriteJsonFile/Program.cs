using SharedClassLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //JsonService.WriteToFile(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\persons.json", new Person("Micke", "Wessen", 34, "Orebro"));
            //JsonService.ReadFromFile(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\persons.json");
            JsonService.WriteToFileCorrect(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\persons.json", new Person("Micke", "Wessen", 34, "Orebro"));
        }
    }
}
