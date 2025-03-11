using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdvisorApp
{
    public abstract class Person
    {
        public string ID { get; protected set; }
        public string Name { get; protected set; }
        public string Major { get; protected set; }

        public Person(string id, string name, string major)
        {
            ID = id;
            Name = name;
            Major = major;
        }

        public abstract string GetInfo();
    }



}
