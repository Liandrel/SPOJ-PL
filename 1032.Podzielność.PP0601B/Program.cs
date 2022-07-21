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
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string[] dane = Console.ReadLine().Split(' ');
            int n = int.Parse(dane[0]);
            int x = int.Parse(dane[1]);
            int y = int.Parse(dane[2]);
            for(int j = 0; j < n; j++)
            {
                if (j % x == 0 && j % y != 0)
                    Console.Write(j + " ");
            }

            Console.WriteLine();
        }

    }
}
