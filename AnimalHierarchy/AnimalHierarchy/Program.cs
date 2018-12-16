using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var listAnimals = new List<Animal>();
            listAnimals.Add(new Dog(8, "Oxy", Gender.Male));
            listAnimals.Add(new Dog(10, "Bobita", Gender.Male));
            listAnimals.Add(new Cat(4, "Tomita", Gender.Male));
            listAnimals.Add(new Frog(2, "Broscuta", Gender.Female));
            listAnimals.Add(new Kitten(3, "Pisicuta"));
            listAnimals.Add(new Tomcat(10, "Motanel"));

            double averageAnimals = 0;
            double averageCats = 0;
            int countAnimals = 0;
            foreach (var x in listAnimals)
            {
                if(x is Kitten || x is Tomcat)
                {
                    averageCats = averageCats + x.Age;
                }
                
                if (x is Cat || x is Dog|| x is Frog)
                {
                    averageAnimals = averageAnimals + x.Age;
                    countAnimals++;
                }

            }
            Console.WriteLine($"Average age of animals is  {averageAnimals/countAnimals}  and average age of all animals is  {(averageCats+averageAnimals)/listAnimals.Count()}");
            Console.ReadKey();

        }
    }
}
