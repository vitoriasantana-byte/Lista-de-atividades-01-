using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite quanto dinheiro você tem em reais (R$): ");
        double reais = double.Parse(Console.ReadLine());

        double dolares = reais / 3.45;

        Console.WriteLine("Você pode comprar: US$ " + dolares.ToString("F2"));
    }
}
