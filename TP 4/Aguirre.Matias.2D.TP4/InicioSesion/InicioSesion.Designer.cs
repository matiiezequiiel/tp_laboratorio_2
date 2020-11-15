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
            this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chcBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.apellidoEmpleado,
            this.legajoEmpleado,
            this.dniEmpleado,
            this.Fecha,
            this.Sueldo,
            this.Nacionalidad,
            this.Sexo});
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
            this.nombreEmpleado.DataPropertyName = "Nombre";
            this.nombreEmpleado.HeaderText = "Nombre";
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            this.nombreEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.DataPropertyName = "Apellido";
            this.apellidoEmpleado.HeaderText = "Apellido";
            this.apellidoEmpleado.Name = "apellidoEmpleado";
            this.apellidoEmpleado.ReadOnly = true;
            this.apellidoEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // legajoEmpleado
            // 
            this.legajoEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.legajoEmpleado.DataPropertyName = "Legajo";
            this.legajoEmpleado.HeaderText = "Legajo";
            this.legajoEmpleado.Name = "legajoEmpleado";
            this.legajoEmpleado.ReadOnly = true;
            this.legajoEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.legajoEmpleado.Width = 64;
            // 
            // dniEmpleado
            // 
            this.dniEmpleado.DataPropertyName = "DNI";
            this.dniEmpleado.HeaderText = "DNI";
            this.dniEmpleado.Name = "dniEmpleado";
            this.dniEmpleado.ReadOnly = true;
            this.dniEmpleado.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha Ingreso";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // Sueldo
            // 
            this.Sueldo.DataPropertyName = "Sueldo";
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            this.Sueldo.Visible = false;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Visible = false;
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
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(570, 460);
            this.Controls.Add(this.dtgLogin);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormIngresoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de ventas";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
    }
}

