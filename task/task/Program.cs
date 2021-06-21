using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int cem = 0;
            while (i <= 100)
            {
                if (i % 2 == 0 || i == 0)
                {
                    Console.WriteLine(i);
                    cem += i;
                }
                i++;
            }
            Console.WriteLine(cem);
        }
    }
}
