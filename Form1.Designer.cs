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
            lststudentsadvisor = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(6, 59);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 0;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(6, 124);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(6, 187);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(125, 27);
            txtMajor.TabIndex = 2;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(6, 249);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(152, 57);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 29);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(11, 158);
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
            lstStudents.Location = new Point(8, 33);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(313, 124);
            lstStudents.TabIndex = 6;
            // 
            // lstAdvisors
            // 
            lstAdvisors.FormattingEnabled = true;
            lstAdvisors.Location = new Point(11, 44);
            lstAdvisors.Name = "lstAdvisors";
            lstAdvisors.Size = new Size(313, 104);
            lstAdvisors.TabIndex = 7;
            lstAdvisors.SelectedIndexChanged += lstAdvisors_SelectedIndexChanged;
            // 
            // cmbAdvisors
            // 
            cmbAdvisors.FormattingEnabled = true;
            cmbAdvisors.Location = new Point(11, 193);
            cmbAdvisors.Name = "cmbAdvisors";
            cmbAdvisors.Size = new Size(151, 28);
            cmbAdvisors.TabIndex = 8;
            cmbAdvisors.SelectedIndexChanged += cmbAdvisors_SelectedIndexChanged;
            // 
            // addAssignAdvisor
            // 
            addAssignAdvisor.Location = new Point(6, 235);
            addAssignAdvisor.Name = "addAssignAdvisor";
            addAssignAdvisor.Size = new Size(125, 29);
            addAssignAdvisor.TabIndex = 9;
            addAssignAdvisor.Text = "asig Advisor";
            addAssignAdvisor.UseVisualStyleBackColor = true;
            addAssignAdvisor.Click += btnAssignAdvisor_Click;
            // 
            // txtAdvisorMajor
            // 
            txtAdvisorMajor.Location = new Point(7, 112);
            txtAdvisorMajor.Name = "txtAdvisorMajor";
            txtAdvisorMajor.Size = new Size(125, 27);
            txtAdvisorMajor.TabIndex = 11;
            // 
            // txtAdvisorName
            // 
            txtAdvisorName.Location = new Point(7, 49);
            txtAdvisorName.Name = "txtAdvisorName";
            txtAdvisorName.Size = new Size(125, 27);
            txtAdvisorName.TabIndex = 10;
            // 
            // txtAdvisorID
            // 
            txtAdvisorID.Location = new Point(138, 112);
            txtAdvisorID.Name = "txtAdvisorID";
            txtAdvisorID.Size = new Size(125, 27);
            txtAdvisorID.TabIndex = 12;
            txtAdvisorID.TextChanged += txtAdvisorID_TextChanged;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Location = new Point(151, 48);
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
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 14;
            label1.Text = "ชื่อนักศึกษา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 15;
            label2.Text = "รหัสนักศึกษา";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 164);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 16;
            label3.Text = "สาขา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 226);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 17;
            label4.Text = "เกรด";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 26);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 18;
            label5.Text = "ชื่ออาจารย์ที่ปรึกษา";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 89);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 19;
            label6.Text = "สาขาของอาจารย์";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 89);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 20;
            label7.Text = "รหัสเข้าทำงาน";
            // 
            // button1
            // 
            button1.Location = new Point(8, 163);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "showstudent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lststudentsadvisor
            // 
            lststudentsadvisor.FormattingEnabled = true;
            lststudentsadvisor.Location = new Point(6, 26);
            lststudentsadvisor.Name = "lststudentsadvisor";
            lststudentsadvisor.Size = new Size(324, 184);
            lststudentsadvisor.TabIndex = 22;
            lststudentsadvisor.SelectedIndexChanged += laststudents_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddStudent);
            groupBox1.Controls.Add(txtGrade);
            groupBox1.Controls.Add(txtMajor);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(46, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 287);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกรหัสนักศีกษา";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAddAdvisor);
            groupBox2.Controls.Add(txtAdvisorID);
            groupBox2.Controls.Add(txtAdvisorMajor);
            groupBox2.Controls.Add(txtAdvisorName);
            groupBox2.Location = new Point(45, 396);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 168);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "กรอกข้อมูลอาจารย์";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.AppWorkspace;
            groupBox3.Controls.Add(lstAdvisors);
            groupBox3.Controls.Add(cmbAdvisors);
            groupBox3.Controls.Add(btnShowTopStudent);
            groupBox3.Location = new Point(448, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 247);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "ข้อมูลอาจารย์";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.AppWorkspace;
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(lstStudents);
            groupBox4.Location = new Point(451, 348);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(339, 216);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "ข้อมูลนักศึกษา";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.AppWorkspace;
            groupBox5.Controls.Add(lststudentsadvisor);
            groupBox5.Controls.Add(addAssignAdvisor);
            groupBox5.Location = new Point(843, 87);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(336, 301);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "ข้อมูลนักเรียนในที่ปรึกษา";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Cursor = Cursors.No;
            label8.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(385, 9);
            label8.Name = "label8";
            label8.Size = new Size(443, 56);
            label8.TabIndex = 28;
            label8.Text = "StudentAdvisorApp";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1254, 573);
            Controls.Add(label8);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
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
        private ListBox lststudentsadvisor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label8;
    }
}
