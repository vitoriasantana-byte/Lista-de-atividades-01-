using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de maçãs compradas: ");
        int qtd = int.Parse(Console.ReadLine());

        double preco;

        if (qtd < 12)
        {
            preco = qtd * 1.30;
        }
        else
        {
            preco = qtd * 1.00;
        }

        Console.WriteLine("O valor total da compra é: R$ " + preco);
    }
}
