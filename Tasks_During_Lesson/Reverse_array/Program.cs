using System;

namespace Reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Random random = new Random();
            for(int i = 0; i<5; i++)
            {
                numbers[i] = random.Next();
            }
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("***************");
           //metod 1
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
