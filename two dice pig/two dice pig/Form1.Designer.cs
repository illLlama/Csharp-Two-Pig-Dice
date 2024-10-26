namespace two_dice_pig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHoldP1 = new System.Windows.Forms.Button();
            this.btnRollP1 = new System.Windows.Forms.Button();
            this.txtGameScP1 = new System.Windows.Forms.TextBox();
            this.gbP1 = new System.Windows.Forms.GroupBox();
            this.lblWinCheckP1 = new System.Windows.Forms.Label();
            this.lblGameScP1 = new System.Windows.Forms.Label();
            this.lblTurnScP1 = new System.Windows.Forms.Label();
            this.txtTurnScP1 = new System.Windows.Forms.TextBox();
            this.gbP2 = new System.Windows.Forms.GroupBox();
            this.lblWinCheckP2 = new System.Windows.Forms.Label();
            this.lblGameScP2 = new System.Windows.Forms.Label();
            this.lblTurnScP2 = new System.Windows.Forms.Label();
            this.txtTurnScP2 = new System.Windows.Forms.TextBox();
            this.txtGameScP2 = new System.Windows.Forms.TextBox();
            this.btnHoldP2 = new System.Windows.Forms.Button();
            this.btnRollP2 = new System.Windows.Forms.Button();
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayerName1 = new System.Windows.Forms.Label();
            this.lblPlayerName2 = new System.Windows.Forms.Label();
            this.lblRollAnnouncer = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.gbP1.SuspendLayout();
            this.gbP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoldP1
            // 
            this.btnHoldP1.BackColor = System.Drawing.Color.White;
            this.btnHoldP1.Enabled = false;
            this.btnHoldP1.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnHoldP1.Location = new System.Drawing.Point(24, 132);
            this.btnHoldP1.Name = "btnHoldP1";
            this.btnHoldP1.Size = new System.Drawing.Size(115, 23);
            this.btnHoldP1.TabIndex = 4;
            this.btnHoldP1.Text = "Hold";
            this.btnHoldP1.UseVisualStyleBackColor = false;
            this.btnHoldP1.Click += new System.EventHandler(this.btnHoldP1_Click);
            // 
            // btnRollP1
            // 
            this.btnRollP1.BackColor = System.Drawing.Color.White;
            this.btnRollP1.Enabled = false;
            this.btnRollP1.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnRollP1.Location = new System.Drawing.Point(24, 103);
            this.btnRollP1.Name = "btnRollP1";
            this.btnRollP1.Size = new System.Drawing.Size(115, 23);
            this.btnRollP1.TabIndex = 3;
            this.btnRollP1.Text = "Roll";
            this.btnRollP1.UseVisualStyleBackColor = false;
            this.btnRollP1.Click += new System.EventHandler(this.btnRollP1_Click);
            // 
            // txtGameScP1
            // 
            this.txtGameScP1.Location = new System.Drawing.Point(93, 66);
            this.txtGameScP1.Name = "txtGameScP1";
            this.txtGameScP1.ReadOnly = true;
            this.txtGameScP1.Size = new System.Drawing.Size(46, 20);
            this.txtGameScP1.TabIndex = 2;
            this.txtGameScP1.TabStop = false;
            // 
            // gbP1
            // 
            this.gbP1.BackColor = System.Drawing.Color.Transparent;
            this.gbP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbP1.Controls.Add(this.lblWinCheckP1);
            this.gbP1.Controls.Add(this.lblGameScP1);
            this.gbP1.Controls.Add(this.lblTurnScP1);
            this.gbP1.Controls.Add(this.txtTurnScP1);
            this.gbP1.Controls.Add(this.txtGameScP1);
            this.gbP1.Controls.Add(this.btnHoldP1);
            this.gbP1.Controls.Add(this.btnRollP1);
            this.gbP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbP1.Location = new System.Drawing.Point(63, 290);
            this.gbP1.Name = "gbP1";
            this.gbP1.Size = new System.Drawing.Size(168, 204);
            this.gbP1.TabIndex = 1;
            this.gbP1.TabStop = false;
            // 
            // lblWinCheckP1
            // 
            this.lblWinCheckP1.AutoSize = true;
            this.lblWinCheckP1.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblWinCheckP1.Location = new System.Drawing.Point(21, 163);
            this.lblWinCheckP1.Name = "lblWinCheckP1";
            this.lblWinCheckP1.Size = new System.Drawing.Size(0, 19);
            this.lblWinCheckP1.TabIndex = 17;
            // 
            // lblGameScP1
            // 
            this.lblGameScP1.AutoSize = true;
            this.lblGameScP1.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblGameScP1.Location = new System.Drawing.Point(7, 66);
            this.lblGameScP1.Name = "lblGameScP1";
            this.lblGameScP1.Size = new System.Drawing.Size(83, 19);
            this.lblGameScP1.TabIndex = 7;
            this.lblGameScP1.Text = "Game Score";
            // 
            // lblTurnScP1
            // 
            this.lblTurnScP1.AutoSize = true;
            this.lblTurnScP1.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblTurnScP1.Location = new System.Drawing.Point(7, 25);
            this.lblTurnScP1.Name = "lblTurnScP1";
            this.lblTurnScP1.Size = new System.Drawing.Size(80, 19);
            this.lblTurnScP1.TabIndex = 6;
            this.lblTurnScP1.Text = "Turn Score";
            this.lblTurnScP1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTurnScP1
            // 
            this.txtTurnScP1.Location = new System.Drawing.Point(93, 26);
            this.txtTurnScP1.Name = "txtTurnScP1";
            this.txtTurnScP1.ReadOnly = true;
            this.txtTurnScP1.Size = new System.Drawing.Size(46, 20);
            this.txtTurnScP1.TabIndex = 1;
            this.txtTurnScP1.TabStop = false;
            // 
            // gbP2
            // 
            this.gbP2.BackColor = System.Drawing.Color.Transparent;
            this.gbP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbP2.Controls.Add(this.lblWinCheckP2);
            this.gbP2.Controls.Add(this.lblGameScP2);
            this.gbP2.Controls.Add(this.lblTurnScP2);
            this.gbP2.Controls.Add(this.txtTurnScP2);
            this.gbP2.Controls.Add(this.txtGameScP2);
            this.gbP2.Controls.Add(this.btnHoldP2);
            this.gbP2.Controls.Add(this.btnRollP2);
            this.gbP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbP2.Location = new System.Drawing.Point(312, 290);
            this.gbP2.Name = "gbP2";
            this.gbP2.Size = new System.Drawing.Size(168, 204);
            this.gbP2.TabIndex = 2;
            this.gbP2.TabStop = false;
            // 
            // lblWinCheckP2
            // 
            this.lblWinCheckP2.AutoSize = true;
            this.lblWinCheckP2.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblWinCheckP2.Location = new System.Drawing.Point(25, 163);
            this.lblWinCheckP2.Name = "lblWinCheckP2";
            this.lblWinCheckP2.Size = new System.Drawing.Size(0, 19);
            this.lblWinCheckP2.TabIndex = 16;
            // 
            // lblGameScP2
            // 
            this.lblGameScP2.AutoSize = true;
            this.lblGameScP2.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblGameScP2.Location = new System.Drawing.Point(10, 66);
            this.lblGameScP2.Name = "lblGameScP2";
            this.lblGameScP2.Size = new System.Drawing.Size(83, 19);
            this.lblGameScP2.TabIndex = 13;
            this.lblGameScP2.Text = "Game Score";
            // 
            // lblTurnScP2
            // 
            this.lblTurnScP2.AutoSize = true;
            this.lblTurnScP2.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblTurnScP2.Location = new System.Drawing.Point(13, 25);
            this.lblTurnScP2.Name = "lblTurnScP2";
            this.lblTurnScP2.Size = new System.Drawing.Size(80, 19);
            this.lblTurnScP2.TabIndex = 12;
            this.lblTurnScP2.Text = "Turn Score";
            this.lblTurnScP2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTurnScP2
            // 
            this.txtTurnScP2.Location = new System.Drawing.Point(97, 26);
            this.txtTurnScP2.Name = "txtTurnScP2";
            this.txtTurnScP2.ReadOnly = true;
            this.txtTurnScP2.Size = new System.Drawing.Size(46, 20);
            this.txtTurnScP2.TabIndex = 1;
            this.txtTurnScP2.TabStop = false;
            // 
            // txtGameScP2
            // 
            this.txtGameScP2.Location = new System.Drawing.Point(97, 66);
            this.txtGameScP2.Name = "txtGameScP2";
            this.txtGameScP2.ReadOnly = true;
            this.txtGameScP2.Size = new System.Drawing.Size(46, 20);
            this.txtGameScP2.TabIndex = 2;
            this.txtGameScP2.TabStop = false;
            // 
            // btnHoldP2
            // 
            this.btnHoldP2.BackColor = System.Drawing.Color.White;
            this.btnHoldP2.Enabled = false;
            this.btnHoldP2.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnHoldP2.Location = new System.Drawing.Point(28, 132);
            this.btnHoldP2.Name = "btnHoldP2";
            this.btnHoldP2.Size = new System.Drawing.Size(115, 23);
            this.btnHoldP2.TabIndex = 4;
            this.btnHoldP2.Text = "Hold";
            this.btnHoldP2.UseVisualStyleBackColor = false;
            this.btnHoldP2.Click += new System.EventHandler(this.btnHoldP2_Click);
            // 
            // btnRollP2
            // 
            this.btnRollP2.BackColor = System.Drawing.Color.White;
            this.btnRollP2.Enabled = false;
            this.btnRollP2.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnRollP2.Location = new System.Drawing.Point(28, 103);
            this.btnRollP2.Name = "btnRollP2";
            this.btnRollP2.Size = new System.Drawing.Size(115, 23);
            this.btnRollP2.TabIndex = 3;
            this.btnRollP2.Text = "Roll";
            this.btnRollP2.UseVisualStyleBackColor = false;
            this.btnRollP2.Click += new System.EventHandler(this.btnRollP2_Click);
            // 
            // pbDice1
            // 
            this.pbDice1.BackColor = System.Drawing.Color.Transparent;
            this.pbDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDice1.Location = new System.Drawing.Point(72, 52);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(150, 150);
            this.pbDice1.TabIndex = 11;
            this.pbDice1.TabStop = false;
            // 
            // pbDice2
            // 
            this.pbDice2.BackColor = System.Drawing.Color.Transparent;
            this.pbDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDice2.Location = new System.Drawing.Point(321, 52);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(150, 150);
            this.pbDice2.TabIndex = 12;
            this.pbDice2.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.White;
            this.btnNewGame.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(183, 529);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(172, 38);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(340, 275);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(115, 20);
            this.txtPlayer2.TabIndex = 2;
            // 
            // lblPlayerName1
            // 
            this.lblPlayerName1.AutoSize = true;
            this.lblPlayerName1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName1.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName1.Location = new System.Drawing.Point(75, 255);
            this.lblPlayerName1.Name = "lblPlayerName1";
            this.lblPlayerName1.Size = new System.Drawing.Size(147, 19);
            this.lblPlayerName1.TabIndex = 16;
            this.lblPlayerName1.Text = "Enter Player 1 Name ";
            // 
            // lblPlayerName2
            // 
            this.lblPlayerName2.AutoSize = true;
            this.lblPlayerName2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName2.Font = new System.Drawing.Font("Script MT Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName2.Location = new System.Drawing.Point(322, 255);
            this.lblPlayerName2.Name = "lblPlayerName2";
            this.lblPlayerName2.Size = new System.Drawing.Size(149, 19);
            this.lblPlayerName2.TabIndex = 17;
            this.lblPlayerName2.Text = "Enter Player 2 Name ";
            this.lblPlayerName2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRollAnnouncer
            // 
            this.lblRollAnnouncer.BackColor = System.Drawing.Color.Transparent;
            this.lblRollAnnouncer.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRollAnnouncer.Location = new System.Drawing.Point(199, 205);
            this.lblRollAnnouncer.Name = "lblRollAnnouncer";
            this.lblRollAnnouncer.Size = new System.Drawing.Size(147, 40);
            this.lblRollAnnouncer.TabIndex = 18;
            this.lblRollAnnouncer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(87, 275);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(115, 20);
            this.txtPlayer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 627);
            this.Controls.Add(this.lblRollAnnouncer);
            this.Controls.Add(this.lblPlayerName2);
            this.Controls.Add(this.lblPlayerName1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbDice2);
            this.Controls.Add(this.pbDice1);
            this.Controls.Add(this.gbP2);
            this.Controls.Add(this.gbP1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Two Dice Pig";
            this.gbP1.ResumeLayout(false);
            this.gbP1.PerformLayout();
            this.gbP2.ResumeLayout(false);
            this.gbP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHoldP1;
        private System.Windows.Forms.Button btnRollP1;
        private System.Windows.Forms.TextBox txtGameScP1;
        private System.Windows.Forms.GroupBox gbP1;
        private System.Windows.Forms.Label lblGameScP1;
        private System.Windows.Forms.Label lblTurnScP1;
        private System.Windows.Forms.TextBox txtTurnScP1;
        private System.Windows.Forms.GroupBox gbP2;
        private System.Windows.Forms.PictureBox pbDice1;
        private System.Windows.Forms.Label lblGameScP2;
        private System.Windows.Forms.Label lblTurnScP2;
        private System.Windows.Forms.TextBox txtTurnScP2;
        private System.Windows.Forms.TextBox txtGameScP2;
        private System.Windows.Forms.Button btnHoldP2;
        private System.Windows.Forms.Button btnRollP2;
        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblWinCheckP1;
        private System.Windows.Forms.Label lblWinCheckP2;
        private System.Windows.Forms.Label lblPlayerName1;
        private System.Windows.Forms.Label lblPlayerName2;
        private System.Windows.Forms.Label lblRollAnnouncer;
        private System.Windows.Forms.TextBox txtPlayer1;
    }
}

