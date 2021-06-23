using System;

namespace Task_2_print_sum_of_previous_number_using_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFromClient;
            int sum = 0;
            do
            {
                Console.Write("Ekrana eded daxil edin : ");
                numberFromClient = int.Parse(Console.ReadLine());
                
                if (numberFromClient == 0)
                {
                    Console.WriteLine($"Bundan evvel daxil edilen ededlerin cemi : {sum}");
                }
                sum += numberFromClient;
            } while (numberFromClient!=0);
        }
    }
}
