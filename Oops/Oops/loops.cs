using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    class loops
    {
        public void printNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("using for loop: " + i);
            }

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("using while loop " + x);
                x++;
            }

            int y = 0;
            do
            {
                Console.WriteLine("using do while loop " + y);
                y++;
            } while (y < 10);

        }

        public void UsingArrays()
        {
            //decaring the array
            int[] numbers;

            //initalize the array, specifiy the size of array
            numbers = new int[5];
            
            //assigning the value for number 1
            numbers[0] = 100;
            numbers[1] = 600;
            numbers[2] = 1600;

            //assigning the value for number 4
            numbers[3] = 50;

            //assigning the value for number 5
            numbers[4] = 300;

            for(int i= 0; i < numbers.Length; i++)
            {
                Console.Write("priting from the array: " + numbers[i]);
            }

            //declaring and initlization in one line
            int[] intNumbers = new int[5];

            //declaring, initlization and asignement in one line
            int[] defaultNumers = { 3, 6, 6, 10 };

            //using for each loop
            foreach (int n in numbers)
            {
                Console.WriteLine("priting from the array using for rach: " + n);
            }

            //using arrays methods, passing array as arugment
            Array.Sort(numbers);

            //print the sort array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("priting from the array: " + numbers[i]);
            }

            //reverse array
            Array.Reverse(numbers);
            // print the reverse array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("priting from the array: " + numbers[i]);
            }

            //to find the inde/positon of value in array
            int pos = Array.IndexOf(numbers, 1600);
            Console.WriteLine("priting from the index of 1600 value: " + pos);

        }
    }
}
