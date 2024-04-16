namespace typeing_test
{
    partial class Form_test
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
            components = new System.ComponentModel.Container();
            panel_test = new Panel();
            label_char_test = new Label();
            button_start = new Button();
            button_close = new Button();
            button_show_scoreboard = new Button();
            label_score = new Label();
            timer_test = new System.Windows.Forms.Timer(components);
            button_pause = new Button();
            panel_test.SuspendLayout();
            SuspendLayout();
            // 
            // panel_test
            // 
            panel_test.BackColor = Color.LightGray;
            panel_test.Controls.Add(label_char_test);
            panel_test.Dock = DockStyle.Top;
            panel_test.Location = new Point(0, 0);
            panel_test.Name = "panel_test";
            panel_test.Size = new Size(800, 261);
            panel_test.TabIndex = 0;
            panel_test.Paint += panel_test_Paint;
            // 
            // label_char_test
            // 
            label_char_test.BackColor = Color.DarkBlue;
            label_char_test.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_char_test.ForeColor = Color.White;
            label_char_test.Location = new Point(200, 100);
            label_char_test.Name = "label_char_test";
            label_char_test.Padding = new Padding(2);
            label_char_test.Size = new Size(42, 41);
            label_char_test.TabIndex = 5;
            label_char_test.TextAlign = ContentAlignment.MiddleCenter;
            label_char_test.Click += label_chat_test_Click;
            // 
            // button_start
            // 
            button_start.BackColor = Color.DarkBlue;
            button_start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_start.ForeColor = Color.White;
            button_start.Location = new Point(21, 323);
            button_start.Name = "button_start";
            button_start.Size = new Size(186, 56);
            button_start.TabIndex = 0;
            button_start.Text = "Start Typing";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button1_Click;
            // 
            // button_close
            // 
            button_close.BackColor = Color.DarkBlue;
            button_close.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_close.ForeColor = Color.White;
            button_close.Location = new Point(226, 323);
            button_close.Name = "button_close";
            button_close.Size = new Size(99, 56);
            button_close.TabIndex = 1;
            button_close.Text = "End";
            button_close.UseVisualStyleBackColor = false;
            button_close.Click += button_close_Click;
            // 
            // button_show_scoreboard
            // 
            button_show_scoreboard.BackColor = Color.DarkBlue;
            button_show_scoreboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_show_scoreboard.ForeColor = Color.White;
            button_show_scoreboard.Location = new Point(634, 397);
            button_show_scoreboard.Name = "button_show_scoreboard";
            button_show_scoreboard.Size = new Size(154, 41);
            button_show_scoreboard.TabIndex = 2;
            button_show_scoreboard.Text = "Scoreboard";
            button_show_scoreboard.UseVisualStyleBackColor = false;
            button_show_scoreboard.Click += button_show_scoreboard_Click;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_score.ForeColor = Color.DarkBlue;
            label_score.Location = new Point(485, 342);
            label_score.Name = "label_score";
            label_score.Size = new Size(65, 21);
            label_score.TabIndex = 4;
            label_score.Text = "Score 0";
            label_score.Click += label2_Click;
            // 
            // timer_test
            // 
            timer_test.Interval = 90;
            timer_test.Tick += timer_test_Tick;
            // 
            // button_pause
            // 
            button_pause.BackColor = Color.DarkBlue;
            button_pause.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_pause.ForeColor = Color.White;
            button_pause.Location = new Point(349, 323);
            button_pause.Name = "button_pause";
            button_pause.Size = new Size(99, 56);
            button_pause.TabIndex = 5;
            button_pause.Text = "Pause";
            button_pause.UseVisualStyleBackColor = false;
            button_pause.Click += button_pause_Click;
            // 
            // Form_test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button_pause);
            Controls.Add(label_score);
            Controls.Add(button_show_scoreboard);
            Controls.Add(button_close);
            Controls.Add(button_start);
            Controls.Add(panel_test);
            KeyPreview = true;
            Name = "Form_test";
            Text = "Typing Test";
            KeyPress += Form_test_KeyPress;
            panel_test.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_test;
        private Button button_start;
        private Button button_close;
        private Button button_show_scoreboard;
        private Label label_score;
        private Label label_char_test;
        private System.Windows.Forms.Timer timer_test;
        private Button button_pause;
    }
}