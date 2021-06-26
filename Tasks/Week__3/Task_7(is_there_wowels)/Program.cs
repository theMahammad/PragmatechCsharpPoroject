using System;

namespace Task_7_is_there_wowels_
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels =new char[] { 'a', 'e', 'u', 'i', 'o', 'ü', 'ı' };
            Console.Write("Yazı daxil edin : ");
            string textFromClient = Console.ReadLine();
            int count = 0;
            foreach(char character in textFromClient)
            {
                foreach(char vowel in vowels)
                {
                    if (Char.ToLower(character) == vowel)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Sait sayı : {count}");
        }
    }
}
