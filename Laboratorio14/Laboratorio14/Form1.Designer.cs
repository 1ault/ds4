namespace Laboratorio12_2
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.Titulo = new System.Windows.Forms.Label();
            this.Lsemestre1 = new System.Windows.Forms.Label();
            this.Lsemestre2 = new System.Windows.Forms.Label();
            this.Lsemestre3 = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.tsbNuevo = new System.Windows.Forms.Button();
            this.tsbGuardar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbEliminar = new System.Windows.Forms.Button();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(386, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(98, 22);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = " Productos";
            // 
            // Lsemestre1
            // 
            this.Lsemestre1.AutoSize = true;
            this.Lsemestre1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsemestre1.Location = new System.Drawing.Point(193, 106);
            this.Lsemestre1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lsemestre1.Name = "Lsemestre1";
            this.Lsemestre1.Size = new System.Drawing.Size(134, 22);
            this.Lsemestre1.TabIndex = 1;
            this.Lsemestre1.Text = "Buscar Por ID:";
            // 
            // Lsemestre2
            // 
            this.Lsemestre2.AutoSize = true;
            this.Lsemestre2.Location = new System.Drawing.Point(193, 270);
            this.Lsemestre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lsemestre2.Name = "Lsemestre2";
            this.Lsemestre2.Size = new System.Drawing.Size(51, 19);
            this.Lsemestre2.TabIndex = 2;
            this.Lsemestre2.Text = "Precio:";
            // 
            // Lsemestre3
            // 
            this.Lsemestre3.Location = new System.Drawing.Point(0, 0);
            this.Lsemestre3.Name = "Lsemestre3";
            this.Lsemestre3.Size = new System.Drawing.Size(100, 23);
            this.Lsemestre3.TabIndex = 21;
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(329, 102);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(100, 26);
            this.tstId.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(197, 302);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 221);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(800, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 38);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stock:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(352, 221);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(561, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(352, 302);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(107, 26);
            this.txtStock.TabIndex = 15;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.Location = new System.Drawing.Point(13, 24);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(39, 29);
            this.tsbNuevo.TabIndex = 16;
            this.tsbNuevo.UseVisualStyleBackColor = true;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.Location = new System.Drawing.Point(12, 79);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(40, 29);
            this.tsbGuardar.TabIndex = 17;
            this.tsbGuardar.UseVisualStyleBackColor = true;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.Location = new System.Drawing.Point(12, 134);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(40, 29);
            this.tsbCancelar.TabIndex = 18;
            this.tsbCancelar.UseVisualStyleBackColor = true;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.Location = new System.Drawing.Point(12, 188);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(40, 29);
            this.tsbEliminar.TabIndex = 19;
            this.tsbEliminar.UseVisualStyleBackColor = true;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.Location = new System.Drawing.Point(435, 100);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(27, 29);
            this.tsbBuscar.TabIndex = 20;
            this.tsbBuscar.UseVisualStyleBackColor = true;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(966, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbNuevo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.Lsemestre3);
            this.Controls.Add(this.Lsemestre2);
            this.Controls.Add(this.Lsemestre1);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Text = "Laboratorio 14";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Lsemestre1;
        private System.Windows.Forms.Label Lsemestre2;
        private System.Windows.Forms.Label Lsemestre3;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button tsbNuevo;
        private System.Windows.Forms.Button tsbGuardar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbEliminar;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.Label label3;
    }
}

