namespace Chrysallis
{
    partial class Control_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Usuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 27);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
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
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.idrolDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idsocioDataGridViewTextBoxColumn,
            this.rolsDataGridViewTextBoxColumn,
            this.socisDataGridViewTextBoxColumn,
            this.comunitatsDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.usuarisBindingSource1;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(886, 389);
            this.dataGridViewUsers.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            this.contrasenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idrolDataGridViewTextBoxColumn
            // 
            this.idrolDataGridViewTextBoxColumn.DataPropertyName = "id_rol";
            this.idrolDataGridViewTextBoxColumn.HeaderText = "id_rol";
            this.idrolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrolDataGridViewTextBoxColumn.Name = "idrolDataGridViewTextBoxColumn";
            this.idrolDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrolDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // idsocioDataGridViewTextBoxColumn
            // 
            this.idsocioDataGridViewTextBoxColumn.DataPropertyName = "id_socio";
            this.idsocioDataGridViewTextBoxColumn.HeaderText = "id_socio";
            this.idsocioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idsocioDataGridViewTextBoxColumn.Name = "idsocioDataGridViewTextBoxColumn";
            this.idsocioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsocioDataGridViewTextBoxColumn.Width = 125;
            // 
            // rolsDataGridViewTextBoxColumn
            // 
            this.rolsDataGridViewTextBoxColumn.DataPropertyName = "rols";
            this.rolsDataGridViewTextBoxColumn.HeaderText = "rols";
            this.rolsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolsDataGridViewTextBoxColumn.Name = "rolsDataGridViewTextBoxColumn";
            this.rolsDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolsDataGridViewTextBoxColumn.Width = 125;
            // 
            // socisDataGridViewTextBoxColumn
            // 
            this.socisDataGridViewTextBoxColumn.DataPropertyName = "socis";
            this.socisDataGridViewTextBoxColumn.HeaderText = "socis";
            this.socisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socisDataGridViewTextBoxColumn.Name = "socisDataGridViewTextBoxColumn";
            this.socisDataGridViewTextBoxColumn.ReadOnly = true;
            this.socisDataGridViewTextBoxColumn.Width = 125;
            // 
            // comunitatsDataGridViewTextBoxColumn
            // 
            this.comunitatsDataGridViewTextBoxColumn.DataPropertyName = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.HeaderText = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comunitatsDataGridViewTextBoxColumn.Name = "comunitatsDataGridViewTextBoxColumn";
            this.comunitatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunitatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarisBindingSource1
            // 
            this.usuarisBindingSource1.DataSource = typeof(Chrysallis.usuaris);
            // 
            // usuarisBindingSource
            // 
            this.usuarisBindingSource.DataSource = typeof(Chrysallis.usuaris);
            // 
            // Control_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control_Usuario";
            this.Text = "Control_Usuario";
            this.Activated += new System.EventHandler(this.Control_Usuario_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarisBindingSource;
        private System.Windows.Forms.BindingSource usuarisBindingSource1;
    }
}