int m = 11, n = 11;
int[,] mas = new int[n, m];

for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
    {
        mas[i, j] = i*j;
    }

for (int i = 1; i < n; i++)
{
    for (int j = 1; j < m; j++)
        Console.Write(String.Format("{0,3}", mas[i, j]));
    Console.WriteLine();
}