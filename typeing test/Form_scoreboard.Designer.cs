namespace typeing_test
{
    partial class Form_scoreboard
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
            label_scorebard = new Label();
            dataGridView_scoreboard = new DataGridView();
            order = new DataGridViewTextBoxColumn();
            maximum_score = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            textBox_username_login = new TextBox();
            label_show_history = new Label();
            label_rank = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_scoreboard).BeginInit();
            SuspendLayout();
            // 
            // label_scorebard
            // 
            label_scorebard.AutoSize = true;
            label_scorebard.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_scorebard.ForeColor = Color.DarkBlue;
            label_scorebard.Location = new Point(296, 28);
            label_scorebard.Name = "label_scorebard";
            label_scorebard.Size = new Size(148, 42);
            label_scorebard.TabIndex = 0;
            label_scorebard.Text = "scoreboard";
            label_scorebard.Click += label1_Click;
            // 
            // dataGridView_scoreboard
            // 
            dataGridView_scoreboard.BackgroundColor = Color.White;
            dataGridView_scoreboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_scoreboard.Columns.AddRange(new DataGridViewColumn[] { order, maximum_score, username });
            dataGridView_scoreboard.GridColor = SystemColors.MenuText;
            dataGridView_scoreboard.Location = new Point(12, 118);
            dataGridView_scoreboard.Name = "dataGridView_scoreboard";
            dataGridView_scoreboard.Size = new Size(716, 150);
            dataGridView_scoreboard.TabIndex = 1;
            dataGridView_scoreboard.CellContentClick += dataGridView1_CellContentClick;
            // 
            // order
            // 
            order.HeaderText = "Rank";
            order.Name = "order";
            order.ReadOnly = true;
            order.Width = 50;
            // 
            // maximum_score
            // 
            maximum_score.HeaderText = "Maximum Score";
            maximum_score.Name = "maximum_score";
            maximum_score.ReadOnly = true;
            maximum_score.Width = 150;
            // 
            // username
            // 
            username.HeaderText = "Name ";
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 500;
            // 
            // textBox_username_login
            // 
            textBox_username_login.BackColor = Color.Silver;
            textBox_username_login.BorderStyle = BorderStyle.None;
            textBox_username_login.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_username_login.Location = new Point(253, 327);
            textBox_username_login.Multiline = true;
            textBox_username_login.Name = "textBox_username_login";
            textBox_username_login.Size = new Size(138, 33);
            textBox_username_login.TabIndex = 15;
            textBox_username_login.TextChanged += textBox_username_login_TextChanged;
            // 
            // label_show_history
            // 
            label_show_history.AutoSize = true;
            label_show_history.Cursor = Cursors.Hand;
            label_show_history.ForeColor = Color.DarkBlue;
            label_show_history.Location = new Point(288, 376);
            label_show_history.Name = "label_show_history";
            label_show_history.Size = new Size(103, 15);
            label_show_history.TabIndex = 16;
            label_show_history.Text = "Show User History";
            label_show_history.Click += label2_Click;
            // 
            // label_rank
            // 
            label_rank.AutoSize = true;
            label_rank.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_rank.Location = new Point(184, 327);
            label_rank.Name = "label_rank";
            label_rank.Size = new Size(57, 25);
            label_rank.TabIndex = 17;
            label_rank.Text = "Rank";
            // 
            // Form_scoreboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(740, 450);
            Controls.Add(label_rank);
            Controls.Add(label_show_history);
            Controls.Add(textBox_username_login);
            Controls.Add(dataGridView_scoreboard);
            Controls.Add(label_scorebard);
            Name = "Form_scoreboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_scoreboard";
            Load += Form_scoreboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_scoreboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_scorebard;
        private DataGridView dataGridView_scoreboard;
        private TextBox textBox_username_login;
        private Label label_show_history;
        private Label label_rank;
        private DataGridViewTextBoxColumn order;
        private DataGridViewTextBoxColumn maximum_score;
        private DataGridViewTextBoxColumn username;
    }
}