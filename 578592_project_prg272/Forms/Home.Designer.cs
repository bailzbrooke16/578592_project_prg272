namespace _578592_project_prg272.Forms
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            viewAllToolStripMenuItem = new ToolStripMenuItem();
            createNewToolStripMenuItem = new ToolStripMenuItem();
            moduleToolStripMenuItem = new ToolStripMenuItem();
            viewAllToolStripMenuItem1 = new ToolStripMenuItem();
            createNewToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            label2 = new Label();
            btnStudents = new Button();
            label3 = new Label();
            btnModules = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 49);
            label1.Name = "label1";
            label1.Size = new Size(337, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Student Manager";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, studentToolStripMenuItem, moduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
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
            viewAllToolStripMenuItem.Size = new Size(180, 22);
            viewAllToolStripMenuItem.Text = "View All";
            viewAllToolStripMenuItem.Click += viewAllToolStripMenuItem_Click;
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.Size = new Size(180, 22);
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
            viewAllToolStripMenuItem1.Size = new Size(180, 22);
            viewAllToolStripMenuItem1.Text = "View All";
            viewAllToolStripMenuItem1.Click += viewAllToolStripMenuItem1_Click;
            // 
            // createNewToolStripMenuItem1
            // 
            createNewToolStripMenuItem1.Name = "createNewToolStripMenuItem1";
            createNewToolStripMenuItem1.Size = new Size(180, 22);
            createNewToolStripMenuItem1.Text = "Create New";
            createNewToolStripMenuItem1.Click += createNewToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(713, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 174);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 3;
            label2.Text = "Please click here for student manager";
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(150, 242);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(75, 23);
            btnStudents.TabIndex = 4;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 174);
            label3.Name = "label3";
            label3.Size = new Size(205, 15);
            label3.TabIndex = 5;
            label3.Text = "Please click here for module manager";
            // 
            // btnModules
            // 
            btnModules.Location = new Point(534, 242);
            btnModules.Name = "btnModules";
            btnModules.Size = new Size(75, 23);
            btnModules.TabIndex = 6;
            btnModules.Text = "Module";
            btnModules.UseVisualStyleBackColor = true;
            btnModules.Click += btnModules_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModules);
            Controls.Add(label3);
            Controls.Add(btnStudents);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private ToolStripMenuItem moduleToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem1;
        private ToolStripMenuItem createNewToolStripMenuItem1;
        private Button button1;
        private Label label2;
        private Button btnStudents;
        private Label label3;
        private Button btnModules;
    }
}