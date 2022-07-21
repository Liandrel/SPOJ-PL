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
            int x, y, z;
            x = int.Parse(dane[0]);
            y = int.Parse(dane[1]);
            z = int.Parse(dane[2]);
            int a = x + y;
            int b = y * z;
            double temp = (double)(a - b) / (double)(z - 1);
            temp *= -12;
            temp = Math.Round(temp);
            Console.WriteLine(temp);

        }

    }
}
