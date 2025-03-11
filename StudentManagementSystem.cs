using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdvisorApp
{
    public class StudentManagementSystem
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddAdvisor(Advisor advisor)
        {
            advisors.Add(advisor);
        }

        public string GetTopStudent()
        {
            if (students.Count == 0)
            {
                return "No students available";
            }
            return students.OrderByDescending(s => s.Grade).First().GetInfo();
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public List<Advisor> GetAllAdvisors()
        {
            return advisors;
        }
    }
}

