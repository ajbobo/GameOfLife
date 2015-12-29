using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GameOfLife
{
	public partial class GameBoard : UserControl
	{
		private bool[,] board;

		public GameBoard()
		{
			InitializeComponent();
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		public void DrawBoard(bool[,] inboard)
		{
			board = inboard;
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;


			if (board == null)
			{
				g.FillRectangle(Brushes.PaleVioletRed, 0, 0, this.Width, this.Height);
				return;
			}

			int boardsize = board.GetUpperBound(0);

			Rectangle src = new Rectangle(0, 0, this.Width + 1, this.Height + 1);
			Rectangle dest = new Rectangle(0, 0, boardsize + 1, boardsize + 1);

			GraphicsContainer gc = g.BeginContainer(src, dest, GraphicsUnit.Pixel);

			for (int x = 0; x <= boardsize; x++)
			{
				for (int y = 0; y <= boardsize; y++)
				{
					if (board[x, y] == true)
						g.FillRectangle(Brushes.Black, x, y, 1, 1);
					else
						g.FillRectangle(SystemBrushes.Control, x, y, 1, 1);	
				}
			}

			g.EndContainer(gc);
		}

		protected override void OnResize(EventArgs e)
		{
			this.Invalidate();
			base.OnResize(e);
		}
	}
}