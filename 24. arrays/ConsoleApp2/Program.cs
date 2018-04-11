using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 3, 5, 7, 9, 2 };
            int[] b = new int[] { 2,4, 5, 8, 10,12 };
            check(a);
        }
        static void oadd(int[] q)
        {
            for (int i = 0; i < q.Length; i++)           
            if (q[i] % 2 == 1)Console.WriteLine( q[i]);                                                                 
        }
         static void even(int[] d)
        {
            for(int i=0;i<d.Length;i++)            
             if(d[i] % 2==0)Console.WriteLine(d[i]);                                                  
            
        }
       static  void check(int[] vvv)
        {
            int b = 0;
            for (int i = 0; i < 2; i++)
            {                
                if (vvv[i] % 2 == 0)b++;                                                         
            }
            if (b <= 1)even(vvv);
            else  oadd(vvv);                                                  
        }
      }
    }

