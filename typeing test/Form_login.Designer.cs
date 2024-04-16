namespace typeing_test
{
    partial class Form_login
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
            label_create_account = new Label();
            label_dont_have_account = new Label();
            button_login = new Button();
            checkBox_show_password_login = new CheckBox();
            textBox_password_login = new TextBox();
            label_passward_login = new Label();
            textBox_username_login = new TextBox();
            label_username_login = new Label();
            label_get_starte = new Label();
            SuspendLayout();
            // 
            // label_create_account
            // 
            label_create_account.AutoSize = true;
            label_create_account.Cursor = Cursors.Hand;
            label_create_account.ForeColor = Color.DarkBlue;
            label_create_account.Location = new Point(76, 415);
            label_create_account.Name = "label_create_account";
            label_create_account.Size = new Size(112, 13);
            label_create_account.TabIndex = 21;
            label_create_account.Text = "Create Account";
            label_create_account.Click += label_create_account_Click;
            // 
            // label_dont_have_account
            // 
            label_dont_have_account.AutoSize = true;
            label_dont_have_account.ForeColor = Color.Gray;
            label_dont_have_account.Location = new Point(59, 391);
            label_dont_have_account.Name = "label_dont_have_account";
            label_dont_have_account.Size = new Size(154, 13);
            label_dont_have_account.TabIndex = 20;
            label_dont_have_account.Text = "Dont Have an Account";
            // 
            // button_login
            // 
            button_login.BackColor = Color.DarkBlue;
            button_login.Cursor = Cursors.Hand;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(36, 334);
            button_login.Name = "button_login";
            button_login.Size = new Size(216, 35);
            button_login.TabIndex = 19;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // checkBox_show_password_login
            // 
            checkBox_show_password_login.AutoSize = true;
            checkBox_show_password_login.Cursor = Cursors.Hand;
            checkBox_show_password_login.FlatStyle = FlatStyle.Flat;
            checkBox_show_password_login.ForeColor = Color.Gray;
            checkBox_show_password_login.Location = new Point(134, 216);
            checkBox_show_password_login.Name = "checkBox_show_password_login";
            checkBox_show_password_login.Size = new Size(118, 17);
            checkBox_show_password_login.TabIndex = 18;
            checkBox_show_password_login.Text = "show password";
            checkBox_show_password_login.UseVisualStyleBackColor = true;
            checkBox_show_password_login.CheckedChanged += checkBox_show_password_login_CheckedChanged;
            // 
            // textBox_password_login
            // 
            textBox_password_login.BackColor = Color.Silver;
            textBox_password_login.BorderStyle = BorderStyle.None;
            textBox_password_login.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_password_login.Location = new Point(36, 182);
            textBox_password_login.Multiline = true;
            textBox_password_login.Name = "textBox_password_login";
            textBox_password_login.PasswordChar = '*';
            textBox_password_login.Size = new Size(216, 28);
            textBox_password_login.TabIndex = 15;
            textBox_password_login.TextChanged += textBox_password_login_TextChanged;
            // 
            // label_passward_login
            // 
            label_passward_login.AutoSize = true;
            label_passward_login.ForeColor = Color.Gray;
            label_passward_login.Location = new Point(36, 162);
            label_passward_login.Name = "label_passward_login";
            label_passward_login.Size = new Size(67, 13);
            label_passward_login.TabIndex = 14;
            label_passward_login.Text = "Password";
            // 
            // textBox_username_login
            // 
            textBox_username_login.BackColor = Color.Silver;
            textBox_username_login.BorderStyle = BorderStyle.None;
            textBox_username_login.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_username_login.Location = new Point(36, 106);
            textBox_username_login.Multiline = true;
            textBox_username_login.Name = "textBox_username_login";
            textBox_username_login.Size = new Size(216, 28);
            textBox_username_login.TabIndex = 13;
            textBox_username_login.TextChanged += textBox_username_login_TextChanged;
            // 
            // label_username_login
            // 
            label_username_login.AutoSize = true;
            label_username_login.ForeColor = Color.Gray;
            label_username_login.Location = new Point(36, 86);
            label_username_login.Name = "label_username_login";
            label_username_login.Size = new Size(71, 13);
            label_username_login.TabIndex = 12;
            label_username_login.Text = "Username";
            // 
            // label_get_starte
            // 
            label_get_starte.AutoSize = true;
            label_get_starte.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_get_starte.ForeColor = Color.DarkBlue;
            label_get_starte.Location = new Point(36, 39);
            label_get_starte.Name = "label_get_starte";
            label_get_starte.Size = new Size(156, 27);
            label_get_starte.TabIndex = 11;
            label_get_starte.Text = "Typing Test";
            // 
            // Form_login
            // 
            AutoScaleDimensions = new SizeF(8F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 507);
            Controls.Add(label_create_account);
            Controls.Add(label_dont_have_account);
            Controls.Add(button_login);
            Controls.Add(checkBox_show_password_login);
            Controls.Add(textBox_password_login);
            Controls.Add(label_passward_login);
            Controls.Add(textBox_username_login);
            Controls.Add(label_username_login);
            Controls.Add(label_get_starte);
            Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_login";
            Load += Form_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_create_account;
        private Label label_dont_have_account;
        private Button button_login;
        private CheckBox checkBox_show_password_login;
        private TextBox textBox_password_login;
        private Label label_passward_login;
        private TextBox textBox_username_login;
        private Label label_username_login;
        private Label label_get_starte;
    }
}