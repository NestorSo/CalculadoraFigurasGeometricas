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
    public partial class Tridimensionales : Form
    {
        public Tridimensionales()
        {
            InitializeComponent();
        }

        Esfera esfera = new Esfera(0, 0);
        Cubo cubo = new Cubo(0, 0);
        Tetaedro tetaedro = new Tetaedro(0, 0);
        string radio = "";
        string lado = "";
        double volumen;
        double area;
        string figura = "";
        string resultado = "";
        public Tridimensionales()
        {
            InitializeComponent();
        }

        private void cboTipo_SelctedIndexChanged(object sender, EventArgs e)
        {

            // capturamos el tipo de figura 
            int tipo = cboTipo.SelectedIndex;

            // Asignamos el tipo seleccionado 
            switch (tipo)
            {
                case 0:
                    radio = "Radio"; lado = "No ingrese valor "; resultado = "El area y Volumen del circulo es:";
                    figura = "Esfera";
                    break;
                case 1:
                    radio = "No ingrese valor "; lado = "Lado "; resultado = "El area y volumen del cubo es";
                    figura = "cubo";
                    break;
                case 2:
                    radio = "No ingrese valor"; lado = "Lado "; resultado = "El area y volumen del tetaedro  es";
                    figura = "tetaedro";
                    break;

            }

            // Mostramos lo info
            txt1.Text = radio.ToString();
            txt2.Text = lado.ToString();
            txtResultado.Text = resultado.ToString();
            txtFigura.Text = figura.ToString();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (figura)
            {
                case "Esfera":


                    esfera.Radio = float.Parse(txtRadio.Text);
                    //Realizando los calculos de las areas y perimetros del circulo 
                    area = esfera.CalcularArea();
                    volumen = esfera.CalcularVolumen();
                    //mandamos a imprimir 
                    txtArea.Text = area.ToString();
                    txtVolumen.Text = volumen.ToString();

                    break;
                case "Cubo":


                    cubo.Lado = float.Parse(txtLado.Text);
                    //Realizando los calculos de las areas y perimetros del cuadrado

                    area = cubo.CalcularArea();
                    volumen = cubo.CalcularVolumen();
                    //mandamos a imrprimir 
                    txtArea.Text = area.ToString();
                    txtVolumen.Text = volumen.ToString();


                    break;
                case "Tetaedro":

                    tetaedro.Lado = float.Parse(txtLado.Text);
                    //Realizando los calculos de las areas y perimetros del triangulo
                    area = tetaedro.CalcularArea();
                    volumen = tetaedro.CalcularVolumen();
                    //mandamos a imprimir
                    txtArea.Text = area.ToString();
                    txtVolumen.Text = volumen.ToString();
                    break;

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txtRadio.Clear();
            txtLado.Clear();
            txtFigura.Clear();
            txtResultado.Clear();
            txtArea.Clear();
            txtVolumen.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.ShowDialog();
        }
    }
}
