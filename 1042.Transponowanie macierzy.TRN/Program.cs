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
        string[] wymiary = Console.ReadLine().Split(' ');
        string[,] macierz = new string[int.Parse(wymiary[0]), int.Parse(wymiary[1])];
        string[,] macierztrans = new string[int.Parse(wymiary[1]), int.Parse(wymiary[0])];
        for (int i = 0; i < int.Parse(wymiary[0]); i++)
        {
            string[] dane = Console.ReadLine().Split(' ');
            for(int j = 0; j < int.Parse(wymiary[1]); j++)
            {
                macierz[i,j] = dane[j];
            }
        }
        for (int i = 0; i < int.Parse(wymiary[1]); i++)
        {
            for (int j = 0; j < int.Parse(wymiary[0]); j++)
            {
                macierztrans[i,j] = macierz[j, i];
                Console.Write(macierztrans[i,j] + " ");
            }
            Console.WriteLine(); 
        }
            

    }
}
