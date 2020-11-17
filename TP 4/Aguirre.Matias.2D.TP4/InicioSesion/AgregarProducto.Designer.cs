
namespace InicioSesion
{
    partial class AgregarProducto
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.cmbConexion = new System.Windows.Forms.ComboBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.lblGamer = new System.Windows.Forms.Label();
            this.lblPerifericos = new System.Windows.Forms.Label();
            this.cmbGamer = new System.Windows.Forms.ComboBox();
            this.cmbPerifericos = new System.Windows.Forms.ComboBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.cmbControl = new System.Windows.Forms.ComboBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(13, 94);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 20);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInicial.Location = new System.Drawing.Point(12, 132);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(95, 20);
            this.lblStockInicial.TabIndex = 2;
            this.lblStockInicial.Text = "Stock inicial";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 22);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(141, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 20);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            this.txtPrecio.Validated += new System.EventHandler(this.txtPrecio_Validated);
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(141, 134);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(111, 20);
            this.txtStockInicial.TabIndex = 6;
            this.txtStockInicial.Validating += new System.ComponentModel.CancelEventHandler(this.txtStockInicial_Validating);
            this.txtStockInicial.Validated += new System.EventHandler(this.txtStockInicial_Validated);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(141, 21);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(111, 21);
            this.cmbTipo.TabIndex = 7;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipo_Validating);
            this.cmbTipo.Validated += new System.EventHandler(this.cmbTipo_Validated);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(399, 313);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 37);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(247, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 37);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(480, 211);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(111, 21);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPerifericos_Validating);
            this.cmbCategoria.Validated += new System.EventHandler(this.cmbPerifericos_Validated);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(318, 212);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 20);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(141, 172);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(111, 20);
            this.txtMemoria.TabIndex = 13;
            this.txtMemoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtMemoria_Validating);
            this.txtMemoria.Validated += new System.EventHandler(this.txtMemoria_Validated);
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoria.Location = new System.Drawing.Point(13, 172);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(68, 20);
            this.lblMemoria.TabIndex = 12;
            this.lblMemoria.Text = "Memoria";
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(141, 214);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(111, 20);
            this.txtAlmacenamiento.TabIndex = 15;
            this.txtAlmacenamiento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlmacenamiento_Validating);
            this.txtAlmacenamiento.Validated += new System.EventHandler(this.txtAlmacenamiento_Validated);
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(12, 212);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(121, 20);
            this.lblAlmacenamiento.TabIndex = 14;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.Location = new System.Drawing.Point(13, 255);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(94, 20);
            this.lblConexion.TabIndex = 17;
            this.lblConexion.Text = "Conexion 5G";
            // 
            // cmbConexion
            // 
            this.cmbConexion.FormattingEnabled = true;
            this.cmbConexion.Location = new System.Drawing.Point(141, 254);
            this.cmbConexion.Name = "cmbConexion";
            this.cmbConexion.Size = new System.Drawing.Size(111, 21);
            this.cmbConexion.TabIndex = 16;
            this.cmbConexion.Validating += new System.ComponentModel.CancelEventHandler(this.cmbConexion_Validating);
            this.cmbConexion.Validated += new System.EventHandler(this.cmbConexion_Validated);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(480, 24);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(111, 20);
            this.txtPantalla.TabIndex = 19;
            this.txtPantalla.Validating += new System.ComponentModel.CancelEventHandler(this.txtPantalla_Validating);
            this.txtPantalla.Validated += new System.EventHandler(this.txtPantalla_Validated);
            // 
            // lblPantalla
            // 
            this.lblPantalla.AutoSize = true;
            this.lblPantalla.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla.Location = new System.Drawing.Point(318, 22);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Size = new System.Drawing.Size(121, 20);
            this.lblPantalla.TabIndex = 18;
            this.lblPantalla.Text = "Tamaño pantalla";
            // 
            // lblGamer
            // 
            this.lblGamer.AutoSize = true;
            this.lblGamer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamer.Location = new System.Drawing.Point(318, 62);
            this.lblGamer.Name = "lblGamer";
            this.lblGamer.Size = new System.Drawing.Size(53, 20);
            this.lblGamer.TabIndex = 20;
            this.lblGamer.Text = "Gamer";
            // 
            // lblPerifericos
            // 
            this.lblPerifericos.AutoSize = true;
            this.lblPerifericos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerifericos.Location = new System.Drawing.Point(318, 97);
            this.lblPerifericos.Name = "lblPerifericos";
            this.lblPerifericos.Size = new System.Drawing.Size(86, 20);
            this.lblPerifericos.TabIndex = 22;
            this.lblPerifericos.Text = "Perifericos";
            // 
            // cmbGamer
            // 
            this.cmbGamer.FormattingEnabled = true;
            this.cmbGamer.Location = new System.Drawing.Point(480, 61);
            this.cmbGamer.Name = "cmbGamer";
            this.cmbGamer.Size = new System.Drawing.Size(111, 21);
            this.cmbGamer.TabIndex = 23;
            this.cmbGamer.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGamer_Validating);
            this.cmbGamer.Validated += new System.EventHandler(this.cmbGamer_Validated);
            // 
            // cmbPerifericos
            // 
            this.cmbPerifericos.FormattingEnabled = true;
            this.cmbPerifericos.Location = new System.Drawing.Point(480, 97);
            this.cmbPerifericos.Name = "cmbPerifericos";
            this.cmbPerifericos.Size = new System.Drawing.Size(111, 21);
            this.cmbPerifericos.TabIndex = 24;
            this.cmbPerifericos.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCategoria_Validating);
            this.cmbPerifericos.Validated += new System.EventHandler(this.cmbCategoria_Validated);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(480, 172);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(111, 20);
            this.txtPotencia.TabIndex = 26;
            this.txtPotencia.Validating += new System.ComponentModel.CancelEventHandler(this.txtPotencia_Validating);
            this.txtPotencia.Validated += new System.EventHandler(this.txtPotencia_Validated);
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.Location = new System.Drawing.Point(318, 172);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(68, 20);
            this.lblPotencia.TabIndex = 25;
            this.lblPotencia.Text = "Potencia";
            // 
            // cmbControl
            // 
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Location = new System.Drawing.Point(480, 134);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(111, 21);
            this.cmbControl.TabIndex = 28;
            this.cmbControl.Validating += new System.ComponentModel.CancelEventHandler(this.cmbControl_Validating);
            this.cmbControl.Validated += new System.EventHandler(this.cmbControl_Validated);
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(318, 135);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(117, 20);
            this.lblControl.TabIndex = 27;
            this.lblControl.Text = "Control incluido";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(757, 362);
            this.Controls.Add(this.cmbControl);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.cmbPerifericos);
            this.Controls.Add(this.cmbGamer);
            this.Controls.Add(this.lblPerifericos);
            this.Controls.Add(this.lblGamer);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.lblPantalla);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.cmbConexion);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.txtMemoria);
            this.Controls.Add(this.lblMemoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtStockInicial);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblStockInicial);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.ComboBox cmbConexion;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.Label lblGamer;
        private System.Windows.Forms.Label lblPerifericos;
        private System.Windows.Forms.ComboBox cmbGamer;
        private System.Windows.Forms.ComboBox cmbPerifericos;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.ComboBox cmbControl;
        private System.Windows.Forms.Label lblControl;
    }
}