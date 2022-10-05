using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Cubo : Tridimensional
    {
        public Cubo(float lado, float radio) : base(lado, radio)
        {
        }

        public override double CalcularArea()
        {
            double area = (6 * Math.Pow(Lado, 2));
            return area;
        }

        public override double CalcularVolumen()
        {
            double volumen = (Math.Pow(Lado, 3));
            return volumen;

        }
    }
}
