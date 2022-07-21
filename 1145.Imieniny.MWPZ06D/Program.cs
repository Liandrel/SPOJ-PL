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
            int L = int.Parse(dane[0]);
            int C = int.Parse(dane[1]);
            L--;
            if (L > C)
            {
                Console.WriteLine("TAK");
                continue;
            }
            if (L == 0 && C > 0)
            {
                Console.WriteLine("TAK");
                continue;
            }
            if (C == 0)
            {
                Console.WriteLine("NIE");
                continue;
            }
            if (C % L > 0)
            {
                Console.WriteLine("TAK");
                continue;
            }
            else
            {
                Console.WriteLine("NIE");
                continue;
            }
        }
    }

}
