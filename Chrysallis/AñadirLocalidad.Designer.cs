namespace Chrysallis
{
    partial class AñadirLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirLocalidad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProvincia2 = new System.Windows.Forms.ComboBox();
            this.provinciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxComunidad2 = new System.Windows.Forms.ComboBox();
            this.comunitatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija la comunidad a la que pertenece la Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija la provincia a la que pertenece la Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escriba el nombre de la Localidad que desae añadir";
            // 
            // comboBoxProvincia2
            // 
            this.comboBoxProvincia2.DataSource = this.provinciesBindingSource;
            this.comboBoxProvincia2.DisplayMember = "nom";
            this.comboBoxProvincia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia2.FormattingEnabled = true;
            this.comboBoxProvincia2.Location = new System.Drawing.Point(370, 138);
            this.comboBoxProvincia2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProvincia2.Name = "comboBoxProvincia2";
            this.comboBoxProvincia2.Size = new System.Drawing.Size(352, 24);
            this.comboBoxProvincia2.TabIndex = 45;
            this.comboBoxProvincia2.ValueMember = "id";
            this.comboBoxProvincia2.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia2_SelectedIndexChanged);
            // 
            // provinciesBindingSource
            // 
            this.provinciesBindingSource.DataSource = typeof(Chrysallis.provincies);
            // 
            // comboBoxComunidad2
            // 
            this.comboBoxComunidad2.DataSource = this.comunitatsBindingSource;
            this.comboBoxComunidad2.DisplayMember = "nom";
            this.comboBoxComunidad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad2.FormattingEnabled = true;
            this.comboBoxComunidad2.Location = new System.Drawing.Point(370, 79);
            this.comboBoxComunidad2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxComunidad2.Name = "comboBoxComunidad2";
            this.comboBoxComunidad2.Size = new System.Drawing.Size(352, 24);
            this.comboBoxComunidad2.TabIndex = 46;
            this.comboBoxComunidad2.ValueMember = "id";
            this.comboBoxComunidad2.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidad2_SelectedIndexChanged);
            // 
            // comunitatsBindingSource
            // 
            this.comunitatsBindingSource.DataSource = typeof(Chrysallis.comunitats);
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(248, 306);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(134, 44);
            this.buttonAñadir.TabIndex = 48;
            this.buttonAñadir.Text = "Crear";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(490, 306);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(134, 44);
            this.buttonCancelar.TabIndex = 49;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(370, 205);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(352, 22);
            this.textBoxLocalidad.TabIndex = 50;
            // 
            // AñadirLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.comboBoxComunidad2);
            this.Controls.Add(this.comboBoxProvincia2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AñadirLocalidad";
            this.Text = "AñadirLocalidad";
            this.Load += new System.EventHandler(this.AñadirLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProvincia2;
        private System.Windows.Forms.ComboBox comboBoxComunidad2;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.BindingSource provinciesBindingSource;
        private System.Windows.Forms.BindingSource comunitatsBindingSource;
    }
}