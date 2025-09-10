using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Digite os dias: ");
        int dias = int.Parse(Console.ReadLine());

        int totalDias = (anos * 365) + (meses * 30) + dias;

        Console.WriteLine("A idade em dias é: " + totalDias);
    }
}
