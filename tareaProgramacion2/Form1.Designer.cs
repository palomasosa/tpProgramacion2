
namespace tareaProgramacion2
{
    partial class Form1
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
            this.lblIntroducir = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.nmDía = new System.Windows.Forms.NumericUpDown();
            this.nmMes = new System.Windows.Forms.NumericUpDown();
            this.nmAño = new System.Windows.Forms.NumericUpDown();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.lblSep2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmDía)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAño)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntroducir
            // 
            this.lblIntroducir.AutoSize = true;
            this.lblIntroducir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroducir.Location = new System.Drawing.Point(262, 144);
            this.lblIntroducir.Name = "lblIntroducir";
            this.lblIntroducir.Size = new System.Drawing.Size(170, 24);
            this.lblIntroducir.TabIndex = 0;
            this.lblIntroducir.Text = "Ingrese la fecha: ";
            this.lblIntroducir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(262, 200);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 24);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Visible = false;
            // 
            // nmDía
            // 
            this.nmDía.Location = new System.Drawing.Point(430, 148);
            this.nmDía.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nmDía.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDía.Name = "nmDía";
            this.nmDía.Size = new System.Drawing.Size(44, 20);
            this.nmDía.TabIndex = 2;
            this.nmDía.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmDía.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmMes
            // 
            this.nmMes.Location = new System.Drawing.Point(497, 148);
            this.nmMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMes.Name = "nmMes";
            this.nmMes.Size = new System.Drawing.Size(49, 20);
            this.nmMes.TabIndex = 3;
            this.nmMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmAño
            // 
            this.nmAño.Location = new System.Drawing.Point(572, 148);
            this.nmAño.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nmAño.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmAño.Name = "nmAño";
            this.nmAño.Size = new System.Drawing.Size(46, 20);
            this.nmAño.TabIndex = 4;
            this.nmAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmAño.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // lblSep1
            // 
            this.lblSep1.AutoSize = true;
            this.lblSep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep1.Location = new System.Drawing.Point(480, 148);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(14, 20);
            this.lblSep1.TabIndex = 5;
            this.lblSep1.Text = "/";
            // 
            // lblSep2
            // 
            this.lblSep2.AutoSize = true;
            this.lblSep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep2.Location = new System.Drawing.Point(552, 148);
            this.lblSep2.Name = "lblSep2";
            this.lblSep2.Size = new System.Drawing.Size(14, 20);
            this.lblSep2.TabIndex = 6;
            this.lblSep2.Text = "/";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(624, 145);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSep2);
            this.Controls.Add(this.lblSep1);
            this.Controls.Add(this.nmAño);
            this.Controls.Add(this.nmMes);
            this.Controls.Add(this.nmDía);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblIntroducir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmDía)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntroducir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown nmDía;
        private System.Windows.Forms.NumericUpDown nmMes;
        private System.Windows.Forms.NumericUpDown nmAño;
        private System.Windows.Forms.Label lblSep1;
        private System.Windows.Forms.Label lblSep2;
        private System.Windows.Forms.Button btnCalcular;
    }
}

