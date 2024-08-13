namespace _578592_project_prg272.Forms
{
    partial class Register
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
            label1 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            btnSubmit = new Button();
            label4 = new Label();
            btnToLogin = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 55);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "Register A New Account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(221, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(346, 134);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 182);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(346, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(190, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 229);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(346, 226);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(190, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(348, 299);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 335);
            label4.Name = "label4";
            label4.Size = new Size(204, 15);
            label4.TabIndex = 8;
            label4.Text = "Already have an account? Login here:";
            // 
            // btnToLogin
            // 
            btnToLogin.Location = new Point(348, 376);
            btnToLogin.Name = "btnToLogin";
            btnToLogin.Size = new Size(75, 23);
            btnToLogin.TabIndex = 9;
            btnToLogin.Text = "To Login";
            btnToLogin.UseVisualStyleBackColor = true;
            btnToLogin.Click += btnToLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(556, 134);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(lblError);
            Controls.Add(btnToLogin);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;
        private Label label4;
        private Button btnToLogin;
        private Label lblError;
    }
}