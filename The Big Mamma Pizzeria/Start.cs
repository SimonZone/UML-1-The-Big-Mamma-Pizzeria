using System;

namespace The_Big_Mamma_Pizzeria
{
    class Start
    {
        static void Main(string[] args)
        {
            PizzaStore theCode = new PizzaStore();
            theCode.MyCode();

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
