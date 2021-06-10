using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{

    public class Person
    {
        //properties
        public Guid ID { get; }
        public string Name;
        public int Age { get; set; }
        //constructor
        public Person()
        {
            ID = Guid.NewGuid();
        }
        //methods
        public virtual string GetName()
        {
            return Name;
        }
        public virtual void SetName(string name)
        {
            Name = name;
        }

    }
    public class Professor : Person
    {
        //properties
        public string Rank { get; set; }
        public List<Course> courses { get; set; }

        //constructor
        public Professor()
        {

        }
        //methods
        public void Teach(Course course, DateTime datetime)
        {

        }
        public void SetGrade(Guid studentID, Guid courseID, int value)
        {
            Grade grade = new Grade() {
                StudentID= studentID,
                CourseID = courseID,
                Value = value
            };
         }
        public override string GetName()
        {
            return String.Format("Dr. {0}", Name);
        }
    }
    public class Student : Person
    {
        //properties
        public int RegistrationNumber { get; set; }
         public List<Course> Courses { get; set; }
        //constructor
        public Student()
        {

        }
        //methods
        public void Attend(Course course, DateTime datetime)
        {

        }
        public void WriteExam(Course course, DateTime datetime) { }

    }

    public class Grade
    {
        //properties
        public Guid ID { get;}
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Value { get; set; }
        //constructor
        public Grade()
        {
            ID = Guid.NewGuid();
        }

    }

    public class Course
    {
        //propeties
        public Guid ID { get; }
        public string Code { get; set; }
        public string Subject { get; set; }
        //constructor
        public Course()
        {
            ID = Guid.NewGuid();
        }
    }
    public class Institute
    {
        //properties
        public Guid ID { get; }
        public string Name;

        public int YearsInService { get; set; }
        //constructor
        public Institute()
        {
            ID = Guid.NewGuid();
        }
        //methods
        public virtual string GetName()
        {
            return Name;
        }
        public virtual void SetName(string name)
        {
            Name = name;
        }


    }
    public class University : Institute
    {   //properties
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }
        //constructor
        public University()
        {

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
    public class Schedule
    {   //propreties
        public Guid ID { get; }
        public Guid CourseID { get; set; }

        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        //constructor
        public Schedule()
        {
            ID = Guid.NewGuid();
        }

    }
}
