class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Please provide an odd number.");
            return;
        }

        for (int i = 0; i < (n + 1) / 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= (n / 2) - i && j <= (n / 2) + i)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        for (int i = (n - 1) / 2 - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= (n / 2) - i && j <= (n / 2) + i)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
