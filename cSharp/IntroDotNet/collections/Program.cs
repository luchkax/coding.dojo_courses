using System;
using System.Collections.Generic;


namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[] {"Tim","Martin","Nikki","Sara"};
            bool[] boolArray = new bool[10];
            for(int i=0; i<10; i++)
            {
                if(i % 2 == 0)
                {
                    boolArray[i] = true;
                }
                else
                {
                    boolArray[i] = false;
                }
                // System.Console.WriteLine(boolArray[i]);
            }

            int[,] multiArray = new int[10,10];
            for(var i = 1; i < 11; i ++){
                for(int j = 1; j < 11; j ++)
                {;
                    multiArray[i-1,j-1] = i*j;
                    // System.Console.WriteLine(multiArray[i-1,j-1]);
                }
            }

            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Banana");
            iceCream.Add("Strawberry");
            iceCream.Add("Beef");
            iceCream.Add("Coconut");
            iceCream.Add("Blackberry");

            // System.Console.WriteLine("Length: " + iceCream.Count);
            // System.Console.WriteLine(iceCream[2]);

            iceCream.RemoveAt(2);
            // System.Console.WriteLine("Length: " + iceCream.Count);


            Dictionary<string,string> info = new Dictionary<string,string>();

            foreach (string name in names)
            {
                info.Add(name, null);
            }
            Random rand = new Random();
            foreach (string name in names)
            {
                info[name] = iceCream[rand.Next(0, iceCream.Count)];
            }
             foreach(var entry in info)
            {
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }




        }
    }
}
