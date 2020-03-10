using System;
using System.Collections.Generic;
using System.Linq;

namespace Using_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //    List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //    var linqQuery = from name in words
            //                    where name.Contains("th")
            //                    select name;
            //    foreach (var name in linqQuery)
            //        Console.WriteLine(name + " ");
            //    Console.ReadLine();
            //    //shorter version
            //    var newQuery = words.Where(w => w.Contains("th"));
            //    foreach (string query in newQuery)
            //    {
            //        Console.WriteLine(query);
            //    }




            //    List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //    var distinct = names.Distinct();
            //    foreach (string value in distinct)
            //    {
            //        Console.WriteLine(value);
            //    }
            //    Console.ReadLine();
    
            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };

            var intClassGrades1 = classGrades[0].Split(',').Select(g => double.Parse(g)).ToList();
            foreach (var item in intClassGrades1)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
            intClassGrades1.Remove(intClassGrades1.Min());
            double average1 = intClassGrades1.Average();

            var intClassGrades2 = classGrades[1].Split(',').Select(s => double.Parse(s)).ToList();
            intClassGrades2.Remove(intClassGrades2.Min());
            double average2 = intClassGrades2.Average();

            var intClassGrades3 = classGrades[2].Split(',').Select(r => double.Parse(r)).ToList();
            intClassGrades3.Remove(intClassGrades3.Min());
            double average3 = intClassGrades3.Average();

            var intClassGrades4 = classGrades[3].Split(',').Select(t => double.Parse(t)).ToList();
            intClassGrades4.Remove(intClassGrades4.Min());
            double average4 = intClassGrades4.Average();

            double totalAverage = (average1 + average2 + average3 + average4) / 4;

            Console.WriteLine(totalAverage);
            Console.ReadLine();


            //IEnumerable<string> result = LINQ.Equals(names, LINQ.HasTwoLetters);
            //foreach (string name in result)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
