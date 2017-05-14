namespace ClienteMultas.Forms
{
    partial class PantallaPonerMulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spPuntos = new System.Windows.Forms.NumericUpDown();
            this.btMultar = new System.Windows.Forms.Button();
            this.textoMulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(109, 31);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(81, 20);
            this.tbMat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puntos:";
            // 
            // spPuntos
            // 
            this.spPuntos.Location = new System.Drawing.Point(274, 32);
            this.spPuntos.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spPuntos.Name = "spPuntos";
            this.spPuntos.Size = new System.Drawing.Size(36, 20);
            this.spPuntos.TabIndex = 3;
            // 
            // btMultar
            // 
            this.btMultar.Location = new System.Drawing.Point(334, 29);
            this.btMultar.Name = "btMultar";
            this.btMultar.Size = new System.Drawing.Size(75, 23);
            this.btMultar.TabIndex = 4;
            this.btMultar.Text = "Multar";
            this.btMultar.UseVisualStyleBackColor = true;
            this.btMultar.Click += new System.EventHandler(this.btMultar_Click);
            // 
            // textoMulta
            // 
            this.textoMulta.Font = new System.Drawing.Font("Papyrus", 10F);
            this.textoMulta.ForeColor = System.Drawing.Color.Red;
            this.textoMulta.Location = new System.Drawing.Point(22, 96);
            this.textoMulta.Name = "textoMulta";
            this.textoMulta.Size = new System.Drawing.Size(387, 25);
            this.textoMulta.TabIndex = 10;
            this.textoMulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PantallaPonerMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.textoMulta);
            this.Controls.Add(this.btMultar);
            this.Controls.Add(this.spPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.label1);
            this.Name = "PantallaPonerMulta";
            this.Text = "PantallaPonerMulta";
            ((System.ComponentModel.ISupportInitialize)(this.spPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spPuntos;
        private System.Windows.Forms.Button btMultar;
        private System.Windows.Forms.Label textoMulta;
    }
}