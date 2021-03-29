namespace Chrysallis
{
    partial class ControlMenores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMenores));
            this.dataGridViewMenores = new System.Windows.Forms.DataGridView();
            this.toolStripCrearMenor = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModMenor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBorrarMenor = new System.Windows.Forms.ToolStripButton();
            this.menors_socis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRelacion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenores)).BeginInit();
            this.toolStripCrearMenor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenores
            // 
            this.dataGridViewMenores.AutoGenerateColumns = false;
            this.dataGridViewMenores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.menors_socis});
            this.dataGridViewMenores.DataSource = this.menorsBindingSource;
            this.dataGridViewMenores.Location = new System.Drawing.Point(9, 24);
            this.dataGridViewMenores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMenores.Name = "dataGridViewMenores";
            this.dataGridViewMenores.RowHeadersWidth = 51;
            this.dataGridViewMenores.RowTemplate.Height = 24;
            this.dataGridViewMenores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenores.Size = new System.Drawing.Size(582, 332);
            this.dataGridViewMenores.TabIndex = 0;
            this.dataGridViewMenores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMenores_CellFormatting);
            // 
            // toolStripCrearMenor
            // 
            this.toolStripCrearMenor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCrearMenor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButtonModMenor,
            this.toolStripButtonBorrarMenor});
            this.toolStripCrearMenor.Location = new System.Drawing.Point(0, 0);
            this.toolStripCrearMenor.Name = "toolStripCrearMenor";
            this.toolStripCrearMenor.Size = new System.Drawing.Size(600, 27);
            this.toolStripCrearMenor.TabIndex = 1;
            this.toolStripCrearMenor.Text = "toolStrip1";
            this.toolStripCrearMenor.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripCrearMenor_ItemClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonModMenor
            // 
            this.toolStripButtonModMenor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModMenor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModMenor.Image")));
            this.toolStripButtonModMenor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModMenor.Name = "toolStripButtonModMenor";
            this.toolStripButtonModMenor.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonModMenor.Text = "toolStripButton1";
            this.toolStripButtonModMenor.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonBorrarMenor
            // 
            this.toolStripButtonBorrarMenor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBorrarMenor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBorrarMenor.Image")));
            this.toolStripButtonBorrarMenor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBorrarMenor.Name = "toolStripButtonBorrarMenor";
            this.toolStripButtonBorrarMenor.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonBorrarMenor.Text = "toolStripButton3";
            this.toolStripButtonBorrarMenor.Click += new System.EventHandler(this.toolStripButtonBorrarMenor_Click);
            // 
            // menors_socis
            // 
            this.menors_socis.DataPropertyName = "menors_socis";
            this.menors_socis.HeaderText = "menors_socis";
            this.menors_socis.Name = "menors_socis";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // menorsBindingSource
            // 
            this.menorsBindingSource.DataSource = typeof(Chrysallis.menors);
            // 
            // bindingSourceRelacion
            // 
            this.bindingSourceRelacion.DataSource = typeof(Chrysallis.menors_socis);
            // 
            // ControlMenores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStripCrearMenor);
            this.Controls.Add(this.dataGridViewMenores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ControlMenores";
            this.Text = "ControlMenores";
            this.Activated += new System.EventHandler(this.ControlMenores_Activated);
            this.Load += new System.EventHandler(this.ControlMenores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenores)).EndInit();
            this.toolStripCrearMenor.ResumeLayout(false);
            this.toolStripCrearMenor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenores;
        private System.Windows.Forms.BindingSource menorsBindingSource;
        private System.Windows.Forms.ToolStrip toolStripCrearMenor;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButtonModMenor;
        private System.Windows.Forms.ToolStripButton toolStripButtonBorrarMenor;
        private System.Windows.Forms.BindingSource bindingSourceRelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menors_socis;
    }
}