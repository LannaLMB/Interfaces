using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Dog : IAnimal  // This is how we Implement the IAnimal Interface - It looks similar to Inheritance syntax.
    {
        public void animalSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}