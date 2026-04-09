namespace CalorieProj
{
    partial class Registration
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
            btnRegister = new Button();
            Username = new Label();
            Password = new Label();
            Title = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkSlateGray;
            btnRegister.Font = new Font("Segoe UI", 7.753846F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(37, 272);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(273, 46);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(37, 157);
            Username.Name = "Username";
            Username.Size = new Size(81, 21);
            Username.TabIndex = 9;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(37, 213);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 11;
            Password.Text = "Password";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Sitka Subheading", 19.9384613F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(52, 35);
            Title.Name = "Title";
            Title.Size = new Size(248, 52);
            Title.TabIndex = 12;
            Title.Text = "CALCOUNTIE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 9.969231F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 87);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 13;
            label1.Text = "Registration";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(37, 181);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(273, 29);
            txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 29);
            txtPassword.TabIndex = 15;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(Password);
            Controls.Add(btnRegister);
            Controls.Add(Username);
            Name = "Registration";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label Username;
        private Label Password;
        private Label Title;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}