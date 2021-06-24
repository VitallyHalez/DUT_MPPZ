using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Description : IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Info { get; set; }
        public int ProductID { get; set; }
        public Description(string Info, int ProductID)
        {
            ID = count++;
            this.Info = Info;
            this.ProductID = ProductID;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Info + " " + ProductID);
        }
    }
}
