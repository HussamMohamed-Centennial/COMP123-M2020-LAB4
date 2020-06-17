using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_LAB4
{
    class Person
    {
        //PRIVATE INSTANCE VARIABLE

        //PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Age { get; set; }

        //CONSTRUCTOR
        public Person(string name, int age)
        {
            //property initialization
            Name = name;
            Age = age;

        }

        //PRIVATE METHODS

        //PUBLIC METHODS
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello");
        }
    }
}
