using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public abstract class Tridimensional : Figura
    {
        public Tridimensional(float lado, float radio) : base(lado, radio)
        {
        }
        public abstract double CalcularVolumen();

    }
}
