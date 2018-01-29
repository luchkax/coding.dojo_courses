using System;
using System.Collections.Generic;

namespace basic12
{
    public class Program
    {
        public static void print1to255()
        {
            for(int i=1; i<256; i++)
            {
                System.Console.WriteLine(i);
            };
        }

        public static void printOdd1to255()
        {
            for(int i=1; i<256; i++)
            {
                if(i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        public static void printSum()
        {
            int sum = 0;
            for(int i=1; i<256; i++)
            {
                sum += i;
                System.Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }
        
        public static void iterArr(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void findMax(int[] arr)
        {
            int max = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] > max){
                    max = arr[i];
                }
            }
            System.Console.WriteLine(max);
        }

        public static void findAvg(int[] arr)
        {
            int sum = arr[0];
            int count = 1;
            for(int i=1; i<arr.Length; i++)
            {
                count ++;
                sum+=arr[i];
            }
            int avg = sum/count;
            System.Console.WriteLine(avg);
        }

        public static void arrOdd()
        {
            List<int> list = new List<int>();
            for(int i = 1; i < 256; i+=2)
            {
                list.Add(i);
            }
            System.Console.WriteLine(list.ToArray());
        }

        public static void greaterY(int y, int[] arr)
        {
            int count = 1;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] > y)
                {
                    count ++;
                }
            }
            System.Console.WriteLine(count);
        }

        public static void squareVal(int[] arr)
        {
            
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
                System.Console.WriteLine(arr[i]);

            }
        }

        public static void elimNeg(int[] arr)
        {
            int eliminator = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if( arr[i] < eliminator)
                {
                    arr[i] = eliminator;
                }
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void minMaxAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = arr[0];
            int count = 1;

            for(int i = 1; i<arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                else if(arr[i] > max)
                {
                    max = arr[i];
                }
                sum+=arr[i];
                count ++;
            }
            float avg = (float)sum/(float)count;
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(avg);
        }

        static void shiftVals(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i ++)
            {
                arr[i] = arr[i + 1];
                System.Console.WriteLine(arr[i]);
            }
            arr[arr.Length-1] = 0;
            System.Console.WriteLine(arr[arr.Length-1]);
        }

        static void numToStr(object[] arr)
        {
            for(int i = 0; i < arr.Length; i ++)
            {
                if(arr[i] is int)
                {
                    if((int)arr[i] < 0)
                    {
                        arr[i] = "Dojo";
                    }
                }
                System.Console.WriteLine(arr[i]);
            }
            
        }

        public static void Main(string[] args)
        {
            // print1to255();
            // printOdd1to255();
            // printSum();
            int[] arr = {1,-3,5,7,9,13};
            // iterArr(arr);
            // findMax(arr);
            // findAvg(arr);
            // arrOdd();
            // greaterY(3, arr);
            // squareVal(arr);
            // elimNeg(arr);
            // minMaxAvg(arr);
            // shiftVals(arr);
            numToStr(new object[]{-1,2,-3,-4,5});


        }
    }
}
