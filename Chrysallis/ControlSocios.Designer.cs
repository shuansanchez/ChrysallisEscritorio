namespace Chrysallis
{
    partial class Control_de_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_de_Usuarios));
            this.buttonValoraciones = new System.Windows.Forms.Button();
            this.dataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.socisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMenores = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Permisoapp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socisBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValoraciones
            // 
            this.buttonValoraciones.Location = new System.Drawing.Point(524, 388);
            this.buttonValoraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonValoraciones.Name = "buttonValoraciones";
            this.buttonValoraciones.Size = new System.Drawing.Size(139, 34);
            this.buttonValoraciones.TabIndex = 15;
            this.buttonValoraciones.Text = "Listar valoraciones";
            this.buttonValoraciones.UseVisualStyleBackColor = true;
            this.buttonValoraciones.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // dataGridViewSocios
            // 
            this.dataGridViewSocios.AllowUserToAddRows = false;
            this.dataGridViewSocios.AllowUserToDeleteRows = false;
            this.dataGridViewSocios.AutoGenerateColumns = false;
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.nombre,
            this.apellido,
            this.DNI,
            this.activo,
            this.Permisoapp,
            this.telefono,
            this.telefono2});
            this.dataGridViewSocios.DataSource = this.socisBindingSource;
            this.dataGridViewSocios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewSocios.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewSocios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.ReadOnly = true;
            this.dataGridViewSocios.RowHeadersWidth = 51;
            this.dataGridViewSocios.RowTemplate.Height = 24;
            this.dataGridViewSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSocios.Size = new System.Drawing.Size(1020, 335);
            this.dataGridViewSocios.TabIndex = 11;
            this.dataGridViewSocios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewSocios_DataBindingComplete);
            this.dataGridViewSocios.DoubleClick += new System.EventHandler(this.dataGridViewSocios_DoubleClick);
            // 
            // buttonMenores
            // 
            this.buttonMenores.Location = new System.Drawing.Point(673, 388);
            this.buttonMenores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenores.Name = "buttonMenores";
            this.buttonMenores.Size = new System.Drawing.Size(139, 34);
            this.buttonMenores.TabIndex = 16;
            this.buttonMenores.Text = "Gestionar menores";
            this.buttonMenores.UseVisualStyleBackColor = true;
            this.buttonMenores.Click += new System.EventHandler(this.buttonMenores_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCrear,
            this.toolStripButtonModificar,
            this.toolStripButtonEliminar,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonCrear
            // 
            this.toolStripButtonCrear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCrear.Image")));
            this.toolStripButtonCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrear.Name = "toolStripButtonCrear";
            this.toolStripButtonCrear.Size = new System.Drawing.Size(68, 24);
            this.toolStripButtonCrear.Text = "Crear";
            this.toolStripButtonCrear.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonModificar
            // 
            this.toolStripButtonModificar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModificar.Image")));
            this.toolStripButtonModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModificar.Name = "toolStripButtonModificar";
            this.toolStripButtonModificar.Size = new System.Drawing.Size(97, 24);
            this.toolStripButtonModificar.Text = "Modificar";
            this.toolStripButtonModificar.Click += new System.EventHandler(this.toolStripButtonModificar_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(87, 24);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(88, 24);
            this.toolStripButton2.Text = "Usuaries";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Acciones sobre la fila elegida: ";
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "Numero Socio";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nom";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "cognoms";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "actiu";
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.activo.Width = 125;
            // 
            // Permisoapp
            // 
            this.Permisoapp.DataPropertyName = "permis_app";
            this.Permisoapp.HeaderText = "PermisoApp";
            this.Permisoapp.MinimumWidth = 6;
            this.Permisoapp.Name = "Permisoapp";
            this.Permisoapp.ReadOnly = true;
            this.Permisoapp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Permisoapp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Permisoapp.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefon1";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // telefono2
            // 
            this.telefono2.DataPropertyName = "telefon2";
            this.telefono2.HeaderText = "Telefono2";
            this.telefono2.MinimumWidth = 6;
            this.telefono2.Name = "telefono2";
            this.telefono2.ReadOnly = true;
            this.telefono2.Width = 125;
            // 
            // Control_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1044, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonMenores);
            this.Controls.Add(this.buttonValoraciones);
            this.Controls.Add(this.dataGridViewSocios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Control_de_Usuarios";
            this.Text = "Control_de_Socies";
            this.Activated += new System.EventHandler(this.Control_de_Usuarios_Activated);
            this.Load += new System.EventHandler(this.Control_de_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socisBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValoraciones;
        private System.Windows.Forms.DataGridView dataGridViewSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permisappDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codipostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menorssocisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource socisBindingSource;
        private System.Windows.Forms.Button buttonMenores;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrear;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Permisoapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2;
    }
}