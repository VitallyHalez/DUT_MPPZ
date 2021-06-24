using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ProductManager
    {
        private DBItem<Product> dbProduct;
        private DBItem<Description> dbDescription;
        public ProductManager()
        {
            dbProduct = DBItem<Product>.Instance();
            dbDescription = DBItem<Description>.Instance();
        }
        public void ProductCreate()
        {
            AbstractInstance checkInputStr = new ChekInputStr("Create Product Name: ", 20);
            checkInputStr.Run();
            string name = (string)checkInputStr.Result;
            decimal price = Helper.CheckDecimalInput("Enter product price: ");
            dbProduct.AddItem(new Product(name, price));
        }
        public void ShowProducts()
        {
            dbProduct.Items.ForEach(item => Console.WriteLine(item));
        }
        public void DescriptionCreate()
        {
            AbstractInstance chekInputStr =new ChekInputStr("Create ProductDescription ", 200);
            chekInputStr.Run();
            string description = (string)chekInputStr.Result;
            
            int productID = Helper.CheckIntInput("Enter produduct ID ");
            dbDescription.AddItem(new Description(description, productID));
        }
        public void ShowProductDescriptions()
        {
            dbProduct.Items.ForEach(product => { Console.WriteLine(product); dbDescription.Items.ForEach(description => { if (description.ProductID == product.ID) { Console.WriteLine("\t" + description); } }); });
        }  
    }
}
