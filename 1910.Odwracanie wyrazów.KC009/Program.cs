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
            string dane;
            do
            {
                dane = Console.ReadLine();
                char[] arr = dane.ToCharArray();
                Array.Reverse(arr);
                string wynik = new string(arr);
                Console.WriteLine(arr);
            }
            while (dane != null);
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
