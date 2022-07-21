class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string data = Console.ReadLine();
            data = data.Substring(2);
            object[] datat = data.Split(' ');
            for( int j = datat.Length - 1; j >= 0; j--)
            {
                Console.Write(datat[j] + " ");
            }
            Console.WriteLine();
        }

    }
}


