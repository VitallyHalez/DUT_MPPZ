using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            DBItem<Product> dbProduct = DBItem<Product>.Instance();
            Product product1 = new Product("TV", 100);
            dbProduct.AddItem(product1);
            Product product2 = new Product("Laptop", 200);
            dbProduct.AddItem(product2);
            Product product3 = new Product("PC", 300);
            dbProduct.AddItem(product3);

            DBItem<Description> dbDescription = DBItem<Description>.Instance();
            Description description1 = new Description("Infolaptop", 2);
            dbDescription.AddItem(description1);
            Description description2 = new Description("InfoPC", 3);
            dbDescription.AddItem(description2);
            Description description3 = new Description("InfoTV", 1);
            dbDescription.AddItem(description3);

            DBItem<Customer> dbCustomer = DBItem<Customer>.Instance();
            Customer customer1 = new Customer("Vasia", "Vasin", 20);
            dbCustomer.AddItem(customer1);
            Customer customer2 = new Customer("Petia", "Petin", 21);
            dbCustomer.AddItem(customer2);
            Customer customer3 = new Customer("Ivan", "Ivanov", 22);
            dbCustomer.AddItem(customer3);

            DBItem<Profile> dbProfile = DBItem<Profile>.Instance();
            Profile profile1 = new Profile(3, "Shototam", "123", "pepega@gmail.com");
            dbProfile.AddItem(profile1);
            Profile profile2 = new Profile(2, "Gdetotam", "321", "gdetotam@i.ua");
            dbProfile.AddItem(profile2);
            Profile profile3 = new Profile(1, "Kaktotam", "312", "gdetotam@i.ua");
            dbProfile.AddItem(profile3);

            DBItem<Employee> dbEmployee =  DBItem<Employee>.Instance();
            Employee employee1 = new Employee("Dimasik", "Priks", "Cheef", 1);
            dbEmployee.AddItem(employee1);
            Employee employee2 = new Employee("Andrysha", "Skur", "Manager", 1);
            dbEmployee.AddItem(employee2);
            Employee employee3 = new Employee("Danya", "Polova", "Konsultant", 2);
            dbEmployee.AddItem(employee3);

            DBItem<Order> dbOrder = DBItem<Order>.Instance();
            Order order1 = new Order("Order1", 2, 2);
            dbOrder.AddItem(order1);
            Order order2 = new Order("Order2", 3, 2);
            dbOrder.AddItem(order2);
            Order order3 = new Order("Order3", 1, 3);
            dbOrder.AddItem(order3);

            DBItem<Basket> dbBasket = DBItem<Basket>.Instance();
            Basket basket1 = new Basket(2, 3, 5);
            dbBasket.AddItem(basket1);
            Basket basket2 = new Basket(1, 2, 6);
            dbBasket.AddItem(basket2);
            Basket basket3 = new Basket(3, 1, 7);
            dbBasket.AddItem(basket3);




            SalesManager salesManager = new SalesManager();
            salesManager.ShowCustomers();
            salesManager.CreateCustomer();
            salesManager.ShowCustomers();

            salesManager.ShowOrders();
            salesManager.CreateOrder();
            salesManager.ShowOrders();

            salesManager.ShowBaskets();
            salesManager.CreateBasket();
            salesManager.ShowBaskets();
            Console.ReadLine();

            HR hr = new HR();
            hr.ShowEmployees();
            hr.CreateEmployee();
            hr.ShowEmployees();
            Console.ReadLine();





            foreach(var customer in dbCustomer.Items)
            {
                Console.WriteLine(customer);
                foreach(var profile in dbProfile.Items)
                {
                    if (customer.ID == profile.CustomerID)
                    {
                        Console.WriteLine("\t" + profile);
                    }
                }
                foreach(var order in dbOrder.Items)
                {
                    if(customer.ID==order.CustomerID)
                    {
                        Console.WriteLine("\t\t"+order); 
                        foreach(var employee in dbEmployee.Items)
                        {
                            if(order.EmployeeID==employee.ID)
                            {
                                Console.WriteLine("\t\t\t" + employee);
                            }
                        }
                        foreach(var basket in dbBasket.Items)
                        {
                            if(basket.OrderID==order.ID)
                            {
                                Console.WriteLine("\t\t\t\t" + basket);
                                foreach (var product in dbProduct.Items)
                                {
                                    if (basket.ProductID==product.ID)
                                    {
                                        Console.WriteLine("\t\t\t\t\t"+product);
                                        foreach (var description in dbDescription.Items)
                                        {
                                            if (description.ProductID==product.ID)
                                            {
                                                Console.WriteLine("\t\t\t\t\t\t"+description);
                                            }
                                        }
                                    }                                  
                                }
                            }
                        }
                    }
                    
                }

            }
          
        }
    }
}
