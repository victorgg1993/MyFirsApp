﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Inheritance
{
    class Person
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Guid = Guid.NewGuid();
        }

        public Person(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                base.Equals(obj) &&
                Guid.Equals(person.Guid) &&
                Name == person.Name &&
                Surname == person.Surname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(),
                Guid, Name, Surname);
        }



    }
}
