using System;

namespace Oef1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Persoon lily = new Persoon("Lily", "Thomas", new DateTime(1994, 12, 9));
            Persoon simon = new Persoon("Simon", "Vanneste", new DateTime(1992, 12, 30));
            Persoon sara = new Persoon("Sara", "Thomas", new DateTime(1988, 1, 26));
            Persoon lala = new Persoon("Lala", "Gonzales", DateTime.Today);

            Console.WriteLine(lily);
            Console.WriteLine(simon);
            Console.WriteLine(sara);
            Console.WriteLine(lala);
        }
    }
}
