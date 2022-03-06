using System;

namespace The_Big_Mamma_Pizzeria
{
    class Order
    {
        private bool Delivery;
        private double OrderPrice;
        private const int DeliveryCost = 40;
        private const double Tax = 0.25;
        private Pizza PizzaPrice;

        
        public Order(bool Delivery, Pizza pizza)
        {
            PizzaPrice = pizza;
            this.Delivery = Delivery;

        }

        #region properties
        public int pizzaprice
        {
            get { return PizzaPrice.Price; }
            set { PizzaPrice.Price = value; }
        }
        public bool delivery
        {
            get { return Delivery; }
            set { Delivery = value; }
        }
        public double orderprice
        {
            get { return OrderPrice; }
            set { OrderPrice = value; }
        }
        #endregion
        public double CalculateTotalPrice()
        {       
            //Calculate price for inhouse or delivery
            if (Delivery == true) 
            {
                orderprice = PizzaPrice.Price + ( PizzaPrice.Price * Tax ) + DeliveryCost ;
            } else {
                orderprice = PizzaPrice.Price + (PizzaPrice.Price * Tax);
            }
            return orderprice;
        }

        public override string ToString()
        {
            CalculateTotalPrice();
            if (delivery == true)
            {
                return "order is " + orderprice + " kr, this is including delivery fees";
            } else
            {
                return "order is " + orderprice + " kr";
            }
            
        }    
    }
}
