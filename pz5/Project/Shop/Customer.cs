using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Customer : IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Customer(string Name, string Surname, int Age)
        {
            ID = count++;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Name + " " + Surname + " " + Age);
        }
    }
}
