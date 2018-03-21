using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podshitai_Capitalistov
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            Console.WriteLine("Privyet comrad, write yor slovo or tiy are capitalist");
            string slovo = Console.ReadLine();
            int dlinya_slovya = slovo.Length;
            for (int i = 0; i < dlinya_slovya; i++)
            {
                char letter = slovo[i];
                if (letter == 'c')
                {
                    
                    b++;
                }
            }
            Console.WriteLine("You found " + b + " capitalists");
        }
    }
}
