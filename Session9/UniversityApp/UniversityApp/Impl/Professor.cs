using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {
    public class Professor : Person {
        //properties
        public string Rank { get; set; }
        //public List<Course> Courses { get; set; }

        //constructor
        public Professor() {

        }
        //methods
        public void Teach(Course course, DateTime datetime) {

        }
        public void SetGrade(Guid studentID, Guid courseID, int value) {
            Grade grade = new Grade() {
                StudentID = studentID,
                CourseID = courseID,
                Value = value
            };
        }
        public override string GetName() {
            return String.Format("Dr. {0}", Name);
        }
    }
}
