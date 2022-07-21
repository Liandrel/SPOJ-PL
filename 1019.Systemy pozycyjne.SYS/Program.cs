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
            int liczba = int.Parse(Console.ReadLine());
            Console.Write(zamien(liczba, 16));
            Console.Write(" ");
            Console.Write(zamien(liczba, 11));
            Console.WriteLine();

        }

    }

    private static string zamien(int liczba, int v)
    {
        int reszta = 0, i = 0;
        Stack<string> sztos = new Stack<string>();
        char[] znaki = "0123456789ABCDEF".ToCharArray();
        while (liczba != 0)
        {
            reszta = liczba % v;
            liczba = liczba / v;
            sztos.Push(znaki[reszta].ToString()); 
            i++;
        }
        string wynik = "";
        for (int j = 0; j < i; j++)
        {
            wynik += sztos.Pop();
        }
        return wynik;
    }
}
