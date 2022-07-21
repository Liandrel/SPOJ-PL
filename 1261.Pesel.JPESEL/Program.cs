using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] p = new int[11];
            string pesel = Console.ReadLine();
            for(int j = 0; j < pesel.Length; j++)
            {
                p[j] = Int32.Parse(pesel.Substring(j, 1));
            }
                
            if(pesel.Length == 11)
            {
                
                p[0] *= 1;
                p[1] *= 3;
                p[2] *= 7;
                p[3] *= 9;
                p[4] *= 1;
                p[5] *= 3;
                p[6] *= 7;
                p[7] *= 9;
                p[8] *= 1;
                p[9] *= 3;
                p[10] *= 1;
                int suma = 0;
                foreach (int x in p)
                    suma += x;
                if((suma % 100) % 10 == 0)
                {
                    Console.WriteLine("D");

                }
                else
                {
                    Console.WriteLine("N");
                }
            }
            else
            {
                Console.WriteLine("N");
            }
            
        }

    }
}
