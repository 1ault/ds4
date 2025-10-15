namespace Laboratorio13
{
    partial class Laboratorio13
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
            this.TituloLAB = new System.Windows.Forms.Label();
            this.Conexion = new System.Windows.Forms.Button();
            this.ListProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TituloLAB
            // 
            this.TituloLAB.AutoSize = true;
            this.TituloLAB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLAB.Location = new System.Drawing.Point(54, 9);
            this.TituloLAB.Name = "TituloLAB";
            this.TituloLAB.Size = new System.Drawing.Size(358, 26);
            this.TituloLAB.TabIndex = 0;
            this.TituloLAB.Text = "Integracion  De Base De Datos C#";
            // 
            // Conexion
            // 
            this.Conexion.BackColor = System.Drawing.Color.SeaGreen;
            this.Conexion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conexion.Location = new System.Drawing.Point(104, 106);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(260, 103);
            this.Conexion.TabIndex = 1;
            this.Conexion.Text = "Conectar y  Desconectar SQL Server";
            this.Conexion.UseVisualStyleBackColor = false;
            this.Conexion.Click += new System.EventHandler(this.Conexion_Click);
            // 
            // ListProductos
            // 
            this.ListProductos.FormattingEnabled = true;
            this.ListProductos.Location = new System.Drawing.Point(104, 237);
            this.ListProductos.Name = "ListProductos";
            this.ListProductos.Size = new System.Drawing.Size(260, 225);
            this.ListProductos.TabIndex = 2;
            // 
            // Laboratorio13
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 490);
            this.Controls.Add(this.ListProductos);
            this.Controls.Add(this.Conexion);
            this.Controls.Add(this.TituloLAB);
            this.Name = "Laboratorio13";
            this.Text = "Laboratorio13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button ConectarDesconectar;
        private System.Windows.Forms.Label TituloLAB;
        private System.Windows.Forms.Button Conexion;
        private System.Windows.Forms.ListBox ListProductos;
    }
}

