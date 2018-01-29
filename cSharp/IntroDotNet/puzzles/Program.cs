using System;
using System.Collections.Generic;


namespace puzzles
{
    class Program
    {

        public static int[] RandomArray()
        {
            int sum = 0;
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i = 0; i<10; i++)
            {
                arr[i] = rand.Next(5,25);
                sum += arr[i];
            }
            System.Console.WriteLine("Sum is {0}", sum);
            int max = arr[0];
            int min = arr[0];

            foreach (var item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
                else if (item < min)
                {
                    min = item;
                }
            }
            System.Console.WriteLine("Max is {0}, and Min is {1}, ", max, min);
            return arr;
        }

        public static int CoinToss()
        {
            System.Console.WriteLine("Tossing coing...");
            Random rand = new Random();
            int coin = rand.Next(1,3);
            if(coin == 1)
            {
                System.Console.WriteLine("Heads!");
            }
            else
            {
                System.Console.WriteLine("Tails!");
            }
            return coin;
        }

        static double TossMultipleCoins(int num)
        {
            double result; 
            int heads = 0;
            int coin;
            Random rand = new Random();
            for(int i = 1; i < num; i++)
            {
                coin = rand.Next(1,3);
                System.Console.WriteLine(coin);
                if(coin == 2)
                {
                    heads++;
                }
            }
            result = (double)heads/(double)num;
            System.Console.WriteLine("result is {0}", result);
            return result;
        }

        static string[] names()
        {
            string[] arr = new string[]{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Length > 5)
                {
                    count++;
                }
                int idx = rand.Next(0, arr.Length);
                string temp = arr[i];
                arr[i] = arr[idx];
                arr[idx] = temp;
            }
            string[] newArr = new string[count];
            int newIdx = 0;
            foreach(string name in arr)
            {
                if(name.Length > 5)
                {
                    newArr[newIdx] = name;
                    newIdx++;
                }
            }
            foreach(string name in newArr)
            {
                System.Console.WriteLine(name);
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            // RandomArray();
            CoinToss();
            // TossMultipleCoins(4);
            // names();


        }
    }
}
