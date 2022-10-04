using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Triangulo : Bidimensional
    {
        private float baseTriangulo { get; set; }
        public Triangulo(float lado, float radio, float altrura) : base(lado, radio, altrura)
        {
           this.baseTriangulo = baseTriangulo;
        }
        public float BaseTriangulo
        {
            get { return baseTriangulo; }
            set { baseTriangulo = value; }
        }

        public override double CalcularArea()
        {
            double area = 0;
            area = (baseTriangulo * Altura) / 2;
            return area;
            
        }

        public override double CalcularPerimetro()
        {
            double perimetro  = 0;
            perimetro = (baseTriangulo + Math.Pow(Lado, 2));
            return perimetro;
        }
    }
}
