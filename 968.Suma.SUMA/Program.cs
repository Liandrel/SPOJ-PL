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
        int  wynik = 0;
        string a;
        while((a = Console.ReadLine()) != null)
        {
            wynik += int.Parse(a);
            Console.WriteLine(wynik);
        }
    }
}
