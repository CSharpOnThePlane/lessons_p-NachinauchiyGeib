using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши сколько звёздочек будет на флаге Ком. Китая а то отправим к националистам.");
             int y = int.Parse(Console.ReadLine());
            string zvezdochki = "";
            for (int i = 0; i < y; i++)
            {
                zvezdochki=zvezdochki + "*";
                
            }
            Console.WriteLine(zvezdochki);
        }
    }
}
