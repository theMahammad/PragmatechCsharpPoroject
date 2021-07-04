using System;

namespace Task_1_reverse_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            Random random = new Random();
            //Randomize the elements of array
            
            for (int index = 0;index<number.Length;index++) {

                number[index] = random.Next();
            }
            //Show  usual sequence of elements
            foreach(int element in number)
            {
                Console.WriteLine(element);
            }
            //Let's reverse the array with two method
            Console.WriteLine("**********");
            //First method
            Console.WriteLine("Tersine çevrilmiş halı : ");
            Array.Reverse(number);
            foreach (int element in number)
            {
                Console.WriteLine(element);
            }
            //Now the order of the elements  is reversed.In order to write second method we must back the order to how it was ,let's reverse again
            Array.Reverse(number);
            Console.WriteLine("**********");
            //Second method
            Console.WriteLine(number.Length);
            int index_= 0;
            int reversed_index;
            
            int[] clone_array = (int[]) number.Clone();
            for(reversed_index = clone_array.Length-1; reversed_index >= 0; reversed_index--)
            {
                number[reversed_index] = clone_array[index_];
                index_++;
            }
            Console.WriteLine("Tersine çevrilmiş halı : ");
           
            foreach (int element in number)
            {
                Console.WriteLine(element);
            }
        }
    }
}
