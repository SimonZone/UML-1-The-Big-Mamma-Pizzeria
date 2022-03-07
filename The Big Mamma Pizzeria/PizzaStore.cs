using System;

namespace The_Big_Mamma_Pizzeria
{
    class PizzaStore
    {
        public void MyCode()
        {
            

            Pizza Pizza1 = new Pizza("Margherita", 25, "Cheese");
            Pizza Pizza2 = new Pizza("Calzone", 42, "Pork");
            Pizza Pizza3 = new Pizza("Big Mamma", 50, "All the meat!");
            Customer Customer1 = new Customer("Simon", 1);
            Customer Customer2 = new Customer("Peter", 2);
            Customer Customer3 = new Customer("Daniel", 3);
            Order Order1 = new Order(true, Pizza1);
            Order Order2 = new Order(false, Pizza2);
            Order Order3 = new Order(true, Pizza3);

            Customer CustomerS = new Customer("", 4);
            Order OrderS = new Order(false, Pizza1);



            Console.WriteLine("If you want to run the normal program, type \"Normal\" or press any enter to order yourself");
            if(Console.ReadLine() == "Normal")
            {
                Console.WriteLine(
                "\nWelcome to The Big Mamma, what would you like to order?\n" +
                "We have these pizza available:\n" +
                $"{Pizza1} \n{Pizza2} \n{Pizza3}\n\n"
                );

            Console.WriteLine($"{Customer1.ID}. {Customer1.Name} have ordered a {Pizza1.Name} and thier {Order1}");
            Console.WriteLine($"{Customer2.ID}. {Customer2.Name} have ordered a {Pizza2.Name} and thier {Order2}");
            Console.WriteLine($"{Customer3.ID}. {Customer3.Name} have ordered a {Pizza3.Name} and thier {Order3}");

            } else {
                    Console.WriteLine("Hi there! What is your name?");
                    CustomerS.CName = Console.ReadLine();
                    Console.Write($"Hi {CustomerS.Name}, ");

                    Console.WriteLine("Do you want your order delivered? type \"Yes\". If no just press enter.");
                    if (Console.ReadLine() == "Yes")
                    {
                        OrderS.delivery = true;
                    } 

                    Console.WriteLine(
                        "Welcome to The Big Mamma, what would you like to order?\n" +
                        "We have these pizza available:\n" +
                        $"1. {Pizza1} \n2. {Pizza2} \n3. {Pizza3}\n\n"
                    );

                // fix this bug: Convert.ToInt32(Console.Read()) make the int as a ascii

                int test = Convert.ToInt32(Console.Read());
                switch (test)
                    {
                        case 49:
                        OrderS.pizzaprice = Pizza1.Price;
                            Console.WriteLine($"{CustomerS.Name} have ordered a {Pizza1.Name} and your {OrderS}.");
                            break;
                        case 50:
                        OrderS.pizzaprice = Pizza2.Price;
                        Console.WriteLine($"{CustomerS.Name} have ordered a {Pizza2.Name} and your {OrderS}.");
                            break;
                        case 51:
                        OrderS.pizzaprice = Pizza3.Price;
                        Console.WriteLine($"{CustomerS.Name} have ordered a {Pizza3.Name} and your {OrderS}.");
                            break;
                        default:
                            Console.WriteLine($"You did not order anything on the menu.");
                            break;
                    }

            }
        }
    }
}
