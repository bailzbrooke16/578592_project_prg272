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
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtGender = new TextBox();
            label4 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            txtStudentNumber = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            rtbAddress = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnUploadImage = new Button();
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
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(557, 158);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(191, 23);
            txtPhoneNumber.TabIndex = 28;
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
            // txtGender
            // 
            txtGender.Location = new Point(291, 158);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(191, 23);
            txtGender.TabIndex = 26;
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
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(30, 158);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(191, 23);
            dtpDateOfBirth.TabIndex = 24;
            dtpDateOfBirth.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
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
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(557, 83);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(191, 23);
            txtStudentNumber.TabIndex = 22;
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
            // txtLastName
            // 
            txtLastName.Location = new Point(291, 83);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 23);
            txtLastName.TabIndex = 20;
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
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 23);
            txtFirstName.TabIndex = 18;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(398, 365);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 33;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
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
            // rtbAddress
            // 
            rtbAddress.Location = new Point(30, 207);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(371, 91);
            rtbAddress.TabIndex = 31;
            rtbAddress.Text = "";
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
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(488, 249);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(137, 23);
            btnUploadImage.TabIndex = 35;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
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
            Controls.Add(btnUploadImage);
            Controls.Add(label8);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(rtbAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label5);
            Controls.Add(txtGender);
            Controls.Add(label4);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label3);
            Controls.Add(txtStudentNumber);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Name = "CreateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtGender;
        private Label label4;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private TextBox txtStudentNumber;
        private Label label2;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtFirstName;
        private Button btnCreate;
        private Button btnCancel;
        private RichTextBox rtbAddress;
        private Label label7;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button btnUploadImage;
        private Label label9;
    }
}