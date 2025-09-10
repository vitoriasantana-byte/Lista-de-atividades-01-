using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a largura da parede (em metros): ");
        double largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura da parede (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        double area = largura * altura;
        double tinta = area / 2.0; // cada litro pinta 2 m²

        Console.WriteLine("Área da parede: " + area + " m²");
        Console.WriteLine("Quantidade de tinta necessária: " + tinta + " litros");
    }
}
