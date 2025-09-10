using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a 1ª nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a 2ª nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        Console.WriteLine("Média: " + media);

        if (media >= 6)
        {
            Console.WriteLine("O aluno foi aprovado!");
        }
        else
        {
            Console.WriteLine("O aluno não foi aprovado!");
        }
    }
}

