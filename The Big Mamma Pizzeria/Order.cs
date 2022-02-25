using System;

namespace The_Big_Mamma_Pizzeria
{
    class Order
    {
        private int TotalPrice = 0; // hjælp skal bruge pizzaens pris
        private bool Delivery;
        private double OrderPrice;
        private const int DeliveryCost = 40;
        private const double Tax = 0.25;

        
        public Order(bool Delivery)
        {
            TotalPrice = totalprice;
            this.Delivery = Delivery;
        }

        #region properties
        public int totalprice
        {
            get { return TotalPrice; }
            set {TotalPrice = value; }
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
        public void CalculateTotalPrice()
        {       
            //Calculate price for inhouse or delivery
            if (Delivery == true) 
            {
                orderprice = TotalPrice + ( TotalPrice * Tax ) + DeliveryCost ;
            } else {
                orderprice = TotalPrice + (TotalPrice * Tax);
            }
        }
        public double;
        public override string ToString()
        {
            CalculateTotalPrice();
            return "Your Order is " + orderprice + " kr";
        }    
    }
}
