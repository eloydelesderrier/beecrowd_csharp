using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beecrowd_c_.Desafios
{
    public class SalarioComBonus
    {
        public static void Main(string[] args)
        {
            string nomeFuncionario = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());
 
            double salarioBonus = salarioFixo + (totalVendas * 0.15);
            Console.WriteLine("TOTAL = R$ " + salarioBonus.ToString("F2"));
        }
        
    }
}