using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    public abstract class AbstractClass
    {
        public abstract void AbstractMethod1();
        public abstract List<string> AbstractMethod2();

        public void SumTwoNumbers(int num1, int num2)
        {
            Console.WriteLine("Sum two numbers in non abstract method: " + (num1 + num2));
        }

    }
}
