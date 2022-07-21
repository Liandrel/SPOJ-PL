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
        string[] teksty = new string[n];
        int count1 = 0;
        for (int i = 0; i < n; i++)
        {
            string tekst = Console.ReadLine();
            teksty[i] = tekst.Replace(" ", "");
            count1 += teksty[i].Length;
        }
        char[] male = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] duze = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int[] malel = new int[30];
        int[] duzel = new int[30];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < teksty[i].Length; j++)
            {
                char temp  = teksty[i][j];
                for (int k = 0; k < male.Length; k++)
                {
                    if (temp == male[k])
                    {
                        malel[k]++;
                    }
                    if(temp == duze[k])
                    {
                        duzel[k]++;
                    }
                }
            }
        }
        for(int i = 0; i < malel.Length; i++)
        {
            if(malel[i] > 0)
                Console.WriteLine(male[i] + " " + malel[i]);
        }
        for (int i = 0; i < duzel.Length; i++)
        {
            if (duzel[i] > 0)
                Console.WriteLine(duze[i] + " " + duzel[i]);
        }
    }
}
