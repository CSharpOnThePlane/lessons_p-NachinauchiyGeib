using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Privyet comrad, write yor slovo or tiy are Syka Blyat ");
            string slovo = Console.ReadLine();
            int dlinya_slovya = slovo.Length;
            for (int i = 0; i < dlinya_slovya; i++)
            {
                char letter = slovo[i];
                if (letter == 'e')
                {
                    Console.WriteLine("Molodets comrad, slovo is horoshoe");
                    break;
                }
            }
        }
    }
}
