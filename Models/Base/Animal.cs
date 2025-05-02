using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base
{
    public abstract class Animal
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public int? NumberOfLegs { get; set; }
        public abstract string Species { get; }

        public Animal() { }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} is sleeping.");
        }
    }
}
