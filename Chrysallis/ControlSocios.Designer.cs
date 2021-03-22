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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.dataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.socisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisappDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codipostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menorssocisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(553, 388);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(138, 35);
            this.buttonUsers.TabIndex = 15;
            this.buttonUsers.Text = "Lista Valoraciones";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(101, 389);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(102, 34);
            this.buttonAñadir.TabIndex = 14;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(242, 389);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(112, 35);
            this.buttonModificar.TabIndex = 13;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(401, 389);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(111, 35);
            this.buttonBorrar.TabIndex = 12;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSocios
            // 
            this.dataGridViewSocios.AutoGenerateColumns = false;
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.cognomsDataGridViewTextBoxColumn,
            this.actiuDataGridViewCheckBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.databaixaDataGridViewTextBoxColumn,
            this.dataaltaDataGridViewTextBoxColumn,
            this.permisappDataGridViewCheckBoxColumn,
            this.codipostalDataGridViewTextBoxColumn,
            this.localitatsDataGridViewTextBoxColumn,
            this.menorssocisDataGridViewTextBoxColumn});
            this.dataGridViewSocios.DataSource = this.socisBindingSource;
            this.dataGridViewSocios.Location = new System.Drawing.Point(70, 76);
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.RowHeadersWidth = 51;
            this.dataGridViewSocios.RowTemplate.Height = 24;
            this.dataGridViewSocios.Size = new System.Drawing.Size(663, 288);
            this.dataGridViewSocios.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(480, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(117, 28);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(357, 22);
            this.textBoxFiltrar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrar";
            // 
            // socisBindingSource
            // 
            this.socisBindingSource.DataSource = typeof(Chrysallis.socis);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "num";
            this.numDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // cognomsDataGridViewTextBoxColumn
            // 
            this.cognomsDataGridViewTextBoxColumn.DataPropertyName = "cognoms";
            this.cognomsDataGridViewTextBoxColumn.HeaderText = "cognoms";
            this.cognomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomsDataGridViewTextBoxColumn.Name = "cognomsDataGridViewTextBoxColumn";
            this.cognomsDataGridViewTextBoxColumn.Width = 125;
            // 
            // actiuDataGridViewCheckBoxColumn
            // 
            this.actiuDataGridViewCheckBoxColumn.DataPropertyName = "actiu";
            this.actiuDataGridViewCheckBoxColumn.HeaderText = "actiu";
            this.actiuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.actiuDataGridViewCheckBoxColumn.Name = "actiuDataGridViewCheckBoxColumn";
            this.actiuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // telefon1DataGridViewTextBoxColumn
            // 
            this.telefon1DataGridViewTextBoxColumn.DataPropertyName = "telefon1";
            this.telefon1DataGridViewTextBoxColumn.HeaderText = "telefon1";
            this.telefon1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefon1DataGridViewTextBoxColumn.Name = "telefon1DataGridViewTextBoxColumn";
            this.telefon1DataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // databaixaDataGridViewTextBoxColumn
            // 
            this.databaixaDataGridViewTextBoxColumn.DataPropertyName = "data_baixa";
            this.databaixaDataGridViewTextBoxColumn.HeaderText = "data_baixa";
            this.databaixaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.databaixaDataGridViewTextBoxColumn.Name = "databaixaDataGridViewTextBoxColumn";
            this.databaixaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataaltaDataGridViewTextBoxColumn
            // 
            this.dataaltaDataGridViewTextBoxColumn.DataPropertyName = "data_alta";
            this.dataaltaDataGridViewTextBoxColumn.HeaderText = "data_alta";
            this.dataaltaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataaltaDataGridViewTextBoxColumn.Name = "dataaltaDataGridViewTextBoxColumn";
            this.dataaltaDataGridViewTextBoxColumn.Width = 125;
            // 
            // permisappDataGridViewCheckBoxColumn
            // 
            this.permisappDataGridViewCheckBoxColumn.DataPropertyName = "permis_app";
            this.permisappDataGridViewCheckBoxColumn.HeaderText = "permis_app";
            this.permisappDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.permisappDataGridViewCheckBoxColumn.Name = "permisappDataGridViewCheckBoxColumn";
            this.permisappDataGridViewCheckBoxColumn.Width = 125;
            // 
            // codipostalDataGridViewTextBoxColumn
            // 
            this.codipostalDataGridViewTextBoxColumn.DataPropertyName = "codi_postal";
            this.codipostalDataGridViewTextBoxColumn.HeaderText = "codi_postal";
            this.codipostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codipostalDataGridViewTextBoxColumn.Name = "codipostalDataGridViewTextBoxColumn";
            this.codipostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // localitatsDataGridViewTextBoxColumn
            // 
            this.localitatsDataGridViewTextBoxColumn.DataPropertyName = "localitats";
            this.localitatsDataGridViewTextBoxColumn.HeaderText = "localitats";
            this.localitatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localitatsDataGridViewTextBoxColumn.Name = "localitatsDataGridViewTextBoxColumn";
            this.localitatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // menorssocisDataGridViewTextBoxColumn
            // 
            this.menorssocisDataGridViewTextBoxColumn.DataPropertyName = "menors_socis";
            this.menorssocisDataGridViewTextBoxColumn.HeaderText = "menors_socis";
            this.menorssocisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menorssocisDataGridViewTextBoxColumn.Name = "menorssocisDataGridViewTextBoxColumn";
            this.menorssocisDataGridViewTextBoxColumn.Width = 125;
            // 
            // Control_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewSocios);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control_de_Usuarios";
            this.Text = "Control_de_Socios";
            this.Load += new System.EventHandler(this.Control_de_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBorrar;
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
    }
}