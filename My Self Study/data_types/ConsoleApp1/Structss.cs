using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Structss
    {
        //Strukturlar data saxlamaq üçün işlədilir və klass ilə bənzərdir.Strukturların dəyişənlərinə hard core dəyər ötürmək olmur,gərək obyektinin yaradılandan sonra və ya həmin an dəyər ötürülsün
        public struct myFirstStruct
        {   public string name;
            public int age;
            public string school;
            public myFirstStruct(string name,int age,string school)
            {
                this.name = name;
                this.age = age;
                this.school = school;

            }
        }
    }
}
