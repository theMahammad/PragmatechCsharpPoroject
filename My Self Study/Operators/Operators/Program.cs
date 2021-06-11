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
            //Müqayisə operatorları bizə nəticədə boolean dəyərlər qaytarır(true və ya false)
            bool isGreaterThan100 = 50 > 100; //Burda 50-nin 100-dən böyük olması halını yoxladıq,və cavab false olacaq
            Console.WriteLine(isGreaterThan100);//false
            Console.WriteLine(50 < 100);//true
            Console.WriteLine(100 >= 100);// 100-ün 100-ə böyük-bərabər halını yoxladıq = true;
            Console.WriteLine(100 != 200 );//100-ün 200-ə bərabər olmama halını yoxladıq = true;
            Console.WriteLine(50 == 50); //50-nin 50-ə bərabər olma halını yoxladıq = true;
            //Məntiqi operatorlar
            //Məntiqi operatorlar,əsasən,if bloku içində 2 və daha artıq şərti yoxlamaq üçün işlədilir
            string username = "Mehemmed391";
            string password = "549746";
            Console.Write("İstifadeçi adını daxil edin : ");
            string usernameFromConsole = Console.ReadLine();
            Console.Write("Şifreni daxil edin : ");
            string passwordFromConsole = Console.ReadLine();
            //VƏ &&
            if (username == usernameFromConsole && password == passwordFromConsole)
            {
                //əgər username VƏ password alınan dəyərlərə bərabərdirsə,o zaman bu if içi işləyəcək
                Console.WriteLine("Sisteme xoş geldiniz");

            }
            else
            { //əgər iki şərtdən biri ödənmirsə,bu blok işləyəcək
                Console.WriteLine("Bele istifadeçi tapılmadı");
            }
            //VƏ YA ||
            if (username == usernameFromConsole || password == passwordFromConsole)
            {
                //əgər username VƏ YA password-dan hər hansı biri alınan dəyərlərə bərabərdirsə,o zaman bu if içi işləyəcək
                Console.WriteLine("Gözümə tanış gəlirsən");

            }
            else
            { //əgər iki şərtdən heç biri ödənmirsə,bu blok işləyəcək
                Console.WriteLine("Bele istifadeçi tapılmadı");
            }




        }

    }
}
