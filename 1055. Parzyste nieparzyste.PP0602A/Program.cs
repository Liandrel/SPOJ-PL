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
            string parz = "", nparz = "";
            string[] dane = Console.ReadLine().Split(' ');
            for (int j = 1; j <= int.Parse(dane[0]); j++)
            {
                if(j % 2 != 0)
                {
                    nparz += dane[j] + " ";
                }
                else
                {
                    parz += dane[j] + " ";
                }
            }
            Console.WriteLine(parz + nparz);
        }
        

    }
}
