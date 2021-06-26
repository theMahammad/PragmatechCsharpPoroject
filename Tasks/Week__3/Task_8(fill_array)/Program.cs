using System;

namespace Task_8_fill_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            //Massivin bütün elementləri 0 olduğu üçün -1 etməliyik ki,random halda da 0 ötürə bilək,yoxsa eyni ədədlər olduğu üçün sonsuz döngü yaranacaq
            Array.Fill(array, -1);
            Random random = new Random();
            int countOfRepetition = 0;
            int randomNumber;
            for (int i = 0; i < array.Length; i++)
            {
                randomNumber = random.Next(10);
                while(Array.Exists(array,element => element == randomNumber))
                {   
                    Console.WriteLine($"{randomNumber} ededi bir daha yaradıldı");
                    randomNumber = random.Next(10);
                    countOfRepetition++;
                }
                array[i] = randomNumber;
                Console.WriteLine($"******\n{randomNumber} ötürüldü\n*****");
            }
            Console.WriteLine("Massivin elementleri : ");
                foreach(int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"Tekrar random element sayı : {countOfRepetition} ");

        }
    }
}
