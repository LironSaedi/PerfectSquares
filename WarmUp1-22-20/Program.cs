using System;

namespace WarmUp1_22_20
{
    class Program
    {


        static bool isPerfect(int num)
        {
            int n = (int)Math.Sqrt(num);


            if (n * n == num)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (isPerfect(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            for (int i = 0; i <= 32; i++)
            {
                Console.WriteLine(i * i);
            }


            //Console.WriteLine("Hello World!");
            //int[] array = new int[1000];
            //double input;

            //int count = 1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] += i;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{


            //    input = Math.Sqrt(array[i]);


            //    if (i/input == count)
            //    {
            //        count++;
            //        Console.WriteLine($"{input}");
            //    }
            //    /*
            //    if(input%1 == 0)
            //    {
            //        Console.WriteLine($"{array[i]}");
            //    }
            //    */

                
            //}
        }
    }
}
