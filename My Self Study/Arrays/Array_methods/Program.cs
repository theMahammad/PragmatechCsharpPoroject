using System;

namespace Array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Massiv metodları*/
            //Əvvəla üzərində əməliyyatlar edəcəyimiz massiv yaradaq 
            int[] array = new int[5] { 7, 9, 23, 5, 3 };
            //Clear(Massivdə verilmiş dəyərləri tipin defolt halına döndərmək üçündür(daxil edilən 2-ci və 3-cü parametrlər arası indeksləri olan elementləri))
            Array.Clear(array,0,5);
            foreach(int element in array)
            {
                Console.WriteLine(element); //Bütün elementlər 0 olacaq
            }
            Console.WriteLine("*************************************");

            array = new int[5]{ 7, 9, 23, 5, 3 };
            //Clone(Massivin dəyərini kopyalayıb ötürür)
            //Yuxarıda "Clear" etdiyimiz üçün massivin qiymətləri 0-landı,təzdən əvvəlki halına gətirmək üçün gərək yenə o dəyərləri bir-bir yazaq
            //Bunun daha asan yolu yoxdurmu?Məsələn bir yeni massiv dəyişəninə əsas massivimin dəyərlərini mənimsədib sonra təkrar geri almaq yaxşı fikirdir
            int[] clone_array = array;//Amma massivlər referans tip olduğu üçün birbaşa belə yazdıqda adress ötürməsi kimi olur.Yəni bir evi kopyalayıb vermirik,eyni evin açarını kopyalayıb veririk
            //Burda işimizə Clone metodu yarıyacaq
            Console.WriteLine(array[0]);//7
            array[0] = 15;
            Console.WriteLine(clone_array[0]);//15
            clone_array = (int[])array.Clone();//birbaşa(implicitly) cast etmək olmur
            array[0] = 28;
            Console.WriteLine(array[0]);//28
            Console.WriteLine(clone_array[0]);//15(Dəyəri(evi) klonladığımız üçün artıq clone_array array ilə eyni yeri paylaşmır)
            Console.WriteLine("************************************");
            //CopyTo(İşlədilmə mahiyyəti əsasən Clone metodu ilə eynidir)
            int[] copy_array = new int[5];
            array.CopyTo(copy_array, 0);//İlk parametr olaraq kopyalayacağımız massivin adını,sonra da kopyalamanın kopyanı alan massivin neçənci indeksindən başlayacağını seçirik(Əsas massivimizin ölçüsü kopyalanacağı massivin ölçüsündən böyük olmamalıdır.)
            array[0] = 30;
            Console.WriteLine(array[0]);//30
            Console.WriteLine(copy_array[0]);//28
            Console.WriteLine("************************************");
            //ConvertAll(Bütün massivin tipini dəyişmək üçündür)
            int[] int_array = new int[5] { 50, 27, 86, 94, 13 };
            string[] str_array = Array.ConvertAll(int_array, element => element.ToString()); //ilk parametr olaraq çevriləcək massivi yazdıq,ikinci olaraq da hər bir element üçün icra ediləcək əməliyyatı(bunun üçün lambda funksiyaları bilmək lazımdır)
            foreach(string element in str_array)
            {
                Console.WriteLine(element);
                Console.WriteLine(element.GetType().Name);//String
            }
            Console.WriteLine("************************************");
            //Exists(Massivin bütün elementlərini ixtiyari bir şərtə görə yoxlayır,ödəyən biri varsa,true yollayır)
            Console.WriteLine(Array.Exists(int_array, element => element==50));//True
            Console.WriteLine(Array.Exists(int_array, element => element == 40));//False
            Console.WriteLine("************************************");
            //Fill(Massivin bütün elementlərinə ixtiyari bir eyni dəyəri ötürmək üçündür)
            Array.Fill(str_array, "Mehemmed");//str_array massivinin bütün elementləri "Mehemmed"-e bərabər olacaq
            foreach (string element in str_array)
            {
                Console.WriteLine(element);//Mehemmed
                
            }
            Console.WriteLine("************************************");
            //Find(Massivin elementlərini hansısa bir şərtə görə yoxlayır və ödəyən ilk elementi qaytarır)
            Console.WriteLine(Array.Find(int_array, element => element % 2 == 1)); //Tək olan ilk elementi qaytardı(27)
            
            Console.WriteLine("************************************");
            //FindIndex(Massivin elementlərini hansısa bir şərtə görə yoxlayır və ödəyən ilk elementin indeksini  qaytarır)
            Console.WriteLine(Array.FindIndex(int_array, element => element % 2 == 1)); //Tək olan ilk elementin indeksini  qaytardı(1)
            Console.WriteLine("************************************");
            //FindLast(Find kimi o da şərtə görə yoxlayır,amma ödəyən sonuncu elementi qaytarır)
            Console.WriteLine(Array.FindLast(int_array, element => element % 2 == 1)); //Tək olan son elementi qaytardı(13)
            Console.WriteLine("************************************");
            //FindLastIndex(Şərti ödəyən sonuncu elementin indeksini qaytarır)
            Console.WriteLine(Array.FindLastIndex(int_array, element => element % 2 == 1)); //Tək olan ilk elementin indeksini  qaytardı(4)
            Console.WriteLine("************************************");

            //FindAll(Find kimidir,fərqi odur ki,şərti ödəyən bütün elementləri qaytarır,yəni massiv olur)

            int[] odd_numbers = Array.FindAll(int_array, element => element % 2 == 0);//Cüt olan elementləri siyahı olaraq qaytardı
           
            Array.ForEach(odd_numbers, element => Console.WriteLine(element));//ForEach metodu massivin bütün elementləri üçün hərhansı bir eyni əmri yazmağa istifadə olunur.Burda ilk parametr olaraq verilən massivdəki bütün elementlər çap olunacaq
            Console.WriteLine("************************************");
            int[] array_1 = new int[] { 55, 96, 87, 63, 87 };
           
            //IndexOf(Massivdə seçilmiş elementin ilk tapıldığı indeksi qaytarır)
            Console.WriteLine(Array.IndexOf(array_1, 87));//2
            Console.WriteLine("************************************");
            //LastIndexOf(Massivdə seçilmiş elementin son tapıldığı indeksi qaytarır)
            Console.WriteLine(Array.LastIndexOf(array_1, 87));//4
            Console.WriteLine("************************************");
            //Resize(Massivin element limitini dəyişdirmək üçün istifadə olunur)
            Console.WriteLine(array_1.Length);//5
            Array.Resize(ref array_1,array_1.Length+5); //Ölçünü 5 vahid artırdıq.
            //Ref açarsözü referans tipin methoda referansı ilə birlikdə ötürülməsi üçündür,beləliklə array_1-də metoddaxili hər dəyişiklik xaricdəki array_1-ə də təsir edir
            Console.WriteLine(array_1.Length);//10 (Sağdan etibarən artdırdığı üçün son 5 element 0 oldu)
            Console.WriteLine("************************************");
            //Reverse(Tərsinə çevirmək üçün istifadə olunur)
            Array.Reverse(array_1);
            foreach(int element in array_1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("************************************");







        }
    }
}
