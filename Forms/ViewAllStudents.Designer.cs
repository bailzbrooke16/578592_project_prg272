namespace _578592_project_prg272.Forms
{
    partial class ViewAllStudents
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
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            viewAllToolStripMenuItem = new ToolStripMenuItem();
            createNewToolStripMenuItem = new ToolStripMenuItem();
            moduleToolStripMenuItem = new ToolStripMenuItem();
            viewAllToolStripMenuItem1 = new ToolStripMenuItem();
            createNewToolStripMenuItem1 = new ToolStripMenuItem();
            btnLogout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtNumber = new TextBox();
            dtpDOB = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtGender = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            rtbAddress = new RichTextBox();
            btnSave = new Button();
            button2 = new Button();
            btnLinkModules = new Button();
            label8 = new Label();
            pbImage = new PictureBox();
            dgvStudents = new DataGridView();
            label9 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, studentToolStripMenuItem, moduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1126, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(57, 20);
            systemToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllToolStripMenuItem, createNewToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // viewAllToolStripMenuItem
            // 
            viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            viewAllToolStripMenuItem.Size = new Size(135, 22);
            viewAllToolStripMenuItem.Text = "View All";
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.Size = new Size(135, 22);
            createNewToolStripMenuItem.Text = "Create New";
            createNewToolStripMenuItem.Click += createNewToolStripMenuItem_Click;
            // 
            // moduleToolStripMenuItem
            // 
            moduleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllToolStripMenuItem1, createNewToolStripMenuItem1 });
            moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            moduleToolStripMenuItem.Size = new Size(60, 20);
            moduleToolStripMenuItem.Text = "Module";
            // 
            // viewAllToolStripMenuItem1
            // 
            viewAllToolStripMenuItem1.Name = "viewAllToolStripMenuItem1";
            viewAllToolStripMenuItem1.Size = new Size(135, 22);
            viewAllToolStripMenuItem1.Text = "View All";
            viewAllToolStripMenuItem1.Click += viewAllToolStripMenuItem1_Click;
            // 
            // createNewToolStripMenuItem1
            // 
            createNewToolStripMenuItem1.Name = "createNewToolStripMenuItem1";
            createNewToolStripMenuItem1.Size = new Size(135, 22);
            createNewToolStripMenuItem1.Text = "Create New";
            createNewToolStripMenuItem1.Click += createNewToolStripMenuItem1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(996, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += logoutToolStripMenuItem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(292, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(329, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 24);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(45, 107);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 23);
            txtFirstName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 89);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(306, 107);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 23);
            txtLastName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 89);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 11;
            label3.Text = "Student Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(572, 107);
            txtNumber.Name = "txtNumber";
            txtNumber.ReadOnly = true;
            txtNumber.Size = new Size(191, 23);
            txtNumber.TabIndex = 10;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(45, 182);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(191, 23);
            dtpDOB.TabIndex = 12;
            dtpDOB.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 164);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 164);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Gender";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(306, 182);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(191, 23);
            txtGender.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(623, 164);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 17;
            label6.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(572, 182);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(191, 23);
            txtPhone.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(187, 235);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 19;
            label7.Text = "Address";
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(45, 253);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(371, 91);
            rtbAddress.TabIndex = 20;
            rtbAddress.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(453, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Location = new Point(572, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLinkModules
            // 
            btnLinkModules.Location = new Point(688, 286);
            btnLinkModules.Name = "btnLinkModules";
            btnLinkModules.Size = new Size(128, 23);
            btnLinkModules.TabIndex = 23;
            btnLinkModules.Text = "Linked Modules";
            btnLinkModules.UseVisualStyleBackColor = true;
            btnLinkModules.Click += btnLinkModules_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(898, 89);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 24;
            label8.Text = "Image";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(847, 117);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(139, 133);
            pbImage.TabIndex = 25;
            pbImage.TabStop = false;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToOrderColumns = true;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(43, 390);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(1071, 245);
            dgvStudents.TabIndex = 26;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(171, 45);
            label9.Name = "label9";
            label9.Size = new Size(133, 15);
            label9.TabIndex = 27;
            label9.Text = "Student Number Search";
            // 
            // ViewAllStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 647);
            Controls.Add(label9);
            Controls.Add(dgvStudents);
            Controls.Add(pbImage);
            Controls.Add(label8);
            Controls.Add(btnLinkModules);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(rtbAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtGender);
            Controls.Add(label4);
            Controls.Add(dtpDOB);
            Controls.Add(label3);
            Controls.Add(txtNumber);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLogout);
            Controls.Add(menuStrip1);
            Name = "ViewAllStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllStudents";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private ToolStripMenuItem moduleToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem1;
        private ToolStripMenuItem createNewToolStripMenuItem1;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtNumber;
        private DateTimePicker dtpDOB;
        private Label label4;
        private Label label5;
        private TextBox txtGender;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private RichTextBox rtbAddress;
        private Button btnSave;
        private Button button2;
        private Button btnLinkModules;
        private Label label8;
        private PictureBox pbImage;
        private DataGridView dgvStudents;
        private Label label9;
    }
}