using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    internal class LinqSamples
    {
        public void LamdaExpressions()
        {
            Func<int, int> add = x => x * 5;

            Console.WriteLine("Calling add method " + add(2));

            Func<int, int, int> multiple = (x, y) => x * y;
            int result = multiple(10, 20);

            Console.WriteLine("Calling add method " + result);

        }

        public void UsingLinqSamples()
        {
            int[] ints =  { 1, 2, 3, 60, 3 };
            string[] strings = { "test40", "test2", "test40" };

            var return3 = from x in ints
                              //where x == 3   //returns all if we dont have where
                          select x;


            var return4 = from x in strings
                          where x == "test1"
                          select x;

            foreach (int x in return3)
            {
                Console.WriteLine("return value: " + x);
            }


            List<int> list = new List<int>();
            list.Add(20);
            list.Add(40);
            list.Add(20);

            var return30 = from x in list
                           where x == 30
                           select x;

            //method query with where
            return3 = ints.Where(x => x == 3);

            // method query with where
            return4 = strings.Select(x => x.ToUpper());        

            foreach (int x in return3)
            {
                Console.WriteLine("return value from method query: " + x);
            }

            foreach (string x in return4)
            {
                Console.WriteLine("return value from select method query: " + x);
            }


            //chanined exoression
            //{ "test40", "test2", "test40" };
            return4 = strings.Where(s => s.Contains("40")).Select(x => x.ToUpper());

            foreach (string x in return4)
            {
                Console.WriteLine("print the upper cases: " + x);
            }
        }

        public void UsingLinqSampeObjects()
        {
            List<EmployeeDetails> empList = new List<EmployeeDetails>();
            
            //adding first emplouee data
            EmployeeDetails emp = new EmployeeDetails();
            emp.age = 30;
            emp.empid = 100;
            emp.name = "test1";

            //adding emp object to the list
            empList.Add(emp);

            //second emp data
            emp = new EmployeeDetails();
            emp.age = 50;
            emp.empid = 200;
            emp.name = "test2";
            empList.Add(emp);

        
            //loop through
            foreach (EmployeeDetails e in empList)
            {
                Console.WriteLine("Empid : " + e.empid + " name : " + e.name + " age :" + e.age);
            }

            //linq query
            var empresult = from e in empList
                            where e.age > 30
                            select e;
            //loop through
            foreach (EmployeeDetails e in empresult)
            {
                Console.WriteLine("Filter Empid : " + e.empid + " name : " + e.name + " age :" + e.age);
            }

        }
    }
}
