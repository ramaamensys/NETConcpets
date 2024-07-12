using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    class ImpleentInterface : UsingInterfaces, IAnimal
    {
        public void CalAge()
        {
            Console.WriteLine("I am inside calage");
        }

        public void Eat()
        {
            
        }

        public void FindSpeed(int age)
        {
            Console.WriteLine("I am inside FindSpeed method");
        }

        public void Sleep()
        {
            
        }

        public void ThirdMethod()
        {
            Console.WriteLine("I am inside ThirdMethod method");
        }
    }
}
