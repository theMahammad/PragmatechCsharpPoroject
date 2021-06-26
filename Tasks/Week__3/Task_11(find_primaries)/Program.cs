using System;

namespace Task_11_find_primaries_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int number = 2; number <= 100; number++)
            {
                int amountOfDividers = 0;
                for(int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        amountOfDividers++;
                    }
                }
                if (amountOfDividers == 0)
                {
                    Console.WriteLine($"{number} sade ededdir");
                }
            }
        }
    }
}
