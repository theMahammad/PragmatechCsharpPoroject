using System;

namespace Task_1
{
    class Program
    {
        struct User
        {
            public string username;
            public string password;
            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
        }
       
        static void Main(string[] args)
        {   
            User user = new User("Mehemmed355","512314");
            //GETTING INFORMATION OF USER
            Console.Write("İstifadeçi adını daxil edin : ");
            
            string username=Console.ReadLine();
            Console.Write("Şifreni daxil edin : ");
            string password = Console.ReadLine();
            //Compare the values of the object of User struct and the values which are got from Console
            if (user.username==username && user.password==password) {
                Console.WriteLine("Xoş gelmişsiniz");

            }
            else
            {
                Console.WriteLine("Istifadeçi adı ve ya şifre yanlışdır");
            }
            
        }
    }
}
