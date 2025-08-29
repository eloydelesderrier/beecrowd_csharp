using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace beecrowd_c_.Desafios
{
    public class Esfera
    {
        public static void Main(string[] args)
        { 
            double pi = 3.14159;
            double Raio = double.Parse(Console.ReadLine());
            double volume = (4 / 3.0) * pi * Math.Pow(Raio, 3);
            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        }
    }
}