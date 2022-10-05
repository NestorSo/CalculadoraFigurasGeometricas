namespace PJCalculadoraFiguras
{
    partial class Principal
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
            this.btnTridimensional = new System.Windows.Forms.Button();
            this.btnBidimensional = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTridimensional
            // 
            this.btnTridimensional.Location = new System.Drawing.Point(133, 113);
            this.btnTridimensional.Name = "btnTridimensional";
            this.btnTridimensional.Size = new System.Drawing.Size(115, 23);
            this.btnTridimensional.TabIndex = 0;
            this.btnTridimensional.Text = "Tridimensional ";
            this.btnTridimensional.UseVisualStyleBackColor = true;
            this.btnTridimensional.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBidimensional
            // 
            this.btnBidimensional.Location = new System.Drawing.Point(388, 114);
            this.btnBidimensional.Name = "btnBidimensional";
            this.btnBidimensional.Size = new System.Drawing.Size(124, 20);
            this.btnBidimensional.TabIndex = 1;
            this.btnBidimensional.Text = "Bidimensional ";
            this.btnBidimensional.UseVisualStyleBackColor = true;
            this.btnBidimensional.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a la super calculadora de figuras geometricas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PJCalculadoraFiguras.Properties.Resources.maxresdefault__1_;
            this.pictureBox1.Location = new System.Drawing.Point(105, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::PJCalculadoraFiguras.Properties.Resources.QvMnfrYhdP87KK7LoDL1JDtyfXDu6E5VwjHuGELi;
            this.pictureBox2.Location = new System.Drawing.Point(388, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pulse un boton para la opcion que desea realizar ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBidimensional);
            this.Controls.Add(this.btnTridimensional);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTridimensional;
        private Button btnBidimensional;
        private Label label1;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}