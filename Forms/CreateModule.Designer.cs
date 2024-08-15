namespace _578592_project_prg272.Forms
{
    partial class CreateModule
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
            label3 = new Label();
            rtbLinks = new RichTextBox();
            rtbDescription = new RichTextBox();
            label7 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtCode = new TextBox();
            label8 = new Label();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 286);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 38;
            label3.Text = "Links";
            // 
            // rtbLinks
            // 
            rtbLinks.Location = new Point(120, 304);
            rtbLinks.Name = "rtbLinks";
            rtbLinks.Size = new Size(291, 153);
            rtbLinks.TabIndex = 37;
            rtbLinks.Text = "";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(58, 172);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(407, 91);
            rtbDescription.TabIndex = 36;
            rtbDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 154);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 35;
            label7.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 92);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 34;
            label2.Text = "Module Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(274, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 92);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 32;
            label1.Text = "Module Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(58, 110);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(191, 23);
            txtCode.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(181, 31);
            label8.Name = "label8";
            label8.Size = new Size(173, 32);
            label8.TabIndex = 39;
            label8.Text = "Create Module";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(274, 506);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 41;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(155, 506);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 579);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(rtbLinks);
            Controls.Add(rtbDescription);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Name = "CreateModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private RichTextBox rtbLinks;
        private RichTextBox rtbDescription;
        private Label label7;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtCode;
        private Label label8;
        private Button btnCreate;
        private Button btnCancel;
    }
}