using System;

namespace Oef3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NUMBER_OF = 20;
            int[] numbers = new int[NUMBER_OF];
            int[] result = new int[NUMBER_OF];

            Console.WriteLine(string.Format("Voeg {0} getallen in:",NUMBER_OF));

            for (int i = 0; i < NUMBER_OF; i ++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < NUMBER_OF; i++)
            {
                result[(i + 3) % numbers.Length] = numbers[i];
            }

            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}
