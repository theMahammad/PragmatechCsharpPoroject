using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngülər(loops)
            //Döngülər də kod təkrarının qarşısını almaq üçün istifadə olunur: 
            //Məsələn 1 yazını 3 dəfə çap etmək istədiyimiz halı düşünək :
            string text = "Salam olsun yaxşılara";
            Console.WriteLine(text);
            Console.WriteLine(text);
            Console.WriteLine(text);
            //Bəs 100 dəfə çap etmək istəsək?Ohoo..
            //bunun üçün köməyimizə döngülər çatır : 
            //FOR
                //ilk vergüldən öncə bir sayğac təyin edirik,bu yuxarıda təyin olunmuş da ola bilər
                int i;
                //Sonra o for-un hansı halda işləyəcəyini bildiririk(Adətən sayğacın rəqəmi ilə əlaqəli olur),ən sonda da sayğacı artırıb-azaldırıq.
                //ilk döngüdə i 0-dan başlayır,i əgər 3-dən kiçikdirsə,döngünün içindəki əmrlər icra olunur,ardından i 1 vahid artırılır
                //ikinci döngüdə i=1 olur,ardından 3-dən kiçiklik halı yoxlanır,yenə əmr icra olunur,sonra i 1 vahid artırılır.
                //Toplamda 3 döngüdən sonra 4-cü döngüdə i=3 olur,3-dən kiçiklik halı səhv olduğu üçün bu dəfə döngü içindəki əmrlər icra olunmur
                for (i=0; i < 3; i++)
                {
                    Console.WriteLine(text);
                }
            //WHILE
                //Məsələn bir ədədi bir-bir artırıb çapa verək
                int number=0;
                //ingilis dilində while "o müddətboyu" kimi anlama gəlir.Yəni bu kodda number dəyişəni 10-dan kiçik olduğu müddətcə döngü çalışacaq.
                while (number < 10)
                {//İlk döngüdə number = 0 olduğu üçün 10-dan kiçik olur,və əmrlər icra olunur.
                    //Ən sonuncu işlədiyi hal isə number=9 halıdır,onu da çapa verib 1 vahid artırdıqdan sonra number=10 olduğu üçün 10-dan kiçi olması şərtini qarşılamır.
                        Console.WriteLine(number);
                        //Əgər aşağıda  number-i artırmasaq,sonsuz döngü olacaq,çünki number daima 0 olacaq və döngü daima işləyəcək
                        number++;
                }
            //DO-WHILE
                //do-while da while ilə oxşardır,tək fərqi odur ki,while-da öncə yoxlayıb edirdisə,burda etdikdən sonra yoxlayır,əgər şərtə uyğun deyilsə,döngü davam etmir
                do
                {   //do-while halında do bloku içindəki əmrlər icra olunur və sonda şərt yoxlanılır,100>200=false olduğu üçün döngü bitir,amma ən az bir dəfə əmrləri etmiş olduq
                    Console.WriteLine("Elə üzmüş ahuzarım məni ruzigar içində,Çap olundum,do-while içində");
                } while (100>200);
                while (100>200)
                {   //While-da isə öncə şərti yoxlayıb sonra əmri icra etdiyi üçün,100>200=false olduğu üçün əmr icra edilməyəcək
                    Console.WriteLine("Çap olunmadım");
                }
            //nested for(iç-içə for)
                //Gəlin,buna aid misal olaraq 10-luq vurma cədvəlini yazaq.
                    //1-ci addım: vurulan ədədi göstərən bir dəyişən təyin etdik
                    int vurulan;
                    //2-ci addım : vurulan ədədləri 1-dən başlatdıq,10-luq vurma cədvəli olduğu üçün 10-dan kiçik-bərabər olduğu müddətcə davam edən bir şərt qoyduq

                    for (vurulan = 1; vurulan <= 10; vurulan++)
                    { 
                        Console.Write($"{vurulan}|");
                        //3-cü addım : Dəyişəni 10-a kimi ədədlərə vurub çap etməsi üçün 0-dan başlayıb 10-a kimi davam edən(10 da daxil) bir döngü təyin etdik

                        for(int vuran = 0; vuran <= 10; vuran++)
                        
                        {   //Vuran-ı hər dəfə bir vahid artıraraq vurulana vurub çap edirik
                            int hasil = vurulan * vuran;
                            Console.Write($" {hasil} ");
                        }
                        //1 vurulan üçün 10 ədədə vurulmasının nəticəsi yazılıb bitdisə,növbəti vurulana keçir kod
                        Console.WriteLine();
                    }
                 /*******************************************************************/
                //KEYWORDS
                    //BREAK
                        //Adətən müəyyən bir şərt ödəndikdə döngüdən tamam çıxılmasını istənil,break keyword-undən istifadə olunur
                        //Məsələn 10-a kimi ədədlər verilib,5-ə kimi ədədlər çapa verilsin,sonra döngüdən çıxsın istəyirik :
                            for(int index = 0; index < 10; index++)
                            {
                            Console.WriteLine(index);
                            if (index == 5)
                            {
                                Console.WriteLine("Sağ olun,dottar");
                                //Əgər index==5 halı olursa,döngü break olacaq(qırılacaq),yəni 5-dən sonrasına baxılmayacaq
                                break;
                            }
                //CONTINUE
                    //Adətən müəyyən bir şərt ödəndikdə döngünün həmin şərti ödəyən elementi üçün "continue" aşağısındakı əmrlər icra olunmur,yəni continue görən kimi növbəti elementə keçir
                    //Dediyimdən anlaşıldığı kimi continue-nı ən sonda qoymaq yersizdir,çünki nə əmr varsa,başda icra olunub,sonda onsuzda döngü özü növbəti elementə keçir
                    //Məsələn : 30-a kimi olan ədədlər içində tək olanları çapa verək.
                        int number1;
                        for (number1 = 0; number1 < 30; number1++)
                        {
                            if (number1 % 2 == 0)
                            {
                                Console.WriteLine("Men cutem");
                                //Əgər number1-in dəyəri 2-ə bölünəndə qalığı 0 olursa,yəni cütdürsə,o zaman bu if-in içərisi işləyir və sonda continue ilə döngünün digər elementinə keçir sıra.
                                //Əgər təkdirsə,deməli continue olmur və aşağıdakı əmrlər icra olunur(dəyər çapa veriləcək)
                                continue;
                            }
                            Console.WriteLine("--------------------------------");
         
                            Console.WriteLine(number1);
                            Console.WriteLine("--------------------------------");
                        }


            }




        }
    }
}
