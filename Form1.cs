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
        //txtGrade
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtMajor.Text) ||
                string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string id = txtStudentID.Text;
            string name = txtStudentName.Text;
            string major = txtMajor.Text;

            double grade;
            if (!double.TryParse(txtGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }

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
            if (cmbAdvisors.SelectedIndex >= 0 && lstStudents.SelectedIndex >= 0)
            {
                Advisor selectedAdvisor = sms.GetAdvisorByIndex(cmbAdvisors.SelectedIndex);
                Student selectedStudent = sms.GetStudentByIndex(lstStudents.SelectedIndex);

                if (selectedAdvisor != null && selectedStudent != null)
                {
                    selectedAdvisor.AddStudent(selectedStudent);
                    selectedStudent.SetAdvisor(selectedAdvisor);
                    MessageBox.Show($"{selectedStudent.Name} has been assigned to {selectedAdvisor.Name}");
                }
            }
            else
            {
                MessageBox.Show("Please select both an advisor and a student.");
            }
        }
        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdvisorID.Text) ||
                string.IsNullOrWhiteSpace(txtAdvisorName.Text) ||
                string.IsNullOrWhiteSpace(txtAdvisorMajor.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string id = txtAdvisorID.Text;
            string name = txtAdvisorName.Text;
            string major = txtAdvisorMajor.Text;

            Advisor advisor = new Advisor(id, name, major);
            sms.AddAdvisor(advisor);

            lstAdvisors.Items.Add(advisor.GetInfo());
            LoadAdvisorsToComboBox(); // โหลดข้อมูลที่ปรึกษาลง ComboBox

            MessageBox.Show("Advisor added successfully!");
        }



        private void cmbAdvisors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdvisors.SelectedIndex >= 0)
            {
                Advisor selectedAdvisor = sms.GetAdvisorByIndex(cmbAdvisors.SelectedIndex);

                lststudentsadvisor.Items.Clear();

                List<Student> students = selectedAdvisor.GetStudents();
                foreach (Student student in students)
                {
                    lststudentsadvisor.Items.Add(student.GetInfo());
                }

                if (students.Count == 0)
                {
                    lststudentsadvisor.Items.Add("No Students");
                }
            }

        }


        private void LoadAdvisorsToComboBox()
        {
            cmbAdvisors.Items.Clear();
            foreach (Advisor advisor in sms.GetAllAdvisors())
            {
                cmbAdvisors.Items.Add(advisor.GetInfo());
            }
        }


        private ListBox lstStudentsUnderAdvisor;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTopStudent_Click_1(object sender, EventArgs e)
        {
            string topStudentInfo = sms.GetTopStudent();
            MessageBox.Show(topStudentInfo, "Top Student");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAdvisors.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an advisor.", "Error");
                return;
            }

            Advisor selectedAdvisor = sms.GetAdvisorByIndex(cmbAdvisors.SelectedIndex);

            if (selectedAdvisor == null)
            {
                MessageBox.Show("Advisor not found!", "Error");
                return;
            }

            List<Student> students = selectedAdvisor.GetStudents();
            string studentList = students.Count > 0
                ? string.Join("\n", students.Select(s => s.GetInfo()))
                : "No Students";

            MessageBox.Show($"Advisor: {selectedAdvisor.Name}\nStudents:\n{studentList}", "Advisor's Students");
        }




        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex >= 0)
            {
                Student selectedStudent = sms.GetStudentByIndex(lstStudents.SelectedIndex);
                if (selectedStudent != null)
                {
                    MessageBox.Show(selectedStudent.GetInfo(), "Student Information");
                }
                else
                {
                    MessageBox.Show("No student found!");
                }
            }
            else
            {
                MessageBox.Show("Please select a student from the list.");
            }
        }

        private void lstAdvisors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAdvisors_Click(object sender, EventArgs e)
        {
            lstAdvisors.Items.Clear();
            foreach (Advisor advisor in sms.GetAllAdvisors())
            {
                lstAdvisors.Items.Add(advisor.GetInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstAdvisors.Items.Clear();
            foreach (Advisor advisor in sms.GetAllAdvisors())
            {
                lstAdvisors.Items.Add(advisor.GetInfo());
            }
        }

        private void laststudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAdvisorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}

