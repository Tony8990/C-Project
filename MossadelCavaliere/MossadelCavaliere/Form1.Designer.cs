namespace MossadelCavaliere
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textsize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(165, 12);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 0;
            this.buttonstart.Text = "GO";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimensioni";
            // 
            // textsize
            // 
            this.textsize.Location = new System.Drawing.Point(75, 14);
            this.textsize.Name = "textsize";
            this.textsize.Size = new System.Drawing.Size(65, 20);
            this.textsize.TabIndex = 2;
            this.textsize.Text = "8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonstart);
            this.Name = "Form1";
            this.Text = "mossa del cavaliere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsize;
    }
}

