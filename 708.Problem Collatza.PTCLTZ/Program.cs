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
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(Oblicz(s, 0));
        }

    }

    private static int Oblicz(int s, int n)
    {
        if(s == 1)
        {
            return n;
        }
        else
        {
            if (s % 2 == 1)
                return Oblicz(3 * s + 1, ++n);
            else
                return Oblicz(s / 2, ++n);
        }
    }
}
