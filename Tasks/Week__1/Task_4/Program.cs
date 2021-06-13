using System;

namespace Task_4
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
            string fullname = first_name + " " + last_name;
            Console.WriteLine($"Salam,dunya,xususen de sene salam olsun,{fullname}");
            
        }
    }
}
