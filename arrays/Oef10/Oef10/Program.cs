using System;

namespace Oef10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			const int NUMBER_OF = 100;
			const int SPACES = 1;
			int[] numbers = new int[NUMBER_OF];
			int[] demo = new int[NUMBER_OF];

			Console.WriteLine(string.Format("Voeg {0} nummers in:", NUMBER_OF));

			for (int i = 0; i < NUMBER_OF; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			foreach (int i in numbers)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine("");

			for (int i = 0; i < numbers.Length; i++)
			{
				demo[(i + SPACES) % numbers.Length] = numbers[i];
			}


			foreach (int i in demo)
			{
				Console.Write(i + " ");
        }
    }
}
