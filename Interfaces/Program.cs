using System;
using System.Threading;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Dog Class to create a dog object
            Dog dog = new Dog();

            // Instantiate the Cat Class to create a cat object
            Cat cat = new Cat();

            // Call animalSound() Method specific for the dog object (from the Dog Class)
            dog.animalSound();

            // Call animalSound() Method specific for the cat object (from the Cat Class)
            cat.animalSound();

            // Suspends the current thread for the specified number of milliseconds.
            // We have to include the 'using System.Threading;' statement at the top of this program in order
            // to be able to access this built in functionality.
            // https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=netframework-4.8
            Thread.Sleep(3000);
        }
    }
}