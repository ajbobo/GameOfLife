namespace GameOfLife
{
	partial class Main
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
			this.lblBoardSize = new System.Windows.Forms.Label();
			this.txtBoardSize = new System.Windows.Forms.TextBox();
			this.lblInitialPercent = new System.Windows.Forms.Label();
			this.txtInitialPercent = new System.Windows.Forms.TextBox();
			this.btnAction = new System.Windows.Forms.Button();
			this.lblSpeed = new System.Windows.Forms.Label();
			this.txtSpeed = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnUseTemp = new System.Windows.Forms.CheckBox();
			this.btnStep = new System.Windows.Forms.Button();
			this.lblGeneration = new System.Windows.Forms.Label();
			this.lblShowGeneration = new System.Windows.Forms.Label();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.trkSpeed = new System.Windows.Forms.TrackBar();
			this.brdGameBoard = new GameOfLife.GameBoard();
			this.pnlControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBoardSize
			// 
			this.lblBoardSize.AutoSize = true;
			this.lblBoardSize.Location = new System.Drawing.Point(35, 7);
			this.lblBoardSize.Name = "lblBoardSize";
			this.lblBoardSize.Size = new System.Drawing.Size(61, 13);
			this.lblBoardSize.TabIndex = 0;
			this.lblBoardSize.Text = "Board Size:";
			// 
			// txtBoardSize
			// 
			this.txtBoardSize.Location = new System.Drawing.Point(106, 4);
			this.txtBoardSize.Name = "txtBoardSize";
			this.txtBoardSize.Size = new System.Drawing.Size(58, 20);
			this.txtBoardSize.TabIndex = 1;
			this.txtBoardSize.Text = "100";
			// 
			// lblInitialPercent
			// 
			this.lblInitialPercent.AutoSize = true;
			this.lblInitialPercent.Location = new System.Drawing.Point(35, 36);
			this.lblInitialPercent.Name = "lblInitialPercent";
			this.lblInitialPercent.Size = new System.Drawing.Size(65, 13);
			this.lblInitialPercent.TabIndex = 2;
			this.lblInitialPercent.Text = "Initial Live %";
			// 
			// txtInitialPercent
			// 
			this.txtInitialPercent.Location = new System.Drawing.Point(106, 33);
			this.txtInitialPercent.Name = "txtInitialPercent";
			this.txtInitialPercent.Size = new System.Drawing.Size(58, 20);
			this.txtInitialPercent.TabIndex = 3;
			this.txtInitialPercent.Text = "15";
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(417, 31);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(48, 23);
			this.btnAction.TabIndex = 5;
			this.btnAction.Text = "Start";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// lblSpeed
			// 
			this.lblSpeed.AutoSize = true;
			this.lblSpeed.Location = new System.Drawing.Point(35, 62);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new System.Drawing.Size(41, 13);
			this.lblSpeed.TabIndex = 7;
			this.lblSpeed.Text = "Speed:";
			// 
			// txtSpeed
			// 
			this.txtSpeed.Location = new System.Drawing.Point(106, 59);
			this.txtSpeed.Name = "txtSpeed";
			this.txtSpeed.ReadOnly = true;
			this.txtSpeed.Size = new System.Drawing.Size(58, 20);
			this.txtSpeed.TabIndex = 8;
			this.txtSpeed.Text = "50";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(309, 31);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(48, 23);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnUseTemp
			// 
			this.btnUseTemp.AutoSize = true;
			this.btnUseTemp.Checked = true;
			this.btnUseTemp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btnUseTemp.Location = new System.Drawing.Point(170, 6);
			this.btnUseTemp.Name = "btnUseTemp";
			this.btnUseTemp.Size = new System.Drawing.Size(102, 17);
			this.btnUseTemp.TabIndex = 10;
			this.btnUseTemp.Text = "Use Temp Array";
			this.btnUseTemp.UseVisualStyleBackColor = true;
			// 
			// btnStep
			// 
			this.btnStep.Location = new System.Drawing.Point(363, 31);
			this.btnStep.Name = "btnStep";
			this.btnStep.Size = new System.Drawing.Size(48, 23);
			this.btnStep.TabIndex = 11;
			this.btnStep.Text = "Step";
			this.btnStep.UseVisualStyleBackColor = true;
			this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
			// 
			// lblGeneration
			// 
			this.lblGeneration.AutoSize = true;
			this.lblGeneration.Location = new System.Drawing.Point(306, 7);
			this.lblGeneration.Name = "lblGeneration";
			this.lblGeneration.Size = new System.Drawing.Size(62, 13);
			this.lblGeneration.TabIndex = 12;
			this.lblGeneration.Text = "Generation:";
			// 
			// lblShowGeneration
			// 
			this.lblShowGeneration.AutoSize = true;
			this.lblShowGeneration.Location = new System.Drawing.Point(374, 7);
			this.lblShowGeneration.Name = "lblShowGeneration";
			this.lblShowGeneration.Size = new System.Drawing.Size(13, 13);
			this.lblShowGeneration.TabIndex = 13;
			this.lblShowGeneration.Text = "0";
			// 
			// pnlControls
			// 
			this.pnlControls.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlControls.Controls.Add(this.trkSpeed);
			this.pnlControls.Controls.Add(this.lblBoardSize);
			this.pnlControls.Controls.Add(this.lblShowGeneration);
			this.pnlControls.Controls.Add(this.txtBoardSize);
			this.pnlControls.Controls.Add(this.lblGeneration);
			this.pnlControls.Controls.Add(this.lblInitialPercent);
			this.pnlControls.Controls.Add(this.btnStep);
			this.pnlControls.Controls.Add(this.txtInitialPercent);
			this.pnlControls.Controls.Add(this.btnUseTemp);
			this.pnlControls.Controls.Add(this.btnAction);
			this.pnlControls.Controls.Add(this.btnReset);
			this.pnlControls.Controls.Add(this.lblSpeed);
			this.pnlControls.Controls.Add(this.txtSpeed);
			this.pnlControls.Location = new System.Drawing.Point(13, 0);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(501, 105);
			this.pnlControls.TabIndex = 14;
			// 
			// trkSpeed
			// 
			this.trkSpeed.Location = new System.Drawing.Point(170, 57);
			this.trkSpeed.Maximum = 100;
			this.trkSpeed.Minimum = 1;
			this.trkSpeed.Name = "trkSpeed";
			this.trkSpeed.Size = new System.Drawing.Size(297, 45);
			this.trkSpeed.TabIndex = 14;
			this.trkSpeed.TickFrequency = 5;
			this.trkSpeed.Value = 50;
			this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
			// 
			// brdGameBoard
			// 
			this.brdGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.brdGameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.brdGameBoard.Location = new System.Drawing.Point(16, 110);
			this.brdGameBoard.Name = "brdGameBoard";
			this.brdGameBoard.Size = new System.Drawing.Size(498, 389);
			this.brdGameBoard.TabIndex = 6;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 502);
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.brdGameBoard);
			this.DoubleBuffered = true;
			this.Name = "Main";
			this.Text = "Game of Life";
			this.pnlControls.ResumeLayout(false);
			this.pnlControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblBoardSize;
		private System.Windows.Forms.TextBox txtBoardSize;
		private System.Windows.Forms.Label lblInitialPercent;
		private System.Windows.Forms.TextBox txtInitialPercent;
		private System.Windows.Forms.Button btnAction;
		private GameBoard brdGameBoard;
		private System.Windows.Forms.Label lblSpeed;
		private System.Windows.Forms.TextBox txtSpeed;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.CheckBox btnUseTemp;
		private System.Windows.Forms.Button btnStep;
		private System.Windows.Forms.Label lblGeneration;
		private System.Windows.Forms.Label lblShowGeneration;
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.TrackBar trkSpeed;
	}
}

