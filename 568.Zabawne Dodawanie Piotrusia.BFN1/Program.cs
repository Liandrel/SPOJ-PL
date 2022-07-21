class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int liczba = int.Parse(Console.ReadLine());
            int reverse = Int32.Parse(Reverse(liczba.ToString()));
            int j = 0;
            while(liczba != reverse)
            {
                liczba += reverse;
                reverse = Int32.Parse(Reverse(liczba.ToString()));
                j++;
            }
            Console.WriteLine(liczba + " " + j);
        }

    }
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

}