namespace JoshDatabaseFirst
{
    partial class AuthorDetails
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
            dtpDOB = new DateTimePicker();
            Lastname = new TextBox();
            Firstname = new TextBox();
            Authorid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Clear_button = new Button();
            Add_button = new Button();
            Delete_button = new Button();
            Update_button = new Button();
            dgvAuthors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(234, 110);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(318, 23);
            dtpDOB.TabIndex = 23;
            dtpDOB.Value = new DateTime(2024, 3, 1, 11, 48, 50, 0);
            // 
            // Lastname
            // 
            Lastname.Location = new Point(231, 80);
            Lastname.Margin = new Padding(3, 2, 3, 2);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(314, 23);
            Lastname.TabIndex = 22;
            // 
            // Firstname
            // 
            Firstname.Location = new Point(230, 50);
            Firstname.Margin = new Padding(3, 2, 3, 2);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(315, 23);
            Firstname.TabIndex = 21;
            // 
            // Authorid
            // 
            Authorid.Enabled = false;
            Authorid.Location = new Point(230, 21);
            Authorid.Margin = new Padding(3, 2, 3, 2);
            Authorid.Name = "Authorid";
            Authorid.Size = new Size(315, 23);
            Authorid.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 108);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 19;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 78);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 18;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 16;
            label1.Text = "Author ID";
            // 
            // Clear_button
            // 
            Clear_button.Location = new Point(500, 140);
            Clear_button.Margin = new Padding(3, 2, 3, 2);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(82, 22);
            Clear_button.TabIndex = 15;
            Clear_button.Text = "Clear";
            Clear_button.UseVisualStyleBackColor = true;
            Clear_button.Click += Clear_button_Click;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(117, 140);
            Add_button.Margin = new Padding(3, 2, 3, 2);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(82, 22);
            Add_button.TabIndex = 14;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(500, 357);
            Delete_button.Margin = new Padding(3, 2, 3, 2);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(82, 22);
            Delete_button.TabIndex = 26;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // Update_button
            // 
            Update_button.Location = new Point(118, 337);
            Update_button.Margin = new Padding(3, 2, 3, 2);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(82, 22);
            Update_button.TabIndex = 25;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = true;
            Update_button.Click += Update_button_Click;
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(116, 182);
            dgvAuthors.Margin = new Padding(3, 2, 3, 2);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.RowTemplate.Height = 29;
            dgvAuthors.Size = new Size(455, 141);
            dgvAuthors.TabIndex = 27;
            // 
            // AuthorDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 388);
            Controls.Add(dgvAuthors);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(dtpDOB);
            Controls.Add(Lastname);
            Controls.Add(Firstname);
            Controls.Add(Authorid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Clear_button);
            Controls.Add(Add_button);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AuthorDetails";
            Text = "AuthorDetails";
            Load += AuthorDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpDOB;
        private TextBox Lastname;
        private TextBox Firstname;
        private TextBox Authorid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Clear_button;
        private Button Add_button;
        private Button Delete_button;
        private Button Update_button;
        private DataGridView dgvAuthors;
    }
}