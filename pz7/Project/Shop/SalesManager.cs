using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class SalesManager
    {
        private DBItem<Customer> dbCustomer;
        private DBItem<Order> dbOrder;
        private DBItem<Basket> dbBacket;
        public SalesManager()
        {
            this.dbCustomer = DBItem<Customer>.Instance();
            this.dbOrder = DBItem<Order>.Instance();
            this.dbBacket = DBItem<Basket>.Instance();
        }

        public void CreateCustomer()
        {
            Console.WriteLine("Create Customer Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Create Customer Surname: ");
            string surname = Console.ReadLine();
            int age = Helper.CheckIntInput("Create Customer age: ");
            Customer customer = new Customer(name, surname, age);
            dbCustomer.AddItem(customer);
        }
        public void ShowCustomers()
        {
            foreach (var item in dbCustomer.Items)
            {
                Console.WriteLine(item); 
            }
        }
        public void CreateOrder()
        {
            Console.WriteLine("Create Order Name: ");
            string orderName = Console.ReadLine();
            int customerID = Helper.CheckIntInput("Enter Customer Id: ");
            int CiefID = Helper.CheckIntInput("Enter Chief Id: ");
            Order order = new Order(orderName, customerID, CiefID);
            dbOrder.AddItem(order);
        }
        public void ShowOrders()
        {
            foreach (var item in dbOrder.Items)
            {
                Console.WriteLine(item);
            }
        }
        public void CreateBasket()
        {
            int orderID = Helper.CheckIntInput("Enter Order ID: ");
            int productID = Helper.CheckIntInput("Enter Product ID: ");
            int amount = Helper.CheckIntInput("Enter Amount: ");
            Basket basket = new Basket(orderID, productID, amount);
            dbBacket.AddItem(basket);
        }
        public void ShowBaskets()
        {
            foreach (var item in dbBacket.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
