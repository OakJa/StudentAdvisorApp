using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdvisorApp
{
    public class Student : Person
    {
        public double Grade { get; private set; }
        public Advisor Advisor { get; private set; }

        public Student(string id, string name, string major, double grade)
            : base(id, name, major)
        {
            Grade = grade;
            Advisor = null;
        }

        public void SetAdvisor(Advisor advisor)
        {
            if (this.Advisor == null)
            {
                this.Advisor = advisor;
                advisor.AddStudent(this);
                Console.WriteLine($"Student {Name} assigned to Advisor {advisor.Name}");
            }
            else
            {
                Console.WriteLine($"Student {Name} already has an advisor: {this.Advisor.Name}");
            }
        }

        public override string GetInfo()
        {
            string advisorName = (Advisor != null) ? Advisor.Name : "No Advisor";
            return $"Student: {Name}, Major: {Major}, Grade: {Grade}, Advisor: {advisorName}";
        }
    }


}
