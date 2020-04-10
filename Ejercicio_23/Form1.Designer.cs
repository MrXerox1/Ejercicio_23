namespace Ejercicio_23
{
    partial class Conversor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            this.TextCotizacion = new System.Windows.Forms.Label();
            this.EuroTextoUno = new System.Windows.Forms.Label();
            this.DolarTextoUno = new System.Windows.Forms.Label();
            this.PesoTextoUno = new System.Windows.Forms.Label();
            this.EntradaEuro = new System.Windows.Forms.TextBox();
            this.EntradaDolar = new System.Windows.Forms.TextBox();
            this.EntradaPeso = new System.Windows.Forms.TextBox();
            this.CotizacionPeso = new System.Windows.Forms.TextBox();
            this.CotizacionEuro = new System.Windows.Forms.TextBox();
            this.CotizacionDolar = new System.Windows.Forms.TextBox();
            this.Euro_Euro = new System.Windows.Forms.TextBox();
            this.Dolar_Euro = new System.Windows.Forms.TextBox();
            this.Peso_Euro = new System.Windows.Forms.TextBox();
            this.Dolar_Dolar = new System.Windows.Forms.TextBox();
            this.Euro_Dolar = new System.Windows.Forms.TextBox();
            this.Peso_Dolar = new System.Windows.Forms.TextBox();
            this.Euro_Peso = new System.Windows.Forms.TextBox();
            this.Dolar_Peso = new System.Windows.Forms.TextBox();
            this.Peso_Peso = new System.Windows.Forms.TextBox();
            this.BotonBloqueado = new System.Windows.Forms.Button();
            this.EuroTextoDos = new System.Windows.Forms.Label();
            this.DolarTextoDos = new System.Windows.Forms.Label();
            this.PesoTextoDos = new System.Windows.Forms.Label();
            this.BotonEuro = new System.Windows.Forms.Button();
            this.BotonDolar = new System.Windows.Forms.Button();
            this.BotonPeso = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // TextCotizacion
            // 
            this.TextCotizacion.AutoSize = true;
            this.TextCotizacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCotizacion.Location = new System.Drawing.Point(41, 27);
            this.TextCotizacion.Name = "TextCotizacion";
            this.TextCotizacion.Size = new System.Drawing.Size(82, 18);
            this.TextCotizacion.TabIndex = 0;
            this.TextCotizacion.Text = "Cotizacion";
            // 
            // EuroTextoUno
            // 
            this.EuroTextoUno.AutoSize = true;
            this.EuroTextoUno.Location = new System.Drawing.Point(21, 82);
            this.EuroTextoUno.Name = "EuroTextoUno";
            this.EuroTextoUno.Size = new System.Drawing.Size(29, 13);
            this.EuroTextoUno.TabIndex = 1;
            this.EuroTextoUno.Text = "Euro";
            // 
            // DolarTextoUno
            // 
            this.DolarTextoUno.AutoSize = true;
            this.DolarTextoUno.Location = new System.Drawing.Point(21, 123);
            this.DolarTextoUno.Name = "DolarTextoUno";
            this.DolarTextoUno.Size = new System.Drawing.Size(32, 13);
            this.DolarTextoUno.TabIndex = 2;
            this.DolarTextoUno.Text = "Dolar";
            // 
            // PesoTextoUno
            // 
            this.PesoTextoUno.AutoSize = true;
            this.PesoTextoUno.Location = new System.Drawing.Point(21, 163);
            this.PesoTextoUno.Name = "PesoTextoUno";
            this.PesoTextoUno.Size = new System.Drawing.Size(31, 13);
            this.PesoTextoUno.TabIndex = 3;
            this.PesoTextoUno.Text = "Peso";
            // 
            // EntradaEuro
            // 
            this.EntradaEuro.Location = new System.Drawing.Point(62, 82);
            this.EntradaEuro.Name = "EntradaEuro";
            this.EntradaEuro.Size = new System.Drawing.Size(100, 20);
            this.EntradaEuro.TabIndex = 4;
            // 
            // EntradaDolar
            // 
            this.EntradaDolar.Location = new System.Drawing.Point(62, 123);
            this.EntradaDolar.Name = "EntradaDolar";
            this.EntradaDolar.Size = new System.Drawing.Size(100, 20);
            this.EntradaDolar.TabIndex = 5;
            // 
            // EntradaPeso
            // 
            this.EntradaPeso.Location = new System.Drawing.Point(62, 163);
            this.EntradaPeso.Name = "EntradaPeso";
            this.EntradaPeso.Size = new System.Drawing.Size(100, 20);
            this.EntradaPeso.TabIndex = 6;
            // 
            // CotizacionPeso
            // 
            this.CotizacionPeso.Location = new System.Drawing.Point(499, 25);
            this.CotizacionPeso.Name = "CotizacionPeso";
            this.CotizacionPeso.Size = new System.Drawing.Size(100, 20);
            this.CotizacionPeso.TabIndex = 7;
            this.CotizacionPeso.Leave += new System.EventHandler(this.CotizacionPeso_Leave);
            // 
            // CotizacionEuro
            // 
            this.CotizacionEuro.Location = new System.Drawing.Point(247, 25);
            this.CotizacionEuro.Name = "CotizacionEuro";
            this.CotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.CotizacionEuro.TabIndex = 8;
            this.CotizacionEuro.Leave += new System.EventHandler(this.CotizacionEuro_Leave);
            // 
            // CotizacionDolar
            // 
            this.CotizacionDolar.Location = new System.Drawing.Point(372, 24);
            this.CotizacionDolar.Name = "CotizacionDolar";
            this.CotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.CotizacionDolar.TabIndex = 9;
            this.CotizacionDolar.Leave += new System.EventHandler(this.CotizacionDolar_Leave);
            // 
            // Euro_Euro
            // 
            this.Euro_Euro.Enabled = false;
            this.Euro_Euro.Location = new System.Drawing.Point(247, 79);
            this.Euro_Euro.Name = "Euro_Euro";
            this.Euro_Euro.Size = new System.Drawing.Size(100, 20);
            this.Euro_Euro.TabIndex = 10;
            // 
            // Dolar_Euro
            // 
            this.Dolar_Euro.Enabled = false;
            this.Dolar_Euro.Location = new System.Drawing.Point(247, 120);
            this.Dolar_Euro.Name = "Dolar_Euro";
            this.Dolar_Euro.Size = new System.Drawing.Size(100, 20);
            this.Dolar_Euro.TabIndex = 11;
            // 
            // Peso_Euro
            // 
            this.Peso_Euro.Enabled = false;
            this.Peso_Euro.Location = new System.Drawing.Point(247, 163);
            this.Peso_Euro.Name = "Peso_Euro";
            this.Peso_Euro.Size = new System.Drawing.Size(100, 20);
            this.Peso_Euro.TabIndex = 12;
            // 
            // Dolar_Dolar
            // 
            this.Dolar_Dolar.Enabled = false;
            this.Dolar_Dolar.Location = new System.Drawing.Point(372, 123);
            this.Dolar_Dolar.Name = "Dolar_Dolar";
            this.Dolar_Dolar.Size = new System.Drawing.Size(100, 20);
            this.Dolar_Dolar.TabIndex = 13;
            // 
            // Euro_Dolar
            // 
            this.Euro_Dolar.Enabled = false;
            this.Euro_Dolar.Location = new System.Drawing.Point(372, 79);
            this.Euro_Dolar.Name = "Euro_Dolar";
            this.Euro_Dolar.Size = new System.Drawing.Size(100, 20);
            this.Euro_Dolar.TabIndex = 14;
            // 
            // Peso_Dolar
            // 
            this.Peso_Dolar.Enabled = false;
            this.Peso_Dolar.Location = new System.Drawing.Point(372, 163);
            this.Peso_Dolar.Name = "Peso_Dolar";
            this.Peso_Dolar.Size = new System.Drawing.Size(100, 20);
            this.Peso_Dolar.TabIndex = 15;
            // 
            // Euro_Peso
            // 
            this.Euro_Peso.Enabled = false;
            this.Euro_Peso.Location = new System.Drawing.Point(499, 79);
            this.Euro_Peso.Name = "Euro_Peso";
            this.Euro_Peso.Size = new System.Drawing.Size(100, 20);
            this.Euro_Peso.TabIndex = 16;
            // 
            // Dolar_Peso
            // 
            this.Dolar_Peso.Enabled = false;
            this.Dolar_Peso.Location = new System.Drawing.Point(499, 123);
            this.Dolar_Peso.Name = "Dolar_Peso";
            this.Dolar_Peso.Size = new System.Drawing.Size(100, 20);
            this.Dolar_Peso.TabIndex = 17;
            // 
            // Peso_Peso
            // 
            this.Peso_Peso.Enabled = false;
            this.Peso_Peso.Location = new System.Drawing.Point(499, 163);
            this.Peso_Peso.Name = "Peso_Peso";
            this.Peso_Peso.Size = new System.Drawing.Size(100, 20);
            this.Peso_Peso.TabIndex = 18;
            // 
            // BotonBloqueado
            // 
            this.BotonBloqueado.Image = global::Ejercicio_23.Properties.Resources.bloqueado__1_;
            this.BotonBloqueado.Location = new System.Drawing.Point(160, 14);
            this.BotonBloqueado.Name = "BotonBloqueado";
            this.BotonBloqueado.Size = new System.Drawing.Size(56, 38);
            this.BotonBloqueado.TabIndex = 19;
            this.BotonBloqueado.UseVisualStyleBackColor = true;
            this.BotonBloqueado.Click += new System.EventHandler(this.BotonBloqueado_Click);
            // 
            // EuroTextoDos
            // 
            this.EuroTextoDos.AutoSize = true;
            this.EuroTextoDos.Location = new System.Drawing.Point(276, 63);
            this.EuroTextoDos.Name = "EuroTextoDos";
            this.EuroTextoDos.Size = new System.Drawing.Size(29, 13);
            this.EuroTextoDos.TabIndex = 20;
            this.EuroTextoDos.Text = "Euro";
            // 
            // DolarTextoDos
            // 
            this.DolarTextoDos.AutoSize = true;
            this.DolarTextoDos.Location = new System.Drawing.Point(403, 63);
            this.DolarTextoDos.Name = "DolarTextoDos";
            this.DolarTextoDos.Size = new System.Drawing.Size(32, 13);
            this.DolarTextoDos.TabIndex = 21;
            this.DolarTextoDos.Text = "Dolar";
            // 
            // PesoTextoDos
            // 
            this.PesoTextoDos.AutoSize = true;
            this.PesoTextoDos.Location = new System.Drawing.Point(533, 59);
            this.PesoTextoDos.Name = "PesoTextoDos";
            this.PesoTextoDos.Size = new System.Drawing.Size(31, 13);
            this.PesoTextoDos.TabIndex = 22;
            this.PesoTextoDos.Text = "Peso";
            // 
            // BotonEuro
            // 
            this.BotonEuro.Location = new System.Drawing.Point(168, 81);
            this.BotonEuro.Name = "BotonEuro";
            this.BotonEuro.Size = new System.Drawing.Size(60, 20);
            this.BotonEuro.TabIndex = 23;
            this.BotonEuro.Text = "-->";
            this.BotonEuro.UseVisualStyleBackColor = true;
            this.BotonEuro.Click += new System.EventHandler(this.BotonEuro_Click);
            // 
            // BotonDolar
            // 
            this.BotonDolar.Location = new System.Drawing.Point(168, 123);
            this.BotonDolar.Name = "BotonDolar";
            this.BotonDolar.Size = new System.Drawing.Size(60, 20);
            this.BotonDolar.TabIndex = 24;
            this.BotonDolar.Text = "-->";
            this.BotonDolar.UseVisualStyleBackColor = true;
            this.BotonDolar.Click += new System.EventHandler(this.BotonDolar_Click);
            // 
            // BotonPeso
            // 
            this.BotonPeso.Location = new System.Drawing.Point(168, 163);
            this.BotonPeso.Name = "BotonPeso";
            this.BotonPeso.Size = new System.Drawing.Size(60, 20);
            this.BotonPeso.TabIndex = 25;
            this.BotonPeso.Text = "-->";
            this.BotonPeso.UseVisualStyleBackColor = true;
            this.BotonPeso.Click += new System.EventHandler(this.BotonPeso_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "desbloqueado.png");
            this.imageList1.Images.SetKeyName(1, "bloqueado.png");
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 225);
            this.Controls.Add(this.BotonPeso);
            this.Controls.Add(this.BotonDolar);
            this.Controls.Add(this.BotonEuro);
            this.Controls.Add(this.PesoTextoDos);
            this.Controls.Add(this.DolarTextoDos);
            this.Controls.Add(this.EuroTextoDos);
            this.Controls.Add(this.BotonBloqueado);
            this.Controls.Add(this.Peso_Peso);
            this.Controls.Add(this.Dolar_Peso);
            this.Controls.Add(this.Euro_Peso);
            this.Controls.Add(this.Peso_Dolar);
            this.Controls.Add(this.Euro_Dolar);
            this.Controls.Add(this.Dolar_Dolar);
            this.Controls.Add(this.Peso_Euro);
            this.Controls.Add(this.Dolar_Euro);
            this.Controls.Add(this.Euro_Euro);
            this.Controls.Add(this.CotizacionDolar);
            this.Controls.Add(this.CotizacionEuro);
            this.Controls.Add(this.CotizacionPeso);
            this.Controls.Add(this.EntradaPeso);
            this.Controls.Add(this.EntradaDolar);
            this.Controls.Add(this.EntradaEuro);
            this.Controls.Add(this.PesoTextoUno);
            this.Controls.Add(this.DolarTextoUno);
            this.Controls.Add(this.EuroTextoUno);
            this.Controls.Add(this.TextCotizacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 264);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 264);
            this.Name = "Conversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextCotizacion;
        private System.Windows.Forms.Label EuroTextoUno;
        private System.Windows.Forms.Label DolarTextoUno;
        private System.Windows.Forms.Label PesoTextoUno;
        private System.Windows.Forms.TextBox EntradaEuro;
        private System.Windows.Forms.TextBox EntradaDolar;
        private System.Windows.Forms.TextBox EntradaPeso;
        private System.Windows.Forms.TextBox CotizacionPeso;
        private System.Windows.Forms.TextBox CotizacionEuro;
        private System.Windows.Forms.TextBox CotizacionDolar;
        private System.Windows.Forms.TextBox Euro_Euro;
        private System.Windows.Forms.TextBox Dolar_Euro;
        private System.Windows.Forms.TextBox Peso_Euro;
        private System.Windows.Forms.TextBox Dolar_Dolar;
        private System.Windows.Forms.TextBox Euro_Dolar;
        private System.Windows.Forms.TextBox Peso_Dolar;
        private System.Windows.Forms.TextBox Euro_Peso;
        private System.Windows.Forms.TextBox Dolar_Peso;
        private System.Windows.Forms.TextBox Peso_Peso;
        private System.Windows.Forms.Button BotonBloqueado;
        private System.Windows.Forms.Label EuroTextoDos;
        private System.Windows.Forms.Label DolarTextoDos;
        private System.Windows.Forms.Label PesoTextoDos;
        private System.Windows.Forms.Button BotonEuro;
        private System.Windows.Forms.Button BotonDolar;
        private System.Windows.Forms.Button BotonPeso;
        private System.Windows.Forms.ImageList imageList1;
    }
}

