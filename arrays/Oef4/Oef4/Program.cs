using System;

namespace Oef4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NUMBER_OF = 5;
            int[] numbers = new int[NUMBER_OF];
            int[] result = new int[NUMBER_OF];
            int x;

            Console.WriteLine("Voeg {0} getallen in:", NUMBER_OF);
            for (int i = 0; i < NUMBER_OF; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Geef een positief getal in kleiner dan {0}:", NUMBER_OF);
                x = int.Parse(Console.ReadLine());
            } while (x < 0 || x >= NUMBER_OF);

            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            for (int i = x; i < numbers.Length; i ++)
            {
                Console.Write(numbers[i] + " ");
            }
            for (int i = 0; i < x; i ++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
