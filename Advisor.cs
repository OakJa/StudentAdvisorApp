using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdvisorApp
{
    public class Advisor : Person
    {
        private List<Student> students = new List<Student>();

        public Advisor(string id, string name, string major)
            : base(id, name, major) { }

        public void AddStudent(Student student)
        {
            if (student.Advisor == null)
            {
                student.SetAdvisor(this);
                students.Add(student);
                Console.WriteLine($"Student {student.Name} assigned to Advisor {Name}");
            }
            else
            {
                Console.WriteLine($"Student {student.Name} already has an advisor: {student.Advisor.Name}");
            }
        }

        public List<Student> GetStudents()
        {
            Console.WriteLine($"Advisor {Name} has {students.Count} students.");
            return students;
        }

        // ✅ เพิ่มฟังก์ชันนี้ตรงนี้
        public string GetStudentNames()
        {
            return students.Any()
                ? string.Join(", ", students.Select(s => s.Name))
                : "No students";
        }

        public override string GetInfo()
        {
            string studentNames = students.Count > 0 ? string.Join(", ", students.Select(s => s.Name)) : "No Students";
            return $"Advisor: {Name}, Major: {Major}, Students Count: {students.Count}, Students: {studentNames}";
        }
    }
}