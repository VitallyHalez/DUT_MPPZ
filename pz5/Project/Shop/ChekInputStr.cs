using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ChekInputStr : AbstractInstance
    {
        ConsoleColor colorDefault;
        int lengthStr = 0;
        string message;
        public ChekInputStr(string message, int lengthStr)
        {
            this.lengthStr = lengthStr;
            this.message = message;
        }
        protected override void Init()
        {
            colorDefault = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
        }
        protected override void Idle()
        {
            Console.Write(message);
            string str = Console.ReadLine();
            if (str.Length <= lengthStr) 
            {
                Result = str;
                SetDone();
            }
            else
            {
                Console.WriteLine("Length is to large"); 
            }
        }
        protected override void CleanUp()
        {
            Console.ForegroundColor = colorDefault;
        }
    }
}
