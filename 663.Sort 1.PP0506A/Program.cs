class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            List<Punkt> list = new List<Punkt>();

            for (int j = 0; j < m; j++)
            {
                string[] dane = Console.ReadLine().Split(' ');
                list.Add(new Punkt(dane[0], int.Parse(dane[1]), int.Parse(dane[2])));
            }
            list.Sort();
            foreach (Punkt punkt in list)
            {
                Console.WriteLine($"{punkt.Nazwa} {punkt.X} {punkt.Y}");
            }
            Console.ReadLine();
        }

    }
    public class Punkt : IComparable<Punkt>
    {
        public string Nazwa { get; }
        public int X { get; }
        public int Y { get; }
        public double Odl { get; set; }
        public Punkt(string nazwa, int x, int y)
        {
            this.Nazwa = nazwa;
            this.X = x;
            this.Y = y;
            this.Odl = Math.Sqrt(X * X + Y * Y);
        }

        public int CompareTo(Punkt other)
        {
            return Odl.CompareTo(other.Odl);
        }
    }
}
