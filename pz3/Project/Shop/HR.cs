using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class HR
    {
        private DBItem<Employee> dbEmployee;

        public HR()
        {
            this.dbEmployee = DBItem<Employee>.Instance();
        }
        public void CreateEmployee()
        {
            Console.Write("Create Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Create Employee Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Create Employee position: ");
            string position = Console.ReadLine();
            int chiefID = Helper.CheckIntInput("Create Employee Cheif Id: ");
            Employee employee = new Employee( name,  surname,  position, chiefID);
            dbEmployee.AddItem(employee);
        }

        public void ShowEmployees()
        {
            foreach (var item in dbEmployee.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
