namespace ServicioMultas.Forms
{
    partial class PantallaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbConsultarMultas = new System.Windows.Forms.RadioButton();
            this.rbConsultarPuntos = new System.Windows.Forms.RadioButton();
            this.rbIdentificacion = new System.Windows.Forms.RadioButton();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú consultas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbConsultarMultas);
            this.panel1.Controls.Add(this.rbConsultarPuntos);
            this.panel1.Controls.Add(this.rbIdentificacion);
            this.panel1.Location = new System.Drawing.Point(142, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 188);
            this.panel1.TabIndex = 2;
            // 
            // rbConsultarMultas
            // 
            this.rbConsultarMultas.AutoSize = true;
            this.rbConsultarMultas.Location = new System.Drawing.Point(57, 133);
            this.rbConsultarMultas.Name = "rbConsultarMultas";
            this.rbConsultarMultas.Size = new System.Drawing.Size(102, 17);
            this.rbConsultarMultas.TabIndex = 2;
            this.rbConsultarMultas.Text = "Consultar multas";
            this.rbConsultarMultas.UseVisualStyleBackColor = true;
            // 
            // rbConsultarPuntos
            // 
            this.rbConsultarPuntos.AutoSize = true;
            this.rbConsultarPuntos.Location = new System.Drawing.Point(57, 84);
            this.rbConsultarPuntos.Name = "rbConsultarPuntos";
            this.rbConsultarPuntos.Size = new System.Drawing.Size(104, 17);
            this.rbConsultarPuntos.TabIndex = 1;
            this.rbConsultarPuntos.Text = "Consultar puntos";
            this.rbConsultarPuntos.UseVisualStyleBackColor = true;
            // 
            // rbIdentificacion
            // 
            this.rbIdentificacion.AutoSize = true;
            this.rbIdentificacion.Checked = true;
            this.rbIdentificacion.Location = new System.Drawing.Point(57, 31);
            this.rbIdentificacion.Name = "rbIdentificacion";
            this.rbIdentificacion.Size = new System.Drawing.Size(88, 17);
            this.rbIdentificacion.TabIndex = 0;
            this.rbIdentificacion.TabStop = true;
            this.rbIdentificacion.Text = "Identificación";
            this.rbIdentificacion.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(199, 461);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(93, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaInicial";
            this.Text = "Bienvenido a la aplicación de multas de la DGT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.RadioButton rbConsultarMultas;
        private System.Windows.Forms.RadioButton rbConsultarPuntos;
        private System.Windows.Forms.RadioButton rbIdentificacion;

    }
}