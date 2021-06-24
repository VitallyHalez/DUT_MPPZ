using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ProductManagerMenu : IInstance
    {
        ConsoleColor colorDefault;
        public bool IsDone { get; set; }
        ProductManager productManager;

        public void Init()
        {
            colorDefault = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = string.Format("Product Manager Menu");
            productManager = new ProductManager();
        }


        public void CleanUp()
        {
            Console.ForegroundColor = colorDefault;
        }

        public void Idle()
        {
            Console.Clear();
            int number = Helper.CheckIntInput("Menu\n\nSelect action:\n\n1.Create Product\n\n2.Show Products\n\n3.Create product description\n\n4. Show product descriptions\n\n5.Exit\n=> ");//
            switch(number)
            {
                case 1:
                    {
                        Console.Clear();
                        productManager.ProductCreate();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        productManager.ShowProducts();
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        productManager.ShowProducts();
                        productManager.DescriptionCreate();
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        productManager.ShowProductDescriptions();
                        Console.ReadKey();
                        break;
                    }
                case 5:
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
