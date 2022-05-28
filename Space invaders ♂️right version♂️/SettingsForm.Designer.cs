namespace Space_invaders__️right_version_️
{
    partial class SettingsForm
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
            this.GachiCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GachiCheckBox
            // 
            this.GachiCheckBox.AutoSize = true;
            this.GachiCheckBox.Checked = true;
            this.GachiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GachiCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GachiCheckBox.Location = new System.Drawing.Point(12, 12);
            this.GachiCheckBox.Name = "GachiCheckBox";
            this.GachiCheckBox.Size = new System.Drawing.Size(148, 24);
            this.GachiCheckBox.TabIndex = 0;
            this.GachiCheckBox.Text = "♂️Right version♂️";
            this.GachiCheckBox.UseVisualStyleBackColor = true;
            this.GachiCheckBox.CheckedChanged += new System.EventHandler(this.GachiCheckBox_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 42);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(148, 24);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Подтвердить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 68);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GachiCheckBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(188, 107);
            this.MinimumSize = new System.Drawing.Size(188, 107);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox GachiCheckBox;
        private System.Windows.Forms.Button SaveButton;
    }
}