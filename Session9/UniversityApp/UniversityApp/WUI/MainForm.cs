using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using UniversityApp.Impl;
using UniversityApp.WUI;

namespace UniversityApp {
    public partial class MainForm : Form
    {

        private const string _JsonFile = "UniversityData.json";

        public University CodingSchool = new University();

        public MainForm()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e) {

        }

       

        private void simpleButton1_Click(object sender, EventArgs e) {
           
            AddStudent();
           
        }
         public void AddStudent() {
            Student student = new Student();

            AddStudentForm form = new AddStudentForm();
            form.NewStudent = student;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Students.Add(form.NewStudent);
                    break;

                default:
                    // messagge
                    break;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            //course
            AddCourse();
        }

       

        private void simpleButton3_Click(object sender, EventArgs e) {
            //professor
            AddProfessor();
        }
        private void AddProfessor() {
            Professor professor = new Professor();

            AddProfessorForm form = new AddProfessorForm();
            form.NewProfessor = professor;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Professors.Add(form.NewProfessor);
                    break;

                default:
                    // messagge
                    break;
            }
        }
        private void AddCourse() {
            Course course = new Course();

            AddCourseForm form = new AddCourseForm();
            form.NewCourse = course;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Courses.Add(form.NewCourse);
                    break;

                default:
                    // messagge
                    break;
            }
        }


        private void simpleButton4_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
       

        private void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(CodingSchool);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }


        private void DeserializeFromJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            CodingSchool = serializer.Deserialize<University>(data);

        }



        private void RefreshList() {
            DisplayForm form = new DisplayForm(CodingSchool);
            form.ShowDialog();
        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

 

        private void ctrlDeSerialize_Click_1(object sender, EventArgs e) {
            DeserializeFromJson();

            RefreshList();
        }
    }
}