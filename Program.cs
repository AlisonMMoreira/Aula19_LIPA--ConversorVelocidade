using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19_ConversorVelocidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usuario vai informar uma velocidade em km/h
            //E a aplicaçao vai converte-la para Knots
            //MP/H --> km/h / 1,609 || Knots --> km/h / 1,852

            //double[] velocidades = new double[3];

            double[] velocidades = new double[3];

            Console.Write("Olá, digite a velocidade em km/h: ");
            double km = double.Parse(Console.ReadLine());
           
            double knots = km / 1.852;
            velocidades[0] = km;

            double mp = km / 1.609;
            velocidades[1] = knots;
            velocidades[2] = mp;

            Console.WriteLine("A velocidade em km/h é: " + +velocidades[0]);
            Console.WriteLine("A velocidade em knots é: " + +velocidades[1]);
            Console.WriteLine("A velocidade em MP/h é: " + +velocidades[2]);

            Console.ReadKey();

        }
    }
}
