using System;

class Program
{
    static void Main()
    {
        int num, resultado, valor;

        Console.WriteLine("Digite um número para a multiplicação:");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Até que valor irá a multiplicação?");
        valor = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador <= valor)
        {
            resultado = contador * num;
            Console.WriteLine($"{num} x {contador} = {resultado}");
            contador++;
        }
    }
}