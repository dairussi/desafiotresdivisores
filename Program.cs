using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número inteiro, e teste se ele possui extamente 3 divisores positivos:");
        int count = 0, n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++) { if (n % i == 0) { count++; } }
        Console.WriteLine(count == 3);
    }
}
