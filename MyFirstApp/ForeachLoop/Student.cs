using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        public Guid Guid { get; set; }

        public static int STUDENT_COUNTER;

        public int StudentId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }

        static Student() {
            STUDENT_COUNTER = 0;
        }

        public Student()
        {
            STUDENT_COUNTER += 1;
            Guid = Guid.NewGuid();
        }

        public Student(int studentId, string name, string surname, int age ): this()
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
