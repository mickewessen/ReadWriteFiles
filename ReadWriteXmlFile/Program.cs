using SharedClassLibrary;
using System;

namespace ReadWriteXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlService.WriteToFile(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\books.xml");
            XmlService.ReadFromFile(@$"C:\Users\Micke\Desktop\EC-WIN20\Files\books.xml");
        }
    }
}
