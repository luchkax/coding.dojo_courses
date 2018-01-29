using System;
using System.Collections.Generic;


namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i < 256; i++)
            // {
            //     System.Console.WriteLine(i);                
            // }

            // for (int i = 1; i < 101; i++)
            // {
            //     if (!(i % 3 == 0) && (i % 5 == 0))
            //     {
            //         if (!(i % 3 == 0) || (i % 5 == 0))
            //         {
            //             System.Console.WriteLine(i);
            //         }
            //     }    
            // }

            // for (int i = 1; i < 101; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         System.Console.WriteLine("FizzBuzz");
            //     }
            //     if (i % 3 == 0)
            //     {
            //         System.Console.WriteLine("Fizz");
            //     }
            //     if (i % 5 == 0)
            //     {
            //         System.Console.WriteLine("Buzz");
            //     }    
            // }

            // int three = 3;
            // int five = 5;
            // for (int num = 1; num < 101; num++)
            // {
            //     three--;
            //     five--;
            //     if (three == 0 && five == 0)
            //     {
            //         Console.WriteLine("FizzBuzz");
            //         three = 3;
            //         five = 5;
            //     }
            //     else if (three == 0)
            //     {
            //         Console.WriteLine("Fizz");
            //         three = 3;
            //     }
            //     else if (five == 0) {
            //         Console.WriteLine("Buzz");
            //         five = 5;
            //     }
            // }

            //Initializing an empty list of Motorcycle Manufacturers
            List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);


            


        }
    }
}
