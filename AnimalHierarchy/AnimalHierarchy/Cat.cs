using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat: Animal, ISound
    {
        public Cat(int age, string name, Gender sex) : base(age, name, sex)
        {

        }
        public Cat(int age, string name) : base(age, name)
        {

        }


        public string Sound()
        {
            return "Miau";
        }
    }
}
