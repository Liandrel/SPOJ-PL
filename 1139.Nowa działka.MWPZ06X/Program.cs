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
        int D = int.Parse(Console.ReadLine());

        for (int i = 0; i < D; i++)
        {
            int kroki = int.Parse(Console.ReadLine());
            Console.WriteLine(kroki * kroki);
        }

    }
}
