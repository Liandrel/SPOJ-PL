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
            string[] dane = Console.ReadLine().Split(' ');
            int[] daneint = new int[dane.Length - 1];
            int suma = 0,wynik = 0;
            double srednia, naj = 100,roz;
            for (int j = 1; j < dane.Length; j++)
            {
                daneint[j - 1] = int.Parse(dane[j]);
                suma += daneint[j - 1];
            }
            srednia = (double)suma / ((double)daneint.Length);

            for (int j = 0; j < daneint.Length; j++)
            {
                roz = Math.Abs(srednia - daneint[j]);
                if(roz < naj)
                {
                    naj = roz;
                    wynik = daneint[j];
                }
            }
            Console.WriteLine(wynik.ToString());


        }

    }
}
