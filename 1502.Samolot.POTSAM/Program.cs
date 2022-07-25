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
        string[] dane = Console.ReadLine().Split(' ');
        Console.WriteLine(int.Parse(dane[0])* int.Parse(dane[1]) + int.Parse(dane[2]) * int.Parse(dane[3]));

    }
}
