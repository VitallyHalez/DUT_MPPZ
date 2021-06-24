using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Order
    {
        private static int count = 1;
        public int ID { get; set; }
        public string OrderName { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public Order(string OrderName, int CustomerID, int EmployeeID)
        {
            ID = count++;
            this.OrderName = OrderName;
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + OrderName + " " + CustomerID + " " + EmployeeID);
        }

    }
}
