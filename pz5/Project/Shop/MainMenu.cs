using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class MainMenu : IInstance
    {
        
        InstanceRun instanceRunHR;
        InstanceRun instanceRunSalesManagerMenu;
        InstanceRun instanceRunProductManagerMenu;
        ConsoleColor colorDefault;
        public bool IsDone { get ; set; }
        public  void Init()
        {
            colorDefault = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = string.Format("Menu");          
            instanceRunHR = new InstanceRun(new HRMenu());
            instanceRunSalesManagerMenu = new InstanceRun(new SalesManagerMenu());
            instanceRunProductManagerMenu = new InstanceRun(new ProductManagerMenu());
        }

        public void CleanUp()
        {
            Console.ForegroundColor = colorDefault;
        }

        public void Idle()
        {
            Console.Clear();
            int number = Helper.CheckIntInput("Menu\n\nSelect action:\n\n1.HR menu\n\n2.Sales Manager menu\n\n3.Product Manager menu\n\n4.Exit\n");
            switch (number)
            {
                case 1:
                    {
                        instanceRunHR.Run();

                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        instanceRunSalesManagerMenu.Run();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        instanceRunProductManagerMenu.Run();
                        Console.Clear();
                        break;
                    }
                case 4:
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
