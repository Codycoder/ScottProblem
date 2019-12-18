using System;
using System.Collections.Generic;
using System.Linq;

namespace ScottProblem
{
    //Here's a quick test... if you have a list, can you write a "for" loop to iterate over it and add 1 to all the numbers larger than 9? It should just modify the original list (not create a new one). Then print it out. (Bonus if the list modification is done in a separate function.)
    //That's probably a basic test of for loops and lists! It's something you would use often.Here's the starting list:


    public class Program

    {
        public static void Main()

        {
            var foo = new List<int>() { 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Starting list: " + String.Join(", ", foo));

            int length = 6;

            while (length < 6)
            {
                for (int i = 0; i < length; i++)
                {
                    if (foo[i] >= 9)
                    {
                        foo.Add(i + 1);
                    }

                    else
                    {

                    }
                }
                /* TODO: add 1 to each list item greater than 9 and print the new list */
            }

            foreach (var item in foo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
