using System;
using System.Collections;

namespace Task_2_sum_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            Random random = new Random();
            for (int index= 0;index <number.Length;index++)
            {
                number[index] = random.Next(50);
            }
            Array.ForEach(number, element=>Console.WriteLine(element));
            //Let's find sum of the element with two ways
            //First way
            int sum = 0;
            foreach(int element in number)
            {
                sum += element;
            }
            Console.WriteLine(sum);
            sum = 0;
            Console.WriteLine("**************");
            //Second way
            
            int index_=0;
            while (index_<number.Length) {
                sum += number[index_];
                index_++;
            
            }
            Console.WriteLine(sum);
            
        }
    }
}
