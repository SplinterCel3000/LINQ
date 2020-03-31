using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using LINQ_Lab.classes;
using System.Linq;

namespace LINQ_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Reading();
            
        }

        static void ReadingJson()
        {
            Console.WriteLine("Hello World!");
            Console.Read();
        }

        static void Reading() 
        {
            try
            {
                String nyData = File.ReadAllText("../../../data.json");
                RootObject thing = JsonConvert.DeserializeObject<RootObject>(nyData);

                All(thing);
                Console.WriteLine("--------");
                Filter(thing);
                Console.WriteLine("--------");
                NoDuplication(thing);
                Console.WriteLine("--------");
                blah(thing);
                Console.WriteLine("--------");
                blah2(thing);



            }
            catch (Exception)
            {

                
            }
        }


        static void All(RootObject data)
        {
            var x = from feature in data.features select feature;

             foreach (var item in x)
           {

               Console.WriteLine(item.properties.neighborhood);

           }
            
        }
        /// <summary>
        /// this is taking in all of the neighboorhoods and filtering them based on having a name or not. 
        /// </summary>
        /// <param name="data"></param>
        static void Filter(RootObject data)
        {
            // x is a new object that shows all the neighborhoods
            // first query
            var x = from neighboorhood in data.features select neighboorhood;

            // y uses x to remove all the blank names
            // second method
            var y = x.Where(z => z.properties.neighborhood != "")
                .Select(z => z.properties.neighborhood);
             foreach (var item in y)
             {

                 Console.WriteLine(item);

             }
        }
        /// <summary>
        /// this is removing all the duplications
        /// </summary>
        /// <param name="data"></param>
        static void NoDuplication(RootObject data)
        {

            var x = from neighboorhood in data.features select neighboorhood;
            var y = x.Where(z => z.properties.neighborhood != "")
                .Select(z => z.properties.neighborhood);

            foreach (string yes in y.Distinct())
            {

                Console.WriteLine(yes);
            }
        }
        /// <summary>
        /// This is doing everything listed above in just one go. 
        /// </summary>
        /// <param name="data"></param>
        static void blah(RootObject data)
        {
            var x = from neighboorhood in data.features select neighboorhood;

            var y = x.Where(z => z.properties.neighborhood != "")
                .Select(z => z.properties.neighborhood);

          foreach(string yes in y.Distinct())
            {
                
                Console.WriteLine(yes);
            }           
        }
        /// <summary>
        /// I rewrote line 126 to be the ooposite version of itself. 
        /// </summary>
        /// <param name="data"></param>
        static void blah2(RootObject data)
        {
            var x = data.features.Select(x => x);

            var y = x.Where(z => z.properties.neighborhood != "")
                .Select(z => z.properties.neighborhood);

            foreach (string yes in y.Distinct())
            {

                Console.WriteLine(yes);
            }
        }


    }

   

}
