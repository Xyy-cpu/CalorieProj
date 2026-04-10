namespace CalorieProj
{
    partial class Dashboard
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
            Title = new Label();
            calgoal = new Label();
            txtGoal = new TextBox();
            Goalbtn = new Button();
            label1 = new Label();
            Calorietaken = new TextBox();
            GoalProglbl = new Label();
            GoalProgress = new ProgressBar();
            HistoryData = new DataGridView();
            History = new Label();
            Consbtn = new Button();
            logoutbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoryData).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Sitka Subheading", 19.9384613F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(64, 46);
            Title.Name = "Title";
            Title.Size = new Size(248, 52);
            Title.TabIndex = 7;
            Title.Text = "CALCOUNTIE";
            // 
            // calgoal
            // 
            calgoal.AutoSize = true;
            calgoal.Font = new Font("Segoe UI", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calgoal.Location = new Point(23, 112);
            calgoal.Name = "calgoal";
            calgoal.Size = new Size(131, 21);
            calgoal.TabIndex = 8;
            calgoal.Text = "Set Calorie Goal";
            // 
            // txtGoal
            // 
            txtGoal.Location = new Point(23, 136);
            txtGoal.Name = "txtGoal";
            txtGoal.Size = new Size(111, 29);
            txtGoal.TabIndex = 9;
            // 
            // Goalbtn
            // 
            Goalbtn.BackColor = SystemColors.ActiveCaption;
            Goalbtn.Font = new Font("Segoe UI", 7.753846F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Goalbtn.Location = new Point(140, 136);
            Goalbtn.Name = "Goalbtn";
            Goalbtn.Size = new Size(102, 31);
            Goalbtn.TabIndex = 10;
            Goalbtn.Text = "Save Goal";
            Goalbtn.UseVisualStyleBackColor = false;
            Goalbtn.Click += Goalbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 170);
            label1.Name = "label1";
            label1.Size = new Size(201, 21);
            label1.TabIndex = 11;
            label1.Text = "Input Calories Consumed";
            // 
            // Calorietaken
            // 
            Calorietaken.Location = new Point(23, 194);
            Calorietaken.Name = "Calorietaken";
            Calorietaken.Size = new Size(111, 29);
            Calorietaken.TabIndex = 12;
            // 
            // GoalProglbl
            // 
            GoalProglbl.AutoSize = true;
            GoalProglbl.Font = new Font("Segoe UI", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoalProglbl.Location = new Point(20, 236);
            GoalProglbl.Name = "GoalProglbl";
            GoalProglbl.Size = new Size(114, 21);
            GoalProglbl.TabIndex = 14;
            GoalProglbl.Text = "Goal Progress";
            // 
            // GoalProgress
            // 
            GoalProgress.Location = new Point(23, 260);
            GoalProgress.Name = "GoalProgress";
            GoalProgress.Size = new Size(327, 19);
            GoalProgress.TabIndex = 15;
            // 
            // HistoryData
            // 
            HistoryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryData.Location = new Point(23, 321);
            HistoryData.Name = "HistoryData";
            HistoryData.RowHeadersWidth = 56;
            HistoryData.Size = new Size(327, 120);
            HistoryData.TabIndex = 16;
            // 
            // History
            // 
            History.AutoSize = true;
            History.Font = new Font("Segoe UI", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            History.Location = new Point(23, 297);
            History.Name = "History";
            History.Size = new Size(66, 21);
            History.TabIndex = 17;
            History.Text = "History";
            // 
            // Consbtn
            // 
            Consbtn.BackColor = SystemColors.ActiveCaption;
            Consbtn.Font = new Font("Segoe UI", 7.753846F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Consbtn.Location = new Point(140, 192);
            Consbtn.Name = "Consbtn";
            Consbtn.Size = new Size(102, 31);
            Consbtn.TabIndex = 18;
            Consbtn.Text = "Add";
            Consbtn.UseVisualStyleBackColor = false;
            Consbtn.Click += Consbtn_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutbtn.BackColor = Color.Turquoise;
            logoutbtn.Font = new Font("Segoe UI", 7.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logoutbtn.Location = new Point(297, 12);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(65, 31);
            logoutbtn.TabIndex = 19;
            logoutbtn.Text = "Log Out";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(logoutbtn);
            Controls.Add(Consbtn);
            Controls.Add(History);
            Controls.Add(HistoryData);
            Controls.Add(GoalProgress);
            Controls.Add(GoalProglbl);
            Controls.Add(Calorietaken);
            Controls.Add(label1);
            Controls.Add(Goalbtn);
            Controls.Add(txtGoal);
            Controls.Add(calgoal);
            Controls.Add(Title);
            Name = "Dashboard";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)HistoryData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label calgoal;
        private TextBox txtGoal;
        private Button Goalbtn;
        private Label label1;
        private TextBox Calorietaken;
        private Label GoalProglbl;
        private ProgressBar GoalProgress;
        private DataGridView HistoryData;
        private Label History;
        private Button Consbtn;
        private Button logoutbtn;
    }
}