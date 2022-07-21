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
            string[] wymiary = Console.ReadLine().Split(' ');
            string[,] macierz = new string[int.Parse(wymiary[0]), int.Parse(wymiary[1])];
            string[,] macierzp = new string[int.Parse(wymiary[0]), int.Parse(wymiary[1])];
            for (int j = 0; j < int.Parse(wymiary[0]); j++)
            {
                string[] dane = Console.ReadLine().Split(' ');
                for (int k = 0; k < int.Parse(wymiary[1]); k++)
                {
                    macierz[j, k] = dane[k];
                    macierzp[j, k] = dane[k];
                }
            }
            for (int j = 0; j < int.Parse(wymiary[0]); j++)
            {
                for (int k = 0; k < int.Parse(wymiary[1]); k++)
                {
                    if (j == 0)
                    {
                        if(k == 0)
                        {
                            macierzp[j + 1, k] = macierz[j, k];
                        }   
                        else
                        {
                            macierzp[j,k - 1] = macierz[j, k];
                        }
                    }
                    else if (j == int.Parse(wymiary[0]) - 1)
                    {
                        if(k == int.Parse(wymiary[1]) - 1)
                        {
                            macierzp[j - 1, k] = macierz[j, k];
                        }
                        else
                        {
                            macierzp[j,k + 1] = macierz[j, k];
                        }
                    }
                    else if (k == 0)
                    {
                        if(j != 0 && j != int.Parse(wymiary[0]) - 1)
                        {
                            macierzp[j + 1,k] = macierz[j, k];
                        }
                    }
                    else if(k == int.Parse(wymiary[1]) - 1)
                    {
                        if (j != 0 && j != int.Parse(wymiary[0]) - 1)
                        {
                            macierzp[j - 1, k] = macierz[j, k];
                        }
                    }

                }
            }
            for (int j = 0; j < int.Parse(wymiary[0]); j++)
            {
                for (int k = 0; k < int.Parse(wymiary[1]); k++)
                    Console.Write(macierzp[j, k] + " ");
                Console.WriteLine();
            }
                
        }

    }
}
