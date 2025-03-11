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

        public string GetTopAdvisor()
        {
            if (advisors.Count == 0)
            {
                return "No advisors available";
            }
            Advisor topAdvisor = advisors.OrderByDescending(a => a.GetStudents().Count).First();
            Console.WriteLine($"Top Advisor: {topAdvisor.GetInfo()}");
            return topAdvisor.GetInfo();
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public List<Advisor> GetAllAdvisors()
        {
            return advisors;
        }

        public Student GetStudentByIndex(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                return students[index];
            }
            return null;
        }

        public Advisor GetAdvisorByIndex(int index)
        {
            if (index >= 0 && index < advisors.Count)
            {
                return advisors[index];
            }
            return null;
        }
    }
}
