namespace Laboratorio12_1
{
    partial class FLaboratorio121
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
            this.TITULO = new System.Windows.Forms.Label();
            this.LVelocidad = new System.Windows.Forms.Label();
            this.LDuracion = new System.Windows.Forms.Label();
            this.LDistancia = new System.Windows.Forms.Label();
            this.TVelocidad = new System.Windows.Forms.TextBox();
            this.TDuracion = new System.Windows.Forms.TextBox();
            this.TDistancia = new System.Windows.Forms.TextBox();
            this.BCalcular = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.Location = new System.Drawing.Point(41, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(438, 31);
            this.TITULO.TabIndex = 0;
            this.TITULO.Text = "Calculadora de Distancia Recorrida";
            // 
            // LVelocidad
            // 
            this.LVelocidad.AutoSize = true;
            this.LVelocidad.Location = new System.Drawing.Point(32, 72);
            this.LVelocidad.Name = "LVelocidad";
            this.LVelocidad.Size = new System.Drawing.Size(218, 22);
            this.LVelocidad.TabIndex = 1;
            this.LVelocidad.Text = "Velocidad Del Automovil:";
            // 
            // LDuracion
            // 
            this.LDuracion.AutoSize = true;
            this.LDuracion.Location = new System.Drawing.Point(32, 123);
            this.LDuracion.Name = "LDuracion";
            this.LDuracion.Size = new System.Drawing.Size(209, 22);
            this.LDuracion.TabIndex = 2;
            this.LDuracion.Text = "Duracion Del Recorrido:";
            // 
            // LDistancia
            // 
            this.LDistancia.AutoSize = true;
            this.LDistancia.Location = new System.Drawing.Point(32, 268);
            this.LDistancia.Name = "LDistancia";
            this.LDistancia.Size = new System.Drawing.Size(137, 22);
            this.LDistancia.TabIndex = 3;
            this.LDistancia.Text = "Distancia Total:";
            // 
            // TVelocidad
            // 
            this.TVelocidad.Location = new System.Drawing.Point(228, 69);
            this.TVelocidad.Name = "TVelocidad";
            this.TVelocidad.Size = new System.Drawing.Size(100, 30);
            this.TVelocidad.TabIndex = 4;
            // 
            // TDuracion
            // 
            this.TDuracion.Location = new System.Drawing.Point(228, 123);
            this.TDuracion.Name = "TDuracion";
            this.TDuracion.Size = new System.Drawing.Size(100, 30);
            this.TDuracion.TabIndex = 5;
            // 
            // TDistancia
            // 
            this.TDistancia.Location = new System.Drawing.Point(228, 268);
            this.TDistancia.Name = "TDistancia";
            this.TDistancia.Size = new System.Drawing.Size(100, 30);
            this.TDistancia.TabIndex = 6;
            // 
            // BCalcular
            // 
            this.BCalcular.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BCalcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCalcular.Location = new System.Drawing.Point(155, 172);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(173, 34);
            this.BCalcular.TabIndex = 7;
            this.BCalcular.Text = "Calcular Distancia";
            this.BCalcular.UseVisualStyleBackColor = false;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(215, 310);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(113, 34);
            this.BLimpiar.TabIndex = 8;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(277, 466);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(119, 35);
            this.BSalir.TabIndex = 9;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // FLaboratorio121
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(408, 513);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.TDistancia);
            this.Controls.Add(this.TDuracion);
            this.Controls.Add(this.TVelocidad);
            this.Controls.Add(this.LDistancia);
            this.Controls.Add(this.LDuracion);
            this.Controls.Add(this.LVelocidad);
            this.Controls.Add(this.TITULO);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FLaboratorio121";
            this.Text = "Laboratorio 12-1";
            this.Load += new System.EventHandler(this.FLaboratorio121_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXVelocidad;
        private System.Windows.Forms.Label TXDuracion;
        private System.Windows.Forms.Label TXDistancia;
        private System.Windows.Forms.TextBox TBVelocidad;
        private System.Windows.Forms.TextBox TBDuracion;
        private System.Windows.Forms.TextBox TBDistancia;
        private System.Windows.Forms.Button BuTCalcular;
        private System.Windows.Forms.Button BuTSalir;
        private System.Windows.Forms.Button BuTLimpiar;
        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Label LVelocidad;
        private System.Windows.Forms.Label LDuracion;
        private System.Windows.Forms.Label LDistancia;
        private System.Windows.Forms.TextBox TVelocidad;
        private System.Windows.Forms.TextBox TDuracion;
        private System.Windows.Forms.TextBox TDistancia;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSalir;
    }
}

