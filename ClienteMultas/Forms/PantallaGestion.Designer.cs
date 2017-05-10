namespace ClienteMultas.Forms
{
    partial class PantallaGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGestion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.rbQuitarMulta = new System.Windows.Forms.RadioButton();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            this.rbPonerMulta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(197, 486);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(93, 23);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBaja);
            this.panel1.Controls.Add(this.rbQuitarMulta);
            this.panel1.Controls.Add(this.rbAlta);
            this.panel1.Controls.Add(this.rbPonerMulta);
            this.panel1.Location = new System.Drawing.Point(140, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 188);
            this.panel1.TabIndex = 5;
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Location = new System.Drawing.Point(57, 130);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(91, 17);
            this.rbBaja.TabIndex = 4;
            this.rbBaja.TabStop = true;
            this.rbBaja.Text = "Baja vehículo";
            this.rbBaja.UseVisualStyleBackColor = true;
            // 
            // rbQuitarMulta
            // 
            this.rbQuitarMulta.AutoSize = true;
            this.rbQuitarMulta.Location = new System.Drawing.Point(57, 54);
            this.rbQuitarMulta.Name = "rbQuitarMulta";
            this.rbQuitarMulta.Size = new System.Drawing.Size(81, 17);
            this.rbQuitarMulta.TabIndex = 3;
            this.rbQuitarMulta.TabStop = true;
            this.rbQuitarMulta.Text = "Quitar multa";
            this.rbQuitarMulta.UseVisualStyleBackColor = true;
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.Location = new System.Drawing.Point(57, 92);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(88, 17);
            this.rbAlta.TabIndex = 1;
            this.rbAlta.Text = "Alta vehículo";
            this.rbAlta.UseVisualStyleBackColor = true;
            // 
            // rbPonerMulta
            // 
            this.rbPonerMulta.AutoSize = true;
            this.rbPonerMulta.Checked = true;
            this.rbPonerMulta.Location = new System.Drawing.Point(57, 15);
            this.rbPonerMulta.Name = "rbPonerMulta";
            this.rbPonerMulta.Size = new System.Drawing.Size(81, 17);
            this.rbPonerMulta.TabIndex = 0;
            this.rbPonerMulta.TabStop = true;
            this.rbPonerMulta.Text = "Poner multa";
            this.rbPonerMulta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú gestión";
            // 
            // PantallaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaGestion";
            this.Text = "PantallaGestion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAlta;
        private System.Windows.Forms.RadioButton rbPonerMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.RadioButton rbQuitarMulta;
    }
}