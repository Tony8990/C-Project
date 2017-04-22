namespace BlackJack
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDealer1m = new System.Windows.Forms.Label();
            this.lblDealer2m = new System.Windows.Forms.Label();
            this.lblDealer3m = new System.Windows.Forms.Label();
            this.lblDealer4m = new System.Windows.Forms.Label();
            this.lblplayer1m = new System.Windows.Forms.Label();
            this.lblplayer2m = new System.Windows.Forms.Label();
            this.lblplayer3m = new System.Windows.Forms.Label();
            this.lblplayer4m = new System.Windows.Forms.Label();
            this.btnChiama = new System.Windows.Forms.Button();
            this.lblPunteggio = new System.Windows.Forms.Label();
            this.lnlRisultato = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partitaToolStripMenuItem
            // 
            this.partitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.partitaToolStripMenuItem.Name = "partitaToolStripMenuItem";
            this.partitaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.partitaToolStripMenuItem.Text = "Partita";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click);
            // 
            // lblDealer1m
            // 
            this.lblDealer1m.AutoSize = true;
            this.lblDealer1m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer1m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer1m.Location = new System.Drawing.Point(241, 109);
            this.lblDealer1m.Name = "lblDealer1m";
            this.lblDealer1m.Size = new System.Drawing.Size(51, 20);
            this.lblDealer1m.TabIndex = 1;
            this.lblDealer1m.Text = "label1";
            // 
            // lblDealer2m
            // 
            this.lblDealer2m.AutoSize = true;
            this.lblDealer2m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer2m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer2m.Location = new System.Drawing.Point(313, 109);
            this.lblDealer2m.Name = "lblDealer2m";
            this.lblDealer2m.Size = new System.Drawing.Size(51, 20);
            this.lblDealer2m.TabIndex = 2;
            this.lblDealer2m.Text = "label2";
            // 
            // lblDealer3m
            // 
            this.lblDealer3m.AutoSize = true;
            this.lblDealer3m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer3m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer3m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer3m.Location = new System.Drawing.Point(397, 109);
            this.lblDealer3m.Name = "lblDealer3m";
            this.lblDealer3m.Size = new System.Drawing.Size(51, 20);
            this.lblDealer3m.TabIndex = 3;
            this.lblDealer3m.Text = "label3";
            // 
            // lblDealer4m
            // 
            this.lblDealer4m.AutoSize = true;
            this.lblDealer4m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer4m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer4m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer4m.Location = new System.Drawing.Point(481, 109);
            this.lblDealer4m.Name = "lblDealer4m";
            this.lblDealer4m.Size = new System.Drawing.Size(51, 20);
            this.lblDealer4m.TabIndex = 4;
            this.lblDealer4m.Text = "label4";
            // 
            // lblplayer1m
            // 
            this.lblplayer1m.AutoSize = true;
            this.lblplayer1m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer1m.Location = new System.Drawing.Point(251, 264);
            this.lblplayer1m.Name = "lblplayer1m";
            this.lblplayer1m.Size = new System.Drawing.Size(51, 20);
            this.lblplayer1m.TabIndex = 8;
            this.lblplayer1m.Text = "label5";
            // 
            // lblplayer2m
            // 
            this.lblplayer2m.AutoSize = true;
            this.lblplayer2m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer2m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer2m.Location = new System.Drawing.Point(318, 264);
            this.lblplayer2m.Name = "lblplayer2m";
            this.lblplayer2m.Size = new System.Drawing.Size(51, 20);
            this.lblplayer2m.TabIndex = 7;
            this.lblplayer2m.Text = "label6";
            // 
            // lblplayer3m
            // 
            this.lblplayer3m.AutoSize = true;
            this.lblplayer3m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer3m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer3m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer3m.Location = new System.Drawing.Point(384, 264);
            this.lblplayer3m.Name = "lblplayer3m";
            this.lblplayer3m.Size = new System.Drawing.Size(51, 20);
            this.lblplayer3m.TabIndex = 6;
            this.lblplayer3m.Text = "label7";
            // 
            // lblplayer4m
            // 
            this.lblplayer4m.AutoSize = true;
            this.lblplayer4m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer4m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer4m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer4m.Location = new System.Drawing.Point(462, 264);
            this.lblplayer4m.Name = "lblplayer4m";
            this.lblplayer4m.Size = new System.Drawing.Size(51, 20);
            this.lblplayer4m.TabIndex = 5;
            this.lblplayer4m.Text = "label8";
            // 
            // btnChiama
            // 
            this.btnChiama.Location = new System.Drawing.Point(466, 307);
            this.btnChiama.Name = "btnChiama";
            this.btnChiama.Size = new System.Drawing.Size(108, 30);
            this.btnChiama.TabIndex = 9;
            this.btnChiama.Text = "Chiama";
            this.btnChiama.UseVisualStyleBackColor = true;
            this.btnChiama.Click += new System.EventHandler(this.btnChiama_Click);
            // 
            // lblPunteggio
            // 
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggio.ForeColor = System.Drawing.Color.White;
            this.lblPunteggio.Location = new System.Drawing.Point(242, 313);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(106, 25);
            this.lblPunteggio.TabIndex = 10;
            this.lblPunteggio.Text = "Punteggio:";
            this.lblPunteggio.Click += new System.EventHandler(this.lblPunteggio_Click);
            // 
            // lnlRisultato
            // 
            this.lnlRisultato.AutoSize = true;
            this.lnlRisultato.BackColor = System.Drawing.Color.Transparent;
            this.lnlRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlRisultato.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lnlRisultato.Location = new System.Drawing.Point(354, 307);
            this.lnlRisultato.Name = "lnlRisultato";
            this.lnlRisultato.Size = new System.Drawing.Size(0, 29);
            this.lnlRisultato.TabIndex = 11;
            this.lnlRisultato.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.BackColor = System.Drawing.Color.Transparent;
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRisultato.Location = new System.Drawing.Point(383, 308);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(26, 29);
            this.lblRisultato.TabIndex = 12;
            this.lblRisultato.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 376);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.lnlRisultato);
            this.Controls.Add(this.lblPunteggio);
            this.Controls.Add(this.btnChiama);
            this.Controls.Add(this.lblplayer1m);
            this.Controls.Add(this.lblplayer2m);
            this.Controls.Add(this.lblplayer3m);
            this.Controls.Add(this.lblplayer4m);
            this.Controls.Add(this.lblDealer4m);
            this.Controls.Add(this.lblDealer3m);
            this.Controls.Add(this.lblDealer2m);
            this.Controls.Add(this.lblDealer1m);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Partita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.Label lblDealer1m;
        private System.Windows.Forms.Label lblDealer2m;
        private System.Windows.Forms.Label lblDealer3m;
        private System.Windows.Forms.Label lblDealer4m;
        private System.Windows.Forms.Label lblplayer1m;
        private System.Windows.Forms.Label lblplayer2m;
        private System.Windows.Forms.Label lblplayer3m;
        private System.Windows.Forms.Label lblplayer4m;
        private System.Windows.Forms.Button btnChiama;
        private System.Windows.Forms.Label lblPunteggio;
        private System.Windows.Forms.Label lnlRisultato;
        private System.Windows.Forms.Label lblRisultato;
    }
}

