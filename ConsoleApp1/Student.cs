using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int id
        {
            get { return id; }
            set
            {
                if (value >= 0)
                {
                    id = value;
                }
                else
                {
                    id = 1;
                }
            }
        }
        public string Name
        {
            get { return Name.ToUpper(); }
            set
            {
                if (value.Length >= 3 )
                {
                    Name = value;
                }
                else
                {
                    Name = "Null name";
                };
            }
        }
        public string Surname { get; set; }
        public Student()
        {
            id = 1;
        }
        public Student(int id, string name, string surname)
        {
            this.id = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
