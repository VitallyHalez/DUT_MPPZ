using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class SalesManagerMenu : IInstance
    {
        ConsoleColor colorDefault;
        public bool IsDone { get; set; }
        SalesManager salesManager;
        public void Init()
        {
            colorDefault = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = string.Format("Sales Manager Menu");
            salesManager = new SalesManager();
        }

        public void CleanUp()
        {
            Console.ForegroundColor = colorDefault;
        }

        public void Idle()
        {
            Console.Clear();
            int number = Helper.CheckIntInput("Menu\n\nSelect Action:\n\n1.Create Customer\n\n2.Show Customers\n\n3.Create Order\n\n4.Show Orders\n\n5.Create Basket\n\n6.Show Baskets\n\n7.Exit\n");
            switch (number)
            {
                case 1:
                    {
                        Console.Clear();
                        salesManager.CreateCustomer();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        salesManager.ShowCustomers();
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        salesManager.CreateOrder();
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        salesManager.ShowOrders();
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        salesManager.CreateBasket();
                        Console.ReadKey();
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        salesManager.ShowBaskets();
                        Console.ReadKey();
                        break;
                    }
                case 7:
                    {
                        Console.Clear();
                        IsDone = true;
                        break;
                    }            
                default:               
                    break;                 
            }           
        }

    }
}
