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
            Queue<String> kolejka = new Queue<string>(Console.ReadLine().Split(' '));
            kolejka.Dequeue();
            var temp = kolejka.Dequeue();
            kolejka.Enqueue(temp);
            foreach (var x in kolejka)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
