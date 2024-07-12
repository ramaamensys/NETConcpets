using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    class AbstractSubClass : AbstractClass
    {
        public override void AbstractMethod1()
        {
            Console.WriteLine("I am inside the abstract method with no return ");
        }

        public override List<string> AbstractMethod2()
        {
            List<string> strings = new List<string>();

            Console.WriteLine("I am inside the abstract method with return ");
            return strings;
        }

        public void NewNonAbstractMethod()
        {
            Console.WriteLine("I am inside the NewNon AbstractMethod ");

        }
    }
}
