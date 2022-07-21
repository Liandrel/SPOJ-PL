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
            int N = int.Parse(Console.ReadLine());
            string[] dane = Console.ReadLine().Split(' ');
            List<int> lista = new List<int>();
            for (int j = 0; j < dane.Length; j++)
            {
                lista.Add(int.Parse(dane[j]));
            }
            lista.Sort();
            int counter = lista.Count() - 1, count = 0;
            bool yup = true;
            while (yup)
            {
                Console.Write(lista[counter] + " ");
                if (counter != 0)
                {
                    if (lista[counter - 1] != lista[counter])
                    {
                        yup = false;
                    }
                }
                else
                {
                    yup = false;
                }

                counter--;
                count++;
            }
            for (int j = 0; j < lista.Count() - count; j++)
            {
                Console.Write(lista[j] + " ");
            }
            Console.WriteLine();
        }

    }
}
