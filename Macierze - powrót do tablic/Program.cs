class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int[,] macierz = new int[n, n];
        int[,] macierza = new int[n, n];
        int[,] macierzsum = new int[n,n];
        Console.WriteLine("     Macierz A: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierz[i, j] = 1;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierz[i, j], 2}");
            }
            Console.WriteLine();
        }


        Console.WriteLine("     Macierz B: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierza[i, j] = 2;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierza[i, j],2}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("     Suma macierzy: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                macierzsum[i,j] = macierz[i, j] + macierza[i, j];

            }
        }
        for ( int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write($"{macierzsum[i,j],2}");
            }
            Console.WriteLine();
        }


    }
}