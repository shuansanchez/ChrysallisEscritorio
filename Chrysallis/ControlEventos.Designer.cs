namespace Chrysallis
{
    partial class Control_de_Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_de_Eventos));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonSocios = new System.Windows.Forms.Button();
            this.titolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrecaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imatgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitatmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitatmínimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contassitentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esdevenimentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esdevenimentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(112, 33);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(357, 22);
            this.textBoxFiltrar.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(475, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titolDataGridViewTextBoxColumn,
            this.descripcioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.adrecaDataGridViewTextBoxColumn,
            this.latitudDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn,
            this.imatgeDataGridViewTextBoxColumn,
            this.quantitatmaxDataGridViewTextBoxColumn,
            this.quantitatmínimaDataGridViewTextBoxColumn,
            this.preuDataGridViewTextBoxColumn,
            this.pagamentDataGridViewTextBoxColumn,
            this.datamaxDataGridViewTextBoxColumn,
            this.contassitentsDataGridViewTextBoxColumn,
            this.meetDataGridViewTextBoxColumn,
            this.assistirDataGridViewTextBoxColumn,
            this.comunitatsDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn});
            this.dataGridViewEventos.DataSource = this.esdevenimentsBindingSource;
            this.dataGridViewEventos.Enabled = false;
            this.dataGridViewEventos.Location = new System.Drawing.Point(65, 81);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.RowHeadersWidth = 51;
            this.dataGridViewEventos.RowTemplate.Height = 24;
            this.dataGridViewEventos.Size = new System.Drawing.Size(663, 288);
            this.dataGridViewEventos.TabIndex = 3;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(396, 394);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(111, 35);
            this.buttonBorrar.TabIndex = 4;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(237, 394);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(112, 35);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(96, 394);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(102, 34);
            this.buttonAñadir.TabIndex = 6;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonSocios
            // 
            this.buttonSocios.Location = new System.Drawing.Point(548, 393);
            this.buttonSocios.Name = "buttonSocios";
            this.buttonSocios.Size = new System.Drawing.Size(111, 35);
            this.buttonSocios.TabIndex = 7;
            this.buttonSocios.Text = "Lista Socios";
            this.buttonSocios.UseVisualStyleBackColor = true;
            // 
            // titolDataGridViewTextBoxColumn
            // 
            this.titolDataGridViewTextBoxColumn.DataPropertyName = "titol";
            this.titolDataGridViewTextBoxColumn.HeaderText = "titol";
            this.titolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titolDataGridViewTextBoxColumn.Name = "titolDataGridViewTextBoxColumn";
            this.titolDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcioDataGridViewTextBoxColumn
            // 
            this.descripcioDataGridViewTextBoxColumn.DataPropertyName = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.HeaderText = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcioDataGridViewTextBoxColumn.Name = "descripcioDataGridViewTextBoxColumn";
            this.descripcioDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.Width = 125;
            // 
            // adrecaDataGridViewTextBoxColumn
            // 
            this.adrecaDataGridViewTextBoxColumn.DataPropertyName = "adreca";
            this.adrecaDataGridViewTextBoxColumn.HeaderText = "adreca";
            this.adrecaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adrecaDataGridViewTextBoxColumn.Name = "adrecaDataGridViewTextBoxColumn";
            this.adrecaDataGridViewTextBoxColumn.Width = 125;
            // 
            // latitudDataGridViewTextBoxColumn
            // 
            this.latitudDataGridViewTextBoxColumn.DataPropertyName = "latitud";
            this.latitudDataGridViewTextBoxColumn.HeaderText = "latitud";
            this.latitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latitudDataGridViewTextBoxColumn.Name = "latitudDataGridViewTextBoxColumn";
            this.latitudDataGridViewTextBoxColumn.Width = 125;
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "longitud";
            this.longitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            this.longitudDataGridViewTextBoxColumn.Width = 125;
            // 
            // imatgeDataGridViewTextBoxColumn
            // 
            this.imatgeDataGridViewTextBoxColumn.DataPropertyName = "imatge";
            this.imatgeDataGridViewTextBoxColumn.HeaderText = "imatge";
            this.imatgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imatgeDataGridViewTextBoxColumn.Name = "imatgeDataGridViewTextBoxColumn";
            this.imatgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitatmaxDataGridViewTextBoxColumn
            // 
            this.quantitatmaxDataGridViewTextBoxColumn.DataPropertyName = "quantitat_max";
            this.quantitatmaxDataGridViewTextBoxColumn.HeaderText = "quantitat_max";
            this.quantitatmaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitatmaxDataGridViewTextBoxColumn.Name = "quantitatmaxDataGridViewTextBoxColumn";
            this.quantitatmaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitatmínimaDataGridViewTextBoxColumn
            // 
            this.quantitatmínimaDataGridViewTextBoxColumn.DataPropertyName = "quantitat_mínima";
            this.quantitatmínimaDataGridViewTextBoxColumn.HeaderText = "quantitat_mínima";
            this.quantitatmínimaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitatmínimaDataGridViewTextBoxColumn.Name = "quantitatmínimaDataGridViewTextBoxColumn";
            this.quantitatmínimaDataGridViewTextBoxColumn.Width = 125;
            // 
            // preuDataGridViewTextBoxColumn
            // 
            this.preuDataGridViewTextBoxColumn.DataPropertyName = "preu";
            this.preuDataGridViewTextBoxColumn.HeaderText = "preu";
            this.preuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preuDataGridViewTextBoxColumn.Name = "preuDataGridViewTextBoxColumn";
            this.preuDataGridViewTextBoxColumn.Width = 125;
            // 
            // pagamentDataGridViewTextBoxColumn
            // 
            this.pagamentDataGridViewTextBoxColumn.DataPropertyName = "pagament";
            this.pagamentDataGridViewTextBoxColumn.HeaderText = "pagament";
            this.pagamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pagamentDataGridViewTextBoxColumn.Name = "pagamentDataGridViewTextBoxColumn";
            this.pagamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // datamaxDataGridViewTextBoxColumn
            // 
            this.datamaxDataGridViewTextBoxColumn.DataPropertyName = "data_max";
            this.datamaxDataGridViewTextBoxColumn.HeaderText = "data_max";
            this.datamaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datamaxDataGridViewTextBoxColumn.Name = "datamaxDataGridViewTextBoxColumn";
            this.datamaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // contassitentsDataGridViewTextBoxColumn
            // 
            this.contassitentsDataGridViewTextBoxColumn.DataPropertyName = "cont_assitents";
            this.contassitentsDataGridViewTextBoxColumn.HeaderText = "cont_assitents";
            this.contassitentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contassitentsDataGridViewTextBoxColumn.Name = "contassitentsDataGridViewTextBoxColumn";
            this.contassitentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetDataGridViewTextBoxColumn
            // 
            this.meetDataGridViewTextBoxColumn.DataPropertyName = "meet";
            this.meetDataGridViewTextBoxColumn.HeaderText = "meet";
            this.meetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetDataGridViewTextBoxColumn.Name = "meetDataGridViewTextBoxColumn";
            this.meetDataGridViewTextBoxColumn.Width = 125;
            // 
            // assistirDataGridViewTextBoxColumn
            // 
            this.assistirDataGridViewTextBoxColumn.DataPropertyName = "assistir";
            this.assistirDataGridViewTextBoxColumn.HeaderText = "assistir";
            this.assistirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assistirDataGridViewTextBoxColumn.Name = "assistirDataGridViewTextBoxColumn";
            this.assistirDataGridViewTextBoxColumn.Width = 125;
            // 
            // comunitatsDataGridViewTextBoxColumn
            // 
            this.comunitatsDataGridViewTextBoxColumn.DataPropertyName = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.HeaderText = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comunitatsDataGridViewTextBoxColumn.Name = "comunitatsDataGridViewTextBoxColumn";
            this.comunitatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "documents";
            this.documentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // esdevenimentsBindingSource
            // 
            this.esdevenimentsBindingSource.DataSource = typeof(Chrysallis.esdeveniments);
            // 
            // Control_de_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSocios);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewEventos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control_de_Eventos";
            this.Text = "Control_de_Eventos";
            this.Load += new System.EventHandler(this.Control_de_Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esdevenimentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn titolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrecaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imatgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitatmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitatmínimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contassitentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource esdevenimentsBindingSource;
    }
}