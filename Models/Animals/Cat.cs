using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animals
{
    internal class Cat : Animal
    {
        public override string Species => "Cat";

        public Cat(string name, int age, int numberOfLegs) : base(name, age)
        {
            NumberOfLegs = numberOfLegs;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
