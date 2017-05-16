namespace ClienteMultas.Forms
{
    partial class PantallaConsultarMultas
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
            this.vistaMultas = new System.Windows.Forms.DataGridView();
            this.numMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btVerMultas = new System.Windows.Forms.Button();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbMat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaMultas
            // 
            this.vistaMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numMulta,
            this.mat,
            this.fecha,
            this.puntos});
            this.vistaMultas.Location = new System.Drawing.Point(17, 94);
            this.vistaMultas.Name = "vistaMultas";
            this.vistaMultas.Size = new System.Drawing.Size(443, 338);
            this.vistaMultas.TabIndex = 0;
            // 
            // numMulta
            // 
            this.numMulta.Frozen = true;
            this.numMulta.HeaderText = "#";
            this.numMulta.Name = "numMulta";
            // 
            // mat
            // 
            this.mat.Frozen = true;
            this.mat.HeaderText = "Matrícula";
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // puntos
            // 
            this.puntos.Frozen = true;
            this.puntos.HeaderText = "Puntos";
            this.puntos.Name = "puntos";
            this.puntos.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrícula:";
            // 
            // btVerMultas
            // 
            this.btVerMultas.Location = new System.Drawing.Point(382, 33);
            this.btVerMultas.Name = "btVerMultas";
            this.btVerMultas.Size = new System.Drawing.Size(78, 23);
            this.btVerMultas.TabIndex = 5;
            this.btVerMultas.Text = "Ver multas";
            this.btVerMultas.UseVisualStyleBackColor = true;
            this.btVerMultas.Click += new System.EventHandler(this.btVerMultas_Click);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(72, 35);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(91, 20);
            this.tbDNI.TabIndex = 6;
            // 
            // tbMat
            // 
            this.tbMat.Location = new System.Drawing.Point(266, 35);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(100, 20);
            this.tbMat.TabIndex = 7;
            // 
            // PantallaConsultarMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 457);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.btVerMultas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vistaMultas);
            this.Name = "PantallaConsultarMultas";
            this.Text = "PantallaConsultarMultas";
            ((System.ComponentModel.ISupportInitialize)(this.vistaMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vistaMultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btVerMultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbMat;
    }
}