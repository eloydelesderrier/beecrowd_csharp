using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beecrowd_c_.Desafios
{
    public class bee_1014
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double consumo = x / y;

            Console.WriteLine($"{consumo:F3} km/l");


        }
    }
}