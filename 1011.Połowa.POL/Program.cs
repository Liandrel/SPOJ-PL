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
        string ciag;
        for (int i = 0; i < n; i++)
        {
            ciag = Console.ReadLine();
            for(int j = 0; j < ciag.Length / 2; j++)
            {
                Console.Write(ciag[j]);
            }
            Console.WriteLine();
        }

    }
}
