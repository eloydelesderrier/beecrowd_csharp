using System;

class Program
{
    static void Main()
    {
        int numeroFuncionario = int.Parse(Console.ReadLine());
        double horasTrabalhadas = double.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine());

        double salario = horasTrabalhadas * valorHora;
        Console.WriteLine("NUMBER = " + numeroFuncionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
    }
}