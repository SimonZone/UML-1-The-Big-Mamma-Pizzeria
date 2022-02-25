using System;

namespace The_Big_Mamma_Pizzeria
{
    class PizzaStore
    {
        public void MyCode()
        {
            Pizza Pizza1 = new Pizza("Margherita", 25);
            Pizza Pizza2 = new Pizza("Calzone", 42);
            Pizza Pizza3 = new Pizza("Big Mamma", 50);
            Customer Customer1 = new Customer("Simon", 1);
            Customer Customer2 = new Customer("Peter", 2);
            Customer Customer3 = new Customer("Daniel", 3);
            Order Order1 = new Order(true);
            Order Order2 = new Order(false);
            Order Order3 = new Order(true);



            Console.WriteLine(
                "Welcome to The Big Mamma, what would you like to order?\n" +
                "We have these pizza available\n" +
                $"{Pizza1} \n{Pizza2} \n{Pizza3}\n");

            

            Console.WriteLine(Customer1);
            Console.WriteLine(Customer2);
            Console.WriteLine(Customer3);

            Console.WriteLine(Order1);
            Console.WriteLine(Order2);
            Console.WriteLine(Order3);
        }
    }
}
