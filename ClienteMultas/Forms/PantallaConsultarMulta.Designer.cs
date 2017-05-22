namespace ClienteMultas.Forms
{
    partial class PantallaConsultarMulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.textoPuntos = new System.Windows.Forms.Label();
            this.btConsultarMulta = new System.Windows.Forms.Button();
            this.textoMulta = new System.Windows.Forms.Label();
            this.tbMulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(70, 34);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(106, 20);
            this.tbDNI.TabIndex = 2;
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(281, 36);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(117, 20);
            this.tbMat.TabIndex = 3;
            // 
            // textoPuntos
            // 
            this.textoPuntos.Font = new System.Drawing.Font("Papyrus", 10F);
            this.textoPuntos.ForeColor = System.Drawing.Color.Red;
            this.textoPuntos.Location = new System.Drawing.Point(76, 88);
            this.textoPuntos.Name = "textoPuntos";
            this.textoPuntos.Size = new System.Drawing.Size(355, 25);
            this.textoPuntos.TabIndex = 4;
            this.textoPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConsultarMulta
            // 
            this.btConsultarMulta.Location = new System.Drawing.Point(428, 34);
            this.btConsultarMulta.Name = "btConsultarMulta";
            this.btConsultarMulta.Size = new System.Drawing.Size(75, 23);
            this.btConsultarMulta.TabIndex = 5;
            this.btConsultarMulta.Text = "Ver multas";
            this.btConsultarMulta.UseVisualStyleBackColor = true;
            this.btConsultarMulta.Click += new System.EventHandler(this.btConsultarMulta_Click);
            // 
            // textoMulta
            // 
            this.textoMulta.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMulta.Location = new System.Drawing.Point(25, 88);
            this.textoMulta.Name = "textoMulta";
            this.textoMulta.Size = new System.Drawing.Size(478, 23);
            this.textoMulta.TabIndex = 6;
            this.textoMulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMulta
            // 
            this.tbMulta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMulta.Location = new System.Drawing.Point(29, 144);
            this.tbMulta.Multiline = true;
            this.tbMulta.Name = "tbMulta";
            this.tbMulta.ReadOnly = true;
            this.tbMulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMulta.Size = new System.Drawing.Size(474, 302);
            this.tbMulta.TabIndex = 7;
            // 
            // PantallaConsultarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 458);
            this.Controls.Add(this.tbMulta);
            this.Controls.Add(this.textoMulta);
            this.Controls.Add(this.btConsultarMulta);
            this.Controls.Add(this.textoPuntos);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaConsultarMulta";
            this.Text = "PantallaConsultarMulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.Label textoPuntos;
        private System.Windows.Forms.Button btConsultarMulta;
        private System.Windows.Forms.Label textoMulta;
        private System.Windows.Forms.TextBox tbMulta;
    }
}