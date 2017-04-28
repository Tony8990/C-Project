namespace HorsePuzzleWinForms
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnGo = new System.Windows.Forms.Button();
      this.txtBoardSize = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = " Board size:";
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(199, 4);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 1;
      this.btnGo.Text = "GO!";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // txtBoardSize
      // 
      this.txtBoardSize.Location = new System.Drawing.Point(80, 6);
      this.txtBoardSize.Name = "txtBoardSize";
      this.txtBoardSize.Size = new System.Drawing.Size(45, 20);
      this.txtBoardSize.TabIndex = 2;
      this.txtBoardSize.Text = "8";
      this.txtBoardSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 355);
      this.Controls.Add(this.txtBoardSize);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "The Horse Puzzle";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.TextBox txtBoardSize;
  }
}

