﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    class Person
    {
        public string Name { get; set; }
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return base.ToString();
            else
                return Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
