using System;

namespace Task_5_show_amount_of_selected_name_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Neçe ad daxil edeceksiniz? : ");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int i = 0;
            while ( i<n)
            {
                Console.Write($"{i+1}. adı daxil edin : ");
                names[i] = Console.ReadLine();
                i++;
            }
            Console.WriteLine("Hansı adı seçmek isteyirsiniz?");
            string selectedName = Console.ReadLine();
            int amountOfSelectedName=0;
            foreach(string name in names)
            {
                if (name == selectedName)
                {
                    amountOfSelectedName += 1;
                }
            }
            Console.WriteLine($"Seçdiyiniz ad : {selectedName} | Seçdiyiniz adın siyahıdakı sayı : {amountOfSelectedName}");

        }
    }
}
