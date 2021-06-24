using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Employee
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ChefID { get; set; }
        public Employee(string Name, string Surname, int ChefID)
        {
            ID = count++;
            this.Name = Name;
            this.Surname = Surname;
            this.ChefID = ChefID;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Name + " " + Surname + " " + ChefID);
        }

    }
}
