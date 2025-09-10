using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número total de eleitores: ");
        int total = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos brancos: ");
        int brancos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos nulos: ");
        int nulos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos válidos: ");
        int validos = int.Parse(Console.ReadLine());

        double percBrancos = (brancos * 100.0) / total;
        double percNulos = (nulos * 100.0) / total;
        double percValidos = (validos * 100.0) / total;

        Console.WriteLine("Percentual de votos brancos: " + percBrancos + "%");
        Console.WriteLine("Percentual de votos nulos: " + percNulos + "%");
        Console.WriteLine("Percentual de votos válidos: " + percValidos + "%");
    }
}
