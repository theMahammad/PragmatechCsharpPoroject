using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Adiniz?");
            
            string first_name = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Soyadiniz?");
            string last_name = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Yashiniz?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Oxudugunuz universitet?");
            string education_place = Console.ReadLine();
            Console.WriteLine("Formu doldurdughunuz uchun minnetdariq");
            Console.WriteLine("Neticeni gostermek  uchun  \"Enter\"-e basin");
           
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine($"Salam,men {first_name} {last_name}. {age} yashim var ve {education_place}-de tehsil aliram");


            }
            
        }
    }
}
