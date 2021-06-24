using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Profile : IID
    {
        private static int count = 1;
       public int ID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerAdress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
       

        public Profile(int CustomerID, string CustomerAdress, string Phone, string Email)
        {
            ID = count++;
            this.CustomerID = CustomerID;
            this.CustomerAdress = CustomerAdress;
            this.Phone = Phone;
            this.Email = Email;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + CustomerID + " " + CustomerAdress + " " + Phone + " " + Email);
        }
    }
}
