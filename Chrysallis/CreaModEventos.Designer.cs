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
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.comunitatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.provinciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.checkBoxGratis = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
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
            this.textBoxLongitud = new System.Windows.Forms.TextBox();
            this.labelLongitud = new System.Windows.Forms.Label();
            this.textBoxLatitud = new System.Windows.Forms.TextBox();
            this.labelLatitud = new System.Windows.Forms.Label();
            this.comboBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.localitatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModificarLocalidadButton = new System.Windows.Forms.Button();
            this.dateTimePickerHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEliminarImg = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(1001, 535);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(205, 76);
            this.buttonModificar.TabIndex = 38;
            this.buttonModificar.Text = "Aceptar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1211, 644);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(80, 27);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonImagen
            // 
            this.buttonImagen.Location = new System.Drawing.Point(911, 21);
            this.buttonImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImagen.Name = "buttonImagen";
            this.buttonImagen.Size = new System.Drawing.Size(125, 28);
            this.buttonImagen.TabIndex = 35;
            this.buttonImagen.Text = "Buscar imagen";
            this.buttonImagen.UseVisualStyleBackColor = true;
            this.buttonImagen.Click += new System.EventHandler(this.buttonImagen_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(37, 516);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(843, 154);
            this.textBoxDescripcion.TabIndex = 32;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(624, 212);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(269, 22);
            this.textBoxPrecio.TabIndex = 31;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(152, 30);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(352, 22);
            this.textBoxTitulo.TabIndex = 28;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(152, 331);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(352, 22);
            this.textBoxDireccion.TabIndex = 27;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(33, 497);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 17);
            this.labelDescripcion.TabIndex = 26;
            this.labelDescripcion.Text = "DESCRIPCIÓN";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(543, 219);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(59, 17);
            this.labelPrecio.TabIndex = 25;
            this.labelPrecio.Text = "PRECIO";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(33, 340);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(91, 17);
            this.labelDireccion.TabIndex = 23;
            this.labelDireccion.Text = "DIRECCIÓN *";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(543, 82);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(91, 17);
            this.labelHora.TabIndex = 22;
            this.labelHora.Text = "HORA INICIO";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(33, 82);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(96, 17);
            this.labelFecha.TabIndex = 21;
            this.labelFecha.Text = "FECHA INICIO";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(33, 33);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(67, 17);
            this.labelTitulo.TabIndex = 20;
            this.labelTitulo.Text = "TITULO *";
            // 
            // pictureBoxImagenEvento
            // 
            this.pictureBoxImagenEvento.Location = new System.Drawing.Point(912, 57);
            this.pictureBoxImagenEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagenEvento.Name = "pictureBoxImagenEvento";
            this.pictureBoxImagenEvento.Size = new System.Drawing.Size(379, 367);
            this.pictureBoxImagenEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenEvento.TabIndex = 34;
            this.pictureBoxImagenEvento.TabStop = false;
            // 
            // buttonArchivoBuscar
            // 
            this.buttonArchivoBuscar.Location = new System.Drawing.Point(16, 16);
            this.buttonArchivoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArchivoBuscar.Name = "buttonArchivoBuscar";
            this.buttonArchivoBuscar.Size = new System.Drawing.Size(164, 28);
            this.buttonArchivoBuscar.TabIndex = 39;
            this.buttonArchivoBuscar.Text = "Seleccionar archivo";
            this.buttonArchivoBuscar.UseVisualStyleBackColor = true;
            this.buttonArchivoBuscar.Click += new System.EventHandler(this.ArchivoBuscar_Click);
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(37, 267);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(85, 17);
            this.labelLocalidad.TabIndex = 40;
            this.labelLocalidad.Text = "LOCALIDAD";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(40, 219);
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
            this.comboBoxComunidad.Location = new System.Drawing.Point(152, 164);
            this.comboBoxComunidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.comboBoxProvincia.Location = new System.Drawing.Point(152, 210);
            this.comboBoxProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(352, 24);
            this.comboBoxProvincia.TabIndex = 45;
            this.comboBoxProvincia.ValueMember = "id";
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // provinciesBindingSource
            // 
            this.provinciesBindingSource.DataSource = typeof(Chrysallis.provincies);
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(33, 174);
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
            this.checkBoxGratis.Location = new System.Drawing.Point(821, 185);
            this.checkBoxGratis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxGratis.Name = "checkBoxGratis";
            this.checkBoxGratis.Size = new System.Drawing.Size(68, 21);
            this.checkBoxGratis.TabIndex = 46;
            this.checkBoxGratis.Text = "Gratis";
            this.checkBoxGratis.UseVisualStyleBackColor = true;
            this.checkBoxGratis.CheckedChanged += new System.EventHandler(this.checkBoxGratis_CheckedChanged);
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(152, 75);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(352, 22);
            this.dateTimePickerFechaInicio.TabIndex = 47;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(656, 75);
            this.dateTimePickerHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(119, 22);
            this.dateTimePickerHoraInicio.TabIndex = 48;
            // 
            // checkBoxVirtual
            // 
            this.checkBoxVirtual.AutoSize = true;
            this.checkBoxVirtual.Location = new System.Drawing.Point(821, 240);
            this.checkBoxVirtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxVirtual.Name = "checkBoxVirtual";
            this.checkBoxVirtual.Size = new System.Drawing.Size(70, 21);
            this.checkBoxVirtual.TabIndex = 51;
            this.checkBoxVirtual.Text = "Virtual";
            this.checkBoxVirtual.UseVisualStyleBackColor = true;
            this.checkBoxVirtual.CheckedChanged += new System.EventHandler(this.checkBoxVirtual_CheckedChanged);
            // 
            // textBoxEnlace
            // 
            this.textBoxEnlace.Location = new System.Drawing.Point(624, 261);
            this.textBoxEnlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnlace.Name = "textBoxEnlace";
            this.textBoxEnlace.Size = new System.Drawing.Size(269, 22);
            this.textBoxEnlace.TabIndex = 50;
            // 
            // labelEnlace
            // 
            this.labelEnlace.AutoSize = true;
            this.labelEnlace.Location = new System.Drawing.Point(540, 270);
            this.labelEnlace.Name = "labelEnlace";
            this.labelEnlace.Size = new System.Drawing.Size(62, 17);
            this.labelEnlace.TabIndex = 49;
            this.labelEnlace.Text = "ENLACE";
            // 
            // checkBoxMinima
            // 
            this.checkBoxMinima.AutoSize = true;
            this.checkBoxMinima.Location = new System.Drawing.Point(768, 352);
            this.checkBoxMinima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMinima.Name = "checkBoxMinima";
            this.checkBoxMinima.Size = new System.Drawing.Size(119, 21);
            this.checkBoxMinima.TabIndex = 56;
            this.checkBoxMinima.Text = "Asist. mínimos";
            this.checkBoxMinima.UseVisualStyleBackColor = true;
            this.checkBoxMinima.CheckedChanged += new System.EventHandler(this.checkBoxMinima_CheckedChanged);
            // 
            // textBoxminimo
            // 
            this.textBoxminimo.Location = new System.Drawing.Point(624, 378);
            this.textBoxminimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxminimo.Name = "textBoxminimo";
            this.textBoxminimo.Size = new System.Drawing.Size(269, 22);
            this.textBoxminimo.TabIndex = 55;
            // 
            // textBoxmax
            // 
            this.textBoxmax.Location = new System.Drawing.Point(624, 319);
            this.textBoxmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.Size = new System.Drawing.Size(269, 22);
            this.textBoxmax.TabIndex = 54;
            // 
            // labelAsistMin
            // 
            this.labelAsistMin.AutoSize = true;
            this.labelAsistMin.Location = new System.Drawing.Point(529, 386);
            this.labelAsistMin.Name = "labelAsistMin";
            this.labelAsistMin.Size = new System.Drawing.Size(83, 17);
            this.labelAsistMin.TabIndex = 53;
            this.labelAsistMin.Text = "ASIST. MIN.";
            // 
            // labelAsistMax
            // 
            this.labelAsistMax.AutoSize = true;
            this.labelAsistMax.Location = new System.Drawing.Point(527, 327);
            this.labelAsistMax.Name = "labelAsistMax";
            this.labelAsistMax.Size = new System.Drawing.Size(88, 17);
            this.labelAsistMax.TabIndex = 52;
            this.labelAsistMax.Text = "ASIST. MAX.";
            // 
            // checkBoxmax
            // 
            this.checkBoxmax.AutoSize = true;
            this.checkBoxmax.Location = new System.Drawing.Point(769, 293);
            this.checkBoxmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelArchivo.Location = new System.Drawing.Point(185, 22);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(18, 17);
            this.labelArchivo.TabIndex = 58;
            this.labelArchivo.Text = "--";
            // 
            // textBoxLongitud
            // 
            this.textBoxLongitud.Location = new System.Drawing.Point(152, 430);
            this.textBoxLongitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLongitud.Name = "textBoxLongitud";
            this.textBoxLongitud.Size = new System.Drawing.Size(352, 22);
            this.textBoxLongitud.TabIndex = 60;
            // 
            // labelLongitud
            // 
            this.labelLongitud.AutoSize = true;
            this.labelLongitud.Location = new System.Drawing.Point(33, 438);
            this.labelLongitud.Name = "labelLongitud";
            this.labelLongitud.Size = new System.Drawing.Size(89, 17);
            this.labelLongitud.TabIndex = 59;
            this.labelLongitud.Text = "LONGITUD *";
            // 
            // textBoxLatitud
            // 
            this.textBoxLatitud.Location = new System.Drawing.Point(152, 378);
            this.textBoxLatitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLatitud.Name = "textBoxLatitud";
            this.textBoxLatitud.Size = new System.Drawing.Size(352, 22);
            this.textBoxLatitud.TabIndex = 62;
            // 
            // labelLatitud
            // 
            this.labelLatitud.AutoSize = true;
            this.labelLatitud.Location = new System.Drawing.Point(33, 386);
            this.labelLatitud.Name = "labelLatitud";
            this.labelLatitud.Size = new System.Drawing.Size(75, 17);
            this.labelLatitud.TabIndex = 61;
            this.labelLatitud.Text = "LATITUD *";
            // 
            // comboBoxLocalidad
            // 
            this.comboBoxLocalidad.DataSource = this.localitatsBindingSource;
            this.comboBoxLocalidad.DisplayMember = "nom";
            this.comboBoxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocalidad.FormattingEnabled = true;
            this.comboBoxLocalidad.Location = new System.Drawing.Point(152, 257);
            this.comboBoxLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLocalidad.Name = "comboBoxLocalidad";
            this.comboBoxLocalidad.Size = new System.Drawing.Size(352, 24);
            this.comboBoxLocalidad.TabIndex = 63;
            this.comboBoxLocalidad.ValueMember = "id";
            // 
            // localitatsBindingSource
            // 
            this.localitatsBindingSource.DataSource = typeof(Chrysallis.localitats);
            // 
            // ModificarLocalidadButton
            // 
            this.ModificarLocalidadButton.Location = new System.Drawing.Point(412, 288);
            this.ModificarLocalidadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModificarLocalidadButton.Name = "ModificarLocalidadButton";
            this.ModificarLocalidadButton.Size = new System.Drawing.Size(93, 25);
            this.ModificarLocalidadButton.TabIndex = 64;
            this.ModificarLocalidadButton.Text = "Editar Loc.";
            this.ModificarLocalidadButton.UseVisualStyleBackColor = true;
            this.ModificarLocalidadButton.Click += new System.EventHandler(this.AñadirLocalidad_Click);
            // 
            // dateTimePickerHoraFinal
            // 
            this.dateTimePickerHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFinal.Location = new System.Drawing.Point(656, 118);
            this.dateTimePickerHoraFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerHoraFinal.Name = "dateTimePickerHoraFinal";
            this.dateTimePickerHoraFinal.Size = new System.Drawing.Size(119, 22);
            this.dateTimePickerHoraFinal.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "HORA CIERRE";
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(152, 117);
            this.dateTimePickerFechaFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(352, 22);
            this.dateTimePickerFechaFinal.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "FECHA CIERRE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonArchivoBuscar);
            this.groupBox1.Controls.Add(this.labelArchivo);
            this.groupBox1.Location = new System.Drawing.Point(911, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(379, 54);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // buttonEliminarImg
            // 
            this.buttonEliminarImg.Location = new System.Drawing.Point(1165, 21);
            this.buttonEliminarImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarImg.Name = "buttonEliminarImg";
            this.buttonEliminarImg.Size = new System.Drawing.Size(125, 28);
            this.buttonEliminarImg.TabIndex = 71;
            this.buttonEliminarImg.Text = "Eliminar";
            this.buttonEliminarImg.UseVisualStyleBackColor = true;
            this.buttonEliminarImg.Click += new System.EventHandler(this.buttonEliminarImg_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreaModEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1305, 684);
            this.Controls.Add(this.buttonEliminarImg);
            this.Controls.Add(this.dateTimePickerFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerHoraFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModificarLocalidadButton);
            this.Controls.Add(this.comboBoxLocalidad);
            this.Controls.Add(this.textBoxLatitud);
            this.Controls.Add(this.labelLatitud);
            this.Controls.Add(this.textBoxLongitud);
            this.Controls.Add(this.labelLongitud);
            this.Controls.Add(this.checkBoxmax);
            this.Controls.Add(this.checkBoxMinima);
            this.Controls.Add(this.textBoxminimo);
            this.Controls.Add(this.textBoxmax);
            this.Controls.Add(this.labelAsistMin);
            this.Controls.Add(this.labelAsistMax);
            this.Controls.Add(this.checkBoxVirtual);
            this.Controls.Add(this.textBoxEnlace);
            this.Controls.Add(this.labelEnlace);
            this.Controls.Add(this.dateTimePickerHoraInicio);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.checkBoxGratis);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.labelComunidad);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.labelLocalidad);
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
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreaModEventos";
            this.Text = " ";
            this.Activated += new System.EventHandler(this.CreaModEventos_Activated);
            this.Load += new System.EventHandler(this.CreaModEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.BindingSource comunitatsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.BindingSource provinciesBindingSource;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.CheckBox checkBoxGratis;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
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
        private System.Windows.Forms.TextBox textBoxLongitud;
        private System.Windows.Forms.Label labelLongitud;
        private System.Windows.Forms.TextBox textBoxLatitud;
        private System.Windows.Forms.Label labelLatitud;
        private System.Windows.Forms.ComboBox comboBoxLocalidad;
        private System.Windows.Forms.BindingSource localitatsBindingSource;
        private System.Windows.Forms.Button ModificarLocalidadButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEliminarImg;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}