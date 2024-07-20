using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    internal static class StringBuilderSamples
    {
        public static void UsingStringBuilder()
        {
            String word = "test this";
            
            word += " this is second string";
            word = "test 3"; //new string will have third memoery location

            StringBuilder sb = new StringBuilder("test this");
            sb.Append(" this is second string ");

            Console.WriteLine(sb.ToString());

        }

        public static int wordCount(this string str)
        {
            return str.Split(" ").Length;
        }
            
        

    }
}
