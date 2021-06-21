using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1 = 17;
            int number_2 = 15;
            int bigger_number;
            int smaller_number;
            if (number_1 > number_2)
            {
                bigger_number = number_1;
                smaller_number = number_2;
            }else if (number_1 < number_2)
            {
                bigger_number = number_2;
                smaller_number = number_1;

            }
            else
            {
                Console.WriteLine("Bu iki eded beraberdir");
                //if the two numbers are equal,then above text is printed and program is finished,because the codes  after the "return" keyword don't work
                return;
            }
            Console.WriteLine($"Böyük eded : {bigger_number}");
            Console.WriteLine($"Kiçik eded : {smaller_number}");
           

        }
    }
}
