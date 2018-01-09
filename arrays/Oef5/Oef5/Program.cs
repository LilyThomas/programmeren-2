using System;

namespace Oef5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NR_OF_NRS = 10;
            const int COL = 3;
            int[][] numbers = new int[COL][];
            int number;

            for (int i = 0; i < NR_OF_NRS; i++){
                Console.WriteLine("Number?");
                number = int.Parse(Console.ReadLine());


            }
        }
    }
}
