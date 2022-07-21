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
        string[] dane = new string[2];
        double v1, v2;
        int s = 100;
        double t1,t2;
        for (int i = 0; i < n; i++)
        {
            dane = Console.ReadLine().Split(' ');
            v1 = int.Parse(dane[0]);
            v2 = int.Parse(dane[1]);     
            t1 = s / v1;
            t2 = s / v2;
            double wynik =(2 * s) / (t1 + t2);
            wynik = Math.Round(wynik);
            Console.WriteLine(wynik);
        }

    }
}
