using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    class Operators
    {
        public void ArthmeticOperators(int num1, int num2)
        {
            Console.WriteLine("Addition: " + (num1 + num2));

            //declare the variable
            int result = num1 * num2;
            Console.WriteLine("Multiplication: " + result);

            result = num1 / num2;
            Console.WriteLine("Divison: " + result);

            result = num1 % num2;
            Console.WriteLine("Modulus : " + result);


        }

        public void CompOperators(int num1, int num2)
        {
            Console.WriteLine("Equal : " + (num1 == num2));

            bool result = num1 != num2;
            Console.WriteLine("Not Eqaul to: " + result);

            result = num1 > num2;
            Console.WriteLine("Greater than: " + result);

            result = num1 < num2;
            Console.WriteLine("Less than : " + result);

            result = num1 <= num2;
            Console.WriteLine("Less than or eqaul to: " + result);

            result = num1 >= num2;
            Console.WriteLine("Greather than or eqaul to: " + result);

        }

        public void LogicalOperators(int num1, int num2)
        {
            bool result = ((num1 > 10) && (num2 > 100));
            Console.WriteLine("Logical And: " + result);

            result = ((num1 > 10) || (num2 > 100));
            Console.WriteLine("Logical Or: " + result);
        }

        public void AssignementOperators(int num1, int num2)
        {
            num1 += num2; //is equal to num1 = num1 + num2;
            int a = 10;
            int b = 20;

            a -= b;  //a = a - b
            a *= b; // a = a * b
            a /= b; // a = a / b
            a %= b; // a = a % b

            //increment operator
            int i = 10;
            i++; // i = i + 1; //increment the i value by 1

            //decrement operator
            i--; //i = i - 1

            //conditinal operators
            int x = 30;
            int y = (x > 100) ? 200 : 300;
            Console.WriteLine(" Conditoanl operator: " + y);

        }

        public void ifCondition(int num1)
        {
            if ((num1 > 10) && (num1 < 100))
            {
                Console.WriteLine(" value is in between 10 and 100 ");
            }
            else if ((num1 > 101) && (num1 < 200))
            {
                Console.WriteLine(" value is in between 101 and 200 ");
            }
            else
            {
                Console.WriteLine(" value is more than 200 and less than 10 ");
            }
        }
    }
}
