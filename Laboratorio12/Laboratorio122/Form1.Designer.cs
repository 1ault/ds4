namespace Laboratorio122
{
    partial class Laboratorio122
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Lsemestre1 = new System.Windows.Forms.Label();
            this.Lsemestre2 = new System.Windows.Forms.Label();
            this.Lsemestre3 = new System.Windows.Forms.Label();
            this.Lpromedio = new System.Windows.Forms.Label();
            this.TSemestre1 = new System.Windows.Forms.TextBox();
            this.TSemestre2 = new System.Windows.Forms.TextBox();
            this.TSemestre3 = new System.Windows.Forms.TextBox();
            this.TPromedioG = new System.Windows.Forms.TextBox();
            this.BCalcular = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(140, 10);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(288, 26);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Calculadora De Promedios";
            // 
            // Lsemestre1
            // 
            this.Lsemestre1.AutoSize = true;
            this.Lsemestre1.Location = new System.Drawing.Point(69, 101);
            this.Lsemestre1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lsemestre1.Name = "Lsemestre1";
            this.Lsemestre1.Size = new System.Drawing.Size(147, 22);
            this.Lsemestre1.TabIndex = 1;
            this.Lsemestre1.Text = "Primer Semestre:";
            // 
            // Lsemestre2
            // 
            this.Lsemestre2.AutoSize = true;
            this.Lsemestre2.Location = new System.Drawing.Point(55, 149);
            this.Lsemestre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lsemestre2.Name = "Lsemestre2";
            this.Lsemestre2.Size = new System.Drawing.Size(160, 22);
            this.Lsemestre2.TabIndex = 2;
            this.Lsemestre2.Text = "Segundo Semestre:";
            // 
            // Lsemestre3
            // 
            this.Lsemestre3.AutoSize = true;
            this.Lsemestre3.Location = new System.Drawing.Point(70, 193);
            this.Lsemestre3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lsemestre3.Name = "Lsemestre3";
            this.Lsemestre3.Size = new System.Drawing.Size(145, 22);
            this.Lsemestre3.TabIndex = 3;
            this.Lsemestre3.Text = "Tercer Semestre:";
            // 
            // Lpromedio
            // 
            this.Lpromedio.AutoSize = true;
            this.Lpromedio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpromedio.Location = new System.Drawing.Point(177, 317);
            this.Lpromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lpromedio.Name = "Lpromedio";
            this.Lpromedio.Size = new System.Drawing.Size(171, 23);
            this.Lpromedio.TabIndex = 4;
            this.Lpromedio.Text = "Promedio General:";
            // 
            // TSemestre1
            // 
            this.TSemestre1.Location = new System.Drawing.Point(191, 98);
            this.TSemestre1.Name = "TSemestre1";
            this.TSemestre1.Size = new System.Drawing.Size(100, 30);
            this.TSemestre1.TabIndex = 5;
            this.TSemestre1.TextChanged += new System.EventHandler(this.TSemestre1_TextChanged);
            // 
            // TSemestre2
            // 
            this.TSemestre2.Location = new System.Drawing.Point(191, 146);
            this.TSemestre2.Name = "TSemestre2";
            this.TSemestre2.Size = new System.Drawing.Size(100, 30);
            this.TSemestre2.TabIndex = 6;
            // 
            // TSemestre3
            // 
            this.TSemestre3.Location = new System.Drawing.Point(191, 190);
            this.TSemestre3.Name = "TSemestre3";
            this.TSemestre3.Size = new System.Drawing.Size(100, 30);
            this.TSemestre3.TabIndex = 7;
            // 
            // TPromedioG
            // 
            this.TPromedioG.Location = new System.Drawing.Point(333, 315);
            this.TPromedioG.Name = "TPromedioG";
            this.TPromedioG.Size = new System.Drawing.Size(100, 30);
            this.TPromedioG.TabIndex = 8;
            // 
            // BCalcular
            // 
            this.BCalcular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BCalcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCalcular.Location = new System.Drawing.Point(123, 235);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(168, 34);
            this.BCalcular.TabIndex = 9;
            this.BCalcular.Text = "Calcular Promedio";
            this.BCalcular.UseVisualStyleBackColor = false;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(333, 359);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(100, 32);
            this.BLimpiar.TabIndex = 10;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(423, 498);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(113, 38);
            this.BSalir.TabIndex = 11;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Laboratorio122
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(545, 543);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.TPromedioG);
            this.Controls.Add(this.TSemestre3);
            this.Controls.Add(this.TSemestre2);
            this.Controls.Add(this.TSemestre1);
            this.Controls.Add(this.Lpromedio);
            this.Controls.Add(this.Lsemestre3);
            this.Controls.Add(this.Lsemestre2);
            this.Controls.Add(this.Lsemestre1);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Laboratorio122";
            this.Text = "Laboratorio 12-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Lsemestre1;
        private System.Windows.Forms.Label Lsemestre2;
        private System.Windows.Forms.Label Lsemestre3;
        private System.Windows.Forms.Label Lpromedio;
        private System.Windows.Forms.TextBox TSemestre1;
        private System.Windows.Forms.TextBox TSemestre2;
        private System.Windows.Forms.TextBox TSemestre3;
        private System.Windows.Forms.TextBox TPromedioG;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSalir;
    }
}

