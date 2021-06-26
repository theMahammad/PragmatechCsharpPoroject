using System;

namespace Task_12_find_primaries_in_specific_range_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum ededi daxil edin :");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Maksimum ededi daxil edin");
            int maxValue = int.Parse(Console.ReadLine());
            for (int number = minValue; number <= maxValue; number++)
            {
                int amountOfDividers = 0;
                for (int divider = 2; divider < number; divider++)
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
