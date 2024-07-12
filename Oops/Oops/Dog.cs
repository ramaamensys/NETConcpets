using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking with zero parameters.");
        }

        public void Bark(int frequency)
        {
            Console.WriteLine("Dog is barking.");
        }

        public void Bark(string speed, string color)
        {
            Console.WriteLine("Dog is barking two parameters");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
}
