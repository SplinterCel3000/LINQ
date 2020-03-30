using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LINQ_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                String nyData = File.ReadAllText("C:/Users/bjohn/source/repos/LabLINQ/LINQ Lab/LINQ Lab/data.json");
                Console.WriteLine(nyData);

            }

            catch (Exception e)
            {
                Console.WriteLine("There was an error reading your file");
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}
