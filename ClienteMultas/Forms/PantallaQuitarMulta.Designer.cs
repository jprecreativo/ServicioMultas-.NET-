namespace ClienteMultas.Forms
{
    partial class PantallaQuitarMulta
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
            this.textoMulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBFecha = new System.Windows.Forms.TextBox();
            this.btRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoMulta
            // 
            this.textoMulta.Font = new System.Drawing.Font("Papyrus", 10F);
            this.textoMulta.ForeColor = System.Drawing.Color.Red;
            this.textoMulta.Location = new System.Drawing.Point(49, 93);
            this.textoMulta.Name = "textoMulta";
            this.textoMulta.Size = new System.Drawing.Size(387, 25);
            this.textoMulta.TabIndex = 11;
            this.textoMulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Matrícula:";
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(106, 30);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(76, 20);
            this.tbMat.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha:";
            // 
            // tBFecha
            // 
            this.tBFecha.Location = new System.Drawing.Point(260, 31);
            this.tBFecha.Name = "tBFecha";
            this.tBFecha.Size = new System.Drawing.Size(108, 20);
            this.tBFecha.TabIndex = 15;
            // 
            // btRetirar
            // 
            this.btRetirar.Location = new System.Drawing.Point(387, 28);
            this.btRetirar.Name = "btRetirar";
            this.btRetirar.Size = new System.Drawing.Size(75, 23);
            this.btRetirar.TabIndex = 16;
            this.btRetirar.Text = "Retirar";
            this.btRetirar.UseVisualStyleBackColor = true;
            this.btRetirar.Click += new System.EventHandler(this.btRetirar_Click);
            // 
            // PantallaQuitarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.btRetirar);
            this.Controls.Add(this.tBFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoMulta);
            this.Name = "PantallaQuitarMulta";
            this.Text = "PantallaQuitarMulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBFecha;
        private System.Windows.Forms.Button btRetirar;
    }
}