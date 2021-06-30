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
            Console.WriteLine(user.age);
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

        }
    }
}
