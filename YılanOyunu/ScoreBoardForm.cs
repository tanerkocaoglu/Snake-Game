using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;


namespace YılanOyunu
{
	public partial class ScoreBoardForm : Form
	{
		public ScoreBoardForm()
		{
			InitializeComponent();
		}

		readonly string sqlQuery = "select * from Tbl_Scoreboard";
		readonly string maincon = ConfigurationManager.ConnectionStrings["sqlString"].ConnectionString;

		private void ScoreBoardForm_Load(object sender, EventArgs e)
		{
			ShowScoreBoard();
		}
		void ShowScoreBoard()
		{
			using (var con = new SQLiteConnection(maincon))

			{
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, con);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				Grd_ScoreBoard.DataSource = dt;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			StartPageForm startPageForm = new StartPageForm();
			startPageForm.Show();
			this.Hide();
		}
	}
}
