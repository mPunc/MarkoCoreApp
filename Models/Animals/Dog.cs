using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animals
{
    internal class Dog : Animal
    {
        public override string Species => "Dog";

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
