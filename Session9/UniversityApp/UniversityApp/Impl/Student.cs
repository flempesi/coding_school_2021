using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversityApp.Impl {
    public class Student : Person {
        //properties
        public int RegistrationNumber { get; set; }
        //public List<Course> Courses { get; set; }
        //constructor
        public Student() {
            //Courses = new List<Course>();
        }
        //methods
        public void Attend(Course course, DateTime datetime) {

        }
        public void WriteExam(Course course, DateTime datetime) { }

    }
}
