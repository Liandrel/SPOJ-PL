using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

class Program
{
    enum Skret
    {
        lewo, prawo
    }

    static void Main()
    {

        int r;
        Skret skret;
        while ((r = int.Parse(Console.ReadLine())) != 0)
        {

            skret = r > 0 ? Skret.lewo : Skret.prawo;
            r = Math.Abs(r);
            char[,] tab = new char[r * 2, r * 2];
            wypelnij(tab);
            Obrot(tab, skret);
            Wyswietl(tab);
        }
    }

    private static void wypelnij(char[,] tab)
    {
        for(int i = 0; i <tab.GetLength(0); i++)
        {
            for(int j = 0; j <tab.GetLength(1); j++)
            {
                tab[i, j] = '*';
            }
        }
    }

    private static void Obrot(char[,] tab, Skret skret)
    {
        for(int i = 0; i < (tab.GetLength(0) / 2) - 1; i++)
        {
            for(int j = i; j < tab.GetLength(0) - i - 1; j++)
            {
                if(skret == Skret.lewo)
                {
                    if(j >= (tab.GetLength(0) / 2))
                    {
                        tab[j,i] = '.';
                        tab[tab.GetLength(0) - i - 1,j] = '.';
                    }
                    if(j < (tab.GetLength(0) / 2) && j > i)
                    {
                        tab[j, tab.GetLength(0) - i - 1] = '.';
                        tab[i,j] = '.';
                    }
                }
                if(skret == Skret.prawo)
                {
                    if( j < (tab.GetLength(0) / 2) && j > i)
                    {
                        tab[j,i] = '.';
                        tab[tab.GetLength (0) - i - 1, j] = '.';
                    }
                    if ( j >= (tab.GetLength(0) / 2))
                    {
                        tab[j,tab.GetLength(0) - i - 1] = '.';
                        tab[i, j] = '.';
                    }
                }
            }
        }
    }

    private static void Wyswietl(char[,] tab)
    {
        StringBuilder sb = new StringBuilder();
        sb.Clear();
        for(int i = 0; i < tab.GetLength(0); i++)
        {
            for ( int j = 0; j < tab.GetLength(1); j++)
            {
                sb.Append(tab[i, j]);
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}
