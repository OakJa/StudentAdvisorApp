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
            addAssignAdvisor = new Button();
            txtAdvisorMajor = new TextBox();
            txtAdvisorName = new TextBox();
            txtAdvisorID = new TextBox();
            btnAddAdvisor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
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
            btnAddStudent.Location = new Point(46, 260);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 29);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(195, 260);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(94, 29);
            btnShowTopStudent.TabIndex = 5;
            btnShowTopStudent.Text = "showtop";
            btnShowTopStudent.UseVisualStyleBackColor = true;
            btnShowTopStudent.Click += btnShowTopStudent_Click_1;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(357, 273);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(150, 104);
            lstStudents.TabIndex = 6;
            // 
            // lstAdvisors
            // 
            lstAdvisors.FormattingEnabled = true;
            lstAdvisors.Location = new Point(531, 273);
            lstAdvisors.Name = "lstAdvisors";
            lstAdvisors.Size = new Size(150, 104);
            lstAdvisors.TabIndex = 7;
            // 
            // cmbAdvisors
            // 
            cmbAdvisors.FormattingEnabled = true;
            cmbAdvisors.Location = new Point(46, 213);
            cmbAdvisors.Name = "cmbAdvisors";
            cmbAdvisors.Size = new Size(151, 28);
            cmbAdvisors.TabIndex = 8;
            cmbAdvisors.SelectedIndexChanged += cmbAdvisors_SelectedIndexChanged;
            // 
            // addAssignAdvisor
            // 
            addAssignAdvisor.Location = new Point(46, 307);
            addAssignAdvisor.Name = "addAssignAdvisor";
            addAssignAdvisor.Size = new Size(125, 29);
            addAssignAdvisor.TabIndex = 9;
            addAssignAdvisor.Text = "asig Advisor";
            addAssignAdvisor.UseVisualStyleBackColor = true;
            addAssignAdvisor.Click += btnAssignAdvisor_Click;
            // 
            // txtAdvisorMajor
            // 
            txtAdvisorMajor.Location = new Point(196, 126);
            txtAdvisorMajor.Name = "txtAdvisorMajor";
            txtAdvisorMajor.Size = new Size(125, 27);
            txtAdvisorMajor.TabIndex = 11;
            // 
            // txtAdvisorName
            // 
            txtAdvisorName.Location = new Point(46, 126);
            txtAdvisorName.Name = "txtAdvisorName";
            txtAdvisorName.Size = new Size(125, 27);
            txtAdvisorName.TabIndex = 10;
            // 
            // txtAdvisorID
            // 
            txtAdvisorID.Location = new Point(357, 126);
            txtAdvisorID.Name = "txtAdvisorID";
            txtAdvisorID.Size = new Size(125, 27);
            txtAdvisorID.TabIndex = 12;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Location = new Point(47, 348);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(94, 29);
            btnAddAdvisor.TabIndex = 13;
            btnAddAdvisor.Text = "addAdvissor";
            btnAddAdvisor.UseVisualStyleBackColor = true;
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 14;
            label1.Text = "ชื่อนักศึกษา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 38);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 15;
            label2.Text = "รหัสนักศึกษา";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 38);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 16;
            label3.Text = "สาขา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 38);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 17;
            label4.Text = "เกรด";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 103);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 18;
            label5.Text = "ชื่ออาจารย์ที่ปรึกษา";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 103);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 19;
            label6.Text = "สาขาของอาจารย์";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 103);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 20;
            label7.Text = "รหัสเข้าทำงาน";
            // 
            // button1
            // 
            button1.Location = new Point(195, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "showstudent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddAdvisor);
            Controls.Add(txtAdvisorID);
            Controls.Add(txtAdvisorMajor);
            Controls.Add(txtAdvisorName);
            Controls.Add(addAssignAdvisor);
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
        private Button addAssignAdvisor;
        private TextBox txtAdvisorMajor;
        private TextBox txtAdvisorName;
        private TextBox txtAdvisorID;
        private Button btnAddAdvisor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}
