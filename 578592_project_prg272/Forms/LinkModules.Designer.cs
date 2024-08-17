namespace _578592_project_prg272.Forms
{
    partial class LinkModules
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
            label8 = new Label();
            dgvLinked = new DataGridView();
            dgvAvailable = new DataGridView();
            btnLink = new Button();
            btnDelink = new Button();
            label1 = new Label();
            label2 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLinked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(226, 24);
            label8.Name = "label8";
            label8.Size = new Size(157, 32);
            label8.TabIndex = 35;
            label8.Text = "Link Modules";
            // 
            // dgvLinked
            // 
            dgvLinked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinked.Location = new Point(12, 101);
            dgvLinked.Name = "dgvLinked";
            dgvLinked.Size = new Size(251, 438);
            dgvLinked.TabIndex = 36;
            dgvLinked.SelectionChanged += dgvLinked_SelectionChanged;
            // 
            // dgvAvailable
            // 
            dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailable.Location = new Point(393, 101);
            dgvAvailable.Name = "dgvAvailable";
            dgvAvailable.Size = new Size(251, 438);
            dgvAvailable.TabIndex = 37;
            dgvAvailable.SelectionChanged += dgvAvailable_SelectionChanged;
            // 
            // btnLink
            // 
            btnLink.Location = new Point(291, 193);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(75, 23);
            btnLink.TabIndex = 38;
            btnLink.Text = "Link";
            btnLink.UseVisualStyleBackColor = true;
            btnLink.Click += btnLink_Click;
            // 
            // btnDelink
            // 
            btnDelink.Location = new Point(291, 278);
            btnDelink.Name = "btnDelink";
            btnDelink.Size = new Size(75, 23);
            btnDelink.TabIndex = 39;
            btnDelink.Text = "Delink";
            btnDelink.UseVisualStyleBackColor = true;
            btnDelink.Click += btnDelink_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 74);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 40;
            label1.Text = "Linked Modules";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 41;
            label2.Text = "Available Modules";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(291, 350);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // LinkModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 594);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelink);
            Controls.Add(btnLink);
            Controls.Add(dgvAvailable);
            Controls.Add(dgvLinked);
            Controls.Add(label8);
            Name = "LinkModules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinkModules";
            ((System.ComponentModel.ISupportInitialize)dgvLinked).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DataGridView dgvLinked;
        private DataGridView dgvAvailable;
        private Button btnLink;
        private Button btnDelink;
        private Label label1;
        private Label label2;
        private Button btnClose;
    }
}