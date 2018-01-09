using System;

namespace Arrays_Oef1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NR_OF_NRS = 5;
            int[] numbers = new int[NR_OF_NRS];

            Console.WriteLine(String.Format("Insert {0} numbers:", NR_OF_NRS));

            for (int i = NR_OF_NRS; i > 0; i--)
            {
                numbers[i - 1] = int.Parse(Console.ReadLine());
            }

            foreach(int nr in numbers)
            {
                Console.Write(nr + " ");
            }
        }
    }
}
