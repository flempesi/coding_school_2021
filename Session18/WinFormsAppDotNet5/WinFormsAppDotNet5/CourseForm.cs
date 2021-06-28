//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WinFormsAppDotNet5 {
//    public partial class CourseForm : Form {
//        public CourseForm() {
//            InitializeComponent();
//        }
//    }
//}
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
    public partial class CourseForm : Form {

        private UniAppContext _uniContext;
        public CourseForm() {
            InitializeComponent();

            bindingSource1.DataSource = typeof(Course);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Category" });
            //dataGridView1.Columns.Add(new DataGridViewDateTimePickerColumn() { DataPropertyName = "Date", HeaderText = "Date" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Duration", HeaderText = "Duration" });

            dataGridView1.DataSource = bindingSource1;

            ctrlTitle.DataBindings.Add("Text", bindingSource1, "Title");
            ctrlCategory.DataBindings.Add("Text", bindingSource1, "Category");
            //ctrlDate.DataBindings.Add("DateTime", bindingSource1, "Date");
            ctrlDuration.DataBindings.Add("Text", bindingSource1, "Duration");


        }

        private void CourseForm_Load(object sender, EventArgs e) {
            var optionsBuilder = new DbContextOptionsBuilder<UniAppContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WinFormAppDotNet5DB;Trusted_Connection=True;");

            _uniContext = new UniAppContext(optionsBuilder.Options);
            //Refresh();
            RefreshCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var newCourse = new Course();
            newCourse.Title = "New";

            bindingSource1.Insert(0, newCourse);
            _uniContext.Courses.Add(newCourse);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var course = bindingSource1.Current as Course;
            if (course is null)
                return;

            bindingSource1.RemoveCurrent();
            _uniContext.Courses.Remove(course);
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            await _uniContext.SaveChangesAsync();
        }

        private void CourseForm_FormClosed(object sender, FormClosedEventArgs e) { 
            _uniContext.Dispose();
        }


        private void btnRefresh_Click(object sender, System.EventArgs e) {
            //Refresh();
            RefreshCourses();
        }

        private void RefreshCourses() {
            bindingSource1.Clear();
            _uniContext.ChangeTracker.Clear();
            foreach (var course in _uniContext.Courses.ToList()) {
                bindingSource1.Add(course);
            }
        }

      
    }
}
