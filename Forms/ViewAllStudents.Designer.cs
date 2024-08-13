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
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Student_Number = new DataGridViewTextBoxColumn();
            Full_Name = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dateTimePicker1.Size = new Size(191, 23);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(623, 164);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 17;
            label6.Text = "Phone Number";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(572, 182);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(191, 23);
            textBox6.TabIndex = 16;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(45, 253);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(371, 91);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(453, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(572, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(688, 286);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 23;
            button3.Text = "Linked Modules";
            button3.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(847, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 133);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Student_Number, Full_Name, DOB, Gender, Phone, Address });
            dataGridView1.Location = new Point(43, 390);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1071, 245);
            dataGridView1.TabIndex = 26;
            // 
            // Student_Number
            // 
            Student_Number.HeaderText = "Student Number";
            Student_Number.Name = "Student_Number";
            // 
            // Full_Name
            // 
            Full_Name.HeaderText = "Full Name";
            Full_Name.Name = "Full_Name";
            // 
            // DOB
            // 
            DOB.HeaderText = "DOB";
            DOB.Name = "DOB";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // ViewAllStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 647);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllStudents";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Student_Number;
        private DataGridViewTextBoxColumn Full_Name;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
    }
}