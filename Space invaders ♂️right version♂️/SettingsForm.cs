using System;
using System.Windows.Forms;

namespace Space_invaders__️right_version_️
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() => InitializeComponent();

        private void SettingsForm_Load(object sender, EventArgs e) { }

        private void GachiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GachiCheckBox.Checked == true)
            {
                DataBase.gachi = true;
            }
            else if (GachiCheckBox.Checked == false)
            {
                DataBase.gachi = false;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
