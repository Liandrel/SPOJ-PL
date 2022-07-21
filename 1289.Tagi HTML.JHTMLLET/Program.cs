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
        try
        {
            string text = "";

            do
            {
                bool temp = false;
                string linia = "";
                text = Console.ReadLine();

                for(int i = 0; i < text.Length; i++)
                {
                    
                    if (temp)
                    {
                        if (text[i] == '>')
                        {
                            temp = false;
                        }
                        else
                        {
                            linia+= text[i].ToString().ToUpper();
                        }
                    }
                    if (text[i] == '<')
                    {
                        temp = true;
                        linia += text[i];
                    }
                    else if(!temp)
                    {
                        linia += text[i];
                    }
                }
                Console.WriteLine(linia);
            }
            while (text != null);
        }
        catch (Exception ex) { Environment.Exit(0); }

    }
}
