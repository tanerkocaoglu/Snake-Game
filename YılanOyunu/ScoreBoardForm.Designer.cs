namespace YılanOyunu
{
	partial class ScoreBoardForm
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
			this.Grd_ScoreBoard = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Grd_ScoreBoard)).BeginInit();
			this.SuspendLayout();
			// 
			// Grd_ScoreBoard
			// 
			this.Grd_ScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Grd_ScoreBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_ScoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Grd_ScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_ScoreBoard.Location = new System.Drawing.Point(12, 12);
			this.Grd_ScoreBoard.Name = "Grd_ScoreBoard";
			this.Grd_ScoreBoard.RowHeadersWidth = 51;
			this.Grd_ScoreBoard.RowTemplate.Height = 24;
			this.Grd_ScoreBoard.Size = new System.Drawing.Size(481, 210);
			this.Grd_ScoreBoard.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(193, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 50);
			this.button1.TabIndex = 1;
			this.button1.Text = "GERİ DÖN";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ScoreBoardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 290);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Grd_ScoreBoard);
			this.Name = "ScoreBoardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ScoreBoardForm";
			this.Load += new System.EventHandler(this.ScoreBoardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grd_ScoreBoard)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView Grd_ScoreBoard;
		private System.Windows.Forms.Button button1;
	}
}