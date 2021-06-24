using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class HRMenu : IInstance
    {
        ConsoleColor colorDefault;
        public bool IsDone { get; set; }
        HR hR;
        public void Init()
        {
            colorDefault = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = string.Format("HR Menu");
            hR = new HR();
        }
        public void CleanUp()
        {
            Console.ForegroundColor = colorDefault;
        }

        public void Idle()
        {
            Console.Clear();
            int number = Helper.CheckIntInput("Menu\n\nSelect action:\n\n1.Create Employees\n\n2.Show Employee\n\n3.Exit\n");
            switch (number)
            {
                case 1:
                    {
                        Console.Clear();
                        hR.CreateEmployee();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        hR.ShowEmployees();
                        Console.ReadKey();
                        break;
                    }
                case 3:
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

