using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDotnet.Common.Models
{
    /// <summary>
    /// Simple Methods For Calculations
    /// </summary>
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} . {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Modulo(int x, int y)
        {
            Console.WriteLine($"Resto de Divisao entre: {x} e {y} sera: {x % y}");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}.");
        }

        public void Seno(double angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            Console.WriteLine($"O Seno de {angulo}° e: {Math.Round(Math.Sin(radiano), 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            Console.WriteLine($"O Coseno de {angulo}° e: {Math.Round(Math.Cos(radiano), 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            Console.WriteLine($"O Tangente de {angulo}° e: {Math.Round(Math.Tan(radiano), 4)}");
        }

        public void RaizQuadrada(double x)
        {
            Console.WriteLine($"A Raiz de √{x} e: {Math.Sqrt(x)}");
        }
    }
}