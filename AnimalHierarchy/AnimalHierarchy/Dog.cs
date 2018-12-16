﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Dog: Animal, ISound
    {
        public Dog(int age, string name, Gender sex) : base(age, name, sex)
        {

        }

        public string Sound()
        {
            return "HamHam";
        }
    }
}
