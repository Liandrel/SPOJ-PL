class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            float f = float.Parse(Console.ReadLine());

            string result = BitConverter.ToString(BitConverter.GetBytes(f));
            string[] resultt = result.Split('-');
            string wynik = "";
            for (int j = resultt.Length - 1; j >= 0; j--)
            {
                if(resultt[j][0] == '0')
                {
                    wynik += resultt[j][1];
                }
                else
                {
                    wynik += resultt[j];
                }
                if(j > 0)
                {
                    wynik += " ";
                }
                
            }
            Console.WriteLine(wynik.ToLower());

        }

    }
}
