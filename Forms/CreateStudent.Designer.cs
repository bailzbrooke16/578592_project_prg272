namespace _578592_project_prg272.Forms
{
    partial class CreateStudent
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
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            btnCancel = new Button();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 140);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 29;
            label6.Text = "Phone Number";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(557, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(191, 23);
            textBox6.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 140);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 27;
            label5.Text = "Gender";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(291, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 23);
            textBox5.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 140);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 25;
            label4.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(30, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 65);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 23;
            label3.Text = "Student Number";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(557, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 23);
            textBox4.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 21;
            label2.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(291, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 19;
            label1.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(398, 365);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 207);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(371, 91);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 189);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 30;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(300, 9);
            label8.Name = "label8";
            label8.Size = new Size(173, 32);
            label8.TabIndex = 34;
            label8.Text = "Create Student";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.Location = new Point(488, 249);
            button3.Name = "button3";
            button3.Size = new Size(137, 23);
            button3.TabIndex = 35;
            button3.Text = "Upload";
            button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(515, 210);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 36;
            label9.Text = "Student Image";
            // 
            // CreateStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(btnCancel);
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
            Name = "CreateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private Button btnCancel;
        private RichTextBox richTextBox1;
        private Label label7;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Label label9;
    }
}