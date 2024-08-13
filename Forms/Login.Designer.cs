namespace _578592_project_prg272.Forms
{
    partial class Login
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
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            lblNoAccount = new Label();
            btnRegister = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(235, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Manager";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(203, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(203, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            lblPassword.UseMnemonic = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(269, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(266, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(322, 251);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Location = new Point(208, 292);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(333, 15);
            lblNoAccount.TabIndex = 6;
            lblNoAccount.Text = "Don't have an account? Register by clicking the button below:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(322, 321);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(187, 380);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(lblError);
            Controls.Add(btnRegister);
            Controls.Add(lblNoAccount);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Label lblNoAccount;
        private Button btnRegister;
        private Label lblError;
    }
}