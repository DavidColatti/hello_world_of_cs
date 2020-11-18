using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            //for(int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //}


            //foreach loop
            //int[] arrInts = new int[] { 3, 5, 6, 23, 95, 45, 32 };

            //foreach (int item in arrInts)
            //{
            //    Console.WriteLine(item);
            //}

            //while loop
            //int sentinel = 0;
            //while(sentinel < 10)
            //{
            //    Console.WriteLine(sentinel);
            //    sentinel++;
            //}

            //do while loop
            //int sentinel = 0;
            //do
            //{
            //    Console.WriteLine(sentinel);
            //    sentinel++;
            //} while (sentinel < 10);

            // Decision Structures

            //if statement
            //bool result = true;
            //if(result)
            //{
            //    Console.WriteLine("Result was true");
            //}
            //else
            //{
            //    Console.WriteLine("Result was false");
            //}

            //if..else if
            int value = 0;
            if(value == 0)
            {
                Console.WriteLine("Value is 0");
            }
            else if (value == 1)
            {
                Console.WriteLine("Value is not 0");
            }
            else
            {
                Console.WriteLine("Value is something else");
            }
        }
    }
}