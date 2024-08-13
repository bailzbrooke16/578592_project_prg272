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
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            btnSearch = new Button();
            textBox1 = new TextBox();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            btnLogout = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Module_Code = new DataGridViewTextBoxColumn();
            Module_Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Links = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(36, 162);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(407, 91);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 144);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 27;
            label7.Text = "Address";
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
            // textBox3
            // 
            textBox3.Location = new Point(252, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 25;
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
            // textBox2
            // 
            textBox2.Location = new Point(36, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(310, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 24);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 21;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(485, 100);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(291, 153);
            richTextBox2.TabIndex = 29;
            richTextBox2.Text = "";
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
            // button1
            // 
            button1.Location = new Point(836, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(836, 188);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Module_Code, Module_Name, Description, Links });
            dataGridView1.Location = new Point(12, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(942, 283);
            dataGridView1.TabIndex = 34;
            // 
            // Module_Code
            // 
            Module_Code.HeaderText = "Module Code";
            Module_Code.Name = "Module_Code";
            // 
            // Module_Name
            // 
            Module_Name.HeaderText = "Module Name";
            Module_Name.Name = "Module_Name";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Links
            // 
            Links.HeaderText = "Links";
            Links.Name = "Links";
            // 
            // ViewAllModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 573);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLogout);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "ViewAllModules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllModules";
            Load += ViewAllModules_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private RichTextBox richTextBox1;
        private Label label7;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Button btnSearch;
        private TextBox textBox1;
        private RichTextBox richTextBox2;
        private Label label3;
        private Button btnLogout;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Module_Code;
        private DataGridViewTextBoxColumn Module_Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Links;
    }
}