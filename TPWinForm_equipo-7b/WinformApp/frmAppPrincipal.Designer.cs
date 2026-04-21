namespace WinformApp
{
    partial class frmAppPrincipal
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
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pcbxArticulos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(26, 58);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(650, 232);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulo_CellContentClick);
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pcbxArticulos
            // 
            this.pcbxArticulos.Location = new System.Drawing.Point(734, 58);
            this.pcbxArticulos.Name = "pcbxArticulos";
            this.pcbxArticulos.Size = new System.Drawing.Size(229, 232);
            this.pcbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxArticulos.TabIndex = 1;
            this.pcbxArticulos.TabStop = false;
            this.pcbxArticulos.Click += new System.EventHandler(this.pcbxArticulos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAppPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 405);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pcbxArticulos);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "frmAppPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pcbxArticulos;
        private System.Windows.Forms.Button btnAgregar;
    }
}

