using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


class Program
{

	static void Main(string[] args)
	{
		try
		{
			string text;
			do
			{
				text = Console.ReadLine();
				char[] tab = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
				string wynik = "";
				for(int i = 0;i < text.Length; i++)
                {
					if(text[i] == ' ')
                    {
						wynik += text[i];
                    }
					else
                    {
						for(int j = 0;j < tab.Length;j++)
                        {
							if(text[i] == tab[j])
                            {
								
								if((j + 3) > tab.Length - 1)
                                {
									wynik += tab[(j + 3) - tab.Length];
                                }
								else
                                {
									wynik += tab[j + 3];
								}
								continue;
                            }
                        }
                    }
                }
				Console.WriteLine(wynik);

			} while (text != null);
		}
		catch (Exception ex) { Environment.Exit(0); }
	}
}
