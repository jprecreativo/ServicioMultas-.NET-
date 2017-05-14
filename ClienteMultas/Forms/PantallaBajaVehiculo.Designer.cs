namespace ClienteMultas.Forms
{
    partial class PantallaBajaVehiculo
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
            this.btBaja = new System.Windows.Forms.Button();
            this.textoBaja = new System.Windows.Forms.Label();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBaja
            // 
            this.btBaja.Location = new System.Drawing.Point(422, 33);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(75, 23);
            this.btBaja.TabIndex = 16;
            this.btBaja.Text = "Dar de baja";
            this.btBaja.UseVisualStyleBackColor = true;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // textoBaja
            // 
            this.textoBaja.Font = new System.Drawing.Font("Papyrus", 10F);
            this.textoBaja.ForeColor = System.Drawing.Color.Red;
            this.textoBaja.Location = new System.Drawing.Point(24, 92);
            this.textoBaja.Name = "textoBaja";
            this.textoBaja.Size = new System.Drawing.Size(486, 25);
            this.textoBaja.TabIndex = 15;
            this.textoBaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(281, 35);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(104, 20);
            this.tbMat.TabIndex = 14;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(79, 35);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(98, 20);
            this.tbDNI.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI:";
            // 
            // PantallaBajaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 161);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.textoBaja);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaBajaVehiculo";
            this.Text = "PantallaBajaVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Label textoBaja;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}