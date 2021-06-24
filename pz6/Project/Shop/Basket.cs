using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Basket : IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public Basket(int OrderID, int ProductID, int Amount)
        {
            ID = count++;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Amount = Amount;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + OrderID + " " + ProductID + " " + Amount);
        }
    }
}
