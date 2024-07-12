using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsConcpets
{
    class Collections
    {
        public void ListCollection()
        {
            List<int> listIntegers = new List<int>();
            List<string> strings = new List<string>();

            //adding the items to the list
            listIntegers.Add(10);
            listIntegers.Add(20);
            listIntegers.Add(30);
            listIntegers.Add(20);

            strings.Add("test1");
            strings.Add("test2");

            foreach(int i in listIntegers)
            {
                Console.WriteLine(i);
            }

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            //will give number of elements from the list
            int size = listIntegers.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("using for loop: " + listIntegers[i]);
            }


        }
        
        public void DictionaryCollection()
        {
            //key is first parameter
            //value is the second parameter
            Dictionary<int, int> dictionaryIntegers = new Dictionary<int, int>();

            dictionaryIntegers.Add(1, 100);
            dictionaryIntegers.Add(2, 400);

            //if u want to read value by key
            Console.WriteLine("Reading the value based on key of 1 " + dictionaryIntegers[1] );

            //update the value at particular key
            dictionaryIntegers[2] = 800;

            //reading values from Dictionary
            foreach (var item1 in dictionaryIntegers)
            {
                Console.WriteLine("key is " + item1.Key + " value is " + item1.Value);
            }

            //check if key is existed or not
            if (dictionaryIntegers.ContainsKey(2))
            {
                Console.WriteLine("Execute logic based on requirmeent");
            }

            //Remove the items based on the key
            dictionaryIntegers.Remove(1);


            // check if value is existed or not
            if (dictionaryIntegers.ContainsValue(800))
            {
                Console.WriteLine("Execute logic based on requirmeent");
            }


            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();

            dictionary2.Add("test1", 500);
            dictionary2.Add("test2", 600);

            //clear the all the elements from the dict
            dictionary2.Clear();


        }

        public void HashSetCollections()
        {
            HashSet<int> hashSet1 = new HashSet<int>();
            hashSet1.Add(10);
            hashSet1.Add(20);
            hashSet1.Add(30);
            hashSet1.Add(20);

            foreach(var item1 in hashSet1)
            {
                Console.WriteLine("values from hashset " + item1);
            }


        }
        public void ArrayListCollection()
        {
            ArrayList listInts = new ArrayList();
            listInts.Add(1);
            listInts.Add(100);

            foreach(var item in listInts)
            {
                Console.WriteLine(item);
            }

            //old way of dict   
            Hashtable htable = new Hashtable();
            htable.Add("test1", 500);
            htable.Add("test2", 800);

            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine(item.Value + " "+ item.Key);
            }
        }

        public void StackQueueCollections()
        {
            //100, 200, 300, 400
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);

            foreach (var item in stack)
            {
                Console.WriteLine("value from stack " + item);
            }

            //remove item from stack
            int removedElement = stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine("After remove value from stack " + item);
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            foreach (var item in queue)
            {
                Console.WriteLine("value from queue " + item);
            }

            // remove item from queue
            int removedQueue = queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine("After remove value from queue " + item);
            }
        }
    }
}
