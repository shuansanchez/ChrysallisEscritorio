namespace Chrysallis
{
    partial class CrearModMenor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearModMenor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomText = new System.Windows.Forms.TextBox();
            this.relacioMenor = new System.Windows.Forms.TextBox();
            this.crearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relación";
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(116, 38);
            this.nomText.Margin = new System.Windows.Forms.Padding(4);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(665, 22);
            this.nomText.TabIndex = 2;
            // 
            // relacioMenor
            // 
            this.relacioMenor.Location = new System.Drawing.Point(116, 102);
            this.relacioMenor.Margin = new System.Windows.Forms.Padding(4);
            this.relacioMenor.Name = "relacioMenor";
            this.relacioMenor.Size = new System.Drawing.Size(665, 22);
            this.relacioMenor.TabIndex = 3;
            // 
            // crearBtn
            // 
            this.crearBtn.Location = new System.Drawing.Point(357, 163);
            this.crearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(100, 28);
            this.crearBtn.TabIndex = 4;
            this.crearBtn.Text = "Crear";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // CrearModMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(844, 228);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.relacioMenor);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrearModMenor";
            this.Text = "CrearMenor";
            this.Load += new System.EventHandler(this.CrearModMenor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.TextBox relacioMenor;
        private System.Windows.Forms.Button crearBtn;
    }
}