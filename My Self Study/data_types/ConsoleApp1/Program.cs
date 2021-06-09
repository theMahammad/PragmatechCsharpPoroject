using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Data tipləri əsasən 2 yerə ayrılır:Value types və Reference types*/
            //Value types
            
           

            int amount_product = 7;
            int amount_product_2 = amount_product;

            double product_price = 0.3;
            bool isActive = false;
           
            
            //Value tiplər adlarını da (məs:product_name),dəyərlərini də (məs:"Qarpiz") "stack" adlı yaddaşda saxlayır                                                                                    //Burda nöqtədən sonra ən çox neçə ədəd ola biləcəyini təyin etdik                                              
            Console.WriteLine($"\"Qarpız \" adlı məhsuldan {amount_product} ədəd qalıb və qiyməti {product_price} AZN-dir.Hamısını birlikdə alsanız, toplam {((amount_product*product_price)*0.85).ToString("#.####")} AZN-e vere bilerik");
            //Reference Types
            //referans type`lar value type`lardan fərqli olaraq yanında(stack-da) dəyəri yox,dəyərin adresini saxlayar.Həmin adres o təyin edilmiş dəyərin Heapda saxlanıldığı yerə açar kimidir.
            string text = "salam";
            string text_2 = text;
            Console.WriteLine(text.GetHashCode().ToString());
            Console.WriteLine(text_2.GetHashCode().ToString());
            //Bu əməliyyatı value tiplər üçün edəndə saxladığı dəyəri,reference type üçün edəndə saxladığı adressi çapa verir
            //İndi isə gəlin,2 tip arasındakı fərqi praktikada göstərək
            int number1 = 5;
            int number2 = number1;//Dəyəri ötürdük,adresi yox.Yəni dəyəri kopyalayıb ötürmüş kimi olduq.number2-dəki hər hansı əməliyyat number1-ə təsir etməyəcək,çünki müstəqil dəyərlərdir
            Console.WriteLine($"Number1-nin indiki qiymeti : {number1}\nNumber2-nin indiki qiymeti : {number2}");
            
            number2 = 25;
            Console.WriteLine("------------------------\nNumber2-nin qiymeti deyishdirildi\n------------------------------------------------------");
            Console.WriteLine($"Number1-nin indiki qiymeti : {number1}\nNumber2-nin indiki qiymeti : {number2}");

            Console.WriteLine("----------------------------------------------------");
            int[] array1 = {1, 2, 7, 9 };
            int[] array2 = array1;
            Console.WriteLine("Array1 massivinin elementləri:");
            for (int index = 0; index < array1.Length; index++)
            {
                
                Console.WriteLine($"----\nindex : {index},deyer : {array1[index]}\n----");
            }
            Console.WriteLine("Array2 massivinin elementləri:");
            for (int index = 0; index < array2.Length; index++)
            {
                
                Console.WriteLine($"----\nindex : {index},deyer : {array2[index]}\n----");
            }
            array2[3] = -25;
            array2[2] = 19;
            Console.WriteLine("Array2-de deyishiklikler oldu");
            Console.WriteLine("Array1 massivinin elementləri:");
            for (int index = 0; index < array1.Length; index++)
            {

                Console.WriteLine($"----\nindex : {index},deyer : {array1[index]}\n----");
            }
            Console.WriteLine("Array2 massivinin elementləri:");
            for (int index = 0; index < array2.Length; index++)
            {

                Console.WriteLine($"----\nindex : {index},deyer : {array2[index]}\n----");
            }
            //Konsoldakı cavabdan da gördüyümüz kimi referans tiplərdə adresi bölüşürük,yəni açarımız müstəqil olur,amma açdığımız yer(çatdığımız dəyər) eynidir,paylaşırıq.Ona görə də biri vasitəsi ilə dəyişiklik edəndə hər ikisinə yansıyır
            
            //Strukturlar
           
            Structss.myFirstStruct myFirst = new Structss.myFirstStruct("Mehemmed", 19, "Baki Muhendislik Universiteti");
            Console.WriteLine($"Adim {myFirst.name}-dir,{myFirst.age} yashim var ve {myFirst.school}-de tehsil aliram");
            //Enumeratorlar
            
            Console.WriteLine(Enumerators.WeekDays.Monday);//Çap: Monday
            Console.WriteLine((int)Enumerators.WeekDays.Monday);//Çap: 0
                                                                
            Console.WriteLine((Enumerators.WeekDays)5);//Çap : Saturday
            //Rəqəmi weekDays-dakı sətirlərə görə konvert etdik


            Console.WriteLine((int)Enumerators.WeekDays.EleBeleGun);//Çap : 15 



        }
    }
}
