class Program
{
    static void Main()
    {
        int ile = int.Parse(Console.ReadLine());
        for (int i = 0; i < ile; i++)
        {
            string tekst = Console.ReadLine();
            string linia = "";
            int il = 1;
            int j = 0;
            while (j < tekst.Length)
            {
                il = 1;
                char znak = tekst[j];
                j++;
                for (; j < tekst.Length && tekst[j] == znak; j++)
                {
                    il++;
                }
                if(il == 1)
                {
                    linia += znak.ToString();
                }
                else if (il == 2)
                {
                    linia += znak.ToString();
                    linia += znak.ToString();
                }
                else
                {
                    linia += znak.ToString() + il.ToString();

                }
            }
            Console.WriteLine(linia);
        }
    }
}
