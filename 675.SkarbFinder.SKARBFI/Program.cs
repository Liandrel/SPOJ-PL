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
            int m = int.Parse(Console.ReadLine());
            int[,] polpol = new int[2, 1];
            int[,] wsza = new int[2, 1];
            int studnia = 0;
            for (int j = 0; j < m; j++)
            {
                string[] dane = Console.ReadLine().Split(' ');
                switch (dane[0])
                {
                    case "0":
                        polpol[0, 0] += int.Parse(dane[1]);
                        break;
                    case "1":
                        polpol[1, 0] += int.Parse(dane[1]);
                        break;
                    case "2":
                        wsza[0, 0] += int.Parse(dane[1]);
                        break;
                    case "3":
                        wsza[1, 0] += int.Parse(dane[1]);
                        break;
                }
                
            }
            if (polpol[0, 0] > polpol[1, 0])
            {
                Console.WriteLine("0" + " " + (polpol[0, 0] - polpol[1, 0]));
            }
            else if (polpol[0, 0] > polpol[1, 0])
            {
                Console.WriteLine("1" + " " + (polpol[1, 0] - polpol[0, 0]));
            }
            else
            {
                studnia++;
            }

            if (wsza[0, 0] > wsza[1, 0])
            {
                Console.WriteLine("2" + " " + (wsza[0, 0] - wsza[1, 0]));
            }
            else if (wsza[0, 0] < wsza[1, 0])
            {
                Console.WriteLine("3" + " " + (wsza[1, 0] - wsza[0, 0]));
            }
            else
            {
                studnia++;
            }
            if (studnia == 2)
            {
                Console.WriteLine("studnia");
            }

        }
    }
}

