using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beecrowd_c_.Desafios
{
    public class Salario
    {
        public static void Main(string[] args)
        {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * valorHora;
            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}