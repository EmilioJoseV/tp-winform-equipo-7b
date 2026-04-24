namespace WinformApp
{
    partial class frmDetalleArticulo
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
            System.Windows.Forms.Label lblDescripcion;
            System.Windows.Forms.Label lblCodigo;
            System.Windows.Forms.Label lblNombre;
            System.Windows.Forms.Label lblMarca;
            System.Windows.Forms.Label lblCategoria;
            System.Windows.Forms.Label lblPrecio;
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdTexto = new System.Windows.Forms.Label();
            this.lblDescripcionTexto = new System.Windows.Forms.Label();
            this.lblCodigoTexto = new System.Windows.Forms.Label();
            this.lblNombreTexto = new System.Windows.Forms.Label();
            this.lblMarcaTexto = new System.Windows.Forms.Label();
            this.lblCategoriaTexto = new System.Windows.Forms.Label();
            this.lblPrecioTexto = new System.Windows.Forms.Label();
            this.pcbxImagenes = new System.Windows.Forms.PictureBox();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblIndiceImagenes = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            lblCodigo = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblMarca = new System.Windows.Forms.Label();
            lblCategoria = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDescripcion.Location = new System.Drawing.Point(22, 120);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(121, 24);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodigo.Location = new System.Drawing.Point(22, 64);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(77, 24);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Codigo";
            lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombre.Location = new System.Drawing.Point(22, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(85, 24);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMarca.Location = new System.Drawing.Point(22, 152);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(67, 24);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCategoria.Location = new System.Drawing.Point(22, 180);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(99, 24);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrecio.Location = new System.Drawing.Point(22, 204);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(70, 24);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(22, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 24);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblIdTexto
            // 
            this.lblIdTexto.AutoSize = true;
            this.lblIdTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTexto.Location = new System.Drawing.Point(179, 36);
            this.lblIdTexto.Name = "lblIdTexto";
            this.lblIdTexto.Size = new System.Drawing.Size(16, 24);
            this.lblIdTexto.TabIndex = 7;
            this.lblIdTexto.Text = "-";
            this.lblIdTexto.Click += new System.EventHandler(this.lblImagenes_Click);
            // 
            // lblDescripcionTexto
            // 
            this.lblDescripcionTexto.AutoSize = true;
            this.lblDescripcionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTexto.Location = new System.Drawing.Point(179, 120);
            this.lblDescripcionTexto.Name = "lblDescripcionTexto";
            this.lblDescripcionTexto.Size = new System.Drawing.Size(16, 24);
            this.lblDescripcionTexto.TabIndex = 8;
            this.lblDescripcionTexto.Text = "-";
            // 
            // lblCodigoTexto
            // 
            this.lblCodigoTexto.AutoSize = true;
            this.lblCodigoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoTexto.Location = new System.Drawing.Point(179, 64);
            this.lblCodigoTexto.Name = "lblCodigoTexto";
            this.lblCodigoTexto.Size = new System.Drawing.Size(16, 24);
            this.lblCodigoTexto.TabIndex = 9;
            this.lblCodigoTexto.Text = "-";
            // 
            // lblNombreTexto
            // 
            this.lblNombreTexto.AutoSize = true;
            this.lblNombreTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTexto.Location = new System.Drawing.Point(179, 92);
            this.lblNombreTexto.Name = "lblNombreTexto";
            this.lblNombreTexto.Size = new System.Drawing.Size(16, 24);
            this.lblNombreTexto.TabIndex = 10;
            this.lblNombreTexto.Text = "-";
            // 
            // lblMarcaTexto
            // 
            this.lblMarcaTexto.AutoSize = true;
            this.lblMarcaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaTexto.Location = new System.Drawing.Point(179, 148);
            this.lblMarcaTexto.Name = "lblMarcaTexto";
            this.lblMarcaTexto.Size = new System.Drawing.Size(16, 24);
            this.lblMarcaTexto.TabIndex = 11;
            this.lblMarcaTexto.Text = "-";
            // 
            // lblCategoriaTexto
            // 
            this.lblCategoriaTexto.AutoSize = true;
            this.lblCategoriaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaTexto.Location = new System.Drawing.Point(179, 176);
            this.lblCategoriaTexto.Name = "lblCategoriaTexto";
            this.lblCategoriaTexto.Size = new System.Drawing.Size(16, 24);
            this.lblCategoriaTexto.TabIndex = 12;
            this.lblCategoriaTexto.Text = "-";
            // 
            // lblPrecioTexto
            // 
            this.lblPrecioTexto.AutoSize = true;
            this.lblPrecioTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTexto.Location = new System.Drawing.Point(179, 204);
            this.lblPrecioTexto.Name = "lblPrecioTexto";
            this.lblPrecioTexto.Size = new System.Drawing.Size(16, 24);
            this.lblPrecioTexto.TabIndex = 13;
            this.lblPrecioTexto.Text = "-";
            // 
            // pcbxImagenes
            // 
            this.pcbxImagenes.Location = new System.Drawing.Point(440, 36);
            this.pcbxImagenes.Name = "pcbxImagenes";
            this.pcbxImagenes.Size = new System.Drawing.Size(348, 326);
            this.pcbxImagenes.TabIndex = 14;
            this.pcbxImagenes.TabStop = false;
            this.pcbxImagenes.Click += new System.EventHandler(this.pbxImagenes_Click);
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenes.Location = new System.Drawing.Point(574, 9);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(88, 20);
            this.lblImagenes.TabIndex = 15;
            this.lblImagenes.Text = "Imagenes";
            this.lblImagenes.Click += new System.EventHandler(this.lblImagenes_Click_1);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(486, 368);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(88, 27);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.Text = "Img. anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(644, 368);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(88, 27);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.Text = "Img. siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblIndiceImagenes
            // 
            this.lblIndiceImagenes.AutoSize = true;
            this.lblIndiceImagenes.Location = new System.Drawing.Point(605, 409);
            this.lblIndiceImagenes.Name = "lblIndiceImagenes";
            this.lblIndiceImagenes.Size = new System.Drawing.Size(10, 13);
            this.lblIndiceImagenes.TabIndex = 18;
            this.lblIndiceImagenes.Text = "-";
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIndiceImagenes);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblImagenes);
            this.Controls.Add(this.pcbxImagenes);
            this.Controls.Add(this.lblPrecioTexto);
            this.Controls.Add(this.lblCategoriaTexto);
            this.Controls.Add(this.lblMarcaTexto);
            this.Controls.Add(this.lblNombreTexto);
            this.Controls.Add(this.lblCodigoTexto);
            this.Controls.Add(this.lblDescripcionTexto);
            this.Controls.Add(this.lblIdTexto);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(lblCategoria);
            this.Controls.Add(lblMarca);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblCodigo);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(this.lblId);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de articulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdTexto;
        private System.Windows.Forms.Label lblDescripcionTexto;
        private System.Windows.Forms.Label lblCodigoTexto;
        private System.Windows.Forms.Label lblNombreTexto;
        private System.Windows.Forms.Label lblMarcaTexto;
        private System.Windows.Forms.Label lblCategoriaTexto;
        private System.Windows.Forms.Label lblPrecioTexto;
        private System.Windows.Forms.PictureBox pcbxImagenes;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblIndiceImagenes;
    }
}