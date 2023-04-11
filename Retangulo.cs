using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(double largura, double altura)
        {
            return Largura * Altura;
        }

        public double Perimetro(double largura, double altura)
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal(double altura, double largura)
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
