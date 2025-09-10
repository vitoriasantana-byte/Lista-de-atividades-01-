using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o ano atual: ");
        int anoAtual = int.Parse(Console.ReadLine());

        Console.Write("Digite o ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int idade = anoAtual - anoNascimento;

        if (idade < 16)
        {
            Console.WriteLine("Não vota.");
        }
        else if ((idade >= 18 && idade <= 70))
        {
            Console.WriteLine("O voto é obrigatório.");
        }
        else
        {
            Console.WriteLine("O voto é facultativo.");
        }
    }
}
