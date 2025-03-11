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
            students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public override string GetInfo()
        {
            return $"Advisor: {Name}, Major: {Major}, Students Count: {students.Count}";
        }
    }


}

