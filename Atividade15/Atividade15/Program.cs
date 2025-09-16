using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor N (maior que zero): ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}
