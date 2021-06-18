using System;

namespace Task_5_Graduation_
{
    class Program
    {
        struct Student{
            public int grade { get; set; }

        }
        static void Main(string[] args)
        {   
            Student student = new Student();
            Console.Write("Telebenin qiymetini daxil edin (0-100 arası)  : ");
            student.grade =int.Parse(Console.ReadLine());
            
            int grade = student.grade;
            if (grade > 91)
            {
                Console.WriteLine("Tebrikler,siz A aldınız");
            }else if (grade>81) {
                Console.WriteLine("Tebrikler,siz B aldınız");
            }else if (grade > 71)
            {
                Console.WriteLine("Tebrikler,siz C aldınız");
            }else if (grade > 61)
            {
                Console.WriteLine("Tebrikler,siz D aldınız");
            }
            else
            {
                Console.WriteLine("Teessüf ki,siz kesildiniz");
            }
        }
    }
}
