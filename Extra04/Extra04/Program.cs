using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o preço do produto: R$ ");
        double preco = double.Parse(Console.ReadLine());

        double desconto = preco * 0.05;
        double precoFinal = preco - desconto;

        Console.WriteLine("Preço com 5% de desconto: R$ " + precoFinal.ToString("F2"));
    }
}
