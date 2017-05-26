namespace cifraDeCesar
{
    partial class Form1
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
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxCifrado = new System.Windows.Forms.TextBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDecifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(266, 115);
            this.textBoxOriginal.TabIndex = 0;
            // 
            // textBoxCifrado
            // 
            this.textBoxCifrado.Location = new System.Drawing.Point(12, 133);
            this.textBoxCifrado.Multiline = true;
            this.textBoxCifrado.Name = "textBoxCifrado";
            this.textBoxCifrado.Size = new System.Drawing.Size(266, 115);
            this.textBoxCifrado.TabIndex = 1;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(313, 12);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 2;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDecifrar
            // 
            this.btnDecifrar.Location = new System.Drawing.Point(313, 55);
            this.btnDecifrar.Name = "btnDecifrar";
            this.btnDecifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDecifrar.TabIndex = 3;
            this.btnDecifrar.Text = "Decifrar";
            this.btnDecifrar.UseVisualStyleBackColor = true;
            this.btnDecifrar.Click += new System.EventHandler(this.btnDecifrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 312);
            this.Controls.Add(this.btnDecifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.textBoxCifrado);
            this.Controls.Add(this.textBoxOriginal);
            this.Name = "Form1";
            this.Text = "Estudo de Criptografia.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxCifrado;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDecifrar;
    }
}

