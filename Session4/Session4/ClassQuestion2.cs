using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class ClassQuestion2
    {
    }

    public class Person
    {
        public Guid Id { get; set; }
        public string Name;
        public int Age { get; set; }

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
        public string Rank { get; set; }
        Course[] courses = new Course[20];



        public void Teach(Course course, DateTime dt)
        {

        }
        public void SetGrade(Guid StudentId, Guid CourseID, int GradeProp)
        {
            Grade grade = new Grade();
            grade.StudentId = StudentId;
            grade.CourseID = CourseID;
            grade.GradeProp = GradeProp;

        }
        public override string GetName()
        {
            return "Dr. " + Name;
        }
    }
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        Course[] courses = new Course[20];

        public void Attend(Course course, DateTime datetime)
        {

        }
        public void WriteExam(Course course, DateTime datetime) { }

    }

    public class Grade
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseID { get; set; }

        public int GradeProp { get; set; }
    }

    public class Course
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Subject { get; set; }
    }
    public class Institute
    {
        public Guid Id { get; set; }
        public string Name;

        public int YearsInService { get; set; }

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
    {
        Student[] students = new Student[30];
        Course[] courses = new Course[20];
        Grade[] grades = new Grade[60];
        Schedule[] scheduledCourse = new Schedule[60];

        public Student[] GetStudents()
        {
            return students;
        }
        public Course[] GetCoursess()
        {
            return courses;
        }
        public Grade[] GetGrades()
        {
            return grades;
        }
        public void SetSchedule(Guid courseId, Guid professorId, DateTime datetime)
        {
            Schedule schedule = new Schedule();
            schedule.CourseId = courseId;
            schedule.ProfessorId = professorId;
            schedule.Callendar = datetime;
        }

    }
    public class Schedule
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }

        public Guid ProfessorId { get; set; }

        public DateTime Callendar { get; set; }

    }
}
