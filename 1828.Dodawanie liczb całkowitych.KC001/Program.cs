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
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(suma);
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
        }

    }
}
