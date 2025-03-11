using System;
using System.Collections.Generic;
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
                student.SetAdvisor(this); // กำหนดอาจารย์ที่ปรึกษาให้นักศึกษา
                students.Add(student);
            }
            else
            {
                Console.WriteLine($"{student.Name} already has an advisor.");
            }
        }

        public List<Student> GetStudents()
        {
            Console.WriteLine($"Advisor {Name} has {students.Count} students.");
            return students;
        }

        public override string GetInfo()
        {
            return $"Advisor: {Name}, Major: {Major}, Students Count: {students.Count}";
        }
    }


}

