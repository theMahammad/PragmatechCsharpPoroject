using System;

namespace Task_4_find_factorial_
{
    class Program
    {
        static void Main(string[] args)
        { Console.Write("Faktorialının tapılmasını istediyiniz ededi daxil edin : ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0 daxil edile bilmez ");
            }
            int factorialOfNumber = 1;
            
            while (number > 0)
            {
                factorialOfNumber *= number;
                number--;
            }
            Console.Write($"Daxil edilmiş ededin faktorialı : {factorialOfNumber} ");
        }
    }
}
