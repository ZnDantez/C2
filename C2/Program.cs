using System;
using System.Collections.Generic;

namespace C2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person[]
            {
                new Person("Дима", 26),
                new Person("Маша", 33),
                new Person("Света", 31),
                new Person("Ваня", 18),
                new Person("Андрей", 19)
            };

            Array.Sort(persons, new AgeComparer());

            foreach (var person in persons)
                Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}
