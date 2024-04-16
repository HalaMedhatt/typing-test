namespace typeing_test
{
    partial class FormRegister
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
            label_get_starte = new Label();
            label_username = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            label_passward = new Label();
            textBox_confirm_password = new TextBox();
            label_confirm_password = new Label();
            checkBox_show_password = new CheckBox();
            button1 = new Button();
            label_have_account = new Label();
            label_back_to_login = new Label();
            SuspendLayout();
            // 
            // label_get_starte
            // 
            label_get_starte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_get_starte.AutoSize = true;
            label_get_starte.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_get_starte.ForeColor = Color.DarkBlue;
            label_get_starte.Location = new Point(31, 32);
            label_get_starte.Name = "label_get_starte";
            label_get_starte.Size = new Size(156, 27);
            label_get_starte.TabIndex = 0;
            label_get_starte.Text = "Typing Test";
            label_get_starte.Click += label1_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.ForeColor = Color.Gray;
            label_username.Location = new Point(31, 79);
            label_username.Name = "label_username";
            label_username.Size = new Size(69, 17);
            label_username.TabIndex = 1;
            label_username.Text = "Username";
            label_username.Click += label_username_Click;
            // 
            // textBox_username
            // 
            textBox_username.BackColor = Color.Silver;
            textBox_username.BorderStyle = BorderStyle.None;
            textBox_username.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_username.Location = new Point(31, 99);
            textBox_username.Multiline = true;
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(216, 28);
            textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.Silver;
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(31, 175);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(216, 28);
            textBox_password.TabIndex = 4;
            textBox_password.TextChanged += textBox_passward_TextChanged;
            // 
            // label_passward
            // 
            label_passward.AutoSize = true;
            label_passward.ForeColor = Color.Gray;
            label_passward.Location = new Point(31, 155);
            label_passward.Name = "label_passward";
            label_passward.Size = new Size(66, 17);
            label_passward.TabIndex = 3;
            label_passward.Text = "Password";
            // 
            // textBox_confirm_password
            // 
            textBox_confirm_password.BackColor = Color.Silver;
            textBox_confirm_password.BorderStyle = BorderStyle.None;
            textBox_confirm_password.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_confirm_password.Location = new Point(31, 256);
            textBox_confirm_password.Multiline = true;
            textBox_confirm_password.Name = "textBox_confirm_password";
            textBox_confirm_password.PasswordChar = '*';
            textBox_confirm_password.Size = new Size(216, 28);
            textBox_confirm_password.TabIndex = 6;
            // 
            // label_confirm_password
            // 
            label_confirm_password.AutoSize = true;
            label_confirm_password.ForeColor = Color.Gray;
            label_confirm_password.Location = new Point(31, 236);
            label_confirm_password.Name = "label_confirm_password";
            label_confirm_password.Size = new Size(120, 17);
            label_confirm_password.TabIndex = 5;
            label_confirm_password.Text = "Confirm Password";
            // 
            // checkBox_show_password
            // 
            checkBox_show_password.AutoSize = true;
            checkBox_show_password.Cursor = Cursors.Hand;
            checkBox_show_password.FlatStyle = FlatStyle.Flat;
            checkBox_show_password.ForeColor = Color.Gray;
            checkBox_show_password.Location = new Point(126, 290);
            checkBox_show_password.Name = "checkBox_show_password";
            checkBox_show_password.Size = new Size(118, 21);
            checkBox_show_password.TabIndex = 7;
            checkBox_show_password.Text = "show password";
            checkBox_show_password.UseVisualStyleBackColor = true;
            checkBox_show_password.CheckedChanged += checkBox_show_password_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 371);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_have_account
            // 
            label_have_account.AutoSize = true;
            label_have_account.ForeColor = Color.Gray;
            label_have_account.Location = new Point(54, 428);
            label_have_account.Name = "label_have_account";
            label_have_account.Size = new Size(163, 17);
            label_have_account.TabIndex = 9;
            label_have_account.Text = "Already Have an Account";
            label_have_account.Click += label1_Click_1;
            // 
            // label_back_to_login
            // 
            label_back_to_login.AutoSize = true;
            label_back_to_login.Cursor = Cursors.Hand;
            label_back_to_login.ForeColor = Color.DarkBlue;
            label_back_to_login.Location = new Point(84, 455);
            label_back_to_login.Name = "label_back_to_login";
            label_back_to_login.Size = new Size(97, 17);
            label_back_to_login.TabIndex = 10;
            label_back_to_login.Text = "Back to LOGIN";
            label_back_to_login.Click += label_back_to_login_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 507);
            Controls.Add(label_back_to_login);
            Controls.Add(label_have_account);
            Controls.Add(button1);
            Controls.Add(checkBox_show_password);
            Controls.Add(textBox_confirm_password);
            Controls.Add(label_confirm_password);
            Controls.Add(textBox_password);
            Controls.Add(label_passward);
            Controls.Add(textBox_username);
            Controls.Add(label_username);
            Controls.Add(label_get_starte);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonShadow;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Register";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_get_starte;
        private Label label_username;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Label label_passward;
        private TextBox textBox_confirm_password;
        private Label label_confirm_password;
        private CheckBox checkBox_show_password;
        private Button button1;
        private Label label_have_account;
        private Label label_back_to_login;
    }
}
