using System;

namespace Oef2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NUMBER_OF = 20;
            int[] numbers = new int[NUMBER_OF];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            for (int i = 0; i < numbers.Length; i ++)
            {
                numbers[(i + 1) % numbers.Length] = numbers[i];
            }

            foreach(int i in numbers){
                Console.Write(i + " ");
            }
        }
    }
}
