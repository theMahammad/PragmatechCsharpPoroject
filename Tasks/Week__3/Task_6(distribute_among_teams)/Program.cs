using System;

namespace Task_6_distribute_among_teams_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Neçe ad daxil etmek isteyirsiniz? : ");
            
            int n = int.Parse(Console.ReadLine());
            while (n % 2 == 1 && n==0)
            {
                Console.Write("Zehmet olmasa,cüt eded daxil edin :");
                n = int.Parse(Console.ReadLine());
            }
            string[] names = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. adı daxil edin : ");
                string nameFromClient = Console.ReadLine();
                while(Array.Exists(names, name => name == nameFromClient))
                {
                    Console.Write($"\"{nameFromClient}\" daxil edilib,başqa ad daxil edin ");
                    nameFromClient = Console.ReadLine();
                }
                if(Array.Exists(names, name => name == nameFromClient) == false)
                {
                    names[i] = nameFromClient;
                }
            }
            string[] firstTeam=new string[n/2];
            string[] secondTeam = new string[n / 2];
            
            Random random = new Random();

            Console.WriteLine("Komandalar seçilir :");
            for(int i = 0; i < firstTeam.Length; i++)
            { int randNumberForFirst = random.Next(names.Length);
                while(Array.Exists(secondTeam,element => element == names[randNumberForFirst]) || Array.Exists(firstTeam, element => element == names[randNumberForFirst]))
                {
                    randNumberForFirst = random.Next(names.Length);
                }
                firstTeam[i] = names[randNumberForFirst];
                Console.WriteLine($"{names[randNumberForFirst]} birinci komandaya seçildiii!");
                
                int randNumberForSecond = random.Next(names.Length);
                while (Array.Exists(firstTeam, element => element == names[randNumberForSecond]) || Array.Exists(secondTeam, element => element == names[randNumberForSecond]))
                {
                    randNumberForSecond = random.Next(names.Length);
                }
                secondTeam[i] = names[randNumberForSecond];
                Console.WriteLine($"{names[randNumberForSecond]} ikinci komandaya seçildiii!");
            }
            Console.WriteLine("Birinci komanda : ");
            Array.ForEach(firstTeam,member => Console.WriteLine(member));
            Console.WriteLine("Ikinci komanda :");
            Array.ForEach(secondTeam, member => Console.WriteLine(member));


        }
    }
}
