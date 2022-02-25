using System;

namespace The_Big_Mamma_Pizzeria
{
    class Pizza
    {
        public int price;
        private string name;
        string[] toppings = { "cheese", "peperoni", "Pork" };
        private int topping = 0;

            public Pizza(string name, int price)
        {
            this.name = name;
            this.price = price;
            toppings = Toppings;
        }
        #region properties
        public string Name
        {
            get { return name; }
        }
        public int Price
        {
            get { return price; }
        }

        public string[] Toppings
        {
            get { return toppings; }
            set { toppings = Toppings; }
        }
        #endregion
        #region Methods
        public void Topping()
        {
            topping = RandomNumberGenerator.Generate(1, 3);
        }
        public override string ToString()
        {
                return "this is a " + name + " which includes " + Toppings[topping] + " and costs " + price + " kr";
        }
        #endregion
    }
}
