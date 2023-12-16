using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;

namespace YılanOyunu
{

	public partial class Form1 : Form
	{
		private readonly List<Circle> snake = new List<Circle>();
		private Circle food = new Circle();
		private new int Width, Height;
		private int score;
		private readonly Random rnd = new Random();
		private bool goLeft, goRight, goDown, goUp;

		private readonly Settings settings = new Settings();
		public static string levelText;
		public static int timerInterval;
		public Form1()
		{
			InitializeComponent();
		}
		private void Create_DB()
		{
			string path = "SnakeGameDB.db";

			if (!System.IO.File.Exists(path))
			{
				SQLiteConnection.CreateFile(path);
				using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
				{
					sqlite.Open();
					string sql = "create table Tbl_Scoreboard(playername nvarchar(50),score int,difficulty nvarchar(50))";
					SQLiteCommand command = new SQLiteCommand(sql, sqlite);
					command.ExecuteNonQuery();
				}
			}
			else
			{
				return;
			}
		}
		private void KeyIsDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left && settings.Directions != "right")
			{
				goLeft = true;
				return;
			}

			if (e.KeyCode == Keys.Right && settings.Directions != "left")
			{
				goRight = true;
				return;
			}

			if (e.KeyCode == Keys.Up && settings.Directions != "down")
			{
				goUp = true;
				return;
			}

			if (e.KeyCode == Keys.Down && settings.Directions != "up")
			{
				goDown = true;
				return;
			}
		}

		private void KeyIsUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Left:
					goLeft = false;
					break;
				case Keys.Right:
					goRight = false;
					break;
				case Keys.Up:
					goUp = false;
					break;
				case Keys.Down:
					goDown = false;
					break;
			}
		}

		private void GameTimerEvent(object sender, EventArgs e)
		{

			if (goLeft)
			{
				settings.Directions = "left";
			}
			if (goRight)
			{
				settings.Directions = "right";
			}
			if (goUp)
			{
				settings.Directions = "up";
			}
			if (goDown)
			{
				settings.Directions = "down";
			}

			for (int i = snake.Count - 1; i >= 0; i--)
			{
				if (i == 0)
				{
					switch (settings.Directions)
					{
						case "left":
							snake[i].X--;
							break;
						case "right":
							snake[i].X++;
							break;
						case "up":
							snake[i].Y--;
							break;
						case "down":
							snake[i].Y++;
							break;
					}
					if (snake[i].X < 0)
					{
						snake[i].X = Width;
					}
					if (snake[i].X > Width)
					{
						snake[i].X = 0;
					}
					if (snake[i].Y < 0)
					{
						snake[i].Y = Height;
					}
					if (snake[i].Y > Height)
					{
						snake[i].Y = 0;
					}


					if (snake[i].X == food.Y && snake[i].Y == food.X)
					{
						EatFood(food);
						continue;
					}


					for (int j = 1; j < snake.Count; j++)
					{
						if (snake[j].X == snake[i].X && snake[j].Y == snake[i].Y)
						{
							GameOver();
						}
					}
				}
				else
				{
					snake[i].X = snake[i - 1].X;
					snake[i].Y = snake[i - 1].Y;
				}
			}

			picCanvas.Invalidate();
		}

		private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
		{
			Graphics canvas = e.Graphics;

			Brush snakeColour;

			for (int i = 0; i < snake.Count; i++)
			{
				snakeColour = i == 0 ? Brushes.LawnGreen : Brushes.Green;

				canvas.FillRectangle(snakeColour, new Rectangle
					(
					snake[i].X * settings.Width,
					snake[i].Y * settings.Height,
					settings.Width, settings.Height
					));
			}
			if (btnStart.Enabled == false)
			{
				canvas.FillRectangle(Brushes.Red, new Rectangle
					(
					food.Y * settings.Height,
					food.X * settings.Width,
					settings.Width, settings.Height
					));
			}
		}

		private void Btn_StartGame(object sender, EventArgs e)
		{
			RestartGame();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Create_DB();
			lbl_PlayerName.Text = StartPageForm.playerName;
			lbl_Difficulty.Text = levelText;
			tmrGame.Interval = timerInterval;
		}

		private void Btn_ReDirectToStarPageForm_Click(object sender, EventArgs e)
		{
			StartPageForm startPageForm = new StartPageForm();
			startPageForm.Show();
			this.Hide();
		}

		private void RestartGame()
		{

			Width = picCanvas.Width / settings.Width - 1;
			Height = picCanvas.Height / settings.Height - 1;

			snake.Clear();

			btnStart.Enabled = false;
			Btn_ReDirectToStarPageForm.Enabled = false;
			score = 0;
			lblScore.Text = score.ToString();

			Circle head = new Circle { X = 10, Y = 5 };
			// add snake head to list
			snake.Add(head);

			for (int i = 0; i < 3; i++)
			{
				Circle body = new Circle();
				snake.Add(body);
			}

			food = new Circle() { X = rnd.Next(2, Width), Y = rnd.Next(2, Height) };

			tmrGame.Start();
		}
		private void EatFood(Circle oldFoodLocation)
		{

			score += 0;

			switch (levelText)
			{
				case "Kolay":
					score += 1;
					break;

				case "Orta":
					score += 3;
					break;

				case "Zor":
					score += 5;
					break;
			}

			lblScore.Text = score.ToString();

			Circle newBody = new Circle()
			{
				X = snake[snake.Count - 1].X,
				Y = snake[snake.Count - 1].Y
			};

			snake.Add(newBody);

			

			var exceptList = TakeLocation(snake);
			var avaliableList = PixelList.Except(exceptList);
			var foodRnd = avaliableList.OrderBy(x => Guid.NewGuid()).FirstOrDefault();

			if (exceptList.Contains(foodRnd))
			{
				var a = 5;
			}

			food = GetCircle(foodRnd);
		}

		private IEnumerable<int> TakeLocation(IEnumerable<Circle> circleList) => circleList.Select(c => c.X * Height + c.Y);

		private Circle GetCircle(int location)
		{
			int x = location / Height;
			int y = location - (Height * x);
			return new Circle()
			{
				X = x,
				Y = y
			};
		}
		private IEnumerable<int> PixelList => Enumerable.Range(0, Height * Width);

		void GameOver()
		{
			string maincon = ConfigurationManager.ConnectionStrings["sqlString"].ConnectionString;
			tmrGame.Stop();
			btnStart.Enabled = true;
			Btn_ReDirectToStarPageForm.Enabled = true;

			using (var con = new SQLiteConnection(maincon))
			{
				string sqlQuery = "INSERT INTO Tbl_Scoreboard(playername,score,difficulty) VALUES(@playername,@score,@difficulty) ";
				SQLiteCommand cmd = new SQLiteCommand(sqlQuery, con);
				cmd.Parameters.AddWithValue("playername", lbl_PlayerName.Text);
				cmd.Parameters.AddWithValue("score", Convert.ToInt32(lblScore.Text));
				cmd.Parameters.AddWithValue("difficulty", lbl_Difficulty.Text);
				con.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}

}

