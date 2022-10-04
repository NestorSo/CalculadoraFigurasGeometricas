using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Tetaedro : Tridimensional
    {
        public Tetaedro(float lado, float radio) : base(lado, radio)
        {
        }

        public override double CalcularArea()
        {
            double area = (Math.Pow(Lado, 2) * (Math.Sqrt(3)));
            return area;

        }

        public override double CalcularVolumen()
        {
            double volumen = (Math.Pow(Lado, 3) * (Math.Sqrt(2) / 12));
            return volumen; 
        }
    }
}
