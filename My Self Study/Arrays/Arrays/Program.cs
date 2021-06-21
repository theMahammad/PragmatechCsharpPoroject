using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS(MASSIVLƏR)
            //Massivlər dəyərləri toplu halda saxlamaq üçün istifadə olunur,proqram daxili databaza kimi düşünə bilərsiniz
            /*Massivlərin üstünlükləri
             1.Optimallaşdırılmış kod(daha az)
             2.Datalar üzərində rahat gəzinmə
             3.Dataları əməliyyatlarda daha rahat işlətmə
             4.Dataları daha rahat sıralamaq və s.
            Massivlərin əskiklikləri
                Sabit ölçü(Yəni element artdıqça ölçüsü artmır)
             */
            //Massivlər əsasən 2 cür olur : Təkölçülü massivlər və çox ölçülü massivlər
            //Tək ölçülü massivlərə baxaq 


            //Təyin olunması
                //Əvvəla dəyişəndən əvvəl tipin önündə kvadrat mötərizə açırıq,bu massiv təyin edəcəyimiz göstərir
                //Bərabərlikdən sağda isə new keywordu ilə yenə başda təyin etdiyimiz tip və mötərizəsini yazırıq,bu dəfə içinə bir ədəd verərək maksimum neçə  elementli olacağına qərar veririk
                int[] array = new int[5];
                //bu massivimiz maksimum 5 element qəbul edə bilər
                //aşağıda bir neçə fərqli təyin olunma üsuluna baxaq
                int[] array1 = new int[] { 5, 6, 7 };
                int[] array2 = new int[3] { 0, 5,7 };// şaxəli mötərizədəki elementlərin sayı kvadrat mötərizədə verilən ədədə bərabər olmalıdır
                int[] array3 = { 5, 1, 30 };
                var array4 = new int[]{ 5, 7, 11 }; //Burda başda spesifik tipi bildirməyə ehtiyac olmasa da,şaxəli mötərizədən öncə yazılmalıdır
            //Datalara çatmaq
            //Massivdə elementlər 0-dan başlayaraq indekslərə görə düzülür.Yəni ilk elementin indeksi 0-dır,sonrakı 1 və beləcə 1 vahid arta-arta gedir.
            int[] array_ = { 5, 7, 9, 4, 23 };
            //Məsələn bu massivdə elementləri indeksi ilə yazsaq : 0|5,1|7,2|9,3|4,4|23
            //Bəs bu indekslər nə işimizə yarayır?Gəlin,baxaq
            int first_index = array_[0];
            //yuxarıdakı sətirdə "first_index" dəyişəninə "array_" massivinin 0-cı elementini ötürdük.Demək massiv_adı[indeks_nömrəsi] tipdə bir əmr-lə massiv üzərində gəzə bilərik.
            Console.WriteLine(first_index);//5
            //Console.WriteLine(array_[5]); //xəta verdi.Çünki bizim massivimiz 5 elementlidir,və bu halda 0-dan başlayanda son indeksimiz 4 olacaq.4-dən böyük indeksləri çağırdıqda,xəta alacağıq
            //Massivlərin üzərində gəzinmənin daha rahat yolu varmı?Təbii ki var.
            //For və massivlər

            for(int index = 0; index < array_.Length; index++) {
                //Yuxarıdakı  sətirdə şərtin yoxlanılması yerində yazdığımız "array_.Length" ifadəsi bizə massivin uzunluğunu qaytarır.Deməli,index<5 olduğu üçün,for-un icra edəcək son index dəyəri 4-dür
                
                    Console.WriteLine($"{index}|{array_[index]}");
            }
            //Amma "daha rahat yolu yoxdur?Əlləşdirmə bizi kvadrat mötərizə ilə" dediyinizi eşidirəm sanki.
            //bunun üçün də foreach istifadə edə bilərik
            foreach(int element in array_)
            {//Bu əmrdə "element" dəyişəni birbaşa massivin içindəki element olur,sayğac kimi rəqəm olmur.
                //Bunu yuxarıdakı for içində yazsaq,belə yazardıq :element=array_[i]
                
                Console.WriteLine(element);
            }
            //**Massivə yeni element əlavə etmək olmur(ayrılan yerləri doldurmaq olur,amma ayrılan yerdən artıq yazmaq olmur)
            int[] massiv = new int[5]; //Əgər başda elementlər təyin olunmursa,ayrılan yer qədər 0 doldurulur massivə(yəni tipin defolt dəyəri)
            foreach(int element in massiv)
            {
                Console.WriteLine(element);
            }


           


        }
    }
}
