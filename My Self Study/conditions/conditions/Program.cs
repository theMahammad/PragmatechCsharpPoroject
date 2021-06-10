using System;

namespace conditions
{
    class Program
    {
        

        static void Main(string[] args)
        {/*IF-ELSE*/

            /* //Proqramlaşdırmanın təməllərindən biri də şərtlərdir,"filan halda bu olsun,digər halda isə bu" tipli alqoritmlər üçün bizə şərtlər lazımdır
             string username = "Mehemmed355";
             string password = "5178";
             Console.WriteLine("Sistemə xoş gəldiniz,zəhmət olmasa ,daxil olun\n----------------");
             Console.Write("İstifadeçi adı : ");
             string usernameFromUser = Console.ReadLine();
             Console.Write("\nŞifre : ");
             string passwordFromUser = Console.ReadLine();
             //Burda istifadəçidən username tələb etdik

             if (username == usernameFromUser && password==passwordFromUser) //Burda bizim hard code olaraq təyin etdiyimiz dəyişənlə istifadəçinin daxil etdiyi dəyişən eynidirmi deyə yoxladıq
                 {   //Əgər bərabərdirsə,ifin içində yazılanları icra edəcək
                     Console.WriteLine("Xoş geldiniz");
                 }
                 else //Əgər bərabər deyilsə,o zaman bu blokun içindəki əmirlər icra olunacaq
                 {
                     Console.WriteLine("Mırt vurmağa başqa adam tap");
                 }
             */
            /*IF-ELSEIF-ELSE*/
            /*
                Console.WriteLine("Sürücü vesiqesi imtahanının qeydiyyatına xoş gelmişsiniz");
                Console.Write("Yaşınızı daxil edin : ");
                
                int age = int.Parse(Console.ReadLine()); //type conversion etdik
                if (age >= 65)//Əgər yaş 65-dən böyük-bərabərdirsə,bu if-in içindəki əmrlər icra olunacaq
                {
                    Console.WriteLine("Sizin yaşınız qeydiyyat üçün böyükdür");
                }
                else if (age < 18 && age>=0)//Yaş 65-ə böyük bərabər,deyilsə,if-else halındakı kimi digər bütün hallar üçün tək əmrlər toplusu etmək əvəzinə,yeni bir şərt daha qoyuruq.
                //Əgər yaş 18-dən kiçik,0-a böyük-bərabərdirsə,bu ifin içi icra olunacaq
                {
                Console.WriteLine("Sizin yaşınız qeydiyyat üçün kiçikdir");
                }
                else //Yuxarıdakı 2 şərt də ödənilmirsə,onda digər bütün hallarda else blokunun içindəki əmrlər icra olunacaq
                {
                    Console.WriteLine("Qeydiyyat üçün uyğunsunuz");
                }
            //Nested-if(İç-içə if)
            //bir şərt ödənmədikdə digər şərtə else if vasitəsi ilə yollaya bilirdik.Bəs bir şərtin ödəndiyi halda?Təbii ki ödənən şərt blokunun içinə yeni bir şərt bloku yazaraq
            
            if (age >= 65)
            {
                Console.WriteLine("Sizin yaşınız qeydiyyat üçün böyükdür");
                Console.WriteLine("Amma 1000 manatın var?Varsa,1,yoxsa,0-a bas");
                int status = Convert.ToInt32(Console.ReadLine());
                if (status==1) { //Eger yaş 65-ə böyük bərabərdirsə,bu şərti yoxlayacaq
                    Console.WriteLine("Sen bizim üçün cavan,qoçaq birisən");
                }
                else
                {
                    Console.WriteLine("Yene deyirem,yaşınız böyükdür");
                }
            }
            else if (age < 18 && age >= 0)
            {
                Console.WriteLine("Sizin yaşınız qeydiyyat üçün kiçikdir");
            }
            else 
            {
                Console.WriteLine("Qeydiyyat üçün uyğunsunuz");
            } */
            
            Console.Write("Eded daxil edin :");
            int number = int.Parse(Console.ReadLine());
            //Tək sətirlik if-else
            /*
            bool isGreaterThan100 = number > 100 ? true : false; //Sualdan solda şərt,sualdan sonrakı halda şərtin ödəndiyi hal qoşa nöqtədən öncə şərtin ödəndiyi hal(if),qoşa nöqtədən sonra isə ödənmədiyi haldır
            if (isGreaterThan100 == true)
            {
                Console.WriteLine("Eded 100-den böyükdür");

            }
            else
            {
                Console.WriteLine("Eded 100-den kiçikdir");
            }
            */
            //tək sətirlik if-elseif-else

            var text = number > 100 ? "100-den böyükdür" :number>50?"50-den böyük,100-den kiçikdir":"50-den de kiçikdir";//ilk qoşa nöqtədən sonrası ilk şərtin ödənmədiyi hal idi.Biz də ondan sonra "number>50" deyə ikinci bir şərt yazdıq
            Console.WriteLine(text);
        
                //switch-case
                //Daha spesifik hallar üçün istifadə olunur
                Console.Write("Imtahandan aldiginiz neticeni daxil edin : ");
            string result = Console.ReadLine();
            //Hansı dəyişənin dəyərinə baxılacaqsa,mötərizə içində yazırıq
            switch (result)
            {
                case "A": Console.WriteLine("Elaçı oldunuz"); //result=="A" halında icra olunacaq
                        break;
                case "B": Console.WriteLine("Zerbeçi oldunuz");
                    break;
                case "C":Console.WriteLine("Adi stipendiyaya düşdünüz");
                    break;
                case "D":
                case "E": //iki hal üçün eyni əmri icra etdirdik
                    Console.WriteLine("Stipendiyadan kesildiniz");
                    break;
                default: //Əgər yuxarıdakı halların heç birinə uyğun deyilsə,default-un altındakı əmrlər icra olunacaq
                    Console.WriteLine("Sehv daxil etmisen");
                    break;
            }
            







        }
    }
}
