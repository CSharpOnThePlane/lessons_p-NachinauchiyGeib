using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Global._Offencife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши гимн для Ком. Китая а то отправим к империалистам.");
            string y = Console.ReadLine();
            int i = y.Length;
            string zvezdochki = "";
            for (int x = 0; x < i; x++)
            {
                zvezdochki = zvezdochki + "*";

            }
            Console.WriteLine(zvezdochki);
        }
    }
}