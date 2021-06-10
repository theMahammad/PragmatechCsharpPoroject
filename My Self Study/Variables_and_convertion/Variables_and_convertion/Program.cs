using System;

namespace Variables_and_convertion
{
    class Program
    {
        //Metodlar
        /*Metodlar kod təkrarının qarşısını almaq üçün istifadə edilir*/
        /*Main özü də bir metoddur.Ondan yuxarıda öz metodumuzu yazaq */

        /*Metodlar iki cür olur : void və return type*/
        /*Void əsasən hər hansı bir işi görmək üçün,return type-lar isə işi görüb dəyər qaytarmaq üçün istifadə olunur*/
        static string text = "Men funksiya colundeyem";
        public  static void myFirstFunction()
        {
            
            int a = 5;/*Bu dəyişən return olunmursa(ki voiddə return olmur),a dəyişənini funksiyanın çölündən çağırmaq mümkün deyil.*/
            Console.WriteLine(text);//Amma funksiya ilə özündən yuxarıda olan dəyişənlərə çatmaq olar

        }
        public static int toplama()//return type-i int olan funksiya yalnız integer dəyər qaytara bilir
        {
            int a = 7;//myFirstFunction içindəki a dəyişəninə dəxli yoxdur
            int b = 15;
            
            return a+b;//Əgər return olmasa,xəta baş verəcək.Çünki proqram "return etmirsənsə,voidlə yazardın da" deyəcək haqlı olaraq

        }
        //Parametrli funksiyalar
        /*Yuxarıda tipləri göstərdik,indi isə funksiyaların parametr almasına baxaq*/
        public static void myFirstFunction(string text)//Eyni adda iki funksiya ola bilər,əgər parametrlərinin tipində və ya sayında fərqlilik varsa

            
        {
            Console.WriteLine(text);
        }
        public static void myFirstFunction(string text,int age)


        {
            Console.WriteLine($"{text} | {age}");
        }
        public static int toplama(int toplanan1,int toplanan2) 


        {
            return toplanan1 + toplanan2;
        }
        //Sonsuz parametr ötürmək
        //Bunun üçün "params" açarsözündən istifadə edəcəyik
        public static int toplama( params int[] toplananlar)
        {
            int cem = 0;
            foreach(int toplanan in toplananlar)
            {
                cem += toplanan;
            }
            return cem;
        }
        //Bir neçə dəyər return etmək
        public static Tuple<int,int> cem_ve_hasil(params int[] toplananlar)
        {
            int cem = 0;
            int hasil = 1;
            foreach (int toplanan in toplananlar)
            {
                cem += toplanan;
                hasil *= toplanan;
            }
            return Tuple.Create( cem,hasil);
        }

        static void Main(string[] args)
        {

            myFirstFunction();
            toplama();//Bu funksiyanı çağırdıq,amma dəyər return edirsə,ya bir dəyişənə ötürməli,ya da birbaşa çap etməliyik.Belə havada saxlamaq olmaz
            //1
                int cem = toplama();//22
                Console.WriteLine(cem);
            //2
            Console.WriteLine(toplama());
            myFirstFunction("Mehemmed");
            myFirstFunction("Mehemmed", 19);
            int cem2 = toplama(17, 35);//52
                Console.WriteLine(cem2);
            int cem3 = toplama(5, 7, 9, 15,25);//61
            Console.WriteLine(cem3);
            int cem4 = cem_ve_hasil(5,9,4).Item1; //18
            Console.WriteLine(cem4);
        }
    }
}
