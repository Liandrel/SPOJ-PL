class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string data = Console.ReadLine();
            string[] datat = data.Split(' ');
            string wiekszy;
            string mniejszy;
            if(datat[0].Length > datat[1].Length)
            {
                wiekszy = datat[0];
                mniejszy = datat[1];
            }
            else
            {
                mniejszy = datat[0];
                wiekszy = datat[1];
            }
            int j = 0;
            string merge = "";
            while(j < mniejszy.Length)
            {
                merge += datat[0][j];
                merge += datat[1][j];
                j++;
            }
            Console.WriteLine(merge);
        }

    }
}