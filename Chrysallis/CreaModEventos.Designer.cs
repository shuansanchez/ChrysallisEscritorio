namespace Chrysallis
{
    partial class CreaModEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaModEventos));
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonImagen = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxImagenEvento = new System.Windows.Forms.PictureBox();
            this.buttonArchivoBuscar = new System.Windows.Forms.Button();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.comunitatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.provinciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.checkBoxGratis = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(254, 436);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(95, 44);
            this.buttonModificar.TabIndex = 38;
            this.buttonModificar.Text = "Aceptar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(384, 445);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(80, 27);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonImagen
            // 
            this.buttonImagen.Location = new System.Drawing.Point(614, 31);
            this.buttonImagen.Name = "buttonImagen";
            this.buttonImagen.Size = new System.Drawing.Size(126, 28);
            this.buttonImagen.TabIndex = 35;
            this.buttonImagen.Text = "Buscar imagen";
            this.buttonImagen.UseVisualStyleBackColor = true;
            this.buttonImagen.Click += new System.EventHandler(this.buttonImagen_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(112, 344);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(352, 86);
            this.textBoxDescripcion.TabIndex = 32;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(112, 267);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(352, 22);
            this.textBoxPrecio.TabIndex = 31;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(112, 37);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(352, 22);
            this.textBoxTitulo.TabIndex = 28;
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.Location = new System.Drawing.Point(112, 149);
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.Size = new System.Drawing.Size(352, 22);
            this.textBoxLugar.TabIndex = 27;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(37, 324);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 17);
            this.labelDescripcion.TabIndex = 26;
            this.labelDescripcion.Text = "DESCRIPCION";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(12, 270);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(59, 17);
            this.labelPrecio.TabIndex = 25;
            this.labelPrecio.Text = "PRECIO";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(12, 152);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(82, 17);
            this.labelDireccion.TabIndex = 23;
            this.labelDireccion.Text = "DIRECCION";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(12, 96);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(48, 17);
            this.labelHora.TabIndex = 22;
            this.labelHora.Text = "HORA";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(12, 68);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(53, 17);
            this.labelFecha.TabIndex = 21;
            this.labelFecha.Text = "FECHA";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 40);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(58, 17);
            this.labelTitulo.TabIndex = 20;
            this.labelTitulo.Text = "TITULO";
            // 
            // pictureBoxImagenEvento
            // 
            this.pictureBoxImagenEvento.Location = new System.Drawing.Point(583, 68);
            this.pictureBoxImagenEvento.Name = "pictureBoxImagenEvento";
            this.pictureBoxImagenEvento.Size = new System.Drawing.Size(232, 190);
            this.pictureBoxImagenEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenEvento.TabIndex = 34;
            this.pictureBoxImagenEvento.TabStop = false;
            // 
            // buttonArchivoBuscar
            // 
            this.buttonArchivoBuscar.Location = new System.Drawing.Point(614, 324);
            this.buttonArchivoBuscar.Name = "buttonArchivoBuscar";
            this.buttonArchivoBuscar.Size = new System.Drawing.Size(109, 28);
            this.buttonArchivoBuscar.TabIndex = 39;
            this.buttonArchivoBuscar.Text = "Elegir archivo";
            this.buttonArchivoBuscar.UseVisualStyleBackColor = true;
            this.buttonArchivoBuscar.Click += new System.EventHandler(this.ArchivoBuscar_Click);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(112, 120);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(352, 22);
            this.textBoxCiudad.TabIndex = 41;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(12, 123);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(59, 17);
            this.labelCiudad.TabIndex = 40;
            this.labelCiudad.Text = "CIUDAD";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(12, 240);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(81, 17);
            this.labelProvincia.TabIndex = 42;
            this.labelProvincia.Text = "PROVINCIA";
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.comunitatsBindingSource;
            this.comboBoxComunidad.DisplayMember = "nom";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(112, 207);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(352, 24);
            this.comboBoxComunidad.TabIndex = 43;
            this.comboBoxComunidad.ValueMember = "id";
            this.comboBoxComunidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comunitatsBindingSource
            // 
            this.comunitatsBindingSource.DataSource = typeof(Chrysallis.comunitats);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DataSource = this.provinciesBindingSource;
            this.comboBoxProvincia.DisplayMember = "nom";
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(112, 237);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(352, 24);
            this.comboBoxProvincia.TabIndex = 45;
            this.comboBoxProvincia.ValueMember = "id";
            // 
            // provinciesBindingSource
            // 
            this.provinciesBindingSource.DataSource = typeof(Chrysallis.provincies);
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(12, 210);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(91, 17);
            this.labelComunidad.TabIndex = 44;
            this.labelComunidad.Text = "COMUNIDAD";
            // 
            // checkBoxGratis
            // 
            this.checkBoxGratis.AutoSize = true;
            this.checkBoxGratis.Checked = true;
            this.checkBoxGratis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGratis.Location = new System.Drawing.Point(470, 268);
            this.checkBoxGratis.Name = "checkBoxGratis";
            this.checkBoxGratis.Size = new System.Drawing.Size(68, 21);
            this.checkBoxGratis.TabIndex = 46;
            this.checkBoxGratis.Text = "Gratis";
            this.checkBoxGratis.UseVisualStyleBackColor = true;
            this.checkBoxGratis.CheckedChanged += new System.EventHandler(this.checkBoxGratis_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(112, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(352, 22);
            this.dateTimePicker.TabIndex = 47;
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(112, 91);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(352, 22);
            this.dateTimePickerHora.TabIndex = 48;
            // 
            // CreaModEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.checkBoxGratis);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.labelComunidad);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.buttonArchivoBuscar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonImagen);
            this.Controls.Add(this.pictureBoxImagenEvento);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxLugar);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreaModEventos";
            this.Text = "ModificarEventos";
            this.Activated += new System.EventHandler(this.CreaModEventos_Activated);
            this.Load += new System.EventHandler(this.CreaModEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagenEvento;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonArchivoBuscar;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.BindingSource comunitatsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.BindingSource provinciesBindingSource;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.CheckBox checkBoxGratis;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
    }
}