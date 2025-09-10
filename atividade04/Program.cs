using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a base do retângulo: ");
        double baseRet = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine());

        double area = baseRet * altura;

        Console.WriteLine("A área do retângulo é: " + area);
    }
}
