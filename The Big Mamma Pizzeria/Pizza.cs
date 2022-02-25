using System;

namespace The_Big_Mamma_Pizzeria
{
    class Pizza
    {
        private int price;
        private string name;
        private string toppings;

            public Pizza(string name, int price, string toppings)
        {
            this.name = name;
            this.price = price;
            this.toppings = toppings;
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

        public string Toppings
        {
            get { return toppings; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
                return "this is a " + name + " which includes " + Toppings + " and costs " + price + " kr";
        }
        #endregion
    }
}
