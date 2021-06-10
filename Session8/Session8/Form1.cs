using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session8
{
    public partial class Form1 : Form
    {
        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        List<Professor> Professors = new List<Professor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e) {

        }

       

        private void simpleButton1_Click(object sender, EventArgs e) {
            Student student = new Student();

            FormAddStudent form = new FormAddStudent();
            form.ShowDialog();

            student.Name = form.NameFull;


            student.Age = form.Age;

            student.RegistrationNumber = form.RegistrationNumber;

            
            Students.Add(student);

            
            MessageBox.Show(string.Format("You entered student with Name: {0} Age: {1} and RegistrationNumber: {2}", student.Name, student.Age, student.RegistrationNumber));
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            Course course = new Course();

            FormAddCourse form = new FormAddCourse();
            form.ShowDialog();

            course.Code = form.Code;
            course.Subject = form.Subject;

            

            Courses.Add(course);


            MessageBox.Show(string.Format("You entered course with Code: {0}  and Subject: {1}", course.Code, course.Subject));



            
        }
        private void simpleButton3_Click(object sender, EventArgs e) {
            Professor professor = new Professor();

            FormAddProfessor form = new FormAddProfessor();
            form.ShowDialog();

            professor.Name = form.NameFull ;
            professor.Age = form.Age;
            professor.Rank = form.Rank;

            

            Professors.Add(professor);


            MessageBox.Show(string.Format("You entered professor with Name: {0} Age: {1} and Rank: {2}", professor.Name, professor.Age, professor.Rank));





        }
        private void simpleButton4_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
