using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ProductManagerMenu : IInstance
    {
        ConsoleColor colorDefault;
        public bool IsDone { get; set; }
        //

        public void Init()
        {
            colorDefault = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = string.Format("Product Manager Menu");
            //
        }


        public void CleanUp()
        {
            Console.ForegroundColor = colorDefault;
        }

        public void Idle()
        {
            Console.Clear();
            int number = Helper.CheckIntInput("Menu\n\nSelect action:\n\n1\n\n2.\n\n3.Exit");//
            switch(number)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    }
                    //
                default:
                    break;
            }
        }

    }
}
