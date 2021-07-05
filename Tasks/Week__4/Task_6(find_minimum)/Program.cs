using System;

namespace Task_6_find_minimum_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6] { 5,7,9,13,2,4};
            //Let's find the minimum number of the array
            //First Way
            int min = numbers[0];
            foreach(int element in numbers)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            Console.WriteLine($"Minimum : {min}");
            Console.WriteLine("**********");
            //Second way
            //We will sort our array with built-in "Sort" method
            Array.Sort(numbers);
           
            int min_ = numbers[0];
            
            Console.WriteLine($"Minimum : {min_}");


        }
    }
}
