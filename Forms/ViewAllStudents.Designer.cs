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
            textBox1 = new TextBox();
            btnSearch = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            menuStrip1.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(21, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(319, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 24);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 6;
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
            // textBox3
            // 
            textBox3.Location = new Point(306, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 8;
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
            // textBox4
            // 
            textBox4.Location = new Point(572, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 23);
            textBox4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(45, 182);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
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
            // textBox5
            // 
            textBox5.Location = new Point(306, 182);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 23);
            textBox5.TabIndex = 14;
            // 
            // ViewAllStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 647);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(btnLogout);
            Controls.Add(menuStrip1);
            Name = "ViewAllStudents";
            Text = "ViewAllStudents";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private TextBox textBox1;
        private Button btnSearch;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
    }
}