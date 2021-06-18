using System;

namespace Task_3_isEven_or_isOdd_
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Yoxlamaq üçün eded daxil edin : ");
          
            int number = int.Parse(Console.ReadLine());
            if(number==0 || number%2==0)
            {
                Console.WriteLine("Bu eded cütdür");
            }
            else
            {
                Console.WriteLine("Bu eded tekdir");
            }
        }
    }
}
