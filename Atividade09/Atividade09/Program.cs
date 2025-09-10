using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número (diferente de zero): ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("Valor zero não é permitido!");
        }
    }
}
