using System;

namespace Task_3_check_two_array_for_duplicates_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts_1 = new string[4] { "Mehemmed", "Salam", "burdasan?", "Aleykum" };
            string[] texts_2 = new string[4] { "Mehemmed", "burdayam", "burdasan?", "burdasan?" };
            foreach(string text_1 in texts_1)
            { int amountOfRepetition = 0;
                foreach(string text_2 in texts_2)
                {
                    if (text_1 == text_2)
                    {
                        amountOfRepetition++;
                    }
                }
                if (amountOfRepetition > 0)
                {
                    Console.WriteLine($"\"{text_1}\" {amountOfRepetition} defe tekrarlanıb");
                }
            }
        }
    }
}
