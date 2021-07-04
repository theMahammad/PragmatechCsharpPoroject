using System;

namespace Task_5_delete_evens_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 5,6,7,8,15,23,4,32,11,22};
            int index;
            int[] odd_numbers = new int[0];
            int index_odd_numbers = 0;
            for (index = 0; index < numbers.Length; index++)
            {
                
                if (numbers[index] % 2 == 1)
                 {
                    //While program finds new odd number,size of our array for odd number increases by one
                    Array.Resize(ref odd_numbers, odd_numbers.Length + 1);
                    odd_numbers[index_odd_numbers] = numbers[index];
                    index_odd_numbers++;
                }
            }
            Array.ForEach(odd_numbers, element => Console.WriteLine(element));
             
        }
    }
}
