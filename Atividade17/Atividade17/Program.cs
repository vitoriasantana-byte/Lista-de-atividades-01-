using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Fatorial de número negativo não existe!");
        }
        else
        {
            long fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine($"{n}! = {fatorial}");
        }
    }
}
