using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

                
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public override string ToString()
        {
            return string.Format(Name+" "+Surname);
        }
    }
}
