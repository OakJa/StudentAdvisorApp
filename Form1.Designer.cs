namespace StudentAdvisorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentName = new TextBox();
            txtStudentID = new TextBox();
            txtMajor = new TextBox();
            txtGrade = new TextBox();
            btnAddStudent = new Button();
            btnShowTopStudent = new Button();
            lstStudents = new ListBox();
            lstAdvisors = new ListBox();
            cmbAdvisors = new ComboBox();
            btnAssignAdvisor = new Button();
            SuspendLayout();
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(47, 61);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 0;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(196, 61);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(357, 61);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(125, 27);
            txtMajor.TabIndex = 2;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(512, 61);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(47, 153);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 29);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(196, 153);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(94, 29);
            btnShowTopStudent.TabIndex = 5;
            btnShowTopStudent.Text = "showtop";
            btnShowTopStudent.UseVisualStyleBackColor = true;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(358, 166);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(150, 104);
            lstStudents.TabIndex = 6;
            // 
            // lstAdvisors
            // 
            lstAdvisors.FormattingEnabled = true;
            lstAdvisors.Location = new Point(532, 166);
            lstAdvisors.Name = "lstAdvisors";
            lstAdvisors.Size = new Size(150, 104);
            lstAdvisors.TabIndex = 7;
            // 
            // cmbAdvisors
            // 
            cmbAdvisors.FormattingEnabled = true;
            cmbAdvisors.Location = new Point(47, 106);
            cmbAdvisors.Name = "cmbAdvisors";
            cmbAdvisors.Size = new Size(151, 28);
            cmbAdvisors.TabIndex = 8;
            // 
            // btnAssignAdvisor
            // 
            btnAssignAdvisor.Location = new Point(47, 200);
            btnAssignAdvisor.Name = "btnAssignAdvisor";
            btnAssignAdvisor.Size = new Size(125, 29);
            btnAssignAdvisor.TabIndex = 9;
            btnAssignAdvisor.Text = "Assign Advisor";
            btnAssignAdvisor.UseVisualStyleBackColor = true;
            btnAssignAdvisor.Click += btnAssignAdvisor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAssignAdvisor);
            Controls.Add(cmbAdvisors);
            Controls.Add(lstAdvisors);
            Controls.Add(lstStudents);
            Controls.Add(btnShowTopStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(txtGrade);
            Controls.Add(txtMajor);
            Controls.Add(txtStudentID);
            Controls.Add(txtStudentName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private TextBox txtMajor;
        private TextBox txtGrade;
        private Button btnAddStudent;
        private Button btnShowTopStudent;
        private ListBox lstStudents;
        private ListBox lstAdvisors;
        private ComboBox cmbAdvisors;
        private Button btnAssignAdvisor;
    }
}
