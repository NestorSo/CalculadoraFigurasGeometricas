namespace FigurasGeometricas
{
    public abstract class Figura
    {
        private float lado { get; set; }
        private float radio { get; set; }
        public Figura(float lado, float radio)
        {
            this.lado = lado;
            this.radio = radio;
        }
        public float Radio { get { return radio; } set { radio = value; } }
        public float Lado { get { return lado; } set { radio = value; } }

        public abstract double CalcularArea();
    }
   
}