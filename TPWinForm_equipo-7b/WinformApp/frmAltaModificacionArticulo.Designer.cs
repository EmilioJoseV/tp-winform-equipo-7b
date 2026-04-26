namespace WinformApp
{
    partial class frmAltaModificacionArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagUrl = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.cmbxMarca = new System.Windows.Forms.ComboBox();
            this.cmbxCategoria = new System.Windows.Forms.ComboBox();
            this.pcbxImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblImagenesCargadas = new System.Windows.Forms.Label();
            this.listboxImagenesUrl = new System.Windows.Forms.ListBox();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.btnVistaPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(54, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(39, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(57, 172);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(50, 206);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblImagUrl
            // 
            this.lblImagUrl.AutoSize = true;
            this.lblImagUrl.Location = new System.Drawing.Point(39, 287);
            this.lblImagUrl.Name = "lblImagUrl";
            this.lblImagUrl.Size = new System.Drawing.Size(58, 13);
            this.lblImagUrl.TabIndex = 3;
            this.lblImagUrl.Text = "ImagenUrl:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(57, 246);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(582, 557);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(697, 557);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(131, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(354, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 126);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(354, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(131, 243);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(354, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(131, 284);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(354, 20);
            this.txtImagenUrl.TabIndex = 14;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // cmbxMarca
            // 
            this.cmbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMarca.FormattingEnabled = true;
            this.cmbxMarca.Location = new System.Drawing.Point(131, 172);
            this.cmbxMarca.Name = "cmbxMarca";
            this.cmbxMarca.Size = new System.Drawing.Size(354, 21);
            this.cmbxMarca.TabIndex = 16;
            // 
            // cmbxCategoria
            // 
            this.cmbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCategoria.FormattingEnabled = true;
            this.cmbxCategoria.Location = new System.Drawing.Point(131, 206);
            this.cmbxCategoria.Name = "cmbxCategoria";
            this.cmbxCategoria.Size = new System.Drawing.Size(354, 21);
            this.cmbxCategoria.TabIndex = 17;
            // 
            // pcbxImagen
            // 
            this.pcbxImagen.Location = new System.Drawing.Point(808, 47);
            this.pcbxImagen.Name = "pcbxImagen";
            this.pcbxImagen.Size = new System.Drawing.Size(262, 253);
            this.pcbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxImagen.TabIndex = 18;
            this.pcbxImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(582, 284);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(108, 24);
            this.btnAgregarImagen.TabIndex = 19;
            this.btnAgregarImagen.Text = "Agregar imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblImagenesCargadas
            // 
            this.lblImagenesCargadas.AutoSize = true;
            this.lblImagenesCargadas.Location = new System.Drawing.Point(197, 342);
            this.lblImagenesCargadas.Name = "lblImagenesCargadas";
            this.lblImagenesCargadas.Size = new System.Drawing.Size(100, 13);
            this.lblImagenesCargadas.TabIndex = 20;
            this.lblImagenesCargadas.Text = "Imagenes cargadas";
            // 
            // listboxImagenesUrl
            // 
            this.listboxImagenesUrl.FormattingEnabled = true;
            this.listboxImagenesUrl.Location = new System.Drawing.Point(34, 369);
            this.listboxImagenesUrl.Name = "listboxImagenesUrl";
            this.listboxImagenesUrl.Size = new System.Drawing.Size(451, 147);
            this.listboxImagenesUrl.TabIndex = 21;
            this.listboxImagenesUrl.SelectedIndexChanged += new System.EventHandler(this.listboxImagenesUrl_SelectedIndexChanged);
            // 
            // btnQuitarImagen
            // 
            this.btnQuitarImagen.Location = new System.Drawing.Point(42, 527);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(212, 24);
            this.btnQuitarImagen.TabIndex = 22;
            this.btnQuitarImagen.Text = "Borrar imagen";
            this.btnQuitarImagen.UseVisualStyleBackColor = true;
            this.btnQuitarImagen.Click += new System.EventHandler(this.btnQuitarImagen_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(273, 527);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(212, 24);
            this.btnVistaPrevia.TabIndex = 23;
            this.btnVistaPrevia.Text = "Ver imagen";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            // 
            // btnVistaPrev
            // 
            this.btnVistaPrev.Location = new System.Drawing.Point(491, 284);
            this.btnVistaPrev.Name = "btnVistaPrev";
            this.btnVistaPrev.Size = new System.Drawing.Size(85, 24);
            this.btnVistaPrev.TabIndex = 24;
            this.btnVistaPrev.Text = "Vista previa";
            this.btnVistaPrev.UseVisualStyleBackColor = true;
            this.btnVistaPrev.Click += new System.EventHandler(this.btnVistaPrev_Click);
            // 
            // frmAltaModificacionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 625);
            this.Controls.Add(this.btnVistaPrev);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.btnQuitarImagen);
            this.Controls.Add(this.listboxImagenesUrl);
            this.Controls.Add(this.lblImagenesCargadas);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pcbxImagen);
            this.Controls.Add(this.cmbxCategoria);
            this.Controls.Add(this.cmbxMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblImagUrl);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAltaModificacionArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta / Modificacion de Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.ComboBox cmbxMarca;
        private System.Windows.Forms.ComboBox cmbxCategoria;
        private System.Windows.Forms.PictureBox pcbxImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblImagenesCargadas;
        private System.Windows.Forms.ListBox listboxImagenesUrl;
        private System.Windows.Forms.Button btnQuitarImagen;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Button btnVistaPrev;
    }
}