using System;

namespace Multi_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÇOXÖLÇÜLÜ MASSİVLƏR(MULTİ-DİMENSİONAL ARRAYS)
            //Bu nümunədə ikiölçülü massivə baxacağıq
           
            int row = 5;
            int col = 7;

            int[,] td_array = new int[row, col]; //5 sətir,7 sütunlu massiv yaratdıq
            for (int r = 0; r < row; r++)
            { //Əvvəlcə bir sətrə girib bütün sütunlarını çap edirik,sonra da digər sətrə keçirik
                for (int c = 0; c < col; c++)
                {

                    Console.Write($"{td_array[r, c]} ");
                }
                Console.WriteLine();//Hər sətir üçün 1 aşağı düşməsini istəyirik
            }
            Console.WriteLine(td_array.Length);
        }
        //Digər təyinetmə üsulları
        int[,] td_array_1 = new int[2, 3] { { 1, 3, 7 }, { 8, 9, 15 } }; //2 sətir,3 sütun
        int[,] td_array_2 = new int[,] { {5,7,8 },{ 51, 85, 96 },{ 95, 78, 14 } };// 3 sətir,3 sütun
        int[,] td_array_3 = { { 5, 7, 14 }, { 51, 85, 96 }, { 95, 78, 14 } };//3 sətir,3 sütun

    }
}
