namespace Arrays___DrawingWithButtons
{
    partial class Form
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnEscudo = new System.Windows.Forms.Button();
            this.btnBordar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(12, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaranja.Location = new System.Drawing.Point(93, 12);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(75, 23);
            this.btnNaranja.TabIndex = 2;
            this.btnNaranja.Text = "Naranja";
            this.btnNaranja.UseVisualStyleBackColor = true;
            this.btnNaranja.Click += new System.EventHandler(this.Naranja_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.Location = new System.Drawing.Point(174, 12);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 3;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnEscudo
            // 
            this.btnEscudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscudo.Location = new System.Drawing.Point(255, 12);
            this.btnEscudo.Name = "btnEscudo";
            this.btnEscudo.Size = new System.Drawing.Size(75, 23);
            this.btnEscudo.TabIndex = 4;
            this.btnEscudo.Text = "Escudo";
            this.btnEscudo.UseVisualStyleBackColor = true;
            this.btnEscudo.Click += new System.EventHandler(this.btnEscudo_Click);
            // 
            // btnBordar
            // 
            this.btnBordar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBordar.Location = new System.Drawing.Point(336, 12);
            this.btnBordar.Name = "btnBordar";
            this.btnBordar.Size = new System.Drawing.Size(75, 23);
            this.btnBordar.TabIndex = 5;
            this.btnBordar.Text = "Bordar";
            this.btnBordar.UseVisualStyleBackColor = true;
            this.btnBordar.Click += new System.EventHandler(this.btnBordar_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 611);
            this.Controls.Add(this.btnBordar);
            this.Controls.Add(this.btnEscudo);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.MaximumSize = new System.Drawing.Size(630, 650);
            this.MinimumSize = new System.Drawing.Size(630, 650);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnEscudo;
        private System.Windows.Forms.Button btnBordar;
    }
}

