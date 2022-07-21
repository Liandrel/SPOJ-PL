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
        int l = int.Parse(Console.ReadLine());

        for (int i = 0; i < l; i++)
        {
            string[] dane = Console.ReadLine().Split(' ');
            double n = double.Parse(dane[0]);
            double k = double.Parse(dane[1]);
            Console.WriteLine(Newton(n,k));
        }

    }

    private static double Newton(double n, double k)
    {
        double wynik = 1;
        for(int i = 1; i <=k; i++)
        {
            wynik = (wynik * (n - i + 1)) / i;
        }
        return Math.Round(wynik);
    }
}

