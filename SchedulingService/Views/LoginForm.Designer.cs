
namespace SchedulingService
{
	partial class LoginForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.languageSelect = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.timeZoneText = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(365, 153);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(366, 212);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(369, 174);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(266, 22);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(369, 233);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(266, 22);
            this.password.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(369, 272);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(267, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(16, 11);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(303, 17);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Welcome to scheduling services, please log-in.";
            // 
            // languageSelect
            // 
            this.languageSelect.FormattingEnabled = true;
            this.languageSelect.Location = new System.Drawing.Point(472, 383);
            this.languageSelect.Margin = new System.Windows.Forms.Padding(4);
            this.languageSelect.Name = "languageSelect";
            this.languageSelect.Size = new System.Drawing.Size(163, 24);
            this.languageSelect.TabIndex = 6;
            this.languageSelect.SelectedValueChanged += new System.EventHandler(this.languageSelect_SelectedValueChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(365, 386);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(72, 17);
            this.languageLabel.TabIndex = 7;
            this.languageLabel.Text = "Language";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.AutoSize = true;
            this.timeZoneLabel.Location = new System.Drawing.Point(16, 62);
            this.timeZoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(80, 17);
            this.timeZoneLabel.TabIndex = 8;
            this.timeZoneLabel.Text = "Time Zone:";
            // 
            // timeZoneText
            // 
            this.timeZoneText.AutoSize = true;
            this.timeZoneText.Location = new System.Drawing.Point(121, 62);
            this.timeZoneText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeZoneText.Name = "timeZoneText";
            this.timeZoneText.Size = new System.Drawing.Size(19, 17);
            this.timeZoneText.TabIndex = 9;
            this.timeZoneText.Text = "tz";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(955, 509);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 33);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.timeZoneText);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageSelect);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Log-In";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox languageSelect;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Label timeZoneText;
        private System.Windows.Forms.Button cancelButton;
    }
}

