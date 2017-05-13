namespace ClienteMultas.Forms
{
    partial class PantallaConsultarPuntos
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(90, 35);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(106, 20);
            this.tbDNI.TabIndex = 2;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbDNI_TextChanged);
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(323, 35);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(117, 20);
            this.tbMat.TabIndex = 3;
            this.tbMat.TextChanged += new System.EventHandler(this.tbMat_TextChanged);
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
            this.textoPuntos.Visible = false;
            // 
            // PantallaConsultarPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.textoPuntos);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaConsultarPuntos";
            this.Text = "PantallaConsultarPuntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.Label textoPuntos;
    }
}