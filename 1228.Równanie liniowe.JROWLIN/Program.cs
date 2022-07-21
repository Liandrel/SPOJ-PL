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
        string[] dane = Console.ReadLine().Split(' ');
        double a, b, c;
        a = double.Parse(dane[0]);
        b = double.Parse(dane[1]);
        c = double.Parse(dane[2]);
        if (a == 0)
        {
            if ((c - b) == 0)
            {
                Console.WriteLine("NWR");
            }
            else
            {
                Console.WriteLine("BR");
            }

        }
        else
        {
            double x = (c - b) / a;
            Console.WriteLine(Math.Round(x, 2).ToString("0.00"));
        }

    }
}
