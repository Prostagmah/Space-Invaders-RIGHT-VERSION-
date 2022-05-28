using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Space_invaders__️right_version_️
{
    public partial class GameForm : Form
    {
        PictureBox[] EnemyArray;
        PictureBox[] BossArray;

        public GameForm()=>InitializeComponent();
     
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                DataBase.isRight = true;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                DataBase.isLeft = true;
            }
            if (e.KeyCode == Keys.Enter && !DataBase.GameOn)
            {
                GameSetup();
                DataBase.GameOn = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                DataBase.isRight = false;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                DataBase.isLeft = false;
            }
            if (e.KeyCode == Keys.Space && DataBase.Shooting == false)
            {
                DataBase.Shooting = true;
                MakeBullet("Bullet");
            }
        }
        private void GameSetup()
        {
            DataBase.Score = 0;
            DataBase.isGameOver = false;

            DataBase.SpeedPl = 10;
            DataBase.Attempts = 3;
            DataBase.Shooting = false;

            DataBase.EnemyBulletTimer = 10;
            DataBase.EnemySpeed = 5;
            DataBase.MaxEnemy = 1;
            DataBase.BossLife = 5;
            DataBase.BossBulletTimer = 100;
            DataBase.BulletTimer = 200;

            DataBase.Level = 1;

            DataBase.RoundKills = 0;

            MakeEnemy();
            GameTimer.Start();
        }

        private void MakeBullet(string BulletTag)
        {
            if (!DataBase.isGameOver)
            {
                PictureBox Bullet = new PictureBox();
                Bullet.Image = Properties.Resources.Bullet;
                Bullet.Size = new Size(5, 20);
                Bullet.Tag = BulletTag;
                Bullet.Left = Player.Left + Player.Width / 2;

                if ((string)BulletTag == "Bullet")
                {
                    Bullet.Top = Player.Top - 20;
                }
                else if ((string)Bullet.Tag == "EnemyBullet")
                {
                    Bullet.Top = -100;
                }
                this.Controls.Add(Bullet);
                Bullet.BringToFront();
            }

        }
        public void MakeEnemy()
        {
            if (!DataBase.isGameOver)
            {
                EnemyArray = new PictureBox[DataBase.MaxEnemy];

                int left = 0;

                for (int i = 0; i < EnemyArray.Length; i++)
                {
                    EnemyArray[i] = new PictureBox();
                    EnemyArray[i].Size = new Size(60, 50);
                    EnemyArray[i].Image = Properties.Resources.Enemy;
                    EnemyArray[i].Top = 5;
                    EnemyArray[i].Tag = "Enemy";
                    EnemyArray[i].Left = left;
                    EnemyArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(EnemyArray[i]);
                    left = left - 80;
                }
            }
        }
        private async void GameOver()
        {
            if(DataBase.gachi == true) {SoundPlayer sound = new SoundPlayer(@"F:\С#\Space Invanders\Sound\Death.wav"); sound.Play();} 
            DataBase.isGameOver = true;
            LoseLabel.Text = $"YOU NOT BOSS OF THIS GYM! Ваш счёт: {DataBase.Score.ToString()}";
            LoseLabel.Visible = true;
            RemoveAll();
            await Task.Delay(3000);
            Application.Exit();
        }
        private void RemoveAll()
        {
            RemoveEnemy();
            RemoveBullet();
            if(DataBase.Level % 10 == 0) {RemoveBoss();}
        }

        private void RemoveEnemy()
        {
            foreach (PictureBox i in EnemyArray)
            {
                this.Controls.Remove(i);
            }
        }
        private void RemoveBoss()
        {
            foreach(PictureBox i in BossArray)
            {
                this.Controls.Remove(i);
            }
        }

        private void RemoveBullet()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Bullet" || (string)x.Tag == "EnemyBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }


        private async void NextLevel()
        {
            DataBase.MaxEnemy += 1;
            DataBase.Level += 1;
            DataBase.RoundKills = 0;
            DataBase.BulletTimer -= 1;
            LevelLabel.Text = DataBase.Level.ToString();
            LevelLabel.Visible = true;
            await Task.Delay(1500);
            LevelLabel.Visible = false;
            MakeEnemy();
        }

        private async void BossLevel()
        {
            LastSetup();
            BossSetup();
            MakeBoss();
            LevelLabel.Text = DataBase.Level.ToString();
            LevelLabel.Visible = true;
            await Task.Delay(1500);
            LevelLabel.Visible = false;
            BossLifeLabel.Visible = true;
        }

        private static void BossSetup()
        {
            DataBase.BossLife = DataBase.BossLife + 5;
            DataBase.MaxEnemy = 1;
            DataBase.EnemySpeed = 5;
            DataBase.Level += 1;
            DataBase.RoundKills = 0;
        }

        private static void LastSetup()
        {
            DataBase.LastMaxEnemy = DataBase.MaxEnemy;
            DataBase.LastEnemySpeed = DataBase.EnemySpeed;
            DataBase.LastBulletTimer = DataBase.BulletTimer;
            DataBase.BossBulletTimer = DataBase.BossBulletTimer - 1;
            DataBase.BulletTimer = DataBase.BossBulletTimer;
        }

        private void MakeBoss()
        {
            BossArray = new PictureBox[DataBase.MaxEnemy];

            int left = 0;

            for (int i = 0; i < BossArray.Length; i++)
            {
                BossArray[i] = new PictureBox();
                BossArray[i].Size = new Size(80, 70);
                BossArray[i].Image = Properties.Resources.Boss;
                BossArray[i].Top = 5;
                BossArray[i].Tag = "Boss";
                BossArray[i].Left = left;
                BossArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(BossArray[i]);
                left = left - 80;
            }

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            ScoreInGame.Text = DataBase.Score.ToString();

            if (DataBase.isLeft)
            {
                Player.Left -= DataBase.SpeedPl;
            }

            if (DataBase.isRight)
            {
                Player.Left += DataBase.SpeedPl;
            }

            DataBase.EnemyBulletTimer -= 10;

            if (DataBase.EnemyBulletTimer < 3)
            {
                DataBase.EnemyBulletTimer = DataBase.BulletTimer;
                MakeBullet("EnemyBullet");
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy"|| x is PictureBox && (string)x.Tag == "Boss")
                {
                    x.Left += (int)DataBase.EnemySpeed;

                    if (x.Left > 730)
                    {
                        x.Top += 65;
                        x.Left = -80;
                    }
                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        GameOver();
                    }
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "Bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                if ((string)x.Tag == "Boss")
                                {
                                    if (DataBase.BossLife <= 0)
                                    {
                                        this.Controls.Remove(x);
                                        this.Controls.Remove(y);
                                        DataBase.Score += 10;
                                        DataBase.RoundKills += 1;
                                        DataBase.Shooting = false;
                                        BossLifeLabel.Visible = false;
                                        if(DataBase.gachi == true)
                                        {
                                            SoundPlayer sound = new SoundPlayer(@"F:\С#\Space Invanders\Sound\FuckYou.wav");
                                            sound.Play();
                                        }
                                    }
                                    else if (DataBase.BossLife > 0)
                                    {
                                        this.Controls.Remove(y);
                                        DataBase.MaxEnemy = DataBase.LastMaxEnemy;
                                        DataBase.BossLife--;
                                        BossLifeLabel.Text = $"Жизней у босса: {DataBase.BossLife.ToString()}";
                                        DataBase.Shooting = false;
                                        if(DataBase.BossLife <= 0)
                                        {
                                            this.Controls.Remove(x);
                                            DataBase.Score += 10;
                                            DataBase.MaxEnemy = DataBase.LastMaxEnemy;
                                            DataBase.BulletTimer = DataBase.LastBulletTimer;
                                            DataBase.EnemySpeed = DataBase.LastEnemySpeed;
                                            DataBase.RoundKills += 1;
                                            BossLifeLabel.Visible = false;
                                            if (DataBase.gachi == true)
                                            {
                                                SoundPlayer sound = new SoundPlayer(@"F:\С#\Space Invanders\Sound\FuckYou.wav");
                                                sound.Play();
                                            }
                                        }
                                    }  
                                }
                                else if  ((string)x.Tag == "Enemy")
                                {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                DataBase.Score += 1;
                                DataBase.RoundKills += 1;
                                DataBase.Shooting =false;
                                }

                            }
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "Bullet")
                {
                    x.Top -= 20;
                    if (x.Top < 15)
                    {
                        this.Controls.Remove(x);
                        DataBase.Shooting = false;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "EnemyBullet")
                {
                    x.Top += 20;
                    if (x.Top > 620)
                    {
                        this.Controls.Remove(x);
                    }
                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        this.Controls.Remove(x);
                        if (DataBase.Attempts <= 0)
                        {
                            AttemptsLabel.Text = $"Жизни: {DataBase.Attempts.ToString()}";
                            GameOver();
                            Controls.Remove(Player);
                        }
                        else if (DataBase.Attempts > 0)
                        {
                            DataBase.Attempts--;
                            AttemptsLabel.Text = $"Жизни: {DataBase.Attempts.ToString()}";
                            if (DataBase.Attempts == 0)
                            {
                                GameOver();
                            }
                        }
                    }
                }
                if (DataBase.RoundKills == DataBase.MaxEnemy)
                {
                    if (DataBase.Level % 10 == 0)
                    {
                        BossLevel();
                        if (DataBase.gachi == true) 
                        {
                            var data = new Random().Next(0,5);
                            SoundPlayer simpleSound;
                            switch (data)
                            {
                                case 0:
                                    simpleSound = new SoundPlayer(@"\С#\Space Invanders\Sound\Sorry.wav");
                                    simpleSound.Play();
                                    break;
                                case 1:
                                    simpleSound = new SoundPlayer(@"\С#\Space Invanders\Sound\Boss of the gym.wav");
                                    simpleSound.Play();
                                    break;
                                case 2:
                                    simpleSound = new SoundPlayer(@"\С#\Space Invanders\Sound\Fucking Slaves.wav");
                                    simpleSound.Play();
                                    break;
                                case 3:
                                    simpleSound = new SoundPlayer(@"\С#\Space Invanders\Sound\mmm.wav");
                                    simpleSound.Play();
                                    break;
                                case 4:
                                    simpleSound = new SoundPlayer(@"\С#\Space Invanders\Sound\Lash.wav");
                                    simpleSound.Play();
                                    break;
                                case 5:
                                    simpleSound = new SoundPlayer(@"\С#\Space Invanders\Sound\Fucked.wav");
                                    simpleSound.Play();
                                    break;
                            }
                            SoundPlayer sound = new SoundPlayer();
                        }
                    }
                    else { NextLevel(); }
                }
            }
        }
    }
}