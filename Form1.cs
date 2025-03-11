namespace StudentAdvisorApp
{
    public partial class Form1 : Form
    {
        private StudentManagementSystem sms = new StudentManagementSystem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string name = txtStudentName.Text;
            string major = txtMajor.Text;

            double grade = double.Parse(txtGrade.Text);

            Student student = new Student(id, name, major, grade);
            sms.AddStudent(student);

            lstStudents.Items.Add(student.GetInfo());
            MessageBox.Show("Student added successfully!");


        }

        private void btnShowTopStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sms.GetTopStudent(), "Top Student");
        }

        private void btnAssignAdvisor_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem == null || lstAdvisors.SelectedItem == null)
            {
                MessageBox.Show("Please select both a student and an advisor.");
                return;
            }

            Student selectedStudent = sms.GetStudentByIndex(lstStudents.SelectedIndex);
            Advisor selectedAdvisor = sms.GetAdvisorByIndex(lstAdvisors.SelectedIndex);

            if (selectedStudent.Advisor == null)
            {
                selectedStudent.SetAdvisor(selectedAdvisor);
                MessageBox.Show("Advisor assigned successfully!");
            }
            else
            {
                MessageBox.Show("This student already has an advisor!");
            }
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            string id = txtAdvisorID.Text;
            string name = txtAdvisorName.Text;
            string major = txtAdvisorMajor.Text;

            Advisor advisor = new Advisor(id, name, major);
            sms.AddAdvisor(advisor);

            lstAdvisors.Items.Add(advisor.GetInfo());
            MessageBox.Show("Advisor added successfully!");
        }

        private void cmbAdvisors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdvisors.SelectedIndex >= 0)
            {
                Advisor selectedAdvisor = sms.GetAdvisorByIndex(cmbAdvisors.SelectedIndex);

                if (selectedAdvisor != null)
                {
                    Console.WriteLine($"Selected Advisor: {selectedAdvisor.GetInfo()}"); // ตรวจสอบว่ามีอาจารย์ที่ปรึกษา

                    lstStudentsUnderAdvisor.Items.Clear();
                    foreach (Student student in selectedAdvisor.GetStudents())
                    {
                        Console.WriteLine($"Student under advisor: {student.GetInfo()}"); // ตรวจสอบนักศึกษา
                        lstStudentsUnderAdvisor.Items.Add(student.GetInfo());
                    }
                }
                else
                {
                    Console.WriteLine("No advisor found!"); // กรณีไม่มีอาจารย์ที่ปรึกษา
                }
            }
        }

        private ListBox lstStudentsUnderAdvisor; // Add this line to declare lstStudentsUnderAdvisor

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTopStudent_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine($"Total students: {sms.GetAllStudents().Count}");

            string topStudentInfo = sms.GetTopStudent();
            MessageBox.Show(topStudentInfo, "Top Student");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstAdvisors.SelectedItem == null)
            {
                MessageBox.Show("Please select an advisor.");
                return;
            }

            Advisor selectedAdvisor = sms.GetAdvisorByIndex(lstAdvisors.SelectedIndex);

            if (selectedAdvisor != null)
            {
                if (lstStudentsUnderAdvisor != null)
                {
                    lstStudentsUnderAdvisor.Items.Clear(); // ล้างรายการก่อนหน้า

                    List<Student> students = selectedAdvisor.GetStudents();

                    if (students.Count > 0)
                    {
                        foreach (Student student in students)
                        {
                            lstStudentsUnderAdvisor.Items.Add(student.GetInfo());
                        }
                    }
                    else
                    {
                        lstStudentsUnderAdvisor.Items.Add("No students under this advisor.");
                    }
                }
                else
                {
                    MessageBox.Show("Student list control is not initialized.");
                }
            }
            else
            {
                MessageBox.Show("No advisor found.");
            }
        }

    }

}

