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
            if (Advisor == null)
            {
                Advisor = advisor;
            }
        }

        public override string GetInfo()
        {
            return $"Student: {Name}, Major: {Major},   Grade: {Grade},  Advisor: {Advisor?.Name ?? "No Advisor"}" ;
        }
    }


}
