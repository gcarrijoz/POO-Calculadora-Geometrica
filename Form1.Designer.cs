namespace wfaCalculadoraGeometrica2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbLosango = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.rbHexagono = new System.Windows.Forms.RadioButton();
            this.rbQuadrado = new System.Windows.Forms.RadioButton();
            this.rbPentagono = new System.Windows.Forms.RadioButton();
            this.rbTrapezio = new System.Windows.Forms.RadioButton();
            this.btCalcularPerimetro = new System.Windows.Forms.Button();
            this.btCalcularArea = new System.Windows.Forms.Button();
            this.btLimparDados = new System.Windows.Forms.Button();
            this.lbRaio = new System.Windows.Forms.Label();
            this.lbLado = new System.Windows.Forms.Label();
            this.lbDiagonalMaior = new System.Windows.Forms.Label();
            this.lbDiagonalMenor = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbBaseMenor = new System.Windows.Forms.Label();
            this.lbBaseMaior = new System.Windows.Forms.Label();
            this.tbRaio = new System.Windows.Forms.TextBox();
            this.tbLado = new System.Windows.Forms.TextBox();
            this.tbDiagonalMaior = new System.Windows.Forms.TextBox();
            this.tbDiagonalMenor = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbBaseMaior = new System.Windows.Forms.TextBox();
            this.tbBaseMenor = new System.Windows.Forms.TextBox();
            this.lvArea = new System.Windows.Forms.ListView();
            this.lvPerimetro = new System.Windows.Forms.ListView();
            this.pbImagens = new System.Windows.Forms.PictureBox();
            this.lbFormasGeometricas = new System.Windows.Forms.Label();
            this.lbCalcular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCirculo.Location = new System.Drawing.Point(476, 70);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(83, 24);
            this.rbCirculo.TabIndex = 1;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // rbLosango
            // 
            this.rbLosango.AutoSize = true;
            this.rbLosango.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLosango.Location = new System.Drawing.Point(476, 103);
            this.rbLosango.Name = "rbLosango";
            this.rbLosango.Size = new System.Drawing.Size(94, 24);
            this.rbLosango.TabIndex = 2;
            this.rbLosango.Text = "Losango";
            this.rbLosango.UseVisualStyleBackColor = true;
            this.rbLosango.CheckedChanged += new System.EventHandler(this.rbLosango_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTriangulo.Location = new System.Drawing.Point(699, 169);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(99, 24);
            this.rbTriangulo.TabIndex = 3;
            this.rbTriangulo.Text = "Triângulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetangulo.Location = new System.Drawing.Point(699, 136);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(105, 24);
            this.rbRetangulo.TabIndex = 4;
            this.rbRetangulo.Text = "Retângulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // rbHexagono
            // 
            this.rbHexagono.AutoSize = true;
            this.rbHexagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHexagono.Location = new System.Drawing.Point(699, 70);
            this.rbHexagono.Name = "rbHexagono";
            this.rbHexagono.Size = new System.Drawing.Size(105, 24);
            this.rbHexagono.TabIndex = 5;
            this.rbHexagono.Text = "Hexágono";
            this.rbHexagono.UseVisualStyleBackColor = true;
            this.rbHexagono.CheckedChanged += new System.EventHandler(this.rbHexagono_CheckedChanged);
            // 
            // rbQuadrado
            // 
            this.rbQuadrado.AutoSize = true;
            this.rbQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuadrado.Location = new System.Drawing.Point(476, 136);
            this.rbQuadrado.Name = "rbQuadrado";
            this.rbQuadrado.Size = new System.Drawing.Size(103, 24);
            this.rbQuadrado.TabIndex = 6;
            this.rbQuadrado.Text = "Quadrado";
            this.rbQuadrado.UseVisualStyleBackColor = true;
            this.rbQuadrado.CheckedChanged += new System.EventHandler(this.rbQuadrado_CheckedChanged);
            // 
            // rbPentagono
            // 
            this.rbPentagono.AutoSize = true;
            this.rbPentagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPentagono.Location = new System.Drawing.Point(699, 103);
            this.rbPentagono.Name = "rbPentagono";
            this.rbPentagono.Size = new System.Drawing.Size(109, 24);
            this.rbPentagono.TabIndex = 7;
            this.rbPentagono.Text = "Pentágono";
            this.rbPentagono.UseVisualStyleBackColor = true;
            this.rbPentagono.CheckedChanged += new System.EventHandler(this.rbPentagono_CheckedChanged);
            // 
            // rbTrapezio
            // 
            this.rbTrapezio.AutoSize = true;
            this.rbTrapezio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrapezio.Location = new System.Drawing.Point(476, 169);
            this.rbTrapezio.Name = "rbTrapezio";
            this.rbTrapezio.Size = new System.Drawing.Size(95, 24);
            this.rbTrapezio.TabIndex = 8;
            this.rbTrapezio.Text = "Trapézio";
            this.rbTrapezio.UseVisualStyleBackColor = true;
            this.rbTrapezio.CheckedChanged += new System.EventHandler(this.rbTrapezio_CheckedChanged);
            // 
            // btCalcularPerimetro
            // 
            this.btCalcularPerimetro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCalcularPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularPerimetro.Location = new System.Drawing.Point(643, 299);
            this.btCalcularPerimetro.Name = "btCalcularPerimetro";
            this.btCalcularPerimetro.Size = new System.Drawing.Size(161, 62);
            this.btCalcularPerimetro.TabIndex = 9;
            this.btCalcularPerimetro.Text = "PERÍMETRO";
            this.btCalcularPerimetro.UseVisualStyleBackColor = false;
            this.btCalcularPerimetro.Click += new System.EventHandler(this.btCalcularPerimetro_Click);
            // 
            // btCalcularArea
            // 
            this.btCalcularArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularArea.Location = new System.Drawing.Point(476, 300);
            this.btCalcularArea.Name = "btCalcularArea";
            this.btCalcularArea.Size = new System.Drawing.Size(161, 63);
            this.btCalcularArea.TabIndex = 10;
            this.btCalcularArea.Text = "ÁREA";
            this.btCalcularArea.UseVisualStyleBackColor = false;
            this.btCalcularArea.Click += new System.EventHandler(this.btCalcularArea_Click);
            // 
            // btLimparDados
            // 
            this.btLimparDados.BackColor = System.Drawing.Color.Maroon;
            this.btLimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparDados.ForeColor = System.Drawing.Color.White;
            this.btLimparDados.Location = new System.Drawing.Point(476, 369);
            this.btLimparDados.Name = "btLimparDados";
            this.btLimparDados.Size = new System.Drawing.Size(328, 44);
            this.btLimparDados.TabIndex = 11;
            this.btLimparDados.Text = "LIMPAR DADOS";
            this.btLimparDados.UseVisualStyleBackColor = false;
            this.btLimparDados.Click += new System.EventHandler(this.btLimparDados_Click);
            // 
            // lbRaio
            // 
            this.lbRaio.AutoSize = true;
            this.lbRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaio.Location = new System.Drawing.Point(34, 378);
            this.lbRaio.Name = "lbRaio";
            this.lbRaio.Size = new System.Drawing.Size(48, 20);
            this.lbRaio.TabIndex = 12;
            this.lbRaio.Text = "Raio:";
            // 
            // lbLado
            // 
            this.lbLado.AutoSize = true;
            this.lbLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLado.Location = new System.Drawing.Point(34, 378);
            this.lbLado.Name = "lbLado";
            this.lbLado.Size = new System.Drawing.Size(51, 20);
            this.lbLado.TabIndex = 13;
            this.lbLado.Text = "Lado:";
            // 
            // lbDiagonalMaior
            // 
            this.lbDiagonalMaior.AutoSize = true;
            this.lbDiagonalMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagonalMaior.Location = new System.Drawing.Point(34, 347);
            this.lbDiagonalMaior.Name = "lbDiagonalMaior";
            this.lbDiagonalMaior.Size = new System.Drawing.Size(127, 20);
            this.lbDiagonalMaior.TabIndex = 14;
            this.lbDiagonalMaior.Text = "Diagonal Maior:";
            // 
            // lbDiagonalMenor
            // 
            this.lbDiagonalMenor.AutoSize = true;
            this.lbDiagonalMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagonalMenor.Location = new System.Drawing.Point(34, 381);
            this.lbDiagonalMenor.Name = "lbDiagonalMenor";
            this.lbDiagonalMenor.Size = new System.Drawing.Size(132, 20);
            this.lbDiagonalMenor.TabIndex = 15;
            this.lbDiagonalMenor.Text = "Diagonal Menor:";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.Location = new System.Drawing.Point(34, 409);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(58, 20);
            this.lbAltura.TabIndex = 16;
            this.lbAltura.Text = "Altura:";
            // 
            // lbBaseMenor
            // 
            this.lbBaseMenor.AutoSize = true;
            this.lbBaseMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseMenor.Location = new System.Drawing.Point(34, 382);
            this.lbBaseMenor.Name = "lbBaseMenor";
            this.lbBaseMenor.Size = new System.Drawing.Size(105, 20);
            this.lbBaseMenor.TabIndex = 17;
            this.lbBaseMenor.Text = "Base Menor:";
            // 
            // lbBaseMaior
            // 
            this.lbBaseMaior.AutoSize = true;
            this.lbBaseMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseMaior.Location = new System.Drawing.Point(34, 348);
            this.lbBaseMaior.Name = "lbBaseMaior";
            this.lbBaseMaior.Size = new System.Drawing.Size(100, 20);
            this.lbBaseMaior.TabIndex = 18;
            this.lbBaseMaior.Text = "Base Maior:";
            // 
            // tbRaio
            // 
            this.tbRaio.Location = new System.Drawing.Point(210, 374);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(225, 22);
            this.tbRaio.TabIndex = 19;
            this.tbRaio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRaio_KeyPress);
            // 
            // tbLado
            // 
            this.tbLado.Location = new System.Drawing.Point(210, 374);
            this.tbLado.Name = "tbLado";
            this.tbLado.Size = new System.Drawing.Size(225, 22);
            this.tbLado.TabIndex = 20;
            this.tbLado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLado_KeyPress);
            // 
            // tbDiagonalMaior
            // 
            this.tbDiagonalMaior.Location = new System.Drawing.Point(210, 343);
            this.tbDiagonalMaior.Name = "tbDiagonalMaior";
            this.tbDiagonalMaior.Size = new System.Drawing.Size(225, 22);
            this.tbDiagonalMaior.TabIndex = 21;
            this.tbDiagonalMaior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiagonalMaior_KeyPress);
            // 
            // tbDiagonalMenor
            // 
            this.tbDiagonalMenor.Location = new System.Drawing.Point(210, 374);
            this.tbDiagonalMenor.Name = "tbDiagonalMenor";
            this.tbDiagonalMenor.Size = new System.Drawing.Size(225, 22);
            this.tbDiagonalMenor.TabIndex = 22;
            this.tbDiagonalMenor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiagonalMenor_KeyPress);
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(210, 405);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(225, 22);
            this.tbAltura.TabIndex = 23;
            this.tbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAltura_KeyPress);
            // 
            // tbBaseMaior
            // 
            this.tbBaseMaior.Location = new System.Drawing.Point(210, 343);
            this.tbBaseMaior.Name = "tbBaseMaior";
            this.tbBaseMaior.Size = new System.Drawing.Size(225, 22);
            this.tbBaseMaior.TabIndex = 24;
            this.tbBaseMaior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseMaior_KeyPress);
            // 
            // tbBaseMenor
            // 
            this.tbBaseMenor.Location = new System.Drawing.Point(210, 374);
            this.tbBaseMenor.Name = "tbBaseMenor";
            this.tbBaseMenor.Size = new System.Drawing.Size(225, 22);
            this.tbBaseMenor.TabIndex = 25;
            this.tbBaseMenor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseMenor_KeyPress);
            // 
            // lvArea
            // 
            this.lvArea.HideSelection = false;
            this.lvArea.Location = new System.Drawing.Point(37, 444);
            this.lvArea.Name = "lvArea";
            this.lvArea.Size = new System.Drawing.Size(767, 146);
            this.lvArea.TabIndex = 26;
            this.lvArea.UseCompatibleStateImageBehavior = false;
            // 
            // lvPerimetro
            // 
            this.lvPerimetro.HideSelection = false;
            this.lvPerimetro.Location = new System.Drawing.Point(37, 612);
            this.lvPerimetro.Name = "lvPerimetro";
            this.lvPerimetro.Size = new System.Drawing.Size(767, 146);
            this.lvPerimetro.TabIndex = 27;
            this.lvPerimetro.UseCompatibleStateImageBehavior = false;
            // 
            // pbImagens
            // 
            this.pbImagens.BackColor = System.Drawing.Color.White;
            this.pbImagens.Image = global::wfaCalculadoraGeometrica2.Properties.Resources.Circulo1;
            this.pbImagens.InitialImage = global::wfaCalculadoraGeometrica2.Properties.Resources.Branco;
            this.pbImagens.Location = new System.Drawing.Point(37, 12);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(398, 319);
            this.pbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagens.TabIndex = 0;
            this.pbImagens.TabStop = false;
            // 
            // lbFormasGeometricas
            // 
            this.lbFormasGeometricas.AutoSize = true;
            this.lbFormasGeometricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormasGeometricas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFormasGeometricas.Location = new System.Drawing.Point(471, 28);
            this.lbFormasGeometricas.Name = "lbFormasGeometricas";
            this.lbFormasGeometricas.Size = new System.Drawing.Size(218, 25);
            this.lbFormasGeometricas.TabIndex = 28;
            this.lbFormasGeometricas.Text = "Formas Geométricas:";
            // 
            // lbCalcular
            // 
            this.lbCalcular.AutoSize = true;
            this.lbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalcular.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCalcular.Location = new System.Drawing.Point(471, 257);
            this.lbCalcular.Name = "lbCalcular";
            this.lbCalcular.Size = new System.Drawing.Size(99, 25);
            this.lbCalcular.TabIndex = 29;
            this.lbCalcular.Text = "Calcular:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 779);
            this.Controls.Add(this.lbCalcular);
            this.Controls.Add(this.lbFormasGeometricas);
            this.Controls.Add(this.lvPerimetro);
            this.Controls.Add(this.lvArea);
            this.Controls.Add(this.tbBaseMenor);
            this.Controls.Add(this.tbBaseMaior);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbDiagonalMenor);
            this.Controls.Add(this.tbDiagonalMaior);
            this.Controls.Add(this.tbLado);
            this.Controls.Add(this.tbRaio);
            this.Controls.Add(this.lbBaseMaior);
            this.Controls.Add(this.lbBaseMenor);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbDiagonalMenor);
            this.Controls.Add(this.lbDiagonalMaior);
            this.Controls.Add(this.lbLado);
            this.Controls.Add(this.lbRaio);
            this.Controls.Add(this.btLimparDados);
            this.Controls.Add(this.btCalcularArea);
            this.Controls.Add(this.btCalcularPerimetro);
            this.Controls.Add(this.rbTrapezio);
            this.Controls.Add(this.rbPentagono);
            this.Controls.Add(this.rbQuadrado);
            this.Controls.Add(this.rbHexagono);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbLosango);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.pbImagens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Geométrica";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagens;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbLosango;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbHexagono;
        private System.Windows.Forms.RadioButton rbQuadrado;
        private System.Windows.Forms.RadioButton rbPentagono;
        private System.Windows.Forms.RadioButton rbTrapezio;
        private System.Windows.Forms.Button btCalcularPerimetro;
        private System.Windows.Forms.Button btCalcularArea;
        private System.Windows.Forms.Button btLimparDados;
        private System.Windows.Forms.Label lbRaio;
        private System.Windows.Forms.Label lbLado;
        private System.Windows.Forms.Label lbDiagonalMaior;
        private System.Windows.Forms.Label lbDiagonalMenor;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbBaseMenor;
        private System.Windows.Forms.Label lbBaseMaior;
        private System.Windows.Forms.TextBox tbRaio;
        private System.Windows.Forms.TextBox tbLado;
        private System.Windows.Forms.TextBox tbDiagonalMaior;
        private System.Windows.Forms.TextBox tbDiagonalMenor;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbBaseMaior;
        private System.Windows.Forms.TextBox tbBaseMenor;
        private System.Windows.Forms.ListView lvArea;
        private System.Windows.Forms.ListView lvPerimetro;
        private System.Windows.Forms.Label lbFormasGeometricas;
        private System.Windows.Forms.Label lbCalcular;
    }
}

