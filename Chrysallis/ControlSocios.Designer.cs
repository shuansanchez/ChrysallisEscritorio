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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenores = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridViewSocios.AutoGenerateColumns = false;
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocios.DataSource = this.socisBindingSource;
            this.dataGridViewSocios.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewSocios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.RowHeadersWidth = 51;
            this.dataGridViewSocios.RowTemplate.Height = 24;
            this.dataGridViewSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSocios.Size = new System.Drawing.Size(800, 335);
            this.dataGridViewSocios.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(905, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(836, 80);
            this.textBoxFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(190, 22);
            this.textBoxFiltrar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrar";
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
            this.toolStripButtonEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Acciones sobre la fila elegida: ";
            // 
            // Control_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1046, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonMenores);
            this.Controls.Add(this.buttonValoraciones);
            this.Controls.Add(this.dataGridViewSocios);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Control_de_Usuarios";
            this.Text = "Control_de_Socios";
            this.Activated += new System.EventHandler(this.Control_de_Usuarios_Activated);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Label label1;
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
    }
}