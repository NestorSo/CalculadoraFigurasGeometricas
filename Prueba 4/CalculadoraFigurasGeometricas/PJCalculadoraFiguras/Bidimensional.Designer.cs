namespace PJCalculadoraFiguras
{
    partial class Bidimensional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtFigura = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Circulo",
            "Cuadrado",
            "Triangulo"});
            this.cboTipo.Location = new System.Drawing.Point(31, 100);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(132, 23);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.Text = "(Seleccione la figura)";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(31, 186);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a la calculadora de figuras geometricas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txtLado);
            this.groupBox1.Controls.Add(this.txtRadio);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Location = new System.Drawing.Point(238, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos ";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(461, 66);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.EnabledChanged += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Location = new System.Drawing.Point(461, 37);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 23);
            this.txt4.TabIndex = 6;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(326, 66);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 23);
            this.txtBase.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(326, 37);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 23);
            this.txt3.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(188, 37);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 23);
            this.txt2.TabIndex = 3;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(188, 66);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 23);
            this.txtLado.TabIndex = 2;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(36, 66);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 23);
            this.txtRadio.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(36, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 23);
            this.txt1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPerimetro);
            this.groupBox2.Controls.Add(this.txtArea);
            this.groupBox2.Controls.Add(this.txtResultado);
            this.groupBox2.Location = new System.Drawing.Point(238, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area y perimetro calculados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perimetro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Area";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(163, 77);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 23);
            this.txtPerimetro.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(36, 77);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 23);
            this.txtArea.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(36, 33);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 23);
            this.txtResultado.TabIndex = 0;
            // 
            // txtFigura
            // 
            this.txtFigura.Enabled = false;
            this.txtFigura.Location = new System.Drawing.Point(238, 227);
            this.txtFigura.Name = "txtFigura";
            this.txtFigura.Size = new System.Drawing.Size(100, 23);
            this.txtFigura.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(31, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(31, 288);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Bidimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtFigura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboTipo);
            this.Name = "Bidimensional";
            this.Text = "Bidimensional";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboTipo;
        private Button btnCalcular;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtBase;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txtLado;
        private TextBox txtRadio;
        private TextBox txt1;
        private GroupBox groupBox2;
        private TextBox txtPerimetro;
        private TextBox txtArea;
        private TextBox txtResultado;
        private TextBox txtAltura;
        private TextBox txt4;
        private TextBox txtFigura;
        private Label label3;
        private Label label2;
        private Button btnLimpiar;
        private Button btnAtras;
    }
}