using System;

namespace Task_4_is_positive_or_negative_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yoxlamaq üçün eded girin");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Eded müsbetdir");
            }
            else
            {
                Console.WriteLine("Eded menfidir");
            }
        }
    }
}
