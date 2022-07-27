using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1941.Porównywanie_dużych_liczb.KC015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string data;
                do
                {
                    data = Console.ReadLine();
                    string[] dataarray = data.Split(' ');
                    string znak = dataarray[1];

                    int nr = 0;
                    switch (znak)
                    {
                        case "==":
                            if (dataarray[0] == dataarray[2])
                            {
                                Console.WriteLine("1");
                            }
                            else
                            {
                                Console.WriteLine("0");
                            }
                            break;
                        case "!=":
                            if(dataarray[0] != dataarray[2])
                            {
                                Console.WriteLine("1");
                            }
                            else
                            {
                                Console.WriteLine("0");
                            }

                            break;
                        case ">=":
                            if (dataarray[0].Length > dataarray[2].Length || (dataarray[0].Length == dataarray[2].Length && double.Parse(dataarray[0]) > double.Parse(dataarray[2])) || dataarray[0] == dataarray[2])
                            {
                                Console.WriteLine("1");
                            }
                            else
                            {
                                Console.WriteLine("0");
                            }
                            break;
                        case "<=":
                            if (dataarray[0].Length < dataarray[2].Length || (dataarray[0].Length == dataarray[2].Length && double.Parse(dataarray[0]) < double.Parse(dataarray[2])) || dataarray[0] == dataarray[2])
                            {
                                Console.WriteLine("1");
                            }
                            else
                            {
                                Console.WriteLine("0");
                            }
                            break;
                    }
                }
                while (data != null);
            }
            catch (Exception ex)
            {
                Environment.Exit(0);
            }
        }
    }
}
