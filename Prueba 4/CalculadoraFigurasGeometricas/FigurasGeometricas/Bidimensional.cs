using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public abstract class Bidimensional : Figura
    {
        private float altura { get; set; }
        public Bidimensional(float lado, float radio, float altura) : base(lado, radio)
        {
            this.altura = altura;

        }
        public float Altura { get { return altura; } set { altura = (value >= 0) ? value : 0; } }
        public abstract double CalcularPerimetro();

    }
}
