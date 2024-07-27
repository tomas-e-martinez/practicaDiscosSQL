namespace DiscosDB_App_1
{
    partial class frmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCanciones = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(138, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 82);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(142, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de lanzamiento:";
            // 
            // lblCanciones
            // 
            this.lblCanciones.AutoSize = true;
            this.lblCanciones.Location = new System.Drawing.Point(33, 131);
            this.lblCanciones.Name = "lblCanciones";
            this.lblCanciones.Size = new System.Drawing.Size(148, 16);
            this.lblCanciones.TabIndex = 2;
            this.lblCanciones.Text = "Cantidad de canciones:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(192, 43);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(264, 22);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(192, 128);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(264, 22);
            this.txtCanciones.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.Location = new System.Drawing.Point(192, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Location = new System.Drawing.Point(366, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(77, 171);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(104, 16);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de edición:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(138, 212);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(43, 16);
            this.lblEstilo.TabIndex = 11;
            this.lblEstilo.Text = "Estilo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(192, 168);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(264, 24);
            this.cboTipo.TabIndex = 3;
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(192, 209);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(264, 24);
            this.cboEstilo.TabIndex = 4;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(96, 254);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(85, 16);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "URL Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(192, 251);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(264, 22);
            this.txtUrlImagen.TabIndex = 5;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(482, 43);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(305, 281);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 14;
            this.pbxDisco.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(192, 82);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(264, 22);
            this.dtpFecha.TabIndex = 15;
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 387);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCanciones);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}