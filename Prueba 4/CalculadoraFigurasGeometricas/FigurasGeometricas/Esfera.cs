using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Esfera : Tridimensional
    {
        private const double PI = 3.1415926535897931;

        public Esfera(float lado, float radio) : base(lado, radio)
        {
        }

        public override double CalcularArea()
        {
            double area = (4 * PI * Math.Pow(Radio,2));
            return area;
        }

        public override double CalcularVolumen()
        {
            double Volumen = ((4 * PI * Math.Pow(Radio, 2))/3);
            return Volumen;
        }
    }
}
