using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigurasGeometricas;

namespace PJCalculadoraFiguras
{
    public partial class Bidimensional : Form
    {

        Circulo circulo = new Circulo(0,0,0);
        Cuadrado cuadrado = new Cuadrado(0,0,0);
        Triangulo triangulo = new Triangulo(0,0,0);
        string radio = "";
        string lado = "";
        string baseT = "";
        string altura = "";
        double perimetro;
        double area;
        string figura = "";
        string resultado = "";
        public Bidimensional()
        {
            InitializeComponent();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // capturamos el tipo de figura 
            int tipo = cboTipo.SelectedIndex;

            // Asignamos el tipo seleccionado 
            switch (tipo)
            {
                case 0: radio = "Radio";lado = "No ingrese valor ";baseT = "No ingrese valor"; altura = "No ingrese valor"; resultado = "El area y perimetro del circulo es:";
                    figura = "Circulo";
                    break;
                case 1: radio = "No ingrese valor ";lado = "Lado ";baseT = "No ingrese valor"; altura = "No ingrese valor";resultado = "El area y perimetro del cuadrado es";
                    figura = "Cuadrado";
                    break;
                case 2: radio = "No ingrese valor";lado = "No ingrese valor ";baseT = "Base"; altura = "Altura"; resultado = "El area y perimetro del circulo es";
                    figura = "Triangulo";
                    break;
                
            }

            // Mostramos lo info
            txt1.Text = radio.ToString();
            txt2.Text = lado.ToString();
            txt3.Text = baseT.ToString();
            txt4.Text = altura.ToString();
            txtResultado.Text = resultado.ToString();
            txtFigura.Text = figura.ToString();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Tomamos los datos ingresdos 
            circulo.Radio = float.Parse(txtRadio.Text);
            cuadrado.Lado = float.Parse(txtLado.Text);
            triangulo.BaseTriangulo = float.Parse(txtBase.Text);
            triangulo.Altura = float.Parse(txtAltura.Text);


            switch (figura)
            {
                case "Circulo":
                    //Realizando los calculos de las areas y perimetros del circulo 
                    area=circulo.CalcularArea();
                    perimetro=circulo.CalcularPerimetro();

                    txtArea.Text = area.ToString();
                    txtPerimetro.Text=perimetro.ToString(); 
                    break;
                case "Cuadrado":
                    //Realizando los calculos de las areas y perimetros del cuadrado
                    cuadrado.CalcularArea();
                    cuadrado.CalcularPerimetro();

                    txtArea.Text = area.ToString();
                    txtPerimetro.Text = perimetro.ToString();
                    break;
                case "Triangulo":
                    
                    //Realizando los calculos de las areas y perimetros del triangulo
                    triangulo.CalcularArea();
                    triangulo.CalcularPerimetro();

                    txtArea.Text = area.ToString();
                    txtPerimetro.Text = perimetro.ToString();
                    break;

            }

           
           



        }
    }
}
