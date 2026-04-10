namespace CalorieProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            Title = new Label();
            Regis = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(51, 114);
            Username.Name = "Username";
            Username.Size = new Size(81, 21);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(51, 170);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(51, 138);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 29);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 29);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkCyan;
            btnLogin.Font = new Font("Times New Roman", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(73, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(244, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Sitka Subheading", 19.9384613F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(73, 30);
            Title.Name = "Title";
            Title.Size = new Size(248, 52);
            Title.TabIndex = 6;
            Title.Text = "CALCOUNTIE";
            // 
            // Regis
            // 
            Regis.AutoSize = true;
            Regis.Location = new Point(108, 274);
            Regis.Name = "Regis";
            Regis.Size = new Size(165, 21);
            Regis.TabIndex = 7;
            Regis.Text = "dont have an account?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkSlateGray;
            btnRegister.Font = new Font("Segoe UI", 7.753846F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(130, 298);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 31);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(btnRegister);
            Controls.Add(Regis);
            Controls.Add(Title);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label Title;
        private Label Regis;
        private Button btnRegister;
    }
}
