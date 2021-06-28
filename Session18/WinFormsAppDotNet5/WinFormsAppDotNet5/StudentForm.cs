using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppDotNet5.EF.Context;
using WinFormsAppDotNet5.Model;

namespace WinFormsAppDotNet5 {
    public partial class StudentForm : Form {

        private UniAppContext _uniContext;
        public StudentForm() {
            InitializeComponent();

            bindingSource1.DataSource = typeof(Student);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Surname", HeaderText = "Surname" });
            //dataGridView1.Columns.Add(new DataGridViewDateTimePickerColumn() { DataPropertyName = "BirtDate", HeaderText = "BirtDate" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Address", HeaderText = "Address" });
            
            dataGridView1.DataSource = bindingSource1;

            ctrlName.DataBindings.Add("Text", bindingSource1, "Name");
            ctrlSurname.DataBindings.Add("Text", bindingSource1, "Surname");
            //ctrlBirthDate.DataBindings.Add("DateTime", bindingSource1, "BirthDate");
            ctrlAddress.DataBindings.Add("Text", bindingSource1, "Address");

           
        }

        private void StudentForm_Load(object sender, EventArgs e) {
            var optionsBuilder = new DbContextOptionsBuilder<UniAppContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WinFormAppDotNet5DB;Trusted_Connection=True;");

            _uniContext = new UniAppContext(optionsBuilder.Options);
            //Refresh();
            RefreshStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var newStudent = new Student();
            newStudent.Name = "New";

            bindingSource1.Insert(0, newStudent);
            _uniContext.Students.Add(newStudent);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var student = bindingSource1.Current as Student;
            if (student is null)
                return;

            bindingSource1.RemoveCurrent();
            _uniContext.Students.Remove(student);
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            await _uniContext.SaveChangesAsync();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e) {
            _uniContext.Dispose();
        }


        private void btnRefresh_Click(object sender, System.EventArgs e) {
            //Refresh();
            RefreshStudents();
        }

        private void RefreshStudents() {
            bindingSource1.Clear();
            _uniContext.ChangeTracker.Clear();
            foreach (var todo in _uniContext.Students.ToList()) {
                bindingSource1.Add(todo);
            }
        }

    }
}
