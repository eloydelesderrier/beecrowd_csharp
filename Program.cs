using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
            
        Console.WriteLine($"{maior} eh o maior ");
    }
}