using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product : IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string Name, decimal Price)
        {
            ID = count++;
            this.Name = Name;
            this.Price = Price;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Name + " " + Price); 
        }
    }
}
