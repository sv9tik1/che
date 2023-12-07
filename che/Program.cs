class Program
    {
        static void Main(string[] args)
        {
    var a = new int[10, 10];
    for (int x = 0; x < a.GetLength(0); x++)
    {
        int i = 0;
        for (int y = 0; y < a.GetLength(0); y++)
        {
            if (y >= x)
                a[x, y] = i++;
        }
    }
    Console.Write('\n');
    for (int x = 0; x < a.GetLength(0); x++)
    {
        for (int y = 0; y < a.GetLength(0); y++)
        {
            Console.Write(a[x, y]);
        }
        Console.Write('\n');
    }
}
    }