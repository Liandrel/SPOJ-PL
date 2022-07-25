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
        try
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] dane = Console.ReadLine().Split(' ');
                int seg = int.Parse(dane[0]);
                seg--;
                int wiek = 0;
                for (int j = 1; j < dane.Length; j++)
                {
                    wiek += int.Parse(dane[j]);
                }
                wiek += seg;
                Console.WriteLine(wiek);

            }
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
