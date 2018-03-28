using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] i = { -1, 2, 3, -666, 228, -323284, 3214 };
            
            Console.WriteLine("Vvedi nomer chisla");

            int um = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedi chislo");


            int ha = int.Parse(Console.ReadLine());
            i[um] = ha;
            Console.WriteLine("Ddergi to ilitnoe chislo");
            for (int or = 0; or < i.Length; or++)
            {
                Console.WriteLine(i[or]);
            }



        }
    }
}
