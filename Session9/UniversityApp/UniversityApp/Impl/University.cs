using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl
{
    public class University : Institute
    {   //properties
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }
        //constructor
        public University()
        {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourse = new List<Schedule>();


        }
        //methods
        public List<Student> GetStudents()
        {
            return Students;
        }
        public List<Course> GetCoursess()
        {
            return Courses;
        }
        public List<Grade> GetGrades()
        {
            return Grades;
        }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime)
        {
            Schedule schedule = new Schedule()
            {
                CourseID = courseID,
                ProfessorID = professorID,
                Callendar = datetime
            };
        }

    }
    
}
