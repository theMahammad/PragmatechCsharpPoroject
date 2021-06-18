using System;

namespace Task_6_Person_info_
{
    class Program
    {
        struct Person
        {
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
            
            public Person(string name,string surname,int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Yaşınızı daxil edin : ");
            Person person = new Person("Mehemmed","Sadigzade",int.Parse(Console.ReadLine()));
            Console.Write("Adınızı daxil edin : ");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin : ");
            string surname = Console.ReadLine();
            if(person.name == name && person.surname == surname)
            {
                if (person.age <= 18)
                {
                    Console.WriteLine("Sizin yaşınız uyğun deyil");
                }
                else
                {
                    Console.WriteLine("Sizin yaşınız uyğundur");
                }
            }

        }
    }
}
