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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblrisultatodelar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpuntedelare = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnrisult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblutente = new System.Windows.Forms.Label();
            this.lblpc = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreUte = new System.Windows.Forms.Label();
            this.lblpcsco = new System.Windows.Forms.Label();
            this.lblmontUT = new System.Windows.Forms.Label();
            this.lblmontePC = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
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
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
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
            this.lblDealer1m.Location = new System.Drawing.Point(310, 224);
            this.lblDealer1m.Name = "lblDealer1m";
            this.lblDealer1m.Size = new System.Drawing.Size(18, 20);
            this.lblDealer1m.TabIndex = 1;
            this.lblDealer1m.Text = "0";
            // 
            // lblDealer2m
            // 
            this.lblDealer2m.AutoSize = true;
            this.lblDealer2m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer2m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer2m.Location = new System.Drawing.Point(382, 224);
            this.lblDealer2m.Name = "lblDealer2m";
            this.lblDealer2m.Size = new System.Drawing.Size(18, 20);
            this.lblDealer2m.TabIndex = 2;
            this.lblDealer2m.Text = "0";
            // 
            // lblDealer3m
            // 
            this.lblDealer3m.AutoSize = true;
            this.lblDealer3m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer3m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer3m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer3m.Location = new System.Drawing.Point(466, 224);
            this.lblDealer3m.Name = "lblDealer3m";
            this.lblDealer3m.Size = new System.Drawing.Size(18, 20);
            this.lblDealer3m.TabIndex = 3;
            this.lblDealer3m.Text = "0";
            // 
            // lblDealer4m
            // 
            this.lblDealer4m.AutoSize = true;
            this.lblDealer4m.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer4m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer4m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDealer4m.Location = new System.Drawing.Point(550, 224);
            this.lblDealer4m.Name = "lblDealer4m";
            this.lblDealer4m.Size = new System.Drawing.Size(18, 20);
            this.lblDealer4m.TabIndex = 4;
            this.lblDealer4m.Text = "0";
            // 
            // lblplayer1m
            // 
            this.lblplayer1m.AutoSize = true;
            this.lblplayer1m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer1m.Location = new System.Drawing.Point(309, 443);
            this.lblplayer1m.Name = "lblplayer1m";
            this.lblplayer1m.Size = new System.Drawing.Size(18, 20);
            this.lblplayer1m.TabIndex = 8;
            this.lblplayer1m.Text = "0";
            // 
            // lblplayer2m
            // 
            this.lblplayer2m.AutoSize = true;
            this.lblplayer2m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer2m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer2m.Location = new System.Drawing.Point(376, 443);
            this.lblplayer2m.Name = "lblplayer2m";
            this.lblplayer2m.Size = new System.Drawing.Size(18, 20);
            this.lblplayer2m.TabIndex = 7;
            this.lblplayer2m.Text = "0";
            // 
            // lblplayer3m
            // 
            this.lblplayer3m.AutoSize = true;
            this.lblplayer3m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer3m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer3m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer3m.Location = new System.Drawing.Point(442, 443);
            this.lblplayer3m.Name = "lblplayer3m";
            this.lblplayer3m.Size = new System.Drawing.Size(18, 20);
            this.lblplayer3m.TabIndex = 6;
            this.lblplayer3m.Text = "0";
            // 
            // lblplayer4m
            // 
            this.lblplayer4m.AutoSize = true;
            this.lblplayer4m.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer4m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer4m.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplayer4m.Location = new System.Drawing.Point(520, 443);
            this.lblplayer4m.Name = "lblplayer4m";
            this.lblplayer4m.Size = new System.Drawing.Size(18, 20);
            this.lblplayer4m.TabIndex = 5;
            this.lblplayer4m.Text = "0";
            // 
            // btnChiama
            // 
            this.btnChiama.Location = new System.Drawing.Point(606, 433);
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
            this.lblPunteggio.Location = new System.Drawing.Point(409, 408);
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
            this.lnlRisultato.Location = new System.Drawing.Point(521, 402);
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
            this.lblRisultato.Location = new System.Drawing.Point(550, 403);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(26, 29);
            this.lblRisultato.TabIndex = 12;
            this.lblRisultato.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dealear Call";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblrisultatodelar
            // 
            this.lblrisultatodelar.AutoSize = true;
            this.lblrisultatodelar.BackColor = System.Drawing.Color.Transparent;
            this.lblrisultatodelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrisultatodelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblrisultatodelar.Location = new System.Drawing.Point(553, 178);
            this.lblrisultatodelar.Name = "lblrisultatodelar";
            this.lblrisultatodelar.Size = new System.Drawing.Size(26, 29);
            this.lblrisultatodelar.TabIndex = 16;
            this.lblrisultatodelar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(524, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 15;
            // 
            // lblpuntedelare
            // 
            this.lblpuntedelare.AutoSize = true;
            this.lblpuntedelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntedelare.ForeColor = System.Drawing.Color.White;
            this.lblpuntedelare.Location = new System.Drawing.Point(412, 183);
            this.lblpuntedelare.Name = "lblpuntedelare";
            this.lblpuntedelare.Size = new System.Drawing.Size(106, 25);
            this.lblpuntedelare.TabIndex = 14;
            this.lblpuntedelare.Text = "Punteggio:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(33, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrisult
            // 
            this.btnrisult.BackColor = System.Drawing.Color.Red;
            this.btnrisult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrisult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrisult.Location = new System.Drawing.Point(611, 394);
            this.btnrisult.Name = "btnrisult";
            this.btnrisult.Size = new System.Drawing.Size(103, 33);
            this.btnrisult.TabIndex = 18;
            this.btnrisult.Text = "Passo";
            this.btnrisult.UseVisualStyleBackColor = false;
            this.btnrisult.Click += new System.EventHandler(this.btnrisult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(279, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(359, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(443, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(446, 293);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 103);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(362, 293);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 103);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(279, 293);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(72, 103);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(531, 293);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(72, 103);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // lblutente
            // 
            this.lblutente.AutoSize = true;
            this.lblutente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblutente.Location = new System.Drawing.Point(289, 405);
            this.lblutente.Name = "lblutente";
            this.lblutente.Size = new System.Drawing.Size(105, 29);
            this.lblutente.TabIndex = 27;
            this.lblutente.Text = "lblutente";
            // 
            // lblpc
            // 
            this.lblpc.AutoSize = true;
            this.lblpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpc.ForeColor = System.Drawing.Color.Red;
            this.lblpc.Location = new System.Drawing.Point(305, 183);
            this.lblpc.Name = "lblpc";
            this.lblpc.Size = new System.Drawing.Size(46, 29);
            this.lblpc.TabIndex = 28;
            this.lblpc.Text = "PC";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(792, 46);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 29);
            this.lblScore.TabIndex = 29;
            this.lblScore.Text = "Score";
            // 
            // lblScoreUte
            // 
            this.lblScoreUte.AutoSize = true;
            this.lblScoreUte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreUte.ForeColor = System.Drawing.Color.Red;
            this.lblScoreUte.Location = new System.Drawing.Point(792, 144);
            this.lblScoreUte.Name = "lblScoreUte";
            this.lblScoreUte.Size = new System.Drawing.Size(77, 29);
            this.lblScoreUte.TabIndex = 30;
            this.lblScoreUte.Text = "Score";
            // 
            // lblpcsco
            // 
            this.lblpcsco.AutoSize = true;
            this.lblpcsco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpcsco.ForeColor = System.Drawing.Color.Red;
            this.lblpcsco.Location = new System.Drawing.Point(955, 144);
            this.lblpcsco.Name = "lblpcsco";
            this.lblpcsco.Size = new System.Drawing.Size(81, 29);
            this.lblpcsco.TabIndex = 31;
            this.lblpcsco.Text = "Banco";
            // 
            // lblmontUT
            // 
            this.lblmontUT.AutoSize = true;
            this.lblmontUT.BackColor = System.Drawing.Color.Transparent;
            this.lblmontUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontUT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblmontUT.Location = new System.Drawing.Point(818, 197);
            this.lblmontUT.Name = "lblmontUT";
            this.lblmontUT.Size = new System.Drawing.Size(26, 29);
            this.lblmontUT.TabIndex = 32;
            this.lblmontUT.Text = "0";
            // 
            // lblmontePC
            // 
            this.lblmontePC.AutoSize = true;
            this.lblmontePC.BackColor = System.Drawing.Color.Transparent;
            this.lblmontePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontePC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblmontePC.Location = new System.Drawing.Point(985, 197);
            this.lblmontePC.Name = "lblmontePC";
            this.lblmontePC.Size = new System.Drawing.Size(26, 29);
            this.lblmontePC.TabIndex = 33;
            this.lblmontePC.Text = "0";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(960, 433);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 491);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblmontePC);
            this.Controls.Add(this.lblmontUT);
            this.Controls.Add(this.lblpcsco);
            this.Controls.Add(this.lblScoreUte);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblpc);
            this.Controls.Add(this.lblutente);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnrisult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblrisultatodelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpuntedelare);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblrisultatodelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpuntedelare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnrisult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblutente;
        private System.Windows.Forms.Label lblpc;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreUte;
        private System.Windows.Forms.Label lblpcsco;
        private System.Windows.Forms.Label lblmontUT;
        private System.Windows.Forms.Label lblmontePC;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

