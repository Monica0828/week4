using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name) : base(age,name)
        {
            Sex = Gender.Male;
        }
    }
}
