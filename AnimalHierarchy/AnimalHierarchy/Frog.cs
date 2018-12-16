using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender sex) : base(age, name, sex)
        {
        }

        public string Sound()
        {
            return "Frog-Frog";
        }
    }
}
