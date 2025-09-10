using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o salário atual do funcionário: R$ ");
        double salario = double.Parse(Console.ReadLine());

        double aumento = salario * 0.15;
        double novoSalario = salario + aumento;

        Console.WriteLine("Novo salário com 15% de aumento: R$ " + novoSalario.ToString("F2"));
    }
}
