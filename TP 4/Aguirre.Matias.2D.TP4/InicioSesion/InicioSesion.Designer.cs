namespace InicioSesion
{
    partial class FormIngresoSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoSistema));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgLogin = new System.Windows.Forms.DataGridView();
            this.s = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chcBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quien es usted?";
            // 
            // dtgLogin
            // 
            this.dtgLogin.AllowUserToAddRows = false;
            this.dtgLogin.AllowUserToDeleteRows = false;
            this.dtgLogin.AllowUserToResizeColumns = false;
            this.dtgLogin.AllowUserToResizeRows = false;
            this.dtgLogin.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtgLogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s,
            this.nombreEmpleado,
            this.fechaDeIngreso,
            this.apellidoEmpleado,
            this.puestoEmpleado,
            this.dniEmpleado,
            this.sueldoEmpleado});
            this.dtgLogin.GridColor = System.Drawing.Color.White;
            this.dtgLogin.Location = new System.Drawing.Point(79, 117);
            this.dtgLogin.MultiSelect = false;
            this.dtgLogin.Name = "dtgLogin";
            this.dtgLogin.ReadOnly = true;
            this.dtgLogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgLogin.Size = new System.Drawing.Size(397, 274);
            this.dtgLogin.TabIndex = 3;
            this.dtgLogin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLogin_CellContentClick);
            // 
            // s
            // 
            this.s.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.s.HeaderText = "Eleccion";
            this.s.Name = "s";
            this.s.ReadOnly = true;
            this.s.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.s.Width = 54;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.DataPropertyName = "nombrePersona";
            this.nombreEmpleado.HeaderText = "Nombre";
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            this.nombreEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fechaDeIngreso
            // 
            this.fechaDeIngreso.DataPropertyName = "FechaIngreso";
            this.fechaDeIngreso.HeaderText = "Fecha de Ingreso";
            this.fechaDeIngreso.Name = "fechaDeIngreso";
            this.fechaDeIngreso.ReadOnly = true;
            this.fechaDeIngreso.Visible = false;
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.DataPropertyName = "apellidoPersona";
            this.apellidoEmpleado.HeaderText = "Apellido";
            this.apellidoEmpleado.Name = "apellidoEmpleado";
            this.apellidoEmpleado.ReadOnly = true;
            this.apellidoEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // puestoEmpleado
            // 
            this.puestoEmpleado.DataPropertyName = "puestoEmpleado";
            this.puestoEmpleado.HeaderText = "Puesto";
            this.puestoEmpleado.Name = "puestoEmpleado";
            this.puestoEmpleado.ReadOnly = true;
            this.puestoEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dniEmpleado
            // 
            this.dniEmpleado.DataPropertyName = "dniPersona";
            this.dniEmpleado.HeaderText = "DNI";
            this.dniEmpleado.Name = "dniEmpleado";
            this.dniEmpleado.ReadOnly = true;
            this.dniEmpleado.Visible = false;
            // 
            // sueldoEmpleado
            // 
            this.sueldoEmpleado.DataPropertyName = "sueldoEmpleado";
            this.sueldoEmpleado.HeaderText = "Sueldo";
            this.sueldoEmpleado.Name = "sueldoEmpleado";
            this.sueldoEmpleado.ReadOnly = true;
            this.sueldoEmpleado.Visible = false;
            // 
            // chcBox
            // 
            this.chcBox.Location = new System.Drawing.Point(0, 0);
            this.chcBox.Name = "chcBox";
            this.chcBox.Size = new System.Drawing.Size(104, 24);
            this.chcBox.TabIndex = 0;
            // 
            // FormIngresoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(570, 460);
            this.Controls.Add(this.dtgLogin);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormIngresoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.FormIngresoSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLogin;
        private System.Windows.Forms.CheckBox chcBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmpleado;
    }
}

