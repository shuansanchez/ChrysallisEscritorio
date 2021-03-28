namespace Chrysallis
{
    partial class VerMenores
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
            this.gridMenors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenors)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMenors
            // 
            this.gridMenors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenors.Location = new System.Drawing.Point(25, 68);
            this.gridMenors.Name = "gridMenors";
            this.gridMenors.Size = new System.Drawing.Size(720, 230);
            this.gridMenors.TabIndex = 0;
            // 
            // VerMenores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridMenors);
            this.Name = "VerMenores";
            this.Text = "VerMenores";
            this.Load += new System.EventHandler(this.VerMenores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMenors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMenors;
    }
}