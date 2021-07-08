using System;

namespace Compare_two_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfDuplicates = 0;
            Console.WriteLine("Her massivde neçe element olsun?");
            int n = int.Parse(Console.ReadLine());
            string[] array_1 = new string[n];
                string[] array_2 = new string[n];
            int i = 0;
            while (i<n)
            { Console.WriteLine($"1-ci massiv üçün {i+1}.adı daxil edin ");
                array_1[i] = Console.ReadLine();
                Console.WriteLine($"2-ci massiv üçün {i + 1}.adı daxil edin ");
                array_2[i] = Console.ReadLine();
                i++;
            }
            foreach(string text_1 in array_1)
            {
                foreach(string text_2 in array_2)
                {
                    if (text_1 == text_2)
                    {
                        amountOfDuplicates++;

                    }
                }
            }
            Console.WriteLine($"Tekrar element sayı : {amountOfDuplicates}");

           
        }
    }
}
