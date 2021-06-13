using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Yazı daxil edin");
            string text = Console.ReadLine();
            string reversed_text = "";
            for(int i = text.Length - 1; i >= 0; i--)
            {   
                
                reversed_text += text[i];
            }
            reversed_text = reversed_text.ToLower();
           
            Console.WriteLine($"----------------------\nTers hali :{reversed_text}");
            
        }
    }
}
