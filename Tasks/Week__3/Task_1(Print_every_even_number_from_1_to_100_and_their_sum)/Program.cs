using System;

namespace Task_1_Print_every_even_number_from_1_to_100_and_their_sum_
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int finishNumber = 100;
            int sum = 0;
            while (startNumber<=finishNumber) {
                if (startNumber % 2 == 0)
                {
                    Console.WriteLine(startNumber);
                    sum += startNumber;
                }
                startNumber++;
                    
            }
            Console.WriteLine(sum);
        }
    }
}
