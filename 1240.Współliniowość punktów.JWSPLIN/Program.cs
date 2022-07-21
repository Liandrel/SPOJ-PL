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
            string[] dane = Console.ReadLine().Split('\t');
            int[] x = new int[3];
            int[] y = new int[3];

            x[0] = int.Parse(dane[0]);
            y[0] = int.Parse(dane[1]);
            x[1] = int.Parse(dane[2]);
            y[1] = int.Parse(dane[3]);
            x[2] = int.Parse(dane[4]);
            y[2] = int.Parse(dane[5]);
            double a1, b1, a2, b2, aw, bw;
            a1 = (double)(y[0] - y[1]);
            b1 = (double)(x[0] - x[1]);
            a2 = (double)(y[0] - y[2]);
            b2 = (double)(x[0] - x[2]);
            aw = a1 / b1;
            bw = a2 / b2;
            double nan = double.NaN;
            if (aw / bw == 1 || (b1 == 0 && b2 == 0) || (aw == 0 && bw == 0) )
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
        }

    }
}
