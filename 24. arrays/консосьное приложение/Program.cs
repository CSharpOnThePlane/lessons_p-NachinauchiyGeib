using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace консосьное_приложение
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = {-1,2,3,-666,228,-323284,3214 };
            Console.WriteLine("Vvedi nomer chisla");
            int m = int.Parse(Console.ReadLine());
            if (i[m]>0)
            {
                Console.WriteLine("chislo is polozgitelenoe");
            }
            else
            {
                Console.WriteLine("chislo isn't polozgitelenoe");
            }
            


        }
    }
}
