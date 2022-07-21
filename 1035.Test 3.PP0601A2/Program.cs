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
        string n = "42", pn = "";
        int count = 0;

        while(count < 3)
        {
            pn = n;
            n = Console.ReadLine();
            if (pn != "42" && n == "42")
                count++;
            Console.WriteLine(n);
        }
    }
}
