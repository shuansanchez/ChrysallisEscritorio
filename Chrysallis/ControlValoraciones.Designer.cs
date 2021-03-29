namespace Chrysallis
{
    partial class ControlValoraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlValoraciones));
            this.dataGridViewValoraciones = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.idsociDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idesdevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esdevenimentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewValoraciones
            // 
            this.dataGridViewValoraciones.AutoGenerateColumns = false;
            this.dataGridViewValoraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValoraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsociDataGridViewTextBoxColumn,
            this.idesdevenimentDataGridViewTextBoxColumn,
            this.valoracioDataGridViewTextBoxColumn,
            this.esdevenimentsDataGridViewTextBoxColumn,
            this.socisDataGridViewTextBoxColumn});
            this.dataGridViewValoraciones.DataSource = this.valoracionsBindingSource;
            this.dataGridViewValoraciones.Location = new System.Drawing.Point(8, 40);
            this.dataGridViewValoraciones.Name = "dataGridViewValoraciones";
            this.dataGridViewValoraciones.RowHeadersWidth = 51;
            this.dataGridViewValoraciones.RowTemplate.Height = 24;
            this.dataGridViewValoraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValoraciones.Size = new System.Drawing.Size(679, 383);
            this.dataGridViewValoraciones.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // idsociDataGridViewTextBoxColumn
            // 
            this.idsociDataGridViewTextBoxColumn.DataPropertyName = "id_soci";
            this.idsociDataGridViewTextBoxColumn.HeaderText = "id_soci";
            this.idsociDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idsociDataGridViewTextBoxColumn.Name = "idsociDataGridViewTextBoxColumn";
            this.idsociDataGridViewTextBoxColumn.Width = 125;
            // 
            // idesdevenimentDataGridViewTextBoxColumn
            // 
            this.idesdevenimentDataGridViewTextBoxColumn.DataPropertyName = "id_esdeveniment";
            this.idesdevenimentDataGridViewTextBoxColumn.HeaderText = "id_esdeveniment";
            this.idesdevenimentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idesdevenimentDataGridViewTextBoxColumn.Name = "idesdevenimentDataGridViewTextBoxColumn";
            this.idesdevenimentDataGridViewTextBoxColumn.Width = 125;
            // 
            // valoracioDataGridViewTextBoxColumn
            // 
            this.valoracioDataGridViewTextBoxColumn.DataPropertyName = "valoracio";
            this.valoracioDataGridViewTextBoxColumn.HeaderText = "valoracio";
            this.valoracioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoracioDataGridViewTextBoxColumn.Name = "valoracioDataGridViewTextBoxColumn";
            this.valoracioDataGridViewTextBoxColumn.Width = 125;
            // 
            // esdevenimentsDataGridViewTextBoxColumn
            // 
            this.esdevenimentsDataGridViewTextBoxColumn.DataPropertyName = "esdeveniments";
            this.esdevenimentsDataGridViewTextBoxColumn.HeaderText = "esdeveniments";
            this.esdevenimentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.esdevenimentsDataGridViewTextBoxColumn.Name = "esdevenimentsDataGridViewTextBoxColumn";
            this.esdevenimentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // socisDataGridViewTextBoxColumn
            // 
            this.socisDataGridViewTextBoxColumn.DataPropertyName = "socis";
            this.socisDataGridViewTextBoxColumn.HeaderText = "socis";
            this.socisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socisDataGridViewTextBoxColumn.Name = "socisDataGridViewTextBoxColumn";
            this.socisDataGridViewTextBoxColumn.Width = 125;
            // 
            // valoracionsBindingSource
            // 
            this.valoracionsBindingSource.DataSource = typeof(Chrysallis.valoracions);
            // 
            // ControlValoraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 426);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewValoraciones);
            this.Name = "ControlValoraciones";
            this.Text = "ControlValoraciones";
            this.Activated += new System.EventHandler(this.ControlValoraciones_Activated);
            this.Load += new System.EventHandler(this.ControlValoraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewValoraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idesdevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esdevenimentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource valoracionsBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}