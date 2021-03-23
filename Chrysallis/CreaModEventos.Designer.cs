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
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxImagenEvento = new System.Windows.Forms.PictureBox();
            this.buttonArchivoBuscar = new System.Windows.Forms.Button();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.comunitatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.provinciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.checkBoxGratis = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.checkBoxVirtual = new System.Windows.Forms.CheckBox();
            this.textBoxEnlace = new System.Windows.Forms.TextBox();
            this.labelEnlace = new System.Windows.Forms.Label();
            this.checkBoxMinima = new System.Windows.Forms.CheckBox();
            this.textBoxminimo = new System.Windows.Forms.TextBox();
            this.textBoxmax = new System.Windows.Forms.TextBox();
            this.labelAsistMin = new System.Windows.Forms.Label();
            this.labelAsistMax = new System.Windows.Forms.Label();
            this.checkBoxmax = new System.Windows.Forms.CheckBox();
            this.labelArchivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(232, 497);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(95, 44);
            this.buttonModificar.TabIndex = 38;
            this.buttonModificar.Text = "Aceptar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(384, 506);
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
            this.textBoxDescripcion.Location = new System.Drawing.Point(112, 391);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(352, 86);
            this.textBoxDescripcion.TabIndex = 32;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(112, 239);
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
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(112, 211);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(352, 22);
            this.textBoxDireccion.TabIndex = 27;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(38, 371);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 17);
            this.labelDescripcion.TabIndex = 26;
            this.labelDescripcion.Text = "DESCRIPCIÓN";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(13, 241);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(59, 17);
            this.labelPrecio.TabIndex = 25;
            this.labelPrecio.Text = "PRECIO";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(12, 214);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(82, 17);
            this.labelDireccion.TabIndex = 23;
            this.labelDireccion.Text = "DIRECCIÓN";
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
            this.buttonArchivoBuscar.Location = new System.Drawing.Point(614, 314);
            this.buttonArchivoBuscar.Name = "buttonArchivoBuscar";
            this.buttonArchivoBuscar.Size = new System.Drawing.Size(109, 28);
            this.buttonArchivoBuscar.TabIndex = 39;
            this.buttonArchivoBuscar.Text = "Elegir archivo";
            this.buttonArchivoBuscar.UseVisualStyleBackColor = true;
            this.buttonArchivoBuscar.Click += new System.EventHandler(this.ArchivoBuscar_Click);
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(112, 182);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(352, 22);
            this.textBoxLocalidad.TabIndex = 41;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(12, 185);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(85, 17);
            this.labelLocalidad.TabIndex = 40;
            this.labelLocalidad.Text = "LOCALIDAD";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(13, 152);
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
            this.comboBoxComunidad.Location = new System.Drawing.Point(112, 119);
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
            this.comboBoxProvincia.Location = new System.Drawing.Point(112, 149);
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
            this.labelComunidad.Location = new System.Drawing.Point(12, 122);
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
            this.checkBoxGratis.Location = new System.Drawing.Point(470, 241);
            this.checkBoxGratis.Name = "checkBoxGratis";
            this.checkBoxGratis.Size = new System.Drawing.Size(68, 21);
            this.checkBoxGratis.TabIndex = 46;
            this.checkBoxGratis.Text = "Gratis";
            this.checkBoxGratis.UseVisualStyleBackColor = true;
            this.checkBoxGratis.CheckedChanged += new System.EventHandler(this.checkBoxGratis_CheckedChanged);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(112, 62);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(352, 22);
            this.dateTimePickerFecha.TabIndex = 47;
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(112, 91);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(352, 22);
            this.dateTimePickerHora.TabIndex = 48;
            
            // 
            // checkBoxVirtual
            // 
            this.checkBoxVirtual.AutoSize = true;
            this.checkBoxVirtual.Location = new System.Drawing.Point(470, 269);
            this.checkBoxVirtual.Name = "checkBoxVirtual";
            this.checkBoxVirtual.Size = new System.Drawing.Size(70, 21);
            this.checkBoxVirtual.TabIndex = 51;
            this.checkBoxVirtual.Text = "Virtual";
            this.checkBoxVirtual.UseVisualStyleBackColor = true;
            this.checkBoxVirtual.CheckedChanged += new System.EventHandler(this.checkBoxVirtual_CheckedChanged);
            // 
            // textBoxEnlace
            // 
            this.textBoxEnlace.Location = new System.Drawing.Point(112, 267);
            this.textBoxEnlace.Name = "textBoxEnlace";
            this.textBoxEnlace.Size = new System.Drawing.Size(352, 22);
            this.textBoxEnlace.TabIndex = 50;
            // 
            // labelEnlace
            // 
            this.labelEnlace.AutoSize = true;
            this.labelEnlace.Location = new System.Drawing.Point(13, 269);
            this.labelEnlace.Name = "labelEnlace";
            this.labelEnlace.Size = new System.Drawing.Size(62, 17);
            this.labelEnlace.TabIndex = 49;
            this.labelEnlace.Text = "ENLACE";
            // 
            // checkBoxMinima
            // 
            this.checkBoxMinima.AutoSize = true;
            this.checkBoxMinima.Location = new System.Drawing.Point(470, 325);
            this.checkBoxMinima.Name = "checkBoxMinima";
            this.checkBoxMinima.Size = new System.Drawing.Size(119, 21);
            this.checkBoxMinima.TabIndex = 56;
            this.checkBoxMinima.Text = "Asist. mínimos";
            this.checkBoxMinima.UseVisualStyleBackColor = true;
            this.checkBoxMinima.CheckedChanged += new System.EventHandler(this.checkBoxMinima_CheckedChanged);
            // 
            // textBoxminimo
            // 
            this.textBoxminimo.Location = new System.Drawing.Point(112, 323);
            this.textBoxminimo.Name = "textBoxminimo";
            this.textBoxminimo.Size = new System.Drawing.Size(352, 22);
            this.textBoxminimo.TabIndex = 55;
            // 
            // textBoxmax
            // 
            this.textBoxmax.Location = new System.Drawing.Point(112, 295);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.Size = new System.Drawing.Size(352, 22);
            this.textBoxmax.TabIndex = 54;
            // 
            // labelAsistMin
            // 
            this.labelAsistMin.AutoSize = true;
            this.labelAsistMin.Location = new System.Drawing.Point(12, 325);
            this.labelAsistMin.Name = "labelAsistMin";
            this.labelAsistMin.Size = new System.Drawing.Size(83, 17);
            this.labelAsistMin.TabIndex = 53;
            this.labelAsistMin.Text = "ASIST. MIN.";
            // 
            // labelAsistMax
            // 
            this.labelAsistMax.AutoSize = true;
            this.labelAsistMax.Location = new System.Drawing.Point(12, 298);
            this.labelAsistMax.Name = "labelAsistMax";
            this.labelAsistMax.Size = new System.Drawing.Size(88, 17);
            this.labelAsistMax.TabIndex = 52;
            this.labelAsistMax.Text = "ASIST. MAX.";
            // 
            // checkBoxmax
            // 
            this.checkBoxmax.AutoSize = true;
            this.checkBoxmax.Location = new System.Drawing.Point(470, 298);
            this.checkBoxmax.Name = "checkBoxmax";
            this.checkBoxmax.Size = new System.Drawing.Size(122, 21);
            this.checkBoxmax.TabIndex = 57;
            this.checkBoxmax.Text = "Asist. máximos";
            this.checkBoxmax.UseVisualStyleBackColor = true;
            this.checkBoxmax.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(614, 285);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(18, 17);
            this.labelArchivo.TabIndex = 58;
            this.labelArchivo.Text = "--";
            // 
            // CreaModEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(848, 578);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.checkBoxmax);
            this.Controls.Add(this.checkBoxMinima);
            this.Controls.Add(this.textBoxminimo);
            this.Controls.Add(this.textBoxmax);
            this.Controls.Add(this.labelAsistMin);
            this.Controls.Add(this.labelAsistMax);
            this.Controls.Add(this.checkBoxVirtual);
            this.Controls.Add(this.textBoxEnlace);
            this.Controls.Add(this.labelEnlace);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.checkBoxGratis);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.labelComunidad);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.buttonArchivoBuscar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonImagen);
            this.Controls.Add(this.pictureBoxImagenEvento);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreaModEventos";
            this.Text = "ModificarEventos";
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
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonArchivoBuscar;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.BindingSource comunitatsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.BindingSource provinciesBindingSource;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.CheckBox checkBoxGratis;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.CheckBox checkBoxVirtual;
        private System.Windows.Forms.TextBox textBoxEnlace;
        private System.Windows.Forms.Label labelEnlace;
        private System.Windows.Forms.CheckBox checkBoxMinima;
        private System.Windows.Forms.TextBox textBoxminimo;
        private System.Windows.Forms.TextBox textBoxmax;
        private System.Windows.Forms.Label labelAsistMin;
        private System.Windows.Forms.Label labelAsistMax;
        private System.Windows.Forms.CheckBox checkBoxmax;
        private System.Windows.Forms.Label labelArchivo;
    }
}