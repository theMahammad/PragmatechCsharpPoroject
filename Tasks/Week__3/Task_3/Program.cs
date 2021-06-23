using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(100);
            int chancesForEstimate = 5;
            Console.WriteLine("1-den 100-e qeder ededler arasında bir texmin edin :");
            int estimateFromClient;
            int usedChances = 0;
            do
            {
                Console.Write($"{usedChances+1}.şans : ");
                estimateFromClient = int.Parse(Console.ReadLine());
                usedChances++;
                if (usedChances == chancesForEstimate&&estimateFromClient!=randomNumber)
                {
                    Console.WriteLine($"Sizin texmin haqqınız bitmişdir :( \nDoğru cavab :{randomNumber}");
                }
                else if (estimateFromClient == randomNumber)
                {
                    Console.WriteLine("Tebrikler,doğru bildiniz!");
                    break;
                }else if (estimateFromClient > randomNumber)
                {
                    Console.WriteLine("Biraz daha aşağı düşün");
                }
                else
                {
                    Console.WriteLine("Biraz daha yuxarı çıxın");
                }
                
            } while (usedChances<chancesForEstimate);
        }
    }
}
