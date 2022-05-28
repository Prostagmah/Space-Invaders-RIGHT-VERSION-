namespace Space_invaders__️right_version_️
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreInGame = new System.Windows.Forms.Label();
            this.LoseLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.BossLifeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(66, 25);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Счёт:";
            // 
            // ScoreInGame
            // 
            this.ScoreInGame.AutoSize = true;
            this.ScoreInGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreInGame.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreInGame.Location = new System.Drawing.Point(72, 9);
            this.ScoreInGame.Name = "ScoreInGame";
            this.ScoreInGame.Size = new System.Drawing.Size(24, 25);
            this.ScoreInGame.TabIndex = 1;
            this.ScoreInGame.Text = "0";
            // 
            // LoseLabel
            // 
            this.LoseLabel.AutoSize = true;
            this.LoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoseLabel.ForeColor = System.Drawing.Color.White;
            this.LoseLabel.Location = new System.Drawing.Point(82, 284);
            this.LoseLabel.Name = "LoseLabel";
            this.LoseLabel.Size = new System.Drawing.Size(70, 25);
            this.LoseLabel.TabIndex = 3;
            this.LoseLabel.Text = "label2";
            this.LoseLabel.Visible = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.AutoSize = true;
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttemptsLabel.ForeColor = System.Drawing.Color.White;
            this.AttemptsLabel.Location = new System.Drawing.Point(614, 9);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(108, 25);
            this.AttemptsLabel.TabIndex = 4;
            this.AttemptsLabel.Text = "Жизни:  3";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelLabel.ForeColor = System.Drawing.Color.White;
            this.LevelLabel.Location = new System.Drawing.Point(314, 65);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(68, 73);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "1";
            this.LevelLabel.Visible = false;
            // 
            // Player
            // 
            this.Player.Image = global::Space_invaders__️right_version_️.Properties.Resources.Ship;
            this.Player.Location = new System.Drawing.Point(296, 499);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // BossLifeLabel
            // 
            this.BossLifeLabel.AutoSize = true;
            this.BossLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BossLifeLabel.ForeColor = System.Drawing.Color.White;
            this.BossLifeLabel.Location = new System.Drawing.Point(12, 547);
            this.BossLifeLabel.Name = "BossLifeLabel";
            this.BossLifeLabel.Size = new System.Drawing.Size(207, 25);
            this.BossLifeLabel.TabIndex = 6;
            this.BossLifeLabel.Text = "Жизней у босса: 10";
            this.BossLifeLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(734, 581);
            this.Controls.Add(this.BossLifeLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.AttemptsLabel);
            this.Controls.Add(this.LoseLabel);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ScoreInGame);
            this.Controls.Add(this.ScoreLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 620);
            this.MinimumSize = new System.Drawing.Size(750, 620);
            this.Name = "GameForm";
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreInGame;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label LoseLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label AttemptsLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label BossLifeLabel;
    }
}