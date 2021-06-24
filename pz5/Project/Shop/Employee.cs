using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Employee : IID
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public int ChefID { get; set; }
        public Employee(string Name, string Surname, string Position, int ChefID)
        {
            ID = count++;
            this.Name = Name;
            this.Surname = Surname;
            this.Position = Position;
            this.ChefID = ChefID;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Name + " " + Surname + " " + Position + " " + ChefID);
        }

    }
}
