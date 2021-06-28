using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDotNet5 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e) {
            StudentForm form = new StudentForm();
            form.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e) {
            CourseForm form = new CourseForm();
            form.Show();
        }

       
    }
}
