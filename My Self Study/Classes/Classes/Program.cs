using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Siniflər(Classes)
            //Siniflər bir-biriylə əlaqəli dəyişənləri,metodları birlikdə saxlamaq üçün istifadə olunur

            //Var olan sinfin dəyişən və metodlarını işlətmək üçün onun obyektini yaratmalıyıq
            User user = new User();
            user.name = "Mehemmed";
            user.age = 15;
            Console.WriteLine(user.name);//Mehemmed
            Console.WriteLine(user.age);//15
            user.celebrateBirthday();//Yaşı 1 vahid artdı
            Console.WriteLine(user.age);//16
            User user1 = new User();//Defolt konstruktor çağrıldı,parametrlərə defolt dəyərləri ötürüldü(initialize olundu)
            Console.WriteLine(user1.age); //0
            User user2 = new User("Reşad Dağlı",35); //Parametrli konstruktor çağrıldı və sinfin içindəki dəyişənlərə mənimsədiləcək dəyərlər verildi
            Console.WriteLine(user2.name);
        }
        //Sinifin təyin olunması
        public class User
        {
            //Bu sinfin içində istifadəçi ilə bağlı datalar saxlanılacaq(structlar ilə oxşardır)
            //Dəyişənlərə "state",metodlara isə "behaviour" deyilir
            public string name;
            public int age;
            public void celebrateBirthday(){
                age++;
            }
            //Sinfin daxilində defolt olaraq parametrsiz konstruktor olur.O konstruktorun içində də dəyişənlər öz defolt dəyərlərinin(Məs : int - 0,string-null və s.) ötürüldüyü əmrlər icra olunur
            public User()
            {   //Defolt olaraq aşağıdakı kimi dəyər ötürmələri baş verir
                //this.name = null;
                //this.age = 0;
            }
            //Parametrli konstruktorlar
            public User(string name,int age)
            {
                this.name = name;
                this.age = age;
                //burda "this" açarsözü sinfin dəyişənləri ilə metoda ötürülən dəyişənləri ayırd edə bilmək üçün istifadə olunur
                //Struktlardan fərqli olaraq burda bütün dəyişənləri initialize etməyə  ehtiyac yoxdur
            }


        }
        
    }
}
