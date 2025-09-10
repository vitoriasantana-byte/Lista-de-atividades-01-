using System;
//atv1
class Program
{
    static void Main()
    {
        int A = 10;
        int B = 20;

        Console.WriteLine("Antes da troca: A = " + A + ", B = " + B);

        // Troca usando variável auxiliar
        int aux = A;
        A = B;
        B = aux;

        Console.WriteLine("Depois da troca: A = " + A + ", B = " + B);
    }
}
