using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Customer : Person, IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public int Age { get; set; }
        public Customer(string Name, string Surname, int Age) : base(Name, Surname)
        {
            ID = count++;
            this.Age = Age;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + base.ToString() + " " + Age);
        }
    }
}
