namespace InicioSesion
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDelNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoConMenosDe10UnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lsvProductos = new System.Windows.Forms.ListView();
            this.nombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precioProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lsvCarrito = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblEmpleadoLogeado = new System.Windows.Forms.Label();
            this.txtEmpleadoLogeado = new System.Windows.Forms.TextBox();
            this.btnDetalleEmpleado = new System.Windows.Forms.Button();
            this.menuCliente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.menuCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.gestionDelNegocioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem});
            this.mToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.mToolStripMenuItem.Text = "Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva compra";
            this.nuevaCompraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompraToolStripMenuItem_Click);
            // 
            // gestionDelNegocioToolStripMenuItem
            // 
            this.gestionDelNegocioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadosToolStripMenuItem,
            this.altaProductoToolStripMenuItem});
            this.gestionDelNegocioToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDelNegocioToolStripMenuItem.Name = "gestionDelNegocioToolStripMenuItem";
            this.gestionDelNegocioToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gestionDelNegocioToolStripMenuItem.Text = "Gestion del negocio";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDeProductosToolStripMenuItem,
            this.comprasPorEmpleadoToolStripMenuItem,
            this.productoConMenosDe10UnidadesToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // stockDeProductosToolStripMenuItem
            // 
            this.stockDeProductosToolStripMenuItem.Name = "stockDeProductosToolStripMenuItem";
            this.stockDeProductosToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.stockDeProductosToolStripMenuItem.Text = "Stock de productos";
            // 
            // comprasPorEmpleadoToolStripMenuItem
            // 
            this.comprasPorEmpleadoToolStripMenuItem.Name = "comprasPorEmpleadoToolStripMenuItem";
            this.comprasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.comprasPorEmpleadoToolStripMenuItem.Text = "Compras por empleado";
            // 
            // productoConMenosDe10UnidadesToolStripMenuItem
            // 
            this.productoConMenosDe10UnidadesToolStripMenuItem.Name = "productoConMenosDe10UnidadesToolStripMenuItem";
            this.productoConMenosDe10UnidadesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.productoConMenosDe10UnidadesToolStripMenuItem.Text = "Producto con menos de 10 unidades";
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaProductoToolStripMenuItem.Text = "Alta Producto";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lsvClientes
            // 
            this.lsvClientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lsvClientes.CheckBoxes = true;
            this.lsvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lsvClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsvClientes.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvClientes.FullRowSelect = true;
            this.lsvClientes.GridLines = true;
            this.lsvClientes.HideSelection = false;
            this.lsvClientes.Location = new System.Drawing.Point(45, 101);
            this.lsvClientes.Name = "lsvClientes";
            this.lsvClientes.Size = new System.Drawing.Size(151, 253);
            this.lsvClientes.TabIndex = 3;
            this.lsvClientes.UseCompatibleStateImageBehavior = false;
            this.lsvClientes.View = System.Windows.Forms.View.Details;
            this.lsvClientes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvClientes_ItemCheck);
            this.lsvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvClientes_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nro Cliente";
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(68, 80);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(107, 18);
            this.lblListaClientes.TabIndex = 4;
            this.lblListaClientes.Text = "Lista de clientes";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.Location = new System.Drawing.Point(269, 80);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(120, 18);
            this.lblListaProductos.TabIndex = 5;
            this.lblListaProductos.Text = "Lista de productos";
            // 
            // lsvProductos
            // 
            this.lsvProductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lsvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreProducto,
            this.stockProducto,
            this.precioProducto});
            this.lsvProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsvProductos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvProductos.FullRowSelect = true;
            this.lsvProductos.GridLines = true;
            this.lsvProductos.HideSelection = false;
            this.lsvProductos.Location = new System.Drawing.Point(221, 101);
            this.lsvProductos.Name = "lsvProductos";
            this.lsvProductos.Size = new System.Drawing.Size(231, 253);
            this.lsvProductos.TabIndex = 6;
            this.lsvProductos.UseCompatibleStateImageBehavior = false;
            this.lsvProductos.View = System.Windows.Forms.View.Details;
            this.lsvProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsvProductos_MouseDown);
            // 
            // nombreProducto
            // 
            this.nombreProducto.Text = "Producto";
            this.nombreProducto.Width = 90;
            // 
            // stockProducto
            // 
            this.stockProducto.Text = "Stock";
            this.stockProducto.Width = 49;
            // 
            // precioProducto
            // 
            this.precioProducto.Text = "Precio";
            this.precioProducto.Width = 80;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(486, 80);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(123, 18);
            this.lblCarrito.TabIndex = 7;
            this.lblCarrito.Text = "Carrito de compras";
            // 
            // lsvCarrito
            // 
            this.lsvCarrito.AllowDrop = true;
            this.lsvCarrito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lsvCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lsvCarrito.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCarrito.GridLines = true;
            this.lsvCarrito.HideSelection = false;
            this.lsvCarrito.Location = new System.Drawing.Point(470, 101);
            this.lsvCarrito.MultiSelect = false;
            this.lsvCarrito.Name = "lsvCarrito";
            this.lsvCarrito.Size = new System.Drawing.Size(151, 253);
            this.lsvCarrito.TabIndex = 8;
            this.lsvCarrito.UseCompatibleStateImageBehavior = false;
            this.lsvCarrito.View = System.Windows.Forms.View.Details;
            this.lsvCarrito.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsvCarrito_DragDrop);
            this.lsvCarrito.DragOver += new System.Windows.Forms.DragEventHandler(this.lsvCarrito_DragOver);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Productos seleccionados";
            this.columnHeader3.Width = 144;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(45, 360);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(151, 50);
            this.btnNuevoCliente.TabIndex = 9;
            this.btnNuevoCliente.Text = "INGRESAR NUEVO CLIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarCarrito.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarCarrito.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(627, 161);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(146, 50);
            this.btnVaciarCarrito.TabIndex = 10;
            this.btnVaciarCarrito.Text = "VACIAR CARRITO";
            this.btnVaciarCarrito.UseVisualStyleBackColor = true;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.Location = new System.Drawing.Point(627, 217);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(146, 48);
            this.btnConfirmarCompra.TabIndex = 11;
            this.btnConfirmarCompra.Text = "CONFIRMAR COMPRA";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(476, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 18);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(547, 368);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 19);
            this.lblTotalCompra.TabIndex = 14;
            // 
            // lblEmpleadoLogeado
            // 
            this.lblEmpleadoLogeado.AutoSize = true;
            this.lblEmpleadoLogeado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoLogeado.Location = new System.Drawing.Point(12, 37);
            this.lblEmpleadoLogeado.Name = "lblEmpleadoLogeado";
            this.lblEmpleadoLogeado.Size = new System.Drawing.Size(69, 18);
            this.lblEmpleadoLogeado.TabIndex = 16;
            this.lblEmpleadoLogeado.Text = "Empleado:";
            // 
            // txtEmpleadoLogeado
            // 
            this.txtEmpleadoLogeado.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoLogeado.Location = new System.Drawing.Point(87, 35);
            this.txtEmpleadoLogeado.Name = "txtEmpleadoLogeado";
            this.txtEmpleadoLogeado.ReadOnly = true;
            this.txtEmpleadoLogeado.Size = new System.Drawing.Size(176, 24);
            this.txtEmpleadoLogeado.TabIndex = 17;
            // 
            // btnDetalleEmpleado
            // 
            this.btnDetalleEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleEmpleado.Location = new System.Drawing.Point(406, 38);
            this.btnDetalleEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalleEmpleado.Name = "btnDetalleEmpleado";
            this.btnDetalleEmpleado.Size = new System.Drawing.Size(82, 21);
            this.btnDetalleEmpleado.TabIndex = 19;
            this.btnDetalleEmpleado.Text = "Mas info";
            this.btnDetalleEmpleado.UseVisualStyleBackColor = true;
            this.btnDetalleEmpleado.Click += new System.EventHandler(this.btnDetalleEmpleado_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(132, 26);
            this.menuCliente.Text = "Mas datos.";
            this.menuCliente.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem1.Text = "Mas datos.";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(278, 37);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(52, 18);
            this.lblLegajo.TabIndex = 20;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.Location = new System.Drawing.Point(336, 35);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(43, 24);
            this.txtLegajo.TabIndex = 21;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.btnDetalleEmpleado);
            this.Controls.Add(this.txtEmpleadoLogeado);
            this.Controls.Add(this.lblEmpleadoLogeado);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.btnVaciarCarrito);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.lsvCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lsvProductos);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.lsvClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionDelNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListView lsvClientes;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.ListView lsvProductos;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.ListView lsvCarrito;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.ColumnHeader nombreProducto;
        private System.Windows.Forms.ColumnHeader stockProducto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader precioProducto;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoConMenosDe10UnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.Label lblEmpleadoLogeado;
        public System.Windows.Forms.TextBox txtEmpleadoLogeado;
        private System.Windows.Forms.Button btnDetalleEmpleado;
        private System.Windows.Forms.ContextMenuStrip menuCliente;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblLegajo;
        public System.Windows.Forms.TextBox txtLegajo;
    }
}