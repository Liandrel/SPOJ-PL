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
        int n, k;
        n = int.Parse(dane[0]);
        k = int.Parse(dane[1]);
        Queue<string> kolejka = new Queue<string>();
        dane = Console.ReadLine().Split(' ');
        foreach (string i in dane)
            kolejka.Enqueue(i);
        for(int i = 0; i < k; i++)
        {
            kolejka.Enqueue(kolejka.Dequeue());
        }
        for(int i = 0; i < n; i++)
        {
            Console.Write(kolejka.Dequeue() + " ");
        }
        Console.WriteLine();
    }
}
