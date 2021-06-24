using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Employee : Person, IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Position { get; set; }
        public int ChefID { get; set; }
        public Employee(string Name, string Surname, string Position, int ChefID) :base(Name, Surname)
        {
            ID = count++;
            this.Position = Position;
            this.ChefID = ChefID;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + base.ToString() + " " + Position + " " + ChefID);
        }

    }
}
