using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal
    {
        public Animal(int age, string name, Gender sex)
        {
            Age = age;
            Name = name;
            Sex = sex;
        }

        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public Gender Sex { get; set; }

    }
   public enum Gender
    {
        Female,
        Male
    }
}
