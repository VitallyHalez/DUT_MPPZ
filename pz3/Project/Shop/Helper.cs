using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    static class Helper
    {
        public static int CheckIntInput(string masage)
        {
            int result;
            bool isDone = false;
            do
            {
                Console.Write(masage);
                string str = Console.ReadLine();
                isDone = int.TryParse(str, out result);
                if (isDone==false)
                {
                    Console.WriteLine("Не число");
                }
            } while (!isDone);
            return 0;
        }
    }
}
