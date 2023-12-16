namespace YılanOyunu
{
	partial class StartPageForm
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
			this.Btn_EasyLevel = new System.Windows.Forms.Button();
			this.Btn_MediumLevel = new System.Windows.Forms.Button();
			this.Btn_HardLevel = new System.Windows.Forms.Button();
			this.Btn_ScoreBoard = new System.Windows.Forms.Button();
			this.txt_PlayerName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_EasyLevel
			// 
			this.Btn_EasyLevel.Location = new System.Drawing.Point(12, 73);
			this.Btn_EasyLevel.Name = "Btn_EasyLevel";
			this.Btn_EasyLevel.Size = new System.Drawing.Size(132, 47);
			this.Btn_EasyLevel.TabIndex = 0;
			this.Btn_EasyLevel.Text = "KOLAY";
			this.Btn_EasyLevel.UseVisualStyleBackColor = true;
			this.Btn_EasyLevel.Click += new System.EventHandler(this.Btn_EasyLevel_Click);
			// 
			// Btn_MediumLevel
			// 
			this.Btn_MediumLevel.Location = new System.Drawing.Point(163, 73);
			this.Btn_MediumLevel.Name = "Btn_MediumLevel";
			this.Btn_MediumLevel.Size = new System.Drawing.Size(132, 47);
			this.Btn_MediumLevel.TabIndex = 0;
			this.Btn_MediumLevel.Text = "ORTA";
			this.Btn_MediumLevel.UseVisualStyleBackColor = true;
			this.Btn_MediumLevel.Click += new System.EventHandler(this.Btn_MediumLevel_Click);
			// 
			// Btn_HardLevel
			// 
			this.Btn_HardLevel.Location = new System.Drawing.Point(313, 73);
			this.Btn_HardLevel.Name = "Btn_HardLevel";
			this.Btn_HardLevel.Size = new System.Drawing.Size(132, 47);
			this.Btn_HardLevel.TabIndex = 0;
			this.Btn_HardLevel.Text = "ZOR";
			this.Btn_HardLevel.UseVisualStyleBackColor = true;
			this.Btn_HardLevel.Click += new System.EventHandler(this.Btn_HardLevel_Click);
			// 
			// Btn_ScoreBoard
			// 
			this.Btn_ScoreBoard.Location = new System.Drawing.Point(163, 141);
			this.Btn_ScoreBoard.Name = "Btn_ScoreBoard";
			this.Btn_ScoreBoard.Size = new System.Drawing.Size(132, 47);
			this.Btn_ScoreBoard.TabIndex = 1;
			this.Btn_ScoreBoard.Text = "SKOR TABLOSU";
			this.Btn_ScoreBoard.UseVisualStyleBackColor = true;
			this.Btn_ScoreBoard.Click += new System.EventHandler(this.Btn_ScoreBoard_Click);
			// 
			// txt_PlayerName
			// 
			this.txt_PlayerName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_PlayerName.Location = new System.Drawing.Point(268, 14);
			this.txt_PlayerName.Name = "txt_PlayerName";
			this.txt_PlayerName.Size = new System.Drawing.Size(177, 30);
			this.txt_PlayerName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Oyuncu Adı Giriniz :";
			// 
			// StartPageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 215);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_PlayerName);
			this.Controls.Add(this.Btn_ScoreBoard);
			this.Controls.Add(this.Btn_HardLevel);
			this.Controls.Add(this.Btn_MediumLevel);
			this.Controls.Add(this.Btn_EasyLevel);
			this.Name = "StartPageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StartPageForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_EasyLevel;
		private System.Windows.Forms.Button Btn_MediumLevel;
		private System.Windows.Forms.Button Btn_HardLevel;
		private System.Windows.Forms.Button Btn_ScoreBoard;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_PlayerName;
	}
}