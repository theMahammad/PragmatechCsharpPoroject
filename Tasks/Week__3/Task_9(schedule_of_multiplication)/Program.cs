using System;

namespace Task_9_schedule_of_multiplication_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int vurulan = 1; vurulan <= 10; vurulan++)
            {
                Console.WriteLine($"{vurulan}\n****");
                for(int vuran = 0; vuran <= 10; vuran++)
                {
                    Console.Write($" {vuran * vurulan} ");
                }
                Console.WriteLine();
            }
        }
    }
}
