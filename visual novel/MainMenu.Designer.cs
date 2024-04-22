namespace visual_novel
{
    partial class MainMenu
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
            this.QuitButton = new visual_novel.RoundButton();
            this.SettingsButton = new visual_novel.RoundButton();
            this.ContinueButton = new visual_novel.RoundButton();
            this.NewGameButton = new visual_novel.RoundButton();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.White;
            this.QuitButton.BorderColor = System.Drawing.Color.Black;
            this.QuitButton.BorderThickness = 6;
            this.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(286, 226);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Radius = 23;
            this.QuitButton.Size = new System.Drawing.Size(205, 48);
            this.QuitButton.TabIndex = 14;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.White;
            this.SettingsButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.BorderThickness = 6;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(286, 172);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Radius = 23;
            this.SettingsButton.Size = new System.Drawing.Size(205, 48);
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.White;
            this.ContinueButton.BorderColor = System.Drawing.Color.Black;
            this.ContinueButton.BorderThickness = 6;
            this.ContinueButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ContinueButton.FlatAppearance.BorderSize = 0;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(286, 118);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Radius = 23;
            this.ContinueButton.Size = new System.Drawing.Size(205, 48);
            this.ContinueButton.TabIndex = 12;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.White;
            this.NewGameButton.BorderColor = System.Drawing.Color.Black;
            this.NewGameButton.BorderThickness = 6;
            this.NewGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.NewGameButton.FlatAppearance.BorderSize = 0;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(286, 64);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Radius = 23;
            this.NewGameButton.Size = new System.Drawing.Size(205, 48);
            this.NewGameButton.TabIndex = 11;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.NewGameButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton QuitButton;
        private RoundButton SettingsButton;
        private RoundButton ContinueButton;
        private RoundButton NewGameButton;
    }
}

