
namespace InicioSesion
{
    partial class VentasRealizadas
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
            this.lsvVentas = new System.Windows.Forms.ListView();
            this.columnaComprador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaVendedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvProductos = new System.Windows.Forms.ListView();
            this.columnaPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvVentas
            // 
            this.lsvVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsvVentas.CheckBoxes = true;
            this.lsvVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaComprador,
            this.columnaVendedor,
            this.columnaTicket});
            this.lsvVentas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvVentas.FullRowSelect = true;
            this.lsvVentas.GridLines = true;
            this.lsvVentas.HideSelection = false;
            this.lsvVentas.Location = new System.Drawing.Point(12, 65);
            this.lsvVentas.MultiSelect = false;
            this.lsvVentas.Name = "lsvVentas";
            this.lsvVentas.Size = new System.Drawing.Size(409, 287);
            this.lsvVentas.TabIndex = 0;
            this.lsvVentas.UseCompatibleStateImageBehavior = false;
            this.lsvVentas.View = System.Windows.Forms.View.Details;
            this.lsvVentas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvVentas_ItemCheck);
            // 
            // columnaComprador
            // 
            this.columnaComprador.Text = "Comprador";
            this.columnaComprador.Width = 96;
            // 
            // columnaVendedor
            // 
            this.columnaVendedor.Text = "Vendedor";
            this.columnaVendedor.Width = 104;
            // 
            // columnaTicket
            // 
            this.columnaTicket.Text = "Numero de Ticket";
            this.columnaTicket.Width = 122;
            // 
            // lsvProductos
            // 
            this.lsvProductos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaProducto,
            this.columnaPrecio,
            this.columnaCodigo});
            this.lsvProductos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvProductos.FullRowSelect = true;
            this.lsvProductos.GridLines = true;
            this.lsvProductos.HideSelection = false;
            this.lsvProductos.Location = new System.Drawing.Point(467, 65);
            this.lsvProductos.MultiSelect = false;
            this.lsvProductos.Name = "lsvProductos";
            this.lsvProductos.Size = new System.Drawing.Size(296, 287);
            this.lsvProductos.TabIndex = 2;
            this.lsvProductos.UseCompatibleStateImageBehavior = false;
            this.lsvProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnaPrecio
            // 
            this.columnaPrecio.DisplayIndex = 1;
            this.columnaPrecio.Text = "Precio";
            // 
            // columnaProducto
            // 
            this.columnaProducto.DisplayIndex = 0;
            this.columnaProducto.Text = "Producto";
            this.columnaProducto.Width = 91;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.Text = "Codigo";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(604, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 48);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lsvProductos);
            this.Controls.Add(this.lsvVentas);
            this.Name = "VentasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas realizadas";
            this.Load += new System.EventHandler(this.VentasRealizadas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvVentas;
        private System.Windows.Forms.ListView lsvProductos;
        private System.Windows.Forms.ColumnHeader columnaComprador;
        private System.Windows.Forms.ColumnHeader columnaVendedor;
        private System.Windows.Forms.ColumnHeader columnaProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnaTicket;
        private System.Windows.Forms.ColumnHeader columnaPrecio;
        private System.Windows.Forms.ColumnHeader columnaCodigo;
    }
}