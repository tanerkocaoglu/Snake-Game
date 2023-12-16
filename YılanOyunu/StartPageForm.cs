using System;
using System.Windows.Forms;

namespace YılanOyunu
{
	public partial class StartPageForm : Form
	{
		public StartPageForm()
		{
			InitializeComponent();
		}
		public static string playerName;
		private void Btn_ScoreBoard_Click(object sender, EventArgs e)
		{
			DirectToScoreBoardForm();
		}

		private void Btn_EasyLevel_Click(object sender, EventArgs e)
		{
			LevelTextToForm1("Kolay", 100);
		}

		private void Btn_MediumLevel_Click(object sender, EventArgs e)
		{
			LevelTextToForm1("Orta", 75);
		}

		private void Btn_HardLevel_Click(object sender, EventArgs e)
		{
			LevelTextToForm1("Zor", 50);
		}
		private void LevelTextToForm1(string levelText, int timerInterval)
		{
			playerName = txt_PlayerName.Text;
			if (string.IsNullOrWhiteSpace(txt_PlayerName.Text))
			{
				MessageBox.Show("Kullanıcı Adı Giriniz");
			}
			else
			{
				Form1 form = new Form1();
				Form1.levelText = levelText;
				Form1.timerInterval = timerInterval;
				form.Show();
				this.Hide();
			}
		}
		private void DirectToScoreBoardForm()
		{
			ScoreBoardForm scoreBoardForm = new ScoreBoardForm();
			scoreBoardForm.Show();
			this.Hide();
		}


	}

}

