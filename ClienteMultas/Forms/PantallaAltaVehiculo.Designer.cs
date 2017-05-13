namespace ClienteMultas.Forms
{
    partial class PantallaAltaVehiculo
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
            this.textoPuntos = new System.Windows.Forms.Label();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoPuntos
            // 
            this.textoPuntos.Font = new System.Drawing.Font("Papyrus", 10F);
            this.textoPuntos.ForeColor = System.Drawing.Color.Red;
            this.textoPuntos.Location = new System.Drawing.Point(24, 93);
            this.textoPuntos.Name = "textoPuntos";
            this.textoPuntos.Size = new System.Drawing.Size(486, 25);
            this.textoPuntos.TabIndex = 9;
            this.textoPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textoPuntos.Visible = false;
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(281, 36);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(104, 20);
            this.tbMat.TabIndex = 8;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(79, 36);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(98, 20);
            this.tbDNI.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI:";
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(422, 34);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(75, 23);
            this.btAlta.TabIndex = 10;
            this.btAlta.Text = "Dar de alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // PantallaAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 161);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.textoPuntos);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaAltaVehiculo";
            this.Text = "PantallaAltaVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoPuntos;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlta;
    }
}