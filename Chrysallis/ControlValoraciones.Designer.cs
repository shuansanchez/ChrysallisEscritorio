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
            this.dataGridViewValoraciones = new System.Windows.Forms.DataGridView();
            this.idsociDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idesdevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esdevenimentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).BeginInit();
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
            this.dataGridViewValoraciones.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewValoraciones.Name = "dataGridViewValoraciones";
            this.dataGridViewValoraciones.RowHeadersWidth = 51;
            this.dataGridViewValoraciones.RowTemplate.Height = 24;
            this.dataGridViewValoraciones.Size = new System.Drawing.Size(679, 383);
            this.dataGridViewValoraciones.TabIndex = 0;
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
            this.Controls.Add(this.dataGridViewValoraciones);
            this.Name = "ControlValoraciones";
            this.Text = "ControlValoraciones";
            this.Activated += new System.EventHandler(this.ControlValoraciones_Activated);
            this.Load += new System.EventHandler(this.ControlValoraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewValoraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idesdevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esdevenimentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource valoracionsBindingSource;
    }
}