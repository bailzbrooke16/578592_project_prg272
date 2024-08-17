namespace _578592_project_prg272.Forms
{
    partial class ViewAllModules
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
            rtbDescription = new RichTextBox();
            label7 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtCode = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            rtbLinks = new RichTextBox();
            label3 = new Label();
            btnLogout = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            dgvModules = new DataGridView();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModules).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, studentToolStripMenuItem, moduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(966, 24);
            menuStrip1.TabIndex = 3;
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
            viewAllToolStripMenuItem.Click += viewAllToolStripMenuItem_Click;
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
            // 
            // createNewToolStripMenuItem1
            // 
            createNewToolStripMenuItem1.Name = "createNewToolStripMenuItem1";
            createNewToolStripMenuItem1.Size = new Size(135, 22);
            createNewToolStripMenuItem1.Text = "Create New";
            createNewToolStripMenuItem1.Click += createNewToolStripMenuItem1_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(36, 162);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(407, 91);
            rtbDescription.TabIndex = 28;
            rtbDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 144);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 27;
            label7.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 82);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 26;
            label2.Text = "Module Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(252, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 82);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 24;
            label1.Text = "Module Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(36, 100);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(191, 23);
            txtCode.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(317, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 24);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 56);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(292, 23);
            txtSearch.TabIndex = 21;
            // 
            // rtbLinks
            // 
            rtbLinks.Location = new Point(485, 100);
            rtbLinks.Name = "rtbLinks";
            rtbLinks.Size = new Size(291, 153);
            rtbLinks.TabIndex = 29;
            rtbLinks.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 82);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 30;
            label3.Text = "Links";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(875, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 31;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(836, 136);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(836, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvModules
            // 
            dgvModules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModules.Location = new Point(12, 278);
            dgvModules.Name = "dgvModules";
            dgvModules.Size = new Size(942, 283);
            dgvModules.TabIndex = 34;
            dgvModules.SelectionChanged += dgvModules_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 35);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 35;
            label4.Text = "Module Code Search";
            // 
            // ViewAllModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 573);
            Controls.Add(label4);
            Controls.Add(dgvModules);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnLogout);
            Controls.Add(label3);
            Controls.Add(rtbLinks);
            Controls.Add(rtbDescription);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(menuStrip1);
            Name = "ViewAllModules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllModules";
            Load += ViewAllModules_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModules).EndInit();
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
        private RichTextBox rtbDescription;
        private Label label7;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtCode;
        private Button btnSearch;
        private TextBox txtSearch;
        private RichTextBox rtbLinks;
        private Label label3;
        private Button btnLogout;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dgvModules;
        private Label label4;
    }
}