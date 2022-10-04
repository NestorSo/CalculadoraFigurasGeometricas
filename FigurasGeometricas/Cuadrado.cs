using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Cuadrado : Bidimensional
    {
        public Cuadrado(float lado, float radio, float altrura) : base(lado, radio, altrura)
        {
        }

        public override double CalcularArea()
        {
            double area = 0;
            area = Math.Pow(Lado, 2);
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 0;
            perimetro = (4 * Lado);
            return perimetro; 

        }
    }
}
