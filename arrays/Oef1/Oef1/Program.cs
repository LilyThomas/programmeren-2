using System;

namespace Oef1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NUMBER_OF = 20;
            int[] numbers = new int[NUMBER_OF];

			Console.WriteLine(string.Format("Voeg {0} nummbers in:", NUMBER_OF));

			for (int i = 0; i < NUMBER_OF; i++){
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach(int i in numbers){
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            for (int i = 0; i < numbers.Length / 2; i ++){
                int tmp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = tmp;
            }

            foreach(int i in numbers){
                Console.Write(i + " ");
            }

        }
    }
}
