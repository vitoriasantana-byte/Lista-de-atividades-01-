using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 10)
        {
            Console.WriteLine("É MAIOR QUE 10!");
        }
        else
        {
            Console.WriteLine("NÃO É MAIOR QUE 10!");
        }
    }
}
