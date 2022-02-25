using System;

namespace The_Big_Mamma_Pizzeria
{
    class Customer
    {
        private string CustomerName;
        private int CustomerID;

        public Customer(string name, int ID)
        {
            this.CustomerName = name;
            this.CustomerID = ID;
        }
        public string CName
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }
        #region properties
        public string Name
        {
            get { return CustomerName; }
        }
        public int ID
        {
            get { return CustomerID; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Name: " + CustomerName + ", Customer ID: " + CustomerID;
        }
        #endregion
    }
}
