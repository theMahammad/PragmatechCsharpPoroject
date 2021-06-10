using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Operatorlar

            //Riyazi operatorlar
            Console.WriteLine(5 + 7);//12
            Console.WriteLine(5 - 7);//-2
            Console.WriteLine(5 * 7);//35
            Console.WriteLine((10/(double)3).ToString("#.###"));//ədədlərdən birini double-a çevirmədikdə yalnız tam  hissəni qaytarır. 3.333 
            Console.WriteLine(15 % 4); //15-in 4-ə bölünməsindən alınan qalığı qaytarır = 3 
            int x = 15;
            
            Console.WriteLine(x++); //dəyişənin dəyərini çapa verib üzərinə 1 vahid gəlir = 15;
            Console.WriteLine(x); // 16
            Console.WriteLine(++x); //dəyişənin dəyərinin üzərinə 1 vahid gəlib çapa verir = 17;
          //Təyinetmə operatorları
            int number = 20;
             number+=5 ; //Olan dəyərin üzərinə 5 vahid gəlib yenidən təyin etdik.Bunu bütün riyazi operatorlar üçün etmək olar
            //Müqayisə operatorları
        
        }

    }
}
