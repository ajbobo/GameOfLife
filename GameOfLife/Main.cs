using System;
using System.Windows.Forms;

namespace GameOfLife
{
	public partial class Main : Form
	{
		private int boardsize;
		private int initialpercent;
		private bool gamerunning;
		private Random rand;
		private bool[,] currentboard; 
		private bool[,] tempboard;
		private Timer timer;
		private uint generation;

		public Main()
		{
			InitializeComponent();
			gamerunning = false;
			rand = new Random();
			timer = new Timer();
			timer.Tick += new EventHandler(UpdateBoard);
			btnReset.Enabled = true;
			btnAction.Enabled = false;
		}


		private void btnReset_Click(object sender, EventArgs e)
		{
			StopGame();
			ResetGame();
			brdGameBoard.DrawBoard(currentboard);

			EnableControls(true);
			btnAction.Enabled = true;
		}


		private void btnStep_Click(object sender, EventArgs e)
		{
			UpdateBoard(null, EventArgs.Empty);
		}

		private void btnAction_Click(object sender, EventArgs e)
		{
			if (currentboard == null || tempboard == null)
				return;

			if (!gamerunning)
				StartGame();
			else
				StopGame();

			EnableControls(!gamerunning);
			brdGameBoard.DrawBoard(currentboard);
		}

		private void trkSpeed_Scroll(object sender, EventArgs e)
		{
			txtSpeed.Text = trkSpeed.Value.ToString();
			timer.Interval = CalculateInterval();
		}

		private void EnableControls(bool enable)
		{
			lblBoardSize.Enabled = enable;
			txtBoardSize.Enabled = enable;
			lblInitialPercent.Enabled = enable;
			txtInitialPercent.Enabled = enable;
			lblSpeed.Enabled = enable;
			txtSpeed.Enabled = enable;
			btnUseTemp.Enabled = enable;
		}

		private void ResetGame()
		{
			// Create the board
			boardsize = int.Parse(txtBoardSize.Text);
			currentboard = new bool[boardsize, boardsize];
			tempboard = new bool[boardsize, boardsize];
			generation = 0;

			// Populate the board
			initialpercent = int.Parse(txtInitialPercent.Text);
			for (int x = 0; x < boardsize; x++)
			{
				for (int y = 0; y < boardsize; y++)
				{
					currentboard[x, y] = ((rand.Next(1, 100) <= initialpercent) ? true : false);
				}
			}

			// Reset the Generation count
			generation = 0;
			lblShowGeneration.Text = generation.ToString();
		}

		private void StopGame()
		{
			gamerunning = false;
			btnAction.Text = "Start";
			timer.Stop();
		}

		private void StartGame()
		{
			gamerunning = true;
			btnAction.Text = "Stop";
			timer.Interval = CalculateInterval();
			timer.Start();
		}

		private int CalculateInterval()
		{
			// Speed 1 = .5 second; 100 = 5 milliseconds
			int interval = -5 * trkSpeed.Value + 505;
			return interval;
		}

		private void UpdateBoard(object sender, EventArgs e)
		{
			// Update the Generation count
			generation++;
			lblShowGeneration.Text = generation.ToString();

			// Calculate the living and dead cells
			bool[,] midboard = (btnUseTemp.Checked ? tempboard : currentboard);

			for (int x = 0; x < boardsize; x++)
			{
				for (int y = 0; y < boardsize; y++)
				{
					int left = (x > 0 ? x - 1 : boardsize - 1);
					int right = (x < boardsize - 1 ? x + 1 : 0);
					int up = (y > 0 ? y - 1 : boardsize - 1);
					int down = (y < boardsize - 1 ? y + 1 : 0);

					bool alive = currentboard[x, y];
					int livecnt = 0;
					if (currentboard[left, y] == true)		livecnt++;
					if (currentboard[right, y] == true)		livecnt++;
					if (currentboard[x, up] == true)			livecnt++;
					if (currentboard[x, down] == true)		livecnt++;
					if (currentboard[left, up] == true)		livecnt++;
					if (currentboard[left, down] == true)	livecnt++;
					if (currentboard[right, up] == true)	livecnt++;
					if (currentboard[right, down] == true) livecnt++;

					if (alive && livecnt < 2)
						midboard[x, y] = false;
					else if (alive && livecnt > 3)
						midboard[x, y] = false;
					else if (alive && (livecnt == 2 || livecnt == 3))
						midboard[x, y] = true;
					else if (!alive && livecnt == 3)
						midboard[x, y] = true;
				}
			}

			// Copy the temp board into the currentboard
			for (int x = 0; x < boardsize; x++)
			{
				for (int y = 0; y < boardsize; y++)
				{
					currentboard[x, y] = midboard[x, y];
				}
			}

			// Send the current board to the screen
			brdGameBoard.DrawBoard(currentboard);
		}
	}
}
