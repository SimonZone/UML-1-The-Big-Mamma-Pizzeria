using System;

namespace The_Big_Mamma_Pizzeria
{
    class Customer
    {
        private string CustommerName;
        private int CustomerID;

        public Customer(string name, int ID)
        {
            this.CustommerName = name;
            this.CustomerID = ID;
        }

        #region properties
        public string Name
        {
            get { return CustommerName; }
        }
        public int ID
        {
            get { return CustomerID; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "A Customer has placed an order, their name is " + CustommerName + " with Customer ID: " + CustomerID;
        }
        #endregion
    }
}
