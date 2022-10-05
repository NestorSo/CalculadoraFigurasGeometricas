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
        public Triangulo(float lado, float radio, float altura) : base(lado, radio, altura)
        {
           this.baseTriangulo = baseTriangulo;
            this.Altura = altura;
        }
        public float BaseTriangulo
        {
            get { return baseTriangulo; }
            set { baseTriangulo = (value>=0)?value:0; }
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
            perimetro = 3 * Lado;
            return perimetro;
        }
    }
}
