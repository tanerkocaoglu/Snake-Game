namespace YılanOyunu
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
			this.components = new System.ComponentModel.Container();
			this.picCanvas = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblScore = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrGame = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_Difficulty = new System.Windows.Forms.Label();
			this.Btn_ReDirectToStarPageForm = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_PlayerName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// picCanvas
			// 
			this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picCanvas.Location = new System.Drawing.Point(12, 43);
			this.picCanvas.Margin = new System.Windows.Forms.Padding(0);
			this.picCanvas.Name = "picCanvas";
			this.picCanvas.Size = new System.Drawing.Size(710, 655);
			this.picCanvas.TabIndex = 0;
			this.picCanvas.TabStop = false;
			this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnStart.Location = new System.Drawing.Point(766, 43);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(188, 50);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "BAŞLA";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.Btn_StartGame);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblScore.Location = new System.Drawing.Point(875, 194);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(19, 20);
			this.lblScore.TabIndex = 2;
			this.lblScore.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(775, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Puan:";
			// 
			// tmrGame
			// 
			this.tmrGame.Interval = 40;
			this.tmrGame.Tick += new System.EventHandler(this.GameTimerEvent);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(775, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Seviye :";
			// 
			// lbl_Difficulty
			// 
			this.lbl_Difficulty.AutoSize = true;
			this.lbl_Difficulty.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_Difficulty.Location = new System.Drawing.Point(875, 146);
			this.lbl_Difficulty.Name = "lbl_Difficulty";
			this.lbl_Difficulty.Size = new System.Drawing.Size(0, 20);
			this.lbl_Difficulty.TabIndex = 5;
			// 
			// Btn_ReDirectToStarPageForm
			// 
			this.Btn_ReDirectToStarPageForm.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Btn_ReDirectToStarPageForm.Location = new System.Drawing.Point(766, 264);
			this.Btn_ReDirectToStarPageForm.Name = "Btn_ReDirectToStarPageForm";
			this.Btn_ReDirectToStarPageForm.Size = new System.Drawing.Size(188, 50);
			this.Btn_ReDirectToStarPageForm.TabIndex = 6;
			this.Btn_ReDirectToStarPageForm.Text = "SEVİYE SEÇ";
			this.Btn_ReDirectToStarPageForm.UseVisualStyleBackColor = true;
			this.Btn_ReDirectToStarPageForm.Click += new System.EventHandler(this.Btn_ReDirectToStarPageForm_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Oyuncu Adı :";
			// 
			// lbl_PlayerName
			// 
			this.lbl_PlayerName.AutoSize = true;
			this.lbl_PlayerName.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbl_PlayerName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_PlayerName.Location = new System.Drawing.Point(149, 9);
			this.lbl_PlayerName.Name = "lbl_PlayerName";
			this.lbl_PlayerName.Size = new System.Drawing.Size(0, 20);
			this.lbl_PlayerName.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 720);
			this.Controls.Add(this.lbl_PlayerName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Btn_ReDirectToStarPageForm);
			this.Controls.Add(this.lbl_Difficulty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.picCanvas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SnakeGame";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
			((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label lbl_Difficulty;
		private System.Windows.Forms.Button Btn_ReDirectToStarPageForm;
		private System.Windows.Forms.Timer tmrGame;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_PlayerName;
	}
}

