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

        }
    }
}
