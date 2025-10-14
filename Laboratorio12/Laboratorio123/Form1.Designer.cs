namespace Laboratorio_12_3
{
    partial class Laboratorio123
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
            this.LLadoA = new System.Windows.Forms.Label();
            this.LLadoB = new System.Windows.Forms.Label();
            this.LLadoC = new System.Windows.Forms.Label();
            this.TLadoA = new System.Windows.Forms.TextBox();
            this.TLadoB = new System.Windows.Forms.TextBox();
            this.TLadoC = new System.Windows.Forms.TextBox();
            this.BCSPerimetro = new System.Windows.Forms.Button();
            this.BCArea = new System.Windows.Forms.Button();
            this.LSemiperimetro = new System.Windows.Forms.Label();
            this.LArea = new System.Windows.Forms.Label();
            this.TSemiperimetro = new System.Windows.Forms.TextBox();
            this.TArea = new System.Windows.Forms.TextBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(638, 31);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Calculadora De Area y Semiperimetro Del  Triangulo";
            // 
            // LLadoA
            // 
            this.LLadoA.AutoSize = true;
            this.LLadoA.Location = new System.Drawing.Point(73, 84);
            this.LLadoA.Name = "LLadoA";
            this.LLadoA.Size = new System.Drawing.Size(91, 22);
            this.LLadoA.TabIndex = 1;
            this.LLadoA.Text = "Lado \"A\":";
            // 
            // LLadoB
            // 
            this.LLadoB.AutoSize = true;
            this.LLadoB.Location = new System.Drawing.Point(73, 123);
            this.LLadoB.Name = "LLadoB";
            this.LLadoB.Size = new System.Drawing.Size(90, 22);
            this.LLadoB.TabIndex = 2;
            this.LLadoB.Text = "Lado \"B\":";
            // 
            // LLadoC
            // 
            this.LLadoC.AutoSize = true;
            this.LLadoC.Location = new System.Drawing.Point(73, 155);
            this.LLadoC.Name = "LLadoC";
            this.LLadoC.Size = new System.Drawing.Size(90, 22);
            this.LLadoC.TabIndex = 3;
            this.LLadoC.Text = "Lado \"C\":";
            // 
            // TLadoA
            // 
            this.TLadoA.Location = new System.Drawing.Point(148, 81);
            this.TLadoA.Name = "TLadoA";
            this.TLadoA.Size = new System.Drawing.Size(100, 30);
            this.TLadoA.TabIndex = 4;
            // 
            // TLadoB
            // 
            this.TLadoB.Location = new System.Drawing.Point(147, 116);
            this.TLadoB.Name = "TLadoB";
            this.TLadoB.Size = new System.Drawing.Size(100, 30);
            this.TLadoB.TabIndex = 5;
            // 
            // TLadoC
            // 
            this.TLadoC.Location = new System.Drawing.Point(147, 152);
            this.TLadoC.Name = "TLadoC";
            this.TLadoC.Size = new System.Drawing.Size(100, 30);
            this.TLadoC.TabIndex = 6;
            // 
            // BCSPerimetro
            // 
            this.BCSPerimetro.BackColor = System.Drawing.Color.SeaGreen;
            this.BCSPerimetro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCSPerimetro.Location = new System.Drawing.Point(29, 198);
            this.BCSPerimetro.Name = "BCSPerimetro";
            this.BCSPerimetro.Size = new System.Drawing.Size(190, 34);
            this.BCSPerimetro.TabIndex = 7;
            this.BCSPerimetro.Text = "Calcular Semiperimetro";
            this.BCSPerimetro.UseVisualStyleBackColor = false;
            this.BCSPerimetro.Click += new System.EventHandler(this.BCSPerimetro_Click);
            // 
            // BCArea
            // 
            this.BCArea.BackColor = System.Drawing.Color.SeaGreen;
            this.BCArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCArea.Location = new System.Drawing.Point(237, 198);
            this.BCArea.Name = "BCArea";
            this.BCArea.Size = new System.Drawing.Size(131, 34);
            this.BCArea.TabIndex = 8;
            this.BCArea.Text = "Calcular Area";
            this.BCArea.UseVisualStyleBackColor = false;
            this.BCArea.Click += new System.EventHandler(this.BCArea_Click);
            // 
            // LSemiperimetro
            // 
            this.LSemiperimetro.AutoSize = true;
            this.LSemiperimetro.Location = new System.Drawing.Point(73, 297);
            this.LSemiperimetro.Name = "LSemiperimetro";
            this.LSemiperimetro.Size = new System.Drawing.Size(133, 22);
            this.LSemiperimetro.TabIndex = 9;
            this.LSemiperimetro.Text = "Semiperimetro:";
            // 
            // LArea
            // 
            this.LArea.AutoSize = true;
            this.LArea.Location = new System.Drawing.Point(131, 340);
            this.LArea.Name = "LArea";
            this.LArea.Size = new System.Drawing.Size(55, 22);
            this.LArea.TabIndex = 10;
            this.LArea.Text = "Area:";
            // 
            // TSemiperimetro
            // 
            this.TSemiperimetro.Location = new System.Drawing.Point(180, 295);
            this.TSemiperimetro.Name = "TSemiperimetro";
            this.TSemiperimetro.Size = new System.Drawing.Size(100, 30);
            this.TSemiperimetro.TabIndex = 11;
            // 
            // TArea
            // 
            this.TArea.Location = new System.Drawing.Point(179, 337);
            this.TArea.Name = "TArea";
            this.TArea.Size = new System.Drawing.Size(100, 30);
            this.TArea.TabIndex = 12;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.BLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(174, 382);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(105, 31);
            this.BLimpiar.TabIndex = 13;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.BSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(372, 496);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(114, 34);
            this.BSalir.TabIndex = 14;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Laboratorio123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(498, 542);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.TArea);
            this.Controls.Add(this.TSemiperimetro);
            this.Controls.Add(this.LArea);
            this.Controls.Add(this.LSemiperimetro);
            this.Controls.Add(this.BCArea);
            this.Controls.Add(this.BCSPerimetro);
            this.Controls.Add(this.TLadoC);
            this.Controls.Add(this.TLadoB);
            this.Controls.Add(this.TLadoA);
            this.Controls.Add(this.LLadoC);
            this.Controls.Add(this.LLadoB);
            this.Controls.Add(this.LLadoA);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Laboratorio123";
            this.Text = "Laboratorio123";
            this.Load += new System.EventHandler(this.Laboratorio123_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label LLadoA;
        private System.Windows.Forms.Label LLadoB;
        private System.Windows.Forms.Label LLadoC;
        private System.Windows.Forms.TextBox TLadoA;
        private System.Windows.Forms.TextBox TLadoB;
        private System.Windows.Forms.TextBox TLadoC;
        private System.Windows.Forms.Button BCSPerimetro;
        private System.Windows.Forms.Button BCArea;
        private System.Windows.Forms.Label LSemiperimetro;
        private System.Windows.Forms.Label LArea;
        private System.Windows.Forms.TextBox TSemiperimetro;
        private System.Windows.Forms.TextBox TArea;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSalir;
    }
}

