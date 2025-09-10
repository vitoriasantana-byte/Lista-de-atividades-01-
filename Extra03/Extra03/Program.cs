// Susing System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        double c = double.Parse(Console.ReadLine());

        double delta = (b * b) - (4 * a * c);

        Console.WriteLine("O valor de Delta é: " + delta);
    }
}
