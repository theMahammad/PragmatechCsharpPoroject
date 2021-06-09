using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enumerators
    {
        //Enumeratorlar sabit adlı dəyişənlərə dəyər ötürmək üçündür.Enum ilə kodlar daha oxunaqlı olur
        public enum WeekDays
        {
            //Default olaraq ilk sətir özündə 0 dəyəri saxlayır,və əgər heç bir müdaxilə yoxdursa,hər bir sətir 1 vahid artıraraq dəyər tutur
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

            EleBeleGun=15//El ile deyer daxil etdik
        }
    }
}
