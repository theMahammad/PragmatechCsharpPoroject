using System;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nizamsız massivlər (JAGGED ARRAYS)
            //Digər massivlərdə bir nizam vardı,amma bu tip massivlər biraz fərqlidir,nizam olmur
            //Təyinetmə üsulu
            int amount = 3;
            int[][] jagged_array = new int[amount][];//jagged array daxilində 3 ayrı alt-massiv yaratdıq
            jagged_array[0] = new int[] { 5,6,7 };//ilk alt-massivə dəyər\adres verdik
            jagged_array[1] = new int[2] { 3, 4 };//ikinciyə də verdik
            jagged_array[2] = new int[]{7,8,9,13};//üçüncüyə də
            //Yuxarıda göründüyü kimi hər alt massivin özünə xas element sayı ola bilər,bu da nizamı pozur.Tərcümə ilə "kələ-kötür" deyə cavab alırıq
            //Çap edilməsi
            for(int i = 0;i<jagged_array.Length;i++)
            {//Bütün alt-massivləri gəzəcək bir döngü yaradırıq
                
                for(int j = 0; j < jagged_array[i].Length; j++)
                {//Ardından da hər alt-massivin içində gəzib elementlərini çap edəcək döngü yaradırıq
                    
                    Console.Write($"{jagged_array[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");

            //Digər təyinetmə üsulları
            int[][] jagged_array_1 = new int[][] //new int-dən sonrakı ilk kvadrat mötərizə içinə ədəd yazsaq,maksimum o qədər massiv təyin etməli olacağıq
            {
                new int[]{5,6,7},
                new int[]{15},
                new int[]{19,22},
                new int[]{19,22,17,91}
            };
                foreach(int[] array in jagged_array_1)
            {
                foreach(int element in array)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
        }

    }
}
