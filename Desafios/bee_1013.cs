using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beecrowd_c_.Desafios
{
    public class bee_1013
    {
        static void Main(string[] args)
        {
            int[] valores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = valores[0];
            int b = valores[1];
            int c = valores[2];
            
            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
            
            Console.WriteLine($"{maior} eh o maior");
        }
    }
}