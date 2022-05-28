using System;
using System.Windows.Forms;

namespace Space_invaders__️right_version_️
{
    public partial class StartForm : Form
    {
        GameForm _gameForm = new GameForm();
        SettingsForm _settingsForm = new SettingsForm();


        public StartForm()=>InitializeComponent();
        private void ExitButton_Click(object sender, EventArgs e)=>Application.Exit();

        private void SettingsButton_Click(object sender, EventArgs e)=>_settingsForm.Show();

        private void StartButton_Click(object sender, EventArgs e)
        {
            _gameForm.Show();
            Visible = false;
        }
    }
}
